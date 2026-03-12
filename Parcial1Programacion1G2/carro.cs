using System;

namespace Parcial1Programacion1G2
{
    public class carro : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public carro(string marca, string modelo, int anio, int numeroPuertas)
            : base(marca, modelo, anio)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo: Carro");
            base.MostrarInformacion();
            Console.WriteLine("Número de puertas: " + NumeroPuertas);
        }

        public override void Encender()
        {
            Console.WriteLine("El carro se encendió con llave.");
        }
    }
}