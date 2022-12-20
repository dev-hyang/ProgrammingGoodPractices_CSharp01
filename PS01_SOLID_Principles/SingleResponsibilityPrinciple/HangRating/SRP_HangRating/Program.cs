// See https://aka.ms/new-console-template for more information
using SRP_HangRating;
using SRP_HangRating.Models;
using SRP_HangRating.StrategyDesign;
using SRP_HangRating.Utils;

Console.WriteLine("SRP Hang Rating Banking System starts...");
var PolicySource = new FilePolicySource();
var PolicySerializer = new JsonPolicySerializer();
// load policy - open file policy.json
var policyJson = PolicySource.GetPolicyFromSource();
var policy = PolicySerializer.GetPolicyFromJsonString(policyJson);

IPolicyStrategy policyStrategy = policy.Type switch
{
    PolicyType.Auto => new AutoPolicyStrategy(),
    PolicyType.Land => new LandPolicyStrategy(),
    PolicyType.Life => new LifePolicyStrategy(),
    _ => default,
};

var engine = new RatingEngine();
engine.Rate(policyStrategy, policy);

if (engine.Rating > 0)
{
    Console.WriteLine($"Rating: {engine.Rating}");
}
else
{
    Console.WriteLine("No rating provided.");
}
