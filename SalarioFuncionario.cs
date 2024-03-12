using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LendosalarioFuncionario.obj
{
    public class SalarioFuncionario
    {
        public string Nome { get; private set; }
        public double SalarioBruto { get; private set; }
        public double TaxaImposto { get; private set; }

        // Construtor
        public SalarioFuncionario(string nome, double salarioBruto, double taxaImposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            TaxaImposto = taxaImposto;
        }

        // Método para calcular o imposto
        public double CalcularImposto()
        {
            return SalarioBruto * TaxaImposto;
        }

        // Método para calcular o salário líquido
        public double CalcularSalarioLiquido()
        {
            return SalarioBruto - CalcularImposto();
        }

        // Método para aumentar o salário com base em uma porcentagem
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto *= (1 + porcentagem);
        }
    }
}