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

        public async Task<IEnumerable<MetaFinanceira>> BuscarMetaFinanceiraAsync()
        {
            return await _dbContext.MetasFinanceiras.ToListAsync();
        }

        public async Task<MetaFinanceira> BuscarMetaFinanceiraPorIdAsync(int id) 
        {
            return await _dbContext.MetasFinanceiras.FindAsync(id);
        }

        public async Task ExcluirAsync(int id) 
        {
            var metafinanceira = await BuscarMetaFinanceiraPorIdAsync(id);
            _dbContext.MetasFinanceiras.Remove(metafinanceira);
            await _dbContext.SaveChangesAsync();
        }
    }
}
