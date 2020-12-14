using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
        //    perguntar a operação
        Console.WriteLine("--- Sistema calculadora simples ---\r\n");
        Console.Write("Qual a operação deseja realizar? \r\nSoma, subtração, divisão ou multiplicação): ");
        string operacao = Console.ReadLine();

        

        // operação 1º
        Console.Write("Digite o primeiro número: ");
        float operacao1 = float.Parse(Console.ReadLine());

        // operação 2º
        Console.Write("Digite o segundo número: ");
        float operacao2 = float.Parse(Console.ReadLine());

        // fazer o cálculo da operação
        float calculo = 0;
    
        switch(operacao){
            case "Soma": 
            calculo = operacao1 + operacao2;
            break;

            case "Subtração":
            calculo = operacao1 - operacao2;
            break;

            case "Divisão":
            calculo = operacao1 / operacao2;
            break;

            case "Multiplicação":
            calculo = operacao1 * operacao2;
            break;

            default:
            Console.WriteLine("Operação inválida!");
            break;
            
        }

        // mostrar o resultado
        Console.WriteLine($"Resultado: {operacao1} com {operacao2} = {calculo}");
        }
    }
}
