using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;
using Catalog.Dtos;
using Catalog.Extensions;

namespace Catalog.Controllers
{
    // Method GET /items 
    [ApiController]
    [Route("items")]
    public class ItemsController: ControllerBase
    {
        private readonly IItemRepository repository;

        public ItemsController(IItemRepository repository)
        {
            this.repository = repository;
        }

        // GET /items
        [HttpGet]
        public IEnumerable<ItemDto> GetItem()
        {
            return repository.GetItems().Select( item => item.GetDto());
        }

        // GET /item/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto>  GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            return item.GetDto();
        }
    }
}