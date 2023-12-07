namespace EscritorioJuridico
{
    public class Cliente : Pessoa
    {
        public string EstadoCivil { get; set; }
        public string Profissao { get; set; }

        public List<IPagamento> pagamentos {get; set;}

        public PlanoConsultoria? plano { get; set; }

        public Cliente(string nome, DateTime dataNascimento, string cpf, string estadoCivil, string profissao, List<IPagamento>? pagamentos, PlanoConsultoria? plano)
            : base(nome, dataNascimento, cpf)
        {
            EstadoCivil = estadoCivil;
            Profissao = profissao;
        }
    }
}