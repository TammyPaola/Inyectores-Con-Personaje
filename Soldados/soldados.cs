using System;

namespace Soldados
{
    public class soldados
    {
        public string Nombre { get; set; }
        public string Arma { get; set; }
        public soldados(string nombre, string arma)
        {
            Nombre = nombre;
            Arma = arma;

        }

    }
}
