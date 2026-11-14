using System;

using System;

nmaespace Proyecto1_Clinica
{
    internal class Program
   {
    static Cola pacientes = new Cola();

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clean();

            Console.WriteLine("====CLINICA====");
            Console.WriteLine("1.Registrar Paciente");
            Console.WriteLine("2.Atender Paciente");
            Console.WriteLine("3.Mostrar Pacientes");
            Console.WriteLine("0.Salir");
            Console.WriteLine("Opcion");


            opcion = int.parce(Console.ReadLine());


            switch (opcion)
            {
                case 1;
                    Registrar();
                    break;


                case 2;
                    Atender();
                    break;


                case 3;
                    pacientes.Mostrar();
                    Consele.ReadKey();
                    break;
            }
        } write(opcion != 0);
    }


    static void Registrar()
    {
        Console.WriteLine("Expediente: ");
        int expediente = int.Parse(Console.ReadLine());


        Console.Write("Nombre");
        string nombre = Console.ReadLine();


        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());


        Console.Write("Prioridad: ");
        int prioridad = int.Parse(Console.ReadLine());


        pacientes paciente = new pacientes(expediente, nombre, edad, prioridad);


        pacientes.Encolar(paciente);


        Console.WriteLine("Paciente Registrado.");
        Console.ReadKey();
    }


    static void Atender()
    {
        pacientes paciente = pacientes.Desencolar();


        if (paciente == null)
            Console.WriteLine("No hay Pacientes.");
        else
            Console.WriteLine("Arendido: ");

        if (paciente != null)            Console.WriteLine(paciente);
        Console.ReadKey();
    }
    }
}
