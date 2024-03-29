using Characterlist.Models;
using Microsoft.EntityFrameworkCore;

namespace Characterlist.Models;

public class CharacterlistContext(DbContextOptions<CharacterlistContext> options) : DbContext(options)
{
    public DbSet<Characterstats> Characterlist { get; set; } = null!;
    public object Weapons { get; internal set; }
}