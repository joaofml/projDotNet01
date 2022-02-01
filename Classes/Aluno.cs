namespace projDotNet01.Classes
{
    public class Aluno
    {
        public int cadastro { get; set; }
        public string nome { get; set; }
        public double nota { get; set; }

        public Aluno(int cadastro, string nome, double nota)
        {
            this.cadastro = cadastro;
            this.nome = nome;
            this.nota =nota;
        }

        public override string ToString()
        {
            return $"Cadastro: {this.cadastro}" + Environment.NewLine +
                   $"Nome: {this.nome}" + Environment.NewLine + 
                   $"Nota: {this.nota}" + Environment.NewLine;
        }

    }
}