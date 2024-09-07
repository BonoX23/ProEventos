using System.Security.Claims;

namespace ProEventos.API.Extensions
{
    //Toda vez que se está criando um método de extensão, a classe deve ser estatica
    public static class ClaimsPrincipalExtensions
    {
        // O metódo de extensão tem a ver com o primeiro parametro  que for passado, e não com o nome da classe
        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}