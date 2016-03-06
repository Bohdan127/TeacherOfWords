using DbManagerLibrary.DefaultManagers.Contexts;

namespace DbManagerLibrary.DefaultManagers.Repositories
{
    /// <summary>
    /// Implementation using our Context => LocalContext
    /// </summary>
    public class LocalRepository : Repository<LocalContext> { }
}
