using System;

using Assignment_A2_01.Models;
using Assignment_A2_01.Services;

namespace Assignment_A2_01
{
    class Program
    {
        static async Task Main(string[] args)
        {
            NewsApiData news = await new NewsService().GetNewsAsync();
        }
    }
}
