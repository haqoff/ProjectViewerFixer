using Newtonsoft.Json;

namespace ProjectViewerFixer.Model
{
    public class DBDictionary
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString() => Name;
    }
}
