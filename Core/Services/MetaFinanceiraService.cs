using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace Core.Services
{
    public class MetaFinanceiraService : IMetaFinanceiraService
    {
        private readonly IMetaFinanceiraRepository _metafinanceiraRepository;

        public MetaFinanceiraService(IMetaFinanceiraRepository metafinanceiraRepository) 
        {
            _metafinanceiraRepository = metafinanceiraRepository;
        }
    }
}
