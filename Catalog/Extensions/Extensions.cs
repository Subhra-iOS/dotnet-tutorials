using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog.Extensions
{
    public static class Extensions 
    {
        public static ItemDto GetDto(this Item item)
        {
            return new ItemDto 
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}