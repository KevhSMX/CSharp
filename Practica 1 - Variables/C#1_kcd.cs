using System;
using System.Formats.Asn1;
// Preguntem el numero:
int queTriar;
Console.WriteLine("Exercici a provar? ");
queTriar = Convert.ToInt32(Console.ReadLine());
switch (queTriar)
{
    case 1:
        //Variables:
        int longitud;
        int amplada;
        double area;
        double perimetre;

        Console.Write("Introdueix  la longitud del rectangle: ");
        longitud = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceix la amplada del rectangle: ");
        amplada = Convert.ToInt32(Console.ReadLine());

        // Calculs
        area = longitud * amplada;
        perimetre = 2 * (longitud + amplada);

        //Informe area i perimetre:
        Console.WriteLine("\n--- Resultats ---");
        Console.WriteLine("> El area del rectangle es: " + area + "m");
        Console.WriteLine("> El perimetre del rectangle es: " + perimetre + "m");
        break;

    case 2:
        //Variables
        double radi;
        double alcada;
        string unitat;
        double volum;

        Console.Write("Quina unitat de mesura vols utilitzar? ");
        unitat = Convert.ToString(Console.ReadLine());

        Console.WriteLine("\n[!] IMPORTANT! Donam les seguents dades en " + unitat + "!\n");

        //Demanem el radi
        Console.Write("Introdueix el radi (r) del cilindre: ");
        radi = Convert.ToDouble(Console.ReadLine());

        //Demanem la alçada
        Console.Write("Introdueix l'alçada (h) del cilindre: ");
        alcada = Convert.ToDouble(Console.ReadLine());

        //Calcul
        volum = Math.PI * Math.Pow(radi, 2) * alcada; // V = n.pi * radi elevat a 2 * alçada

        // Resultats:
        Console.WriteLine("\n--- Resultat del volum ---");
        Console.WriteLine($"El volum del cilindre es: {volum:F4} {unitat}³");
        break;

    case 3:
        //Variables:
        double A, B, C;
        double nInteriror;
        double x1, x2; // Les dos solucions de l'equació

        //Demanem la A
        Console.Write("Introdueix el coeficient A: ");
        A = Convert.ToDouble(Console.ReadLine());

        //Demanem la B
        Console.Write("Introdueix el coeficient B: ");
        B = Convert.ToDouble(Console.ReadLine());

        //Demanem la C
        Console.Write("Introdueix el coeficient C: ");
        C = Convert.ToDouble(Console.ReadLine());

        if (A == 0)
        {
            Console.WriteLine("\n[!]ERROR! No es posible fer l'equacio ja que la A no pot ser 0!");
        }
        else
        {
            nInteriror = Math.Pow(B, 2) - (4 * A * C);

            if (nInteriror > 0) //El numero de dins de la arrel es major a 0
            {
                //Sumem i restem la arrel quadrada del numero interior de aquesta i fem la divisió, surten dues solucions
                x1 = (-B + Math.Sqrt(nInteriror)) / (2 * A);
                x2 = (-B - Math.Sqrt(nInteriror)) / (2 * A);

                Console.WriteLine("\nL'equació té dues solucions:");
                Console.WriteLine($"> Solució de la suma: x = {x1:F4}");
                Console.WriteLine($"> Solucio de la resta: x = {x2:F4}");
            }
            else if (nInteriror == 0)
            {
                //No fa falta fer res amb la arrel, nomes fem la resta, ja que donaria 0
                x1 = -B / (2 * A);

                Console.WriteLine("\nL'equació té una única solució:");
                Console.WriteLine($"> x = {x1:F4}");
            }
            else //Si el numero del 0 don negatiu no te solució.
            {
                Console.WriteLine("\n> L'equació no té solucions reals, ja que el numero dins de l'arrel és negatiu.");
            }
        }
        break;
}