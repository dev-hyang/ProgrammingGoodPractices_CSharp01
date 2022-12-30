// See https://aka.ms/new-console-template for more information
using HangRating;

Console.WriteLine("Hang Rating Banking System starts...");
var engine = new RatingEngine();
engine.Rate();

if (engine.Rating > 0)
{
    Console.WriteLine($"Rating: {engine.Rating}");
}
else
{
    Console.WriteLine("No rating provided.");
    Console.WriteLine("No rating provided.");
    Console.WriteLine("No rating provided.");
}
