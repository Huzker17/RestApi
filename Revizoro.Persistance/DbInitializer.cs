namespace Revizoro.Persistence
{
    public class DbInitializer
    {
        public static void Initializer(RevizoroDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
