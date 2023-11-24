using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace Api_Empopasto.Controllers
{
    /// <summary>
    /// Anderson Benavides
    /// Controlador para el manejo del token
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthTokenController : ControllerBase
    {
        private readonly IAuthToken authToken;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_authToken"></param>
        /// <returns></returns>
        public AuthTokenController(IAuthToken _authToken)
        {
            this.authToken = _authToken;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para generar el token
        /// </summary>
        /// <param name="authModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        public async Task<IActionResult> GeneraToken(AuthModel authModel)
        {
            string vToken = authToken.GenerarToken(authModel);

            return Ok(new AuthResponseDto
            {
                IsAuthSuccessful = true,
                Token = vToken,
                ExpiresIn = DateTime.UtcNow.AddMinutes(10).ToString(),
                TokenType = "bearer"
            });
        }
    }
}
