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
        

        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade2 = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.00;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("\nProdutos:");
        Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
        Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto2, preco2);
        Console.WriteLine($"\nRegistro: {idade2} anos de idade, código {codigo} e gênero: {genero}");
        Console.WriteLine($"\nMedida com oito casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
    }
}
