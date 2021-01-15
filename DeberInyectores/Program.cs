using System;
using Interfaces;
using Soldados;
using LogicaNegocio;
using AccionSoldados;
using Ninject;

namespace DeberInyectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a mi Personaje");
            var opcionUsuario = 0;
            var kernel = new StandardKernel();

            Console.WriteLine("Escoje tu personaje Call Of Duty");
            Console.WriteLine("1.- Ghost");
            Console.WriteLine("2.- Price");
            Console.WriteLine("3.- Soap");
            Console.WriteLine("4.- David Mason");
            opcionUsuario = int.Parse(Console.ReadLine());

            if (opcionUsuario == 1)
            {
                soldados soldado1 = new soldados("Ghost", "BK57");
                kernel.Bind<Iarma>().To<Disparos>();
                var jugador1 = kernel.Get<CallOfDuty>();
                jugador1.EjecucionDisparar(soldado1);
            }
            if (opcionUsuario == 2)
            {
                soldados soldado2 = new soldados("Price", "LK24");
                kernel.Bind<Iarma>().To<Disparos>();
                var jugador2 = kernel.Get<CallOfDuty>();
                jugador2.EjecucionDisparar(soldado2);
            }
            if (opcionUsuario == 3)
            {
                soldados soldado3 = new soldados("Soap", "MAN O WAR");
                kernel.Bind<Iarma>().To<Disparos>();
                var jugador3 = kernel.Get<CallOfDuty>();
                jugador3.EjecucionDisparar(soldado3);
            }
            if (opcionUsuario == 4)
            {
                soldados soldado4 = new soldados("David Mason", "ARTIC 50");
                kernel.Bind<Iarma>().To<Disparos>();
                var jugador4 = kernel.Get<CallOfDuty>();
                jugador4.EjecucionDisparar(soldado4);
            }
    
            }

        }
    }


