using System;
using System.Diagnostics;

namespace DelegadosYEventosG4
{
    class Program
    {
        private delegate void MensajeDelegado(string dato);
        private static void MensajeCajero()
        {
            Console.WriteLine("Es posible que ingresaste un nombre incorrecto");
        }

        private static void OperacionCajero(int opcion)
        {
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Por el momento no puedo realizar esa operación");
                    break;
                case 2:
                    Console.WriteLine("Seleccione cantidad :\n 1)100 \n2)200 \n3)500  \n4)1000   ");
                    break;

            }

        }

        static void Main()
        {
            Banco miBanco = new Banco();
            miBanco.ValidaUsuario += MensajeCajero;
            miBanco.Operacion += OperacionCajero;
            MensajeDelegado miDelegado = new MensajeDelegado(miBanco.MensajeBanco);
            Console.WriteLine("Ingresa tu nombre");
            string nombre = Console.ReadLine();
            miDelegado(nombre);

            
            Random funcionaAleatorio = new Random();
            int funciona = funcionaAleatorio.Next(2);
          
            if( funciona == 1)
            {
                miBanco.DisparaValida();
            }
            else
            {
                miBanco.Operacion -= OperacionCajero;
                try
                {
                    miBanco.DisparaValida();
                }
                catch(NullReferenceException)
                {
                    Console.WriteLine(" Cajero en mantenimiento ");
                }
                

            }    




            miDelegado = new MensajeDelegado(SPEI.MensajeSPEI);
            string hora = DateTime.Now.ToString("hh:mm");
            miDelegado(hora);



        }
    }
}
