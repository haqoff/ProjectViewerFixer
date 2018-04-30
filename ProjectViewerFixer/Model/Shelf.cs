using Newtonsoft.Json;

namespace ProjectViewerFixer.Model
{
    public class Shelf
    {
        [JsonProperty("id_counter")]
        public int IdCounter { get; set; }

        [JsonProperty("bbox")]
        public string Bbox { get; set; }

        [JsonProperty("objects")]
        public Object[] Objects { get; set; }
    }
}