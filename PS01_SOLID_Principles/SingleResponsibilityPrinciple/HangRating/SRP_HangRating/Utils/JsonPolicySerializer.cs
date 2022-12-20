using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using SRP_HangRating.Models;

namespace SRP_HangRating.Utils
{
    public class JsonPolicySerializer : PolicySerializer
    {
        public override Policy GetPolicyFromJsonString(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter()) ?? new Policy();
        }
    }
}