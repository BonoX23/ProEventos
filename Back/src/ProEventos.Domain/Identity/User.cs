using System.Collections.Generic;
using ProEventos.Domain.Enum;

namespace ProEventos.Domain.Identity
{
    public class User
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Titulo Titulo { get; set; }
        public string Descricao { get; set; }
        public Funcao Funcao { get; set; }
        public string ImagemURL { get; set; }
        //Saber quais são as roles desse usuario
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}