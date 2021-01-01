﻿namespace Nacos.Remote.Requests
{
    public class InstanceRequest : AbstractNamingRequest
    {
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("instance")]
        public Nacos.Naming.Dtos.Instance Instance { get; set; }

        public InstanceRequest(string @namespace, string serviceName, string groupName, string type, Nacos.Naming.Dtos.Instance instance)
            : base(@namespace, serviceName, groupName)
        {
            this.Type = type;
            this.Instance = instance;
        }

        public InstanceRequest(string @namespace, string serviceName, string groupName)
            : base(@namespace, serviceName, groupName)
        {
        }

        public override string GetRemoteType() => RemoteRequestType.Req_Naming_Instance;
    }
}
