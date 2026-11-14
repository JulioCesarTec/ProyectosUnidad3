using System;

using System;
namespace Proyecto1_Clinica
{
    public class Cola
    {
        private Nodo frente;
        private Nodo final;
        public Cola()
        {
            frente = null;
            final = null;
        }
        public void Encolar(Paciente paciente)
        {
            Nodo nuevo = new Nodo(paciente);
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }
        public Paciente Desencolar()
        {
            if (frente == null)
                return null;
            Paciente paciente = frente.Datos;
            frente = frente.Siguiente;
            if (frente == nullfinal = null;
            return paciente);
        }

        public void Mostrar()
        {
            if (frente == null)
            {
                Console.WriteLine("No hay Pacientes Registrados."):
                    return;
            }
            Nodo aux = frente;
            while (aux != null)
            {
                Console.WriteLine(aux.Datos);
                aux = aux.Siguiente;
            }
        }
    }
}
