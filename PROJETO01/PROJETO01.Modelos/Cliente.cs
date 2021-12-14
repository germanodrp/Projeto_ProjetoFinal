using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
    public class Cliente
    {
        public string ClienteID { get; set; }
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public  DateTime DataNascimento { get; set; }
    }
}
