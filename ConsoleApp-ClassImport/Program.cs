using System;

namespace ConsoleApp_ClassImport

{
    class Program
    {
        static void Main(string[] args)
        {
           ClassPerson p1 = new ClassPerson(5, "Denis", "Zelaya");
            p1.mostrarInformacion();

            //String nombrePersona = p1.getNombre();
            //Console.WriteLine(nombrePersona);
        }
    }
}
