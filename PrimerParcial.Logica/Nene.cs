using System;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Logica
{
    public class Nene
    {
        [Required(ErrorMessage = "El nombre del niño es obligatorio.")]
        public string Nombre { get; set; }

        private double peso;

        [Range(1, 19, ErrorMessage = "El peso del niño debe estar en el rango válido (1 < Peso < 20).")]
        public double Peso
        {
            get { return peso; }
            set
            {
                peso = value;
                CalcularTamanioDelPanal();
            }
        }

        [Range(1, 4, ErrorMessage = "La edad del niño debe estar en el rango válido (1 < Edad < 5).")]
        public int Edad { get; set; }

        public TamanioPanal Tamanio { get; set; }

    
        private void CalcularTamanioDelPanal()
        {
            if (peso <= 3)
            {
                Tamanio = TamanioPanal.RN;
            }
            else if (peso < 5)
            {
                Tamanio = TamanioPanal.XS;
            }
            else if (peso < 7)
            {
                Tamanio = TamanioPanal.S;
            }
            else if (peso < 9)
            {
                Tamanio = TamanioPanal.M;
            }
            else if (peso < 12)
            {
                Tamanio = TamanioPanal.G;
            }
            else if (peso <= 15)
            {
                Tamanio = TamanioPanal.XG;
            }
            else
            {
                Tamanio = TamanioPanal.XXG;
            }
        }
    }

    public enum TamanioPanal
    {
        RN, XS, S, M, G, XG, XXG
    }
}
