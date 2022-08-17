namespace Escola.Api.Model;

public class Turma
{
    public int Id { get; set; }
    public string Serie { get; set; }
    public IEnumerable<Materia> Materias { get; set; }
    public IEnumerable<Aluno> Alunos { get; set; }
}

