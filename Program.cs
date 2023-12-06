using PatronVisitor.Component;
using PatronVisitor.Components;
using PatronVisitor.Concreto;
using PatronVisitor.Interface;

IVisitor visitante1 = new VisitanteConcreto();
Componente _Dr1 = new DiscoRigido("Disasd1234123412345");
Componente _Pb1 = new PlacaBase("Disasd1234123412345");
Componente _P1 = new Procesador("Disasd1234123412345");

_Dr1.Aceptar(visitante1);
_Pb1.Aceptar(visitante1);
_P1.Aceptar(visitante1);

Console.ReadKey();