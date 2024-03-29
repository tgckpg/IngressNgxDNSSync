﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngressNgxDNSSync.KServices.Kubernetes.WebhookServer
{
    public class Startup
    {
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddControllers();
        }

        public void Configure( IApplicationBuilder app )
        {
            app.UseRouting();
            app.UseEndpoints( endpoints => endpoints.MapControllers() );
        }
    }
}
