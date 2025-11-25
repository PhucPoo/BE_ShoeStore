using ShoeStoreAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShoeStoreAPI.Services
{
    public class ShoeService
    {
        private static List<Shoe> shoes = new List<Shoe>();

        public List<Shoe> GetAll() => shoes;
        public Shoe? GetById(int id) => shoes.FirstOrDefault(s => s.Id == id);
        public void Add(Shoe shoe) => shoes.Add(shoe);
        public void Update(Shoe shoe)
        {
            var existing = shoes.FirstOrDefault(s => s.Id == shoe.Id);
            if (existing != null)
            {
                existing.Name = shoe.Name;
                existing.Price = shoe.Price;
            }
        }
        public void Delete(int id)
        {
            var shoe = shoes.FirstOrDefault(s => s.Id == id);
            if (shoe != null) shoes.Remove(shoe);
        }
    }
}
