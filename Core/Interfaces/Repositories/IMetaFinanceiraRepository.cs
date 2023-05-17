using Core.Models;

namespace Core.Interfaces.Repositories
{
    public interface IMetaFinanceiraRepository
    {
        Task CadastrarAsync(MetaFinanceira meta);
    }
}
