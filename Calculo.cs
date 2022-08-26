using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class Calclular
    {
        private float Combustivel1;

        public float combustivel1
        {
            get { return this.Combustivel1; }
            set { this.Combustivel1 = value; }
        }

        private float Combustivel2;

        public float combustivel2
        {
            get { return Combustivel2; }
            set { Combustivel2 = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine(" Valor do Alcool " + Combustivel1);
            Console.WriteLine("Valor da Gasolina " + Combustivel2);
            float total = this.Resultado ();

            if (total <= 0.7)
            {
                Console.WriteLine("compensa mais colocar Alcool  " + total);
            }

            else  
                    {
                Console.WriteLine("compensa mais colocar Gasolina  " + total);
            }
        }

        private float Resultado()
        {
            float total = Combustivel1/Combustivel2;
            return total;
        }
    }
}