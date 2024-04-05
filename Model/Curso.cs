using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAapp2.Model
{
    public class Curso
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        private List<Aluno> alunos = new List<Aluno>();
        private List<Disciplina> disciplinas = new List<Disciplina>();

        public void AddAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public string ExibirAlunos()
        {
            string result = $"Alunos do Curso {Nome}:\n";
            foreach (var aluno in alunos)
            {
                result += $"{aluno.Nome}\n";
            }
            return result;
        }

        public void AddDisciplina(Disciplina disciplina)
        {
            disciplinas.Add(disciplina);
        }

        public string ExibirGrade()
        {
            string result = $"Grade do Curso {Nome}:\n";
            foreach (var disciplina in disciplinas)
            {
                result += $"{disciplina.Nome}\n";
            }
            return result;
        }
    }
}
