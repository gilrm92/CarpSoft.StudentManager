using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarpSoft.StudentManager.Entitys
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public IList<Familiar> DadosFamiliares { get; set; }
    }
}