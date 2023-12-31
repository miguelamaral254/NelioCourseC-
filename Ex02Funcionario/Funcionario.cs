using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02Funcionario
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;

        public double Imposto;

        public double AumentoS;


        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public double NovoSalarioLiquido(){
            return SalarioLiquido() + ((AumentoS / 100) * SalarioBruto);
        }
    }
}