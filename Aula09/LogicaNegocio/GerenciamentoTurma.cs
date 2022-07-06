using Modelo.Dados;

namespace LogicaNegocio;
public class GerenciamentoTurma
{
    //CRUD
    //Create 
    //Read
    //Update
    //Delete
    private Turma turma;

    public GerenciamentoTurma()
    {
        turma.Alunos = new List<Aluno>();
    }

    public void AdicionarAluno(Aluno aluno)
    {
        turma.Alunos.Add(aluno);
    }

    public Aluno ObterAlunoPorNome(string nome)
    {
        var alunoSelecionado = (from aluno in turma.Alunos
                                orderby aluno.DataNascimento descending
                                where aluno.Nome == nome
                                select aluno).FirstOrDefault();
        /*
         Select * 
         from alunos 
         where nome = @nome
         */

        return alunoSelecionado;
    }

    public Aluno ObterAlunoPorNomeUsandoExpressaoLambda(string nome)
    {
        var alunoSelecionado = turma.Alunos
                                    .Where(aluno => aluno.Nome.Equals(nome))
                                    .OrderByDescending(aluno => aluno.DataNascimento)
                                    .FirstOrDefault();
        return alunoSelecionado;
    }

    public Aluno ObterAlunoPorNomeUsandoExpressaoLambdaFirstOrDefault(string nome)
    {
        var alunoSelecionado = turma.Alunos
                                    .OrderByDescending(aluno => aluno.DataNascimento)
                                    .FirstOrDefault(aluno => aluno.Nome.Equals(nome));                                    
        return alunoSelecionado;
    }

    public List<Aluno> ObterTodosOsAlunosComOnome(string nome)
    {
        var alunosSelecionados = turma.Alunos.Where(aluno => aluno.Nome == nome).ToList();
        return alunosSelecionados;
    }

}
