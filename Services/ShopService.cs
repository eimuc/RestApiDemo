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
        public List<Item> GetAll()
        {
            return Items;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
