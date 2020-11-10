using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace division.Services
{
    public class HealthcheckService
    {
        public static string Status()
        {
            return "{\"status\": \"ok\"}";
        }
    }
}