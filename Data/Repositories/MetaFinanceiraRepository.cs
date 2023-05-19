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

        public async Task EditarAsync(MetaFinanceira metafinanceira)
        {
            var metafinanceiraeditada = new {
                Titulo = metafinanceira.Titulo,
                Descricao = metafinanceira.Descricao,
                ValorMeta = metafinanceira.ValorMeta
            };

            await _dbContext.UpdateEntryAsync<MetaFinanceira>(metafinanceira.Id, metafinanceiraeditada);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<MetaFinanceira> DetalhesAsync(int id)
        {
            return await _dbContext.MetasFinanceiras.FindAsync(id);
        }
    }
}
