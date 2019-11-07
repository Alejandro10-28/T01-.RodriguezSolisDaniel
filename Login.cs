using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificacion2._0
{
   public class Login
    {
        //Se crea la lista usuarios donde guardara los usuarios que se vayan ingresando
        List<Usuario> usuarios = new List<Usuario>();
        Registro registro = new Registro();
        Usuario Us = new Usuario();
        //El metodo ingresarDatos ayudara a verificar que el usuario ya este registrado
        public void IngresarDatos()
        {
            Console.WriteLine("Ingresa tu nombre:");
            Us.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu usuario:");
            Us.Username = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            Us.Password = Console.ReadLine();
            //Se agregan los datos ingresado en la lista para despues compararlos con los ya existentes.
            usuarios.Add(Us);
            //Solo crea ruta para almacenar el enlace al archivo.
            string ruta = @"C: /Users/dany1/source/repos/Autentificacion2.0/Autentificacion2.0/bin/Debug/RegistroUsuario.txt";
            //Se usa la lista para datos donde llama el obtenerLineas para verificar que el archivo exista.
            List<string> datos = registro.ObtenerLineas(ruta);
            //Se manda como parametros la ruta y la informacion almacenada en datos.
            ValidarDatos(ruta, datos);
        }
        //Validar datos es el metodo que nos ayudara a comparar los datos ingresados con los ya obtenidos
        //se usa como parametro un string donde almacena el enlace, y la lista donde estan los datos registrados ya almacenados
        private void ValidarDatos(string ruta, List<string> datos)
        {
            //El foreach ayudara a pasar por la lista datos
            foreach(var iteam in datos)
            {
               //se usa un arreglo de string para guardar los datos ya registrados
               //y el split para cortar la cadena de string que ya se tiene.
                string[] Info = iteam.Split(',');
                //Se agrega la informacion obtenida en usuarios 
                //Donse se crea un nuevo dato de tipo usuario que sera igual al arreglo de 
                //cadena de string .
                usuarios.Add(new Usuario { Nombre = Info[0] });
            }
            //Se usa otro foreach para buscar en la lista de usuarios
            foreach(var u in usuarios)
            {
                //Se usa el if para comparar la informacion nueva con la ya existente
                if(u.Username==Us.Username && u.Password == Us.Password)
                {
                    //En dado caso que los datos ingresados sean iguales a los ya existentes se llama al metodo bienvenida
                    //Que es el cual ya reconoce que el usuario existe
                    Console.Clear();
                    Bienvenida(u);
                }
                //Si no existe el usuario se manda el mensaje para decirlo
                else
                {
                    Console.WriteLine("Usuario no registrado");
                }
            }

        }

        //Se crea el metodo bienvenida que usara como parametro usuario para asi llamar al nombre de este en la bienvenida.
        private void Bienvenida(Usuario U)
        {
            
            Console.WriteLine("BIENVENIDO A EXPOTEC:"+U.Username);
            Console.ReadKey();

        }
    }
}
