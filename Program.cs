using System;

namespace LendosalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo nome do Funcionário
            Console.WriteLine("Digite o nome do Funcionário : ");
            string nome = Console.ReadLine();

            // Obtendo Salario Bruto do Funcionario
            Console.WriteLine("Digite o salário Bruto do Funcionário : ");
            double salario = double.Parse(Console.ReadLine());

            // Obtendo o valor do Imposto do Funcionário
            Console.WriteLine("Qual é a taxa que o Funcionário paga de Imposto : ");
            double taxaImposto = double.Parse(Console.ReadLine());

            // Calculando o Imposto
            double imposto = salario * taxaImposto;

            // Calculando o salário líquido
            double salarioLiquido = salario - imposto;

            // Calculando o aumento de 20%
            double porcentagemAumento = 0.20; // 20% de aumento
            double aumento = salario * porcentagemAumento; // Valor do aumento
            double salarioComAumento = salario + aumento; // Salário com aumento

            // Exibindo saídas de dados do salário do Funcionário
            Console.WriteLine("\nNome do Funcionário : " + nome);
            Console.WriteLine("Salário bruto do Funcionário é : " + salario.ToString("F2"));
            Console.WriteLine("O funcionário paga " + imposto.ToString("F2") + " de imposto sobre o salário");

            // Exibindo o salário líquido do Funcionário
            Console.WriteLine("Salário líquido do Funcionário é : " + salarioLiquido.ToString("F2"));

            // Exibindo o salário com aumento de 20%
            Console.WriteLine("\nSalário com aumento de 20% é : " + salarioComAumento.ToString("F2"));

            Console.ReadLine();
        }
    }
}

