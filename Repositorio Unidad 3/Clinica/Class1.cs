using System;

namespaces Proyecto1_Clinica
{
    public class Nudo
{
    public Paciente Datos;
    public Nodo Siguiente;


    public Nodo(Paciente paciente)
    {
        Datos = paciente;
        Siguiente = null;
    }
}
}