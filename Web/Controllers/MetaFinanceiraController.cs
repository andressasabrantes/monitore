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

        [HttpGet]
        public async Task<IActionResult> BuscarMetaFinanceira() => View("Index", await _metafinanceiraRepository.BuscarMetaFinanceiraAsync());

        [HttpGet("excluir")]
        public async Task<IActionResult> MostrarViewExcluir(int id) 
        {
            if (id == default)
                return BadRequest("Meta financeira não encontrada");

            return View("Excluir", await _metafinanceiraRepository.BuscarMetaFinanceiraPorIdAsync(id));
        }

        [HttpPost("excluir")]
        public async Task<IActionResult> Excluir(int id) 
        {
            await _metafinanceiraRepository.ExcluirAsync(id);
            return Ok();
        }
    }
}
