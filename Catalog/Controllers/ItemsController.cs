using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;

namespace Catalog.Controllers
{
    // Method GET /items 
    [ApiController]
    [Route("items")]
    public class ItemsController: ControllerBase
    {
        private readonly InMemItemRepository repository;

        public ItemsController()
        {
            repository = new InMemItemRepository();
        }

        // GET /items
        [HttpGet]
        public IEnumerable<Item> GetItem()
        {
            return repository.GetItems();
        }
    }
}