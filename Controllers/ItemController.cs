using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Models;
using RestApiDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ShopService _shopService;

        public ItemController(ShopService shopService)
        {
            _shopService = shopService;
        }
        [HttpGet]
        public List<Item> GetAll()
        {
            return _shopService.GetAll();
        }
        [HttpPost]
        public void AddItem(Item item)
        {
            _shopService.AddItem(item);
        }
        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            _shopService.DeleteItem(id);
        }
    }
}
