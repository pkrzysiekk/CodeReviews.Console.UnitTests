using Microsoft.EntityFrameworkCore;
using ShoppingListAPI.Models;

namespace ShoppingListAPI.Data;

public class ShoppingContext  : DbContext
{
    public DbSet<ShoppingItem>  ShoppingItems { get; set; }
    public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=ShoppingList.db");
    }
    
}