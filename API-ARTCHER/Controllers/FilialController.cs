using API_ARTCHER.Data;
using API_ARTCHER.Data.DTO;
using API_ARTCHER.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace API_ARTCHER.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    
    public class FilialController: ControllerBase
    {



        // injeção dependence
        private CadastroContext _context;
   


        public FilialController(CadastroContext teste/*, IMapper mapper*/)
        {
            _context = teste;
            //_mapper = mapper;
        }






        /// <summary>
        /// Adiciona uma Filial ao banco de dados
        /// </summary>
        /// <param name="FilialDto">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="201">Caso inserção seja feita com sucesso</response>
        /// 
        [HttpPost("CadastrandoUsuario")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CadastroFilial( [FromBody]  CreateFilialDto dto)
        {


            CadastroFilial testebanco = new CadastroFilial 
            { 
                NomeDaFilial = dto.NomeDaFilial,
                Contato = dto.Contato,
                Endereco = dto.Endereco,
                Numero = dto.Numero,
                Bairro = dto.Bairro,
                Descricao = dto.Descriacao,
                Foto = dto.Foto,
                Data= dto.Data

            };

           await  _context.AddAsync(testebanco);
          await  _context.SaveChangesAsync();

                return Ok(testebanco);
                //Status 200,201
            
            
            //Testebanco testebanco = _mapper.Map<Testebanco>(dto);


        }







        /// <summary>
        ///Atualiza uma filial ao banco de dados
        /// </summary>
        /// <param name="FilialDto">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso inserção seja feita com sucesso</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> AtualizarFilial(int id, [FromBody] CreateFilialDto dto)
        {
            var filial =  await _context.CadastroFilials.FirstOrDefaultAsync(filial => filial.Id == id);
            if (filial == null) return NotFound();

            filial.NomeDaFilial = dto.NomeDaFilial;
            filial.Contato = dto.Contato;
            filial.Endereco = dto.Endereco;
            filial.Numero = dto.Numero;
            filial.Bairro = dto.Bairro;
            filial.Descricao = dto.Descriacao;
            filial.Foto = dto.Foto;

          await  _context.SaveChangesAsync();

            return NoContent();
        }








        /// <summary>
        /// Faz a busca da filial no banco de dados
        /// </summary>
        /// <param name="id">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Caso inserção seja feita com sucesso</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public async Task<IActionResult> RecuperaFilialID(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var filial = await _context.CadastroFilials.FirstOrDefaultAsync(filial => filial.Id == id);
            if (filial == null) return NotFound();
            return Ok(filial);



            //Status 201,404
        }










        /// <summary>
        /// Apaga uma filial ao banco de dados
        /// </summary>
        /// <param name="id">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso inserção seja feita com sucesso</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        //retornando de acordo com o VERBO HTTP, então adicionamos o IACTIONRESULT
        public async Task<IActionResult> DeleteFilialID(int id)
        {

            //usuario que eu estou buscando tem o ID igual ao o Parametro recebido;
            var filial = await _context.CadastroFilials.FirstOrDefaultAsync(filial => filial.Id == id);
            if (filial == null) return NotFound();

            _context.Remove(filial);
          await  _context.SaveChangesAsync();
            return NoContent();



            //Status 201,404
        }

    }

}
