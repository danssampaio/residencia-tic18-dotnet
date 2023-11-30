using System.Reflection.Emit;

public class BankAccount
{
    private decimal Saldo;

    public BankAccount(decimal saldo)
    {
        Saldo = saldo;
    }

    public decimal _saldo
    {
        get { return Saldo; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Saldo não pode ser negativo");
            }
            Saldo = value;
        }
    }

}
