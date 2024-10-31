using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32_Eva
{
    internal class Matricula
    {
        // Propiedades
        private int Estudiante { get; set; }
       
        public Matricula(int Estudiante)
        {
            Estudiante = Estudiante;
        }

        public void Costo_Subsidio()
        {
            decimal Valor_Final = Estudiante.CalculoMatricula();
            decimal Subsidio = Estudiante.Calculo_Subsidio();

            Console.WriteLine($"El costo de la matricula es: {Valor_Final:C}");
            Console.WriteLine($"El subsidio otorgado es: {Subsidio:C}");
        }

    }
}


