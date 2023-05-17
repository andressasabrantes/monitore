namespace Data.Repositories
{
    public class MetaFinanceiraRepository : IMetaFinanceiraRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public MetaFinanceiraRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CadastrarAsync(MetaFinanceira metafinanceira)
        {
            await _dbContext.MetasFinanceiras.AddAsync(metafinanceira);
            await _dbContext.SaveChangesAsync();
        }
    }
}
