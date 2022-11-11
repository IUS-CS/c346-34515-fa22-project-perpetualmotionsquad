namespace FlightApi.Models.Restaurants;
using System.Text.Json.Serialization;


public class Result  
{
        [JsonPropertyName("business_status")]
        public string? Business_status { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry? Geometry { get; set; }

        [JsonPropertyName("icon")]
        public string? Icon { get; set; }

        [JsonPropertyName("icon_background_color")]
        public string? Icon_background_color { get; set; }

        [JsonPropertyName("icon_mask_base_uri")]
        public string? Icon_mask_base_uri { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("opening_hours")]
        public OpeningHours? Opening_hours { get; set; }

        [JsonPropertyName("photos")]
        public List<Photo>? Photos { get; set; }

        [JsonPropertyName("place_id")]
        public string? Place_id { get; set; }

        [JsonPropertyName("plus_code")]
        public PlusCode? Plus_code { get; set; }

        [JsonPropertyName("price_level")]
        public int Price_level { get; set; }

        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        [JsonPropertyName("reference")]
        public string? Reference { get; set; }

        [JsonPropertyName("scope")]
        public string? Scope { get; set; }

        [JsonPropertyName("types")]
        public List<string>? Types { get; set; }

        [JsonPropertyName("user_ratings_total")]
        public int User_ratings_total { get; set; }

        [JsonPropertyName("vicinity")]
        public string? Vicinity { get; set; }

}