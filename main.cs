// Created by: Ashley Monaghan
// Created on: Jan 2023
//
// This program shows pictures of dogs!

using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(
            "https://dog.ceo/api/breeds/image/random"
        );
        var jsonAsDictionary = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        Console.WriteLine("");
        JsonNode docNode = JsonNode.Parse(response)!;
        JsonNode factsNode = docNode!["message"]!;
        string fact = factsNode.ToString();
        Console.WriteLine(fact);

        Console.WriteLine("\nDone.");
    }
}