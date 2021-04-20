using RestApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Services
{
    public class ShopService
    {
        private List<Item> Items = new List<Item>();
        private int id = 0;
        public List<Item> GetAll()
        {
            return Items;
        }
        public void AddItem(Item item)
        {
            id += 1;
            item.Id = id;
            Items.Add(item);
        }

        internal void DeleteItem(int id)
        {
            Items = Items.Where(i => i.Id != id).ToList();
        }
    }
}
