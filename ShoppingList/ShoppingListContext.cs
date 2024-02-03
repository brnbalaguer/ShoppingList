using Microsoft.EntityFrameworkCore;
using ShoppingList.Models;

namespace ShoppingList
{
    public class ShoppingListContext : DbContext
    {
        public ShoppingListContext(DbContextOptions<ShoppingListContext> options) : base(options)
        {
                
        }

        public DbSet<Grocery> Grocery { get; set; }
    }
}
