﻿namespace Nacos.Remote.Responses
{
    using Nacos.Remote.Requests;
    using System.Collections.Generic;

    public class ConfigChangeBatchListenResponse : Nacos.Remote.CommonResponse
    {
        [Newtonsoft.Json.JsonProperty("changedConfigs")]
        public List<ConfigContext> ChangedConfigs = new List<ConfigContext>();

        public override string GetRemoteType() => RemoteRequestType.Resp_Config_BatchListen;
    }
}
