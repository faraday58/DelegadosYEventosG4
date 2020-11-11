using System;

namespace DelegadosYEventosG4
{
    class Banco
    {
        private string nombre;
        public delegate void DelegadoValidaUsuario();
        public event DelegadoValidaUsuario ValidaUsuario;

        public delegate void DelegadoOperacion(int opcion);
        public event DelegadoOperacion Operacion;


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
            }else
            {
                Console.WriteLine("Proceder a las operaciones siguientes: \n 1)Estado de cuenta \n 2)Retiro de Efectivo ");
                int opcion = int.Parse(Console.ReadLine());
                Operacion(opcion);
            }

        }


    }
}
