﻿namespace DurableFunctions.Demo.DotNetCore.AzureOps.Activities.Models
{
    public sealed class AddUserInput
    {
        public string UserName { get; set; }

        public string CountryIsoCode { get; set; }
    }
}