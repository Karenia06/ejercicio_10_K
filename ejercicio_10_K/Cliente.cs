using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_K
{
    class Cliente: Persona
    {
        private int telefono;

        public Cliente(string nom,int telefono)
        {
            this.Nom = nom;
            this.telefono = telefono;
        }

        public int Telefono { get => telefono; set => telefono = value; }

        public override void Mostrar()
        {
            Console.WriteLine(this.Nom);
            Console.WriteLine(this.Telefono);
        }
    }
}
