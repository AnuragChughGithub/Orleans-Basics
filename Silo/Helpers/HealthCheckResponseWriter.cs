using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;

namespace OrleansBasics.Silo.Helpers;

internal static class HealthCheckResponseWriter
{
    public static Task WriteResponse(HttpContext context, HealthReport healthReport)
    {
        context.Response.ContentType = "application/json; charset=utf-8";

        var result = JsonConvert.SerializeObject(new
        {
            status = healthReport.Status.ToString(),
            details = healthReport.Entries.Select(e => new
            {
                key = e.Key,
                description = e.Value.Description,
                status = e.Value.Status.ToString(),
                data = e.Value.Data
            })
        }, Formatting.Indented);

        return context.Response.WriteAsync(result);
    }
}
