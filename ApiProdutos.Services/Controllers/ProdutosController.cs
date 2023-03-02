using ApiProdutos.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProdutos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        /// <summary>
        /// serviço para  cadastro de produtos na API
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(ProdutosPostModel model)
        {
            return Ok();
        }

        /// <summary>
        /// serviço para edição de produto na API
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(ProdutosPutModel model)
        {
            return Ok();
        }

        /// <summary>
        /// serviço para exclusão de produto na API
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid? id)
        {
            return Ok();
        }

        /// <summary>
        /// serviço para consultar todos os produtos na API
        /// </summary>
        /// <returns></returns>

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<ProdutosGetModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        /// <summary>
        /// serviço para consultar 1 produto na API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ProdutosGetModel), 200)]
        public IActionResult GetById(Guid? id)
        {
            return Ok();
        }


    }
}
