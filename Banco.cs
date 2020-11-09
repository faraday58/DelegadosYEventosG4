using System;

namespace DelegadosYEventosG4
{
    class Banco
    {
        private string nombre;
        public delegate void DelegadoValidaUsuario();
        public event DelegadoValidaUsuario ValidaUsuario;


        public void MensajeBanco(string Nombre)
        {
            Console.WriteLine("Bienvenido {0} a la red de tu Banco", Nombre);
            nombre = Nombre;
        }


        public void DisparaValida()
        {
            if ( nombre != "Armando")
            {
                Console.WriteLine("El usuario no es válido en el sistema");
                ValidaUsuario();
            }

        }


    }
}
