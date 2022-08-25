using Catalog.Entities;

namespace Catalog.Repositories
{   
    
    public interface IItemRepository
    {
        Item? GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}