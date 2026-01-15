using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;

int queTriar;
Console.Write("Quin es l'exercici que vols triar? ");
queTriar = Convert.ToInt32(Console.ReadLine());
switch (queTriar)
{

    case 1:
        //Variables
        int numero = 0;
        int contador = 13;
        int numSuma = 13;
        //Codi
        Console.Write("Introdueix un numero (mes gran a 13): ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (contador < numero)
        {
            contador++;
            numSuma += contador;

        }
        Console.WriteLine($"El numero total es {numSuma}");
        break;

    case 2:
        //Variables
        int numero2 = 0;
        int parells = 0;
        int imparells = 0;
        //Codi
        Console.WriteLine("Introdueix un numero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero2; i++)
        {
            if (i % 2 == 0)
            {
                parells++;
            }
            else
            {
                imparells++;
            }
        }
        Console.WriteLine($"Hi han {parells} parells i {imparells} imparells.");
        break;
    
    case 3:
        //Variables
        int Jugada1;
        int Jugada2;
        string J0 = "Pedra";
        string J1 = "Paper";
        string J2 = "Tisores";
        //Codi 
        Console.Write("[+] Jugador 1 | Introdueix la teva jugada: ");
        Jugada1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("[+] Jugador 2 | Introdueix la teva jugada: ");
        Jugada2 = Convert.ToInt32(Console.ReadLine());

        if (Jugada1 == Jugada2)
        {
            Console.WriteLine("EMPAT!");
        }
        else
        {
            // Jugada 1 == 0
            if (Jugada1 == 0 && Jugada2 == 1)
            {
                Console.WriteLine("\n--- Jugades ---");
                Console.WriteLine($"Jugador 1: {J0}");
                Console.WriteLine($"Jugador 2: {J1}");
                Console.WriteLine("[!] Guanya el jugador 2!");
            }
            else if (Jugada1 == 0 && Jugada2 == 2)
            {
                Console.WriteLine("\n--- Jugades ---");
                Console.WriteLine($"Jugador 1: {J0}");
                Console.WriteLine($"Jugador 2: {J2}");
                Console.WriteLine("[!] Guanya el jugador 1!");
            }
            // Jugada 1 == 1
            else if ( Jugada1 == 1 && Jugada2 == 0)
            {
                Console.WriteLine("\n--- Jugades ---");
                Console.WriteLine($"Jugador 1: {J1}");
                Console.WriteLine($"Jugador 2: {J0}");
                Console.WriteLine("[!] Guanya el jugador 1!");
            }
            else if (Jugada1 == 1 && Jugada2 == 2)
            {
                Console.WriteLine("\n--- Jugades ---");
                Console.WriteLine($"Jugador 1: {J1}");
                Console.WriteLine($"Jugador 2: {J2}");
                Console.WriteLine("[!] Guanya el jugador 2!");
            }
            // Jugada 1 == 2
            else if (Jugada1 == 2 && Jugada2 == 0)
            {
                Console.WriteLine("\n--- Jugades ---");
                Console.WriteLine($"Jugador 1: {J2}");
                Console.WriteLine($"Jugador 2: {J0}");
                Console.WriteLine("[!] Guanya el jugador 2!");
            }
            else if (Jugada1 == 1 && Jugada2 == 1)
            {
                Console.WriteLine("\n--- Jugades ---");
                Console.WriteLine($"Jugador 1: {J2}");
                Console.WriteLine($"Jugador 2: {J1}");
                Console.WriteLine("[!] Guanya el jugador 1!");
            }
        }
        break;

    case 4:
        // Variables
        int accio;
        int depositar;
        int saldo = 1000;
        int retirar;

        //Codi
        Console.WriteLine("Quina acció vols realitzar?\n -Introdueix 1 si vols veure el saldo\n -Introdueix 2 si vols depositar diners\n -Introdueix 3 si vols retirar diners");
        accio = Convert.ToInt32(Console.ReadLine());
        if (accio == 1)
        {
            Console.WriteLine($"aquest es el teu saldo actual: {saldo}");
        }
        else if (accio == 2)
        {
            Console.WriteLine("Quants diners vols depositar");
            depositar = Convert.ToInt32(Console.ReadLine());
            saldo = saldo + depositar;
            Console.WriteLine($"Ja esta depositat, el teu saldo actual es de {saldo}");
        }
        else if (accio == 3)
        {
            Console.WriteLine("Quants diners vols retirar");
            retirar = Convert.ToInt32(Console.ReadLine());
            if (retirar > saldo)
            {
                Console.WriteLine("No pots retirar mes diners del que hi ha!");
            }
            else
            {
                saldo = saldo - retirar;
                Console.WriteLine($"Ja esta retirat, el teu saldo actual es de {saldo}");
            }
        }
        break;
}

