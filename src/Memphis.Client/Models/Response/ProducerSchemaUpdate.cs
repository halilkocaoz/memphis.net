﻿using System.Runtime.Serialization;

namespace Memphis.Client.Models.Response
{
    [DataContract]
    internal sealed class ProducerSchemaUpdate
    {
        [DataMember(Name = "UpdateType")] public string UpdateType { get; set; }

        [DataMember(Name = "init")] public ProducerSchemaUpdateInit Init { get; set; }
    }

    internal static class ProducerSchemaUpdateType
    {
        public const int SCHEMA_UPDATE_TYPE_INIT = 1;
        public const int SCHEMA_UPDATE_TYPE_DROP = 2;
    }
}