﻿using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace NetoDotNET.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load configuration
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            var config = configBuilder.Build();

            Console.WriteLine($"Loaded Configuration:" + Environment.NewLine +
                $"Neto Store Name: {config.GetSection("NETO_STORENAME").Value}" + Environment.NewLine +
                $"Neto API Key: {config.GetSection("NETO_API_KEY").Value}" + Environment.NewLine +
                $"Neto Username: {config.GetSection("NETO_USERNAME").Value}");
        }
    }
}