using Newtonsoft.Json;
using System.Collections.Generic;


namespace API_Testing.DataFolder
{
    public class LocationDTO
    {
        [JsonProperty("post code")]
        public string PostCode { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("country abbreviation")]
        public string CountryAbbreviation { get; set; }
        [JsonProperty("places")]
        public List<PlaceDTO> Places { get; set; }

    }
}
