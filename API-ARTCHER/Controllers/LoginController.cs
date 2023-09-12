using API_ARTCHER.Data;
using API_ARTCHER.Data.DTO;
using API_ARTCHER.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_ARTCHER.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class LoginController : ControllerBase
    {

        // injeção dependence
        private CadastroContext _context;

        public LoginController(CadastroContext teste)
        {
            _context = teste;
        }

        /// <summary>
        /// Adiciona uma Filial ao banco de dados
        /// </summary>
        /// <param name="login"></param>
        /// <returns>IActionResult</returns>
        /// <response code="201">Caso inserção seja feita com sucesso</response>
        /// 
        [HttpPost("Cadastrandologin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CadastroLogin([FromBody] Login login)
        {

            await _context.AddAsync(login);
            await _context.SaveChangesAsync();

            return Ok(login);
            //Status 200,201


        }

        /// <summary>
        /// Faz uma busca pelo usuario atravez do  banco de dados
        /// </summary>
        /// <param name="id">Objeto com os campos necessários</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Caso inserção seja feita com sucesso</response>


        [HttpGet("{id}")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public async  Task<IActionResult> RecuperaLoginID(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var login =  await _context.Login.FirstOrDefaultAsync(usuario => usuario.Id_Log == id);
            if (login == null) return NotFound();
            return Ok(login);

            throw new NotImplementedException();
            //Status 201,404
        }


        /// <summary>
        /// Atualiza um usuario ao banco de dados
        /// </summary>
        /// <param name="UpdateUsuario">Objeto para atualizar</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso inserção seja feita com sucesso</response>


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public async Task<IActionResult> RecuperaLogin(int id, [FromBody] UpdateLogin updateLogin)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var user =  await _context.Login.FirstOrDefaultAsync(usuarios => usuarios.Id_Log == id);

            if (user == null) return NotFound();

            //passando os valores;
            user.Nome = updateLogin.Nome;
            user.Senha = updateLogin.Senha;
            user.Email = updateLogin.Email;
            user.Telefone = updateLogin.Telefone;
            user.Foto = updateLogin.Foto;

            //salvando no banco;
            _context.SaveChanges();

            return NoContent();

            //Status 201,404
        }

        /// <summary>
        /// Apaga um Usuario ao banco de dados
        /// </summary>
        /// <param name="id">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso inserção seja feita com sucesso</response>

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public async Task<IActionResult> deletaLogin(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var login =  await _context.Login.FirstOrDefaultAsync(usuarios => usuarios.Id_Log == id);

            if (login == null) return NotFound();

            //passando os valores;

            _context.Remove(login);
            _context.SaveChanges();

            return NoContent();

            //Status 201,404
        }



        //[HttpGet("Exibindoporpaginacao")]
        
        //    //skip pula e take pegaaa, quando tiver muita informação ;
        //  return  usuarios.Skip(skip).Take(take);//   public IEnumerable<Testebanco> Exibindoporpaginacao([FromQuery] int skip, [FromQuery] int take)
        //{

        //}


    }

}
