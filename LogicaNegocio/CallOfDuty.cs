using System;
using Soldados;
using Interfaces;

namespace LogicaNegocio
{
    public class CallOfDuty
    {
        Iarma Arma;

        public CallOfDuty(Iarma Arma)
        {
            this.Arma = Arma;
        }
        public void EjecucionDisparar(soldados soldados)
        {
            Arma.disparar(soldados);
        }
    }
}
