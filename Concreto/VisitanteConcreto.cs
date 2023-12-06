using PatronVisitor.Components;
using PatronVisitor.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronVisitor.Concreto
{
    public class VisitanteConcreto : IVisitor
    {
        public void Visitar(Procesador componente)
        {
            Console.WriteLine(String.Format("Procesador s/n {0}", componente.Serial));
        }
        public void Visitar(DiscoRigido componente)
        {
            Console.WriteLine(String.Format("Disco rígido s/n {0}", componente.Serial));
        }
        public void Visitar(PlacaBase componente)
        {
            Console.WriteLine(String.Format("Placa base s/n {0}", componente.Serial));
        }
    }
}
