//Array de les hores
string[] hores = { "una", "dos", "tres", "quatre", "cinc", "sis", "set", "vuit", "nou", "deu", "onze", "dotze" };

//Bucle infinit
while (true)
{
    //Obtenir l'hora actual
    string hora = DateTime.Now.ToString("HH");
    int horaActual = Convert.ToInt32(hora);

    string minut = DateTime.Now.ToString("mm");
    int minutActual = Convert.ToInt32(minut);

    //Convertim les hores al format am/pm per no tenir que fer una string massa llarga
    if (horaActual > 12)
        horaActual = horaActual - 12;

    //Si el minut actual es multiple de 5 es mostrará si no mostrara un numero.
    switch (minutActual)
    {
        case 0: 
            Console.WriteLine($"La hora és  {hores[horaActual - 1]}");
            break;

        case 5:
            Console.WriteLine($"La hora és: Les {hores[horaActual - 1]} i cinc");
            break;

        case 10:
            Console.WriteLine($"La hora és: Les {hores[horaActual - 1]} i deu");
            break;

        case 15:
            Console.WriteLine($"La hora és: Un quart de {hores[horaActual]}");
            break;

        case 20:
            Console.WriteLine($"La hora és: Un quart i cinc de {hores[horaActual]}");
            break;

        case 25:
            Console.WriteLine($"La hora és: Un quart i deu de {hores[horaActual]}");
            break;

        case 30:
            Console.WriteLine($"La hora és: Dos quarts de {hores[horaActual]}");
            break;

        case 35:
            Console.WriteLine($"La hora és: Dos quarts i cinc de {hores[horaActual]}");
            break;

        case 40:
            Console.WriteLine($"La hora és: Dos quarts i deu de {hores[horaActual]}");
            break;

        case 45:
            Console.WriteLine($"La hora és: Tres quarts de {hores[horaActual]}");
            break;

        case 50:
            Console.WriteLine($"La hora és: Tres quarts i cinc de {hores[horaActual]}");
            break;

        case 55:
            Console.WriteLine($"La hora és: Tres quarts i deu de {hores[horaActual]}");
            break;

        case 60:
            Console.WriteLine($"La hora és: {hores[horaActual]}");
            break;

        default:
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
            break;
    }

    //1min entre bucle y bucle
    Thread.Sleep(60000);
}