using Core.Models;

namespace Core.Interfaces.Repositories
{
    public interface IMetaFinanceiraRepository
    {
        Task CadastrarAsync(MetaFinanceira meta);
        Task<IEnumerable<MetaFinanceira>> BuscarMetaFinanceiraAsync();
        Task<MetaFinanceira> BuscarMetaFinanceiraPorIdAsync(int id);
        Task ExcluirAsync(int id);
    }
}
