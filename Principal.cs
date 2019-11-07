using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificacion2._0
{
    class Principal
    {
        //Se hacen las intancias de las clases que utilizaremos
        Usuario usuario = new Usuario();
        Registro registro = new Registro();
        Login L = new Login();
        //Se hace el metodo bienvenida que es la que se usara en el main que contendra todo los procesos ya creados
        public void Welcome()
        {
            Console.WriteLine("=====BIENVENIDO USUARIOS DEL TECNOLOGICO=======");
            Console.WriteLine(">> Crea una nueva cuenta para disfrutar de nuestras opciones");
            Menu();
        }

        public void Menu()
        {
            Console.WriteLine("Escoja una opción:\n1-.Registrarse\n2-.Iniciar sesion");
            //Se hace el switch para que el usuario pueda escoger la opcion que desea.
            switch (Console.ReadLine())
            {
                case "1":
                    //Se usa el metodo registrar usuario el cual manda como parametro el enlace del archivo y la instancia del usuario.
                    registro.RegistrarUsuario(usuario, @"C: /Users/dany1/source/repos/Autentificacion2.0/Autentificacion2.0/bin/Debug/RegistroUsuario.txt");

                    break;
                case "2":
                    //Se llama ingresar usuario para comparar los datos.
                    L.IngresarDatos();
                    break;
            }
        }
    }
}
//C:/Users/dany1/OneDrive/Documents/RegistroUsuarios.txt