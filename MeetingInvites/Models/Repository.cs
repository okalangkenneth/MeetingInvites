using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetingInvites.Models
{
    public class Repository
    {
        private static Dictionary<string, FarmerResponse> responses;
        static Repository()
        {
            // Add default data to populate model with responses.

            responses = new Dictionary<string, FarmerResponse>();
            responses.Add("Bob", new FarmerResponse
            {
                Name = "Bob",
                Email = "bob@example.com",
                WillAttend = true
            });
            responses.Add("Alice", new FarmerResponse
            {
                Name = "Alice",
                Email = "alice@example.com",
                WillAttend = true
            });
            responses.Add("Paul", new FarmerResponse
            {
                Name = "Paul",
                Email = "paul@example.com",
                WillAttend = true
            });
        }
        public static void Add(FarmerResponse newResponse)
        {
            string key = newResponse.Name.ToLowerInvariant();
            if (responses.ContainsKey(key))
            {
                responses[key] = newResponse;
            }
            else
            {
                responses.Add(key, newResponse);
            }
        }
        public static IEnumerable<FarmerResponse> Responses
        {
            get { return responses.Values; }
        }
    }
}