namespace Mv_school_API.models
{
    public class Aluno
    {

        public Aluno()
        {}
        public Aluno(int id, string nome, string sobrenome, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;

        }
        public int id { get; set; }
        public string nome { get; set; }

        public string sobrenome { get; set; }
        public string telefone { get; set; }

    }
}