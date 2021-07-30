using Newtonsoft.Json;

namespace DollarHG
{
    public class Market
    {
        public Market()
        {
            this.Currency = new Currency();
        }
        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }
    }
}

