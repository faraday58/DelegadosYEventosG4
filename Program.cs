using System;

namespace DelegadosYEventosG4
{
    class Program
    {
        private delegate void MensajeDelegado(string dato);
        private static void MensajeCajero()
        {
            Console.WriteLine("Es posible que ingresaste un nombre incorrecto");
        }


        static void Main()
        {
            Banco miBanco = new Banco();
            miBanco.ValidaUsuario += MensajeCajero;
            MensajeDelegado miDelegado = new MensajeDelegado(miBanco.MensajeBanco);
            Console.WriteLine("Ingresa tu nombre");
            string nombre = Console.ReadLine();
            miDelegado(nombre);
            miBanco.DisparaValida();


            miDelegado = new MensajeDelegado(SPEI.MensajeSPEI);
            string hora = DateTime.Now.ToString("hh:mm");
            miDelegado(hora);




        }
    }
}
