using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Logica
{
    public  interface INeneService
    {
        void AgregarNene(Nene nene);

        List<Nene> MostrarResultado(); 

    }
    public class NeneService : INeneService
    {
        public static List<Nene> listaNenes { get; set; } = new();
        void INeneService.AgregarNene(Nene nene)
        {
            listaNenes.Add(nene);   
        }

        List<Nene> INeneService.MostrarResultado()
        {
           return listaNenes;
        }
    }
}
