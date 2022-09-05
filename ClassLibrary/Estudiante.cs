using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Estudiante
    {
        private string _apellido;
        private string _nombre;
        private string _legajo;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static  Random _random;
        double notaFinal;

        public Estudiante(string nombre, string apellido, string legajo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _legajo = legajo;
        }
        public int notaPrimerParcial
        {
            set { _notaPrimerParcial = value; }
            get { return _notaPrimerParcial; }
        }

        public int notaSegundoParcial
        {
            set { _notaSegundoParcial = value; }
            get { return _notaSegundoParcial; }
        }

        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        static Estudiante()
        {
            _random = new Random();
        }

        private double CalcularNotaFinal()
        {
            int nota = -1;
            if (notaPrimerParcial >= 6 && notaSegundoParcial >= 6)
            {
                nota = Estudiante._random.Next(6, 10);                  
            }
            return nota;
        }

        public void Mostrar()
        {
            StringBuilder msjSB = new StringBuilder();
            msjSB.AppendLine($"{_nombre} {_apellido} {_legajo}");
            msjSB.AppendLine($"Nota Primer Parcial {notaPrimerParcial} Nota segundo Parcial {notaSegundoParcial}");
            msjSB.AppendLine($"Promedio de notas {CalcularPromedio()}");
            
            notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                msjSB.AppendLine($"Nota Final :{notaFinal}");
            }
            else
            {
                msjSB.AppendLine("Alumno desaprobado");
            }

            msjSB.AppendLine("---------------------");

            Console.Write(msjSB);
        }
    }
}
