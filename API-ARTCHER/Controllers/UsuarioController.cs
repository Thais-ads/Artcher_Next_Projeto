using API_ARTCHER.Data;
using API_ARTCHER.Data.DTO;
using API_ARTCHER.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_ARTCHER.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {

        // injeção dependence
        private CadastroContext _context;
  
        public UsuarioController(CadastroContext teste)
        {
            _context = teste;
        }





        /// <summary>
        /// Adiciona um Usuario ao banco de dados
        /// </summary>
        /// <param name="createDto">Object Create</param>
        /// <returns>IActionResult</returns>
        /// <response code="201">Caso inserção seja feita com sucesso</response>

        [HttpPost("CadastrandoUsuario")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CadastroCliente([FromBody] CreateUsuarioDto dto)
        {


            var emailBanco = _context.CadastroDeUsuarios.FirstOrDefault(emaill => emaill.Email == dto.Email);
            var usuarioBanco = _context.CadastroDeUsuarios.FirstOrDefault(usuario => usuario.Usuario == dto.Usuario);

            if (emailBanco == null && usuarioBanco == null)
            {
                CadastroUsuario usuario = new CadastroUsuario
                {
                    Nome = dto.Nome,
                    Senha = dto.Senha,
                    Email = dto.Email,
                    Usuario = dto.Usuario,
                    Data = dto.Data
                };


                await _context.AddRangeAsync(usuario);
                await _context.SaveChangesAsync();

                return Ok(usuario);
                //Status 200,201
            }

            return BadRequest("E-mail ou usuario já existe");
            throw new ApplicationException("Falha");

        }

        /// <summary>
        /// Valida o login do Usuario ao banco de dados
        /// </summary>
        /// <param name="dto">Object transfer</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Caso inserção seja feita com sucesso</response>
        [HttpPost("LoginUsuario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public async Task <IActionResult> LoginUsuario([FromBody] LoginDto acesso)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;

            var validaEmail =   await  _context.CadastroDeUsuarios.FirstOrDefaultAsync(valemail => valemail.Email == acesso.EmailUser);
            var validaUsuario = await  _context.CadastroDeUsuarios.FirstOrDefaultAsync(valusuario => valusuario.Usuario == acesso.Senha);
            LoginDto loginUsuario = new LoginDto();

            if (validaEmail == null && validaUsuario == null)
            {
                return NotFound("Usuario não cadastrado");
            }
            else if (validaEmail == null && validaUsuario != null)
            {
                loginUsuario.EmailUser = validaUsuario.Usuario;
                loginUsuario.Senha = validaUsuario.Senha;
            }
            else
            {
                loginUsuario.EmailUser = validaEmail.Email;
                loginUsuario.Senha = validaEmail.Senha;
            }
            
            if (loginUsuario.Senha == acesso.Senha)
            {
                return Ok("Autenticado!!!");
            }

            return NotFound("Senha invalida!!!");
            throw new ApplicationException("Falha");


            //Status 201,404
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
        public async  Task<IActionResult> RecuperaUsuarioID(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var usuario =  await _context.CadastroDeUsuarios.FirstOrDefaultAsync(usuario => usuario.Id == id);
            if (usuario == null) return NotFound();
            return Ok(usuario);


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
        public async Task<IActionResult> RecuperaUsuario(int id, [FromBody] UpdateUsuario updateusuario)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var user =  await _context.CadastroDeUsuarios.FirstOrDefaultAsync(usuarios => usuarios.Id == id);

            if (user == null) return NotFound();

            //passando os valores;
            user.Nome = updateusuario.Nome;
            user.Senha = updateusuario.Senha;
            user.Email = updateusuario.Email;


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
        public async Task<IActionResult> deletausuario(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var user =  await _context.CadastroDeUsuarios.FirstOrDefaultAsync(usuarios => usuarios.Id == id);

            if (user == null) return NotFound();

            //passando os valores;


            _context.Remove(user);
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
