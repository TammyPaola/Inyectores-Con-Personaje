using System;
using Soldados;
using Interfaces;

namespace AccionSoldados
{
    public class Disparos: Iarma
    {
        public bool disparar(soldados soldados)
        {
            Console.WriteLine("El personaje {0} se ah equipado con arma {1}", soldados.Nombre, soldados.Arma);
            return true;
        }
    }
}
