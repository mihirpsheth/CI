using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WebApplication8.Controllers;

namespace WebApplication8
{
    public class HelloWorldHealth : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            bool result = GetTestResult();

            if (result)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("Hello World Healthy"));
            }

            return Task.FromResult(
                HealthCheckResult.Unhealthy("Hello World Not Healthy"));
        }

        private bool GetTestResult()
        {
            //return false;
            using (var client = new HttpClient())
            {
                var controller = new HelloWorldController();
                var response = controller.Get() as ObjectResult;
                if (response.StatusCode == 200)
                    return true;
                else
                    return false;
            }
        }
    }
}
