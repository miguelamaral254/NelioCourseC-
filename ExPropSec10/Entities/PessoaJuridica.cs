namespace ExPropSec10.Entities;
internal class PessoaJuridica : PessoaFisica
{
    public int NumeroFuncionarios { get; set; }

    public PessoaJuridica()
    {
    }

    public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
        : base(nome, rendaAnual)
    {
        NumeroFuncionarios = numeroFuncionarios;
    }

    public override double Imposto()
    {
        if (NumeroFuncionarios > 10)
        {
            return RendaAnual * 0.14;
        }
        else
        {
            return RendaAnual * 0.16;
        }

    }
}