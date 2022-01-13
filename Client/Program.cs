using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;
using Orleans.Runtime;

namespace OrleansBasics
{
	//Reference 1, https://medium.com/swlh/getting-started-with-microsoft-orleans-882cdac4307f
	//Reference 2, https://kritner.medium.com/microsoft-orleans-reusing-grains-and-grain-state-136977facd42
	//Reference 3, https://medium.com/free-code-camp/microsoft-orleans-reporting-dashboard-16465d255199
	//Reference 4, https://kritner.medium.com/microsoft-orleans-dependency-injection-6379d52a7169
	//Reference 5, https://kritner.medium.com/microsoft-orleans-reminders-and-grains-calling-grains-6ad58ad104a2
	//Reference 6, https://kritner.medium.com/microsoft-orleans-my-first-podcast-interview-43d3c2e1aa3f

	public class Program
	{
		const int initializeAttemptsBeforeFailing = 5;
		private static int attempt = 0;

		static int Main(string[] args)
		{
			return RunMainAsync().Result;
		}

		private static async Task<int> RunMainAsync()
		{
			try
			{
				using (var client = await StartClientWithRetries())
				{
					await DoClientWork(client);
					Console.ReadKey();
				}

				return 0;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				Console.ReadKey();
				return 1;
			}
		}

		private static async Task<IClusterClient> StartClientWithRetries()
		{
			attempt = 0;
			IClusterClient client;
			client = new ClientBuilder()
				.UseLocalhostClustering()
				.Configure<ClusterOptions>(options =>
				{
					options.ClusterId = "dev";
					options.ServiceId = "OrleansBasics";
				})
				.ConfigureLogging(logging => logging.AddConsole())
				.Build();

			await client.Connect(RetryFilter);
			Console.WriteLine("Client successfully connected to silo host");
			return client;
		}

		private static async Task<bool> RetryFilter(Exception exception)
		{
			if (exception.GetType() != typeof(SiloUnavailableException))
			{
				Console.WriteLine($"Cluster client failed to connect to cluster with unexpected error.  Exception: {exception}");
				return false;
			}
			attempt++;
			Console.WriteLine($"Cluster client attempt {attempt} of {initializeAttemptsBeforeFailing} failed to connect to cluster.  Exception: {exception}");
			if (attempt > initializeAttemptsBeforeFailing)
			{
				return false;
			}
			await Task.Delay(TimeSpan.FromSeconds(4));
			return true;
		}

		private static async Task DoClientWork(IClusterClient client)
		{
			Console.WriteLine("Hello, what should I call you?");
			var name = Console.ReadLine();

			if (string.IsNullOrEmpty(name))
			{
				name = "Anurag Chugh";
			}

			// example of calling grains from the initialized client
			var grain = client.GetGrain<IHello>(Guid.NewGuid());

			var response = await grain.SayHello(name);
			Console.WriteLine($"\n\n{response}\n\n");
		}
	}
}
