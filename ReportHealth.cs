using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class ReportHealth : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            bool result = GetTestResult();

            if (result)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("Report Healthy"));
            }

            return Task.FromResult(
                HealthCheckResult.Unhealthy("Report Not Healthy"));
        }

        private bool GetTestResult()
        {
            return false;
        }
    }
}
