using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        int idade = 32;
        string nome = "Rafael";
        double saldo = 10.35784;

        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //Placeholder
        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //Interpolação
        Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //Concatenação
                
    }
}
