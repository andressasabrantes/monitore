namespace Web.Controllers
{
    [Route("Meta")]
    public class MetaFinanceiraController : Controller
    {
        public IActionResult Index() => View();

        [HttpGet("cadastrar")]
        public IActionResult MostrarViewCadastrar() => View("Cadastrar");
    }
}
