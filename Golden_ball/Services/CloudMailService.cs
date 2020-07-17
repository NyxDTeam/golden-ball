﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Golden_Ball.API.Services
{
    public class CloudMailService
    {
        private readonly IConfiguration _configuration;

        public CloudMailService(IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));
        }

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Mail from{_configuration["mailSettings:mailFromAdress"]}) to {_configuration["mailToAdress"]}, with LocalServiceMail");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message{message}");
        }
    }
}
