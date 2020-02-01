using System;
using System.Collections.Generic;

namespace ApiCapitaniCliente.Models
{
    public partial class Cliente
    {
        public int CodCli { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataNasc { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
    }
}
