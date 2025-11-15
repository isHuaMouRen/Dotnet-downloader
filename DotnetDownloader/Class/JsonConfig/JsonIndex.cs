using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetDownloader.Class.JsonConfig
{
    public class JsonIndex
    {
        public partial class Index
        {
            [JsonProperty("releases-index")]
            public ReleasesIndex[] ReleasesIndex { get; set; }
        }

        public partial class ReleasesIndex
        {
            [JsonProperty("channel-version")]
            public string ChannelVersion { get; set; }

            [JsonProperty("latest-release")]
            public string LatestRelease { get; set; }

            [JsonProperty("latest-release-date")]
            public string LatestReleaseDate { get; set; }

            [JsonProperty("security")]
            public bool Security { get; set; }

            [JsonProperty("latest-runtime")]
            public string LatestRuntime { get; set; }

            [JsonProperty("latest-sdk")]
            public string LatestSdk { get; set; }

            [JsonProperty("product")]
            public string Product { get; set; }

            [JsonProperty("support-phase")]
            public string SupportPhase { get; set; }

            [JsonProperty("eol-date")]
            public string EolDate { get; set; }

            [JsonProperty("release-type")]
            public string ReleaseType { get; set; }

            [JsonProperty("releases.json")]
            public string ReleasesJson { get; set; }

            [JsonProperty("supported-os.json", NullValueHandling = NullValueHandling.Ignore)]
            public string SupportedOsJson { get; set; }
        }
    }
}
