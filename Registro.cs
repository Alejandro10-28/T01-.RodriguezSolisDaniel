using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se usa el using System.IO para poder hacer uso de los archivos(File)
using System.IO;
namespace Autentificacion2._0
{
    class Registro
    {
        //Se crea el metodo registrarUsuario y tiene como parametro la clase usuario para utilizar los atributos que 
        //contienen y otro de tipo string para almacenar la ruta al archivo.
        public void RegistrarUsuario(Usuario U, string path)
        {
            //Se pide que llene los datos correspondientes
            Console.WriteLine("Ingresa tu nombre:");
            U.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu nombre de usuario:");
            U.Username = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña:");
            U.Password = Console.ReadLine();

            //Se crea la variable data para que guarde los datos ingresados por el usuario.
            string data = U.Nombre + "," + U.Username + "," + U.Password;
            //datos guarda el metodo ObtenerLineas para asegurarse de el que archivo exista por ello se manda como parametro
            //el enlace
            var datos = ObtenerLineas(path);
            //Se usa un if para verificar si Datos es diferente a nulo.
            if (datos != null)
            {
                //De ser diferente a nulo datos agrega lo ingresado por el usuario que se almaceno en data.
                datos.Add(data);
                //Se crea un archivo nuevo, escribe una colección de cadenas en él y lo cierra.

                File.WriteAllLines(path, datos);
            }
            else
            {
                //Se encarga de escribir el texto en el archivo.
                File.WriteAllText(path, data);
            }



        }

        //Se crea un metodo de tipo lista para con un parametro string que el que recibe la ruta del archivo
        //y la lista sirve para almacenar las lineas que se mandan.
        public List<string> ObtenerLineas(string path)
        {
            //Se crea un arreglo de string para que sea igual a nulo
            string[] data = null;
            //El if se usa para verificar que el archivo exista por eso utiliza path que es el que contiene la ruta
            if (File.Exists(path))
            {
                //Si el archivo existe entonces lee todo lo que contiene las lineas
                //y las guarda en data.

                data = File.ReadAllLines(path);
                Console.WriteLine("REGISTRO EXITOSO...");
                Console.ReadKey();
            }
            else

            {
                //Si no se encuentra nada entonces manda el mensaje y cierra el programa
                Console.WriteLine("No se encontro ningún archivo");
                return null;
            }
            //Se crea una lista de tipo string llamada Datos donde se agregara la informacion almacenada en data.
            List<string> Datos = new List<string>();
            foreach(var iteam in data)
            {
                Datos.Add(iteam);
            }
            //Y datos es lo que devolvera el metodo.
            return Datos;
        }
    }
}
