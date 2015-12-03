using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarpSoft.StudentManager.Entitys
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Grau Grau { get; set; }
        public Serie Serie { get; set; }
        public Turno Turno { get; set; }
        public IList<Aluno> Alunos { get; set; }
        //public IList<Professor> Professores { get; set; }
        public int LimiteAlunos { get; set; }
    }
}