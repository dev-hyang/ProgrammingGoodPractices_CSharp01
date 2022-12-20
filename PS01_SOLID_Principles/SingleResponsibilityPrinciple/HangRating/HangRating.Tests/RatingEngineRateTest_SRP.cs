using Newtonsoft.Json;
using SRP_HangRating;
using SRP_HangRating.Utils;
using System;
using System.IO;
using Xunit;

namespace HangRating.Tests
{
    public class RatingEngineRateTest_SRP
    {
        public ConsoleLogger _logger { get; set; }
        public FilePolicySource _policySource { get; set; }

        //public RatingEngineRateTest_SRP(ConsoleLogger logger, FilePolicySource policySource)
        //{
        //    _logger= logger;
        //    _policySource = policySource;
        //}
        public RatingEngineRateTest_SRP()
        {
            _logger = new ConsoleLogger();
            _policySource = new FilePolicySource();
        }

        [Fact]
        public void ReturnsDefaultPolicyFromEmptyJsonString()
        {
            var inputJson = "{}";
            var serializer = new JsonPolicySerializer();
            var result = serializer.GetPolicyFromJsonString(inputJson);

            var policy = new SRP_HangRating.Models.Policy();
            Assert.Equal(result, policy, new PolicyEqualityComparer());
        }

        //[Fact]
        //public void ReturnsRatingOf10000For200000LandPolicy()
        //{
        //    var policy = new Policy
        //    {
        //        Type = PolicyType.Land,
        //        BondAmount = 200000,
        //        Valuation = 200000
        //    };
        //    string json = PolicySerializer.GetPolicyFromJsonString(policy);
        //    File.WriteAllText("policy.json", json);

        //    var engine = new RatingEngine();
        //    engine.Rate();
        //    var result = engine.Rating;

        //    Assert.Equal(10000, result);
        //}

        //[Fact]
        //public void ReturnsRatingOf0For200000BondOn260000LandPolicy()
        //{
        //    var policy = new Policy
        //    {
        //        Type = PolicyType.Land,
        //        BondAmount = 200000,
        //        Valuation = 260000
        //    };
        //    string json = JsonConvert.SerializeObject(policy);
        //    File.WriteAllText("policy.json", json);

        //    var engine = new RatingEngine();
        //    engine.Rate();
        //    var result = engine.Rating;

        //    Assert.Equal(0, result);
        //}
    }
}