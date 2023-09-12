using API_ARTCHER.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API_ARTCHER.Controllers
{


    [ApiController]
    [Route("[Controller]")]
    public class AuthController : Controller
    {


        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;



        public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]

        public async Task <IActionResult> Registrar(CadastroUsuario dto)
        {
            if(ModelState.IsValid) {

                var user = new IdentityUser
                {
                    UserName = dto.Usuario,
                    Email = dto.Email
                    
                };

                var result = await userManager.CreateAsync(user, dto.Senha );

                if(result.Succeeded)
                {

                    return Ok();
                }

            }
            return NotFound("Erro");
        } 


    }
}
