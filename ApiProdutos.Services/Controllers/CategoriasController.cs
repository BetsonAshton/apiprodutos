using ApiProdutos.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProdutos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        /// <summary>
        /// serviço para  cadastro de  categora na API
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(CategoriasPostModel model)
        {
            return Ok();
        }

        /// <summary>
        /// serviço para edição de categoria na API
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(CategoriasPutModel model)
        {
            return Ok();
        }

        /// <summary>
        /// serviço para exclusão de categoria na API
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid? id)
        {
            return Ok();
        }

        /// <summary>
        /// serviço para consultar todas as categorias na API
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType(typeof(List<CategoriasGetModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        /// <summary>
        /// serviço para consultar 1 categoria na API
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CategoriasGetModel),200)]
        public IActionResult GetById(Guid? id)
        {
            return Ok();
        }

    }
}
