﻿namespace Microsoft.Practices.DataPipeline.ColdStorage
{
    public class ColdStorageEvent
    {
        public string MessageType { get; set; }
        public string Offset { get; set; }
        public string Payload { get; set; }
    }
}