using Newtonsoft.Json;

namespace ProjectViewerFixer.Model
{
    public class Data
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("shelf_number")]
        public int ShelfNumber { get; set; }

        [JsonProperty("shelfs")]
        public Shelf[] Shelfs { get; set; }

        [JsonProperty("objects")]
        public Object[] Objects { get; set; }
    }
}
