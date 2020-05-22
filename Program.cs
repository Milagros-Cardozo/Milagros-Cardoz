using System;

namespace _22_5_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cuando tenemos polimorfismo?
                - Los objetos comparten una Interfaces
                - Los objetos pertenecen a la misma clase
                - Hay herencia
            */

            /*
                Intefaz vs clase con herencia:
                    - La clase puede compartir atributos
                    - La clase puede compartir compartamiento
                
                Si no comparten atributos ni comportamiento, elegimos la interfaz
            */

            Maestro katara = new MaestroAgua(30);

            Console.WriteLine("Katara es grosa?" + katara.esGroso());

            /*
                Tipos encapsulamiento:
                    - public: Se puede acceder desde cualquier punto de la aplicacion
                    - private: Solamente se utiliza en esa clase
                    - protected: Es como private, pero se puede acceder desde subclases
            */
            Maestro zuko = new MaestroFuego(50,200,10);
            Console.WriteLine("El poder de zuko es:" + zuko.poder());

            //Maestro roshi = new Maestro();//Tira error

        }
    }
}
