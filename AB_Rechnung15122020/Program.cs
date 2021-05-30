using System;

namespace AB_Rechnung15122020
{
    class Program
    {
        static void Main(string[] args)
        {

            //Rechnungsobjekte erzeugen
            //Deklaration einer Objektvariable
            Rechnung rechnung1;
            //Initialisieren einer Variable
            rechnung1 = new Rechnung();

            //Deklaration und Initialisierung
            Rechnung rechnung2 = new Rechnung();

            rechnung1.operand1 = 53;
            rechnung1.operand2 = 2345;
            rechnung1.ergebnis = rechnung1.operand1 + rechnung1.operand2;
            rechnung1.meldung = "Addition";

            rechnung2.operand1 = 5;
            rechnung2.operand2 = 3;
            //rechnung2.ergebnis = Convert.ToSingle(rechnung2.operand1) / (rechnung2.operand2);
            rechnung2.ergebnis = Convert.ToInt32(rechnung2.operand1) / (rechnung2.operand2);
            rechnung2.meldung = "Division";

            Console.WriteLine(rechnung1.ergebnis);
            Console.WriteLine(rechnung2.ergebnis);

            Console.ReadKey();
        }
    }
}



