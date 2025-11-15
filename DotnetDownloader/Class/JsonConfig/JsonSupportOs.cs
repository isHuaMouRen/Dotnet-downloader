using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetDownloader.Class.JsonConfig
{
    public class JsonSupportOs
    {
        public partial class Index
        {
            [JsonProperty("channel-version")]
            public string ChannelVersion { get; set; }

            [JsonProperty("last-updated")]
            public DateTimeOffset LastUpdated { get; set; }

            [JsonProperty("families")]
            public Family[] Families { get; set; }

            [JsonProperty("libc")]
            public Libc[] Libc { get; set; }

            [JsonProperty("notes")]
            public string[] Notes { get; set; }
        }

        public partial class Family
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("distributions")]
            public Distribution[] Distributions { get; set; }
        }

        public partial class Distribution
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("link")]
            public Uri Link { get; set; }

            [JsonProperty("lifecycle", NullValueHandling = NullValueHandling.Ignore)]
            public Uri Lifecycle { get; set; }

            [JsonProperty("architectures")]
            public Architecture[] Architectures { get; set; }

            [JsonProperty("supported-versions")]
            public string[] SupportedVersions { get; set; }

            [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Notes { get; set; }
        }

        public partial class Libc
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("architectures")]
            public Architecture[] Architectures { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("source")]
            public string Source { get; set; }
        }

        public enum Architecture { Arm32, Arm64, Ppc64Le, S390X, X64 };
    }
}
