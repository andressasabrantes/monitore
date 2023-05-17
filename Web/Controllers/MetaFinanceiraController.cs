namespace Web.Controllers
{
    [Route("MetaFinanceira")]
    public class MetaFinanceiraController : Controller
    {
        private readonly IMetaFinanceiraRepository _metafinanceiraRepository;
        public MetaFinanceiraController(IMetaFinanceiraRepository metafinanceiraRepository) 
        {
            _metafinanceiraRepository = metafinanceiraRepository;
        }
        public IActionResult Index() => View();

        [HttpGet("cadastrar")]
        public IActionResult MostrarViewCadastrar() => View("Cadastrar");

        [HttpPost]
        public async Task<IActionResult> Cadastrar(MetaFinanceira meta)
        {
            await _metafinanceiraRepository.CadastrarAsync(meta);
            return Ok();
        }
    }
}
