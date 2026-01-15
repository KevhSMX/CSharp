using System;
using System.Collections.Generic;
using System.Linq; // Average()
using System.Security.Cryptography;

//Variables Globals:
int accio;
int saldo = 1000;

//Funcions
void ObservarSaldo()
{
    Console.WriteLine($"Aquest es el teu saldo actual: {saldo}");
}

void depositarDiners(int quantitatDepositar)
{
    saldo += quantitatDepositar;
    Console.WriteLine($"S'ha depositat {quantitatDepositar}$ i ara tens: {saldo}$ al teu compe.");
}

void retirarDiners(int quantitatRetirar)
{ 
    saldo -= quantitatRetirar;
    Console.WriteLine($"Has retirat {quantitatRetirar}$ i ara tens {saldo}$ al teu compte.");
}

//
int exercici = 0;

Console.WriteLine("Quin exercici vols triar? ");
exercici = Convert.ToInt32(Console.ReadLine());

switch (exercici)
{
    case 1:
        //Variables
        List<int> ListaNumeros = new List<int>();
            
        //Codigo
        for (int i = 0; i < 55; i++)
        {
            int numeroRandom = Random.Shared.Next(22, 1559);
            ListaNumeros.Add(numeroRandom);
        }     
        int minim = ListaNumeros[0];
        int maxim = ListaNumeros[0];
       

        foreach (int num in ListaNumeros)
        {
            if (minim > num)
                minim = num;
            if (maxim < num)
                maxim = num;
        }
        Console.WriteLine($"La llista de numeros generada es: {string.Join(", ", ListaNumeros)}\n");
        Console.WriteLine($"El numero mes petit es: {minim}");
        Console.WriteLine($"El numero mes gran es: {maxim}");
    break;

    case 2:
        //Variables
        List<int> ListaNumeros333 = new List<int>();
        int count4 = 0;
        int mesQueMitjana = 0;
        //Codi
        for (int i = 0; i < 333; i++)
        {
            int numeroRandom2 = new Random().Next();
            ListaNumeros333.Add(numeroRandom2);
        }

        //Mitjana
        double mitjana = ListaNumeros333.Average();
        Console.WriteLine($"La mitjana dels 333 numeros es: {mitjana}");

        //Multiples de 4
        foreach (int i in ListaNumeros333)
        {
            if (i % 4 == 0)
            count4++;
        }
        Console.WriteLine($"Hi ha {count4} multiples de 4");

        //Mes gran que la mitjana:
        foreach (int o in ListaNumeros333)
        {
            if (o > mitjana)
                mesQueMitjana++;
        }
        Console.WriteLine($"Hi ha {mesQueMitjana} numeros mes grans que la mitjana.");
    break;

    case 3:
        //Variables & Listas
        string string3;
        int vocalsCount = 0;
        string Lstring3;
        //Codi
        Console.Write("Introdueix una frase per analitzar: ");
        string3 = Convert.ToString(Console.ReadLine());
        Lstring3 = string3.ToLower();

        foreach (char u in Lstring3)
        {
            if (u == 'a' || u == 'e' || u == 'i' || u == 'o' || u == 'u')
                vocalsCount++;
        }
        Console.WriteLine($"Hi ha {vocalsCount} vocals a la teva frase.");
    break;

    case 4:
        //Variables
        int quantitatDepositarEX;
        int quantitatRetirarEX;
        
        //Codi
        Console.WriteLine("Quina acció vols realitzar?\n - Introdueix 1 si vols veure el teu saldo.\n - Introdueix 2 si vols depositar diners.\n - Introdueix 3 si vols retirar diners.");
        accio = Convert.ToInt32(Console.ReadLine());

        switch (accio)
        {
            case 1:
                ObservarSaldo();
                break;

            case 2:
                Console.Write("Quant saldo vols depositar? ");
                quantitatDepositarEX = Convert.ToInt32(Console.ReadLine());
                depositarDiners(quantitatDepositarEX);
                break;

            case 3:
                Console.Write("Quant saldo vols retirar? ");
                quantitatRetirarEX = Convert.ToInt32(Console.ReadLine());
                retirarDiners(quantitatRetirarEX);
                break;
        }
        break;
}

