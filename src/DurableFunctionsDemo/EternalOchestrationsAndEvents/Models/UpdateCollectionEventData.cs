﻿namespace DurableFunctionsDemo.EternalOchestrationsAndEvents.Models
{
    public class UpdateCollectionEventData
    {
        public string OrchestrationInstanceId { get; set; }

        public string Name { get; set; }
    }
}
