using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_K
{
    class Empleado: Persona
    {
        private double salario;

        public Empleado(string nom,int edad, double salario, Directivo direc)
        {
            this.Nom = nom;
            this.Edad = edad; 
            this.salario = salario;
        }

        public double Salario { get => salario; set => salario = value; }

        public override void Mostrar()
        {
            Console.WriteLine(this.salario);
        }
        public void CalSal()
        {
            Console.WriteLine("El salario bruto es: {0}", this.Salario); 
        }
    }
}
