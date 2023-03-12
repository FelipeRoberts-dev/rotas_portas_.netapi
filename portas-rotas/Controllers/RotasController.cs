using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portas_rotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RotasController : ControllerBase
    {
        [HttpGet("metodo1")]
        [HttpGet("metodo1rout2")]  //Recebendo o end-point do metodo em duas rotas
        public string pagamento() => "Metodo 1";

        [HttpGet]  //Recebendo o end-point do metodo rota default
        public string pedidos() => "Metodo2";

        [Route("pedidos3")] //Recebendo o end-point do metodo com Routas declarando com Route
        public string pedidos3xxx() => "Metodo3";

        [HttpGet("pedidos3/{id}")] //Recebendo parametros por rota.
        public string pedidos3param(int id) => $"param do metodo 4 - o que foi passado: {id}";




    }
}
