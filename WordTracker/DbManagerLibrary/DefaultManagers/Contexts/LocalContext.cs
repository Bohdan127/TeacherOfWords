using DbManagerLibrary.Tables;
using System.Data.Entity;

namespace DbManagerLibrary.DefaultManagers.Contexts
{
    public class LocalContext : DbContext
    {
        public DbSet<LinkedWord> LinkedWords { get; set; }

        public LocalContext()
            : base("LocalConnection")
        {
        }
    }
}
