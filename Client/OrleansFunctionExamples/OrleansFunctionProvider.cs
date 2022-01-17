using System;
using System.Collections.Generic;
using System.Text;

namespace OrleansBasics.Client.OrleansFunctionExamples;

public class OrleansFunctionProvider : IOrleansFunctionProvider
{
    public IList<IOrleansFunction> GetOrleansFunctions()
    {
        return new List<IOrleansFunction>()
        {
            new HelloGrain(),
            new MultipleInstantiations(),
            new StatefulWork(),
            new ShowoffDashboard(),
            new DependencyInjectionEmailService(),
            new EverythingIsOkReminder(),
            new GrainObserverReceiver(),
            new GrainObserverEventSender(),
        };
    }
}