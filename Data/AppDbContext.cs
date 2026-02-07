using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Stash.Models;

namespace Stash.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Bookmark> Bookmarks => Set<Bookmark>();
}
