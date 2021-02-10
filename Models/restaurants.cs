using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    public class restaurants
    {
        //rank, restaurant name, favorite dish, address, restaurant phone #, link to website
        // Question mark means the value can be null
        public int? foodRank { get; set; }
        public string? foodRestaurant { get; set; }
        public string foodDish { get; set; } = "It's all tasty!";
        public string? foodAddress { get; set; }
        public string foodPhone { get; set; }

        public string foodWebsite { get; set; } = "Coming soon.";

        //this lets us make new restaurant objects
        public static restaurants[] GetRestaurants()
        {
            restaurants r1 = new restaurants
            {
                foodRank = 1,
                foodRestaurant = "Don Joaquin Street Tacos",
                foodDish = "Taco al Pastor",
                foodAddress = "150 W 1230 N St",
                foodPhone = "801-40-2894",
                foodWebsite = "donjoaquinsttacosprovo.com"
            };

            restaurants r2 = new restaurants
            {
                foodRank = 2,
                foodRestaurant = "Bombay House",
                foodDish = "Any curry",
                foodAddress = "463 N University Ave",
                foodPhone = "801-373-6677",
                foodWebsite = "bombayhouse.com"
            };

            restaurants r3 = new restaurants
            {
                foodRank = 3,
                foodRestaurant = "Wild Ginger",
                foodDish = "anything",
                foodAddress = "366 N Univeristy Ave",
                foodPhone = "801-691-1177",
                foodWebsite = "wildgingerut.com"
            };

            restaurants r4 = new restaurants
            {
                foodRank = 4,
                foodRestaurant = "Burgers Supreme",
                foodDish = "Cowboy burger",
                foodAddress = "1796 N University Pkwy",
                foodPhone = "801-373-5713",
                foodWebsite = "burgerssupreme.com"
            };

            restaurants r5 = new restaurants
            {
                foodRank = 2,
                foodRestaurant = "Koko Lunchbox",
                foodDish = "Anything",
                foodAddress = "1175 N Canyon Rd #3420",
                foodPhone = "801-850-4358"
            };


            return new restaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
