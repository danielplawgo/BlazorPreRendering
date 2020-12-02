using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPreRendering.Shared.Services
{
    public class PreRenderService : IPreRenderService
    {
        public bool IsPreRendering { get; private set; }

        public PreRenderService()
        {
        }

        public PreRenderService(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor.HttpContext.Response.HasStarted)
            {
                IsPreRendering = false;
            }
            else
            {
                IsPreRendering = true;
            }
        }
    }

    public interface IPreRenderService
    {
        bool IsPreRendering { get; }
    }
}
