using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Data.Models;
namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name="Ugi's",Cuisine = CuisineType.Italian},
                new Restaurant{Id = 2, Name="McDonald",Cuisine = CuisineType.None},
                new Restaurant{Id = 2, Name="Apu's",Cuisine = CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r=> r.Name);
        }
    }
}
