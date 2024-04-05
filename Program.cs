using SCAapp2.Model;

class Program
{
    static void Main()
    {
        // Criando instâncias das classes
        Aluno aluno1 = new Aluno { Matricula = 1, Nome = "Alice" };
        Aluno aluno2 = new Aluno { Matricula = 2, Nome = "Bob" };
        Disciplina disciplina1 = new Disciplina { Codigo = 101, Nome = "Matemática" };
        Disciplina disciplina2 = new Disciplina { Codigo = 102, Nome = "História" };

        Curso curso1 = new Curso { Codigo = 1, Nome = "Engenharia" };
        curso1.AddAluno(aluno1);
        curso1.AddAluno(aluno2);
        curso1.AddDisciplina(disciplina1);
        curso1.AddDisciplina(disciplina2);

        // Exibindo informações do curso
        Console.WriteLine($"Curso: {curso1.Nome}, Código: {curso1.Codigo}");
        Console.WriteLine(curso1.ExibirAlunos());
        Console.WriteLine(curso1.ExibirGrade());
    }
}