namespace TellDontAskKata.Main.UseCase;

public class TaxRounding
{
    public static decimal Round(decimal amount)
    {
        return decimal.Round(amount, 2, System.MidpointRounding.ToPositiveInfinity);
    }
}