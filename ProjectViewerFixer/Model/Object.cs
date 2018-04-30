using Newtonsoft.Json;

namespace ProjectViewerFixer.Model
{
    public class Object
    {
        [JsonProperty("id_counter")]
        public int IdCounter { get; set; }

        [JsonProperty("bbox")]
        public string Bbox { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("size_id")]
        public string SizeId { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("brand_id")]
        public string BrandId { get; set; }

        [JsonProperty("price_val")]
        public string PriceValue { get; set; }
    }
}