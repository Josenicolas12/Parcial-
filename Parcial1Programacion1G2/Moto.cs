using System;

namespace Parcial1Programacion1G2
{
    public class Moto : Vehiculo
    {
        public int Cilindraje { get; set; }

        public Moto(string marca, string modelo, int anio, int cilindraje)
            : base(marca, modelo, anio)
        {
            Cilindraje = cilindraje;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo: Moto");
            base.MostrarInformacion();
            Console.WriteLine("Cilindraje: " + Cilindraje);
        }

        public override void Encender()
        {
            Console.WriteLine("La moto se encendió con botón.");
        }
    }
}