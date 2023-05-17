using System.Collections.Generic;

namespace BestRestaurant.Models
{
    public class Restaurant
    {
        public string Description { get; set; }
        public int Id { get; }
        private static List<Restaurant> _instances = new List<Restaurant> { };

        public Restaurant(string description)
        {
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Restaurant> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static Restaurant Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}