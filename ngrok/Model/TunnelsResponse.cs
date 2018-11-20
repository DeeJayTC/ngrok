using System;

namespace ngrok
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TunnelsResponse
    {
        [JsonProperty("tunnels")]
        public List<Tunnel> Tunnels { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public partial class Tunnel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("public_url")]
        public Uri PublicUrl { get; set; }

        [JsonProperty("proto")]
        public string Proto { get; set; }

        [JsonProperty("config")]
        public Config Config { get; set; }

        [JsonProperty("metrics")]
        public Metrics Metrics { get; set; }
    }

    public partial class Config
    {
        [JsonProperty("addr")]
        public string Addr { get; set; }

        [JsonProperty("inspect")]
        public bool Inspect { get; set; }
    }

    public partial class Metrics
    {
        [JsonProperty("conns")]
        public Conns Conns { get; set; }

        [JsonProperty("http")]
        public Conns Http { get; set; }
    }

    public partial class Conns
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("gauge", NullValueHandling = NullValueHandling.Ignore)]
        public long? Gauge { get; set; }

        [JsonProperty("rate1")]
        public double Rate1 { get; set; }

        [JsonProperty("rate5")]
        public double Rate5 { get; set; }

        [JsonProperty("rate15")]
        public double Rate15 { get; set; }

        [JsonProperty("p50")]
        public long P50 { get; set; }

        [JsonProperty("p90")]
        public long P90 { get; set; }

        [JsonProperty("p95")]
        public long P95 { get; set; }

        [JsonProperty("p99")]
        public long P99 { get; set; }
    }

    public partial class TunnelsResponse
    {
        public static TunnelsResponse FromJson(string json) => JsonConvert.DeserializeObject<TunnelsResponse>(json, ngrok.model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TunnelsResponse self) => JsonConvert.SerializeObject(self, ngrok.model.Converter.Settings);
    }


}
