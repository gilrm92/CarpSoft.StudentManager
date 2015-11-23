using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarpSoft.StudentManager.Entitys
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public IList<Endereco> Enderecos { get; set; }
        public IList<Email> Emails { get; set; }
        public IList<Telefone> Telefones { get; set; }
    }
}
