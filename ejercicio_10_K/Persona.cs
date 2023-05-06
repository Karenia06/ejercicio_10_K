using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_K
{
    class Persona
    {
        private string nom;
        private int edad;

        public Persona() { }
        public Persona(string nom, int edad)
        {
            this.nom = nom;
            this.edad = edad;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Edad { get => edad; set => edad = value; }

        public virtual void Mostrar()
        {
            Console.WriteLine(this.nom);
            Console.WriteLine(this.edad);
        }
    }

    
}
