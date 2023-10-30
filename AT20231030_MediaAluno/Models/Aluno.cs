namespace AT20231030_MediaAluno.Models
{
    public class Aluno
    {//Aluno (Nome, Telefone, DataNasc, Endereco, NomePai, NomeMae, Nota1, Nota2, Nota3, Nota4, Média (calculado))
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string DataNasc { get; set; }
        public string Endereco { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public double? Media { get; set; }
    }
}
