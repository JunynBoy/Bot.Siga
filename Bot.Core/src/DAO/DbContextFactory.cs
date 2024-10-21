using Bot.Core.DAO;


namespace Bot.Core.src.DAO
{
    public static class DbContextFactory
    {
        private static ApplicationDbContext? _dbContext;

        public static ApplicationDbContext GetDbContext()
        {
            if (_dbContext == null)
            {
                _dbContext = new ApplicationDbContext();
            }
            return _dbContext;
        }
    }
}
