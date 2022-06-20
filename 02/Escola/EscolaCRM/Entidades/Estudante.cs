namespace Entidades
{
    public class Estudante : Pessoa
    {
        public Turma Turma { get; set; }

        public override string ToString()
        {
            return base.ToString() +  "NumeroRegistro : " + NumeroRegistro;
        }
    }
}
