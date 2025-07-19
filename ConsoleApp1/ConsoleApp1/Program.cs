using System;

class Program
{
    static void Main()
    {
        // Skriver ut en hälsningsfras till användaren
        Console.WriteLine("Hej och välkommen! ");

        // Frågar efter användarens förnamn och sparar det i variabeln 'fornamn'
        Console.Write("Vad heter du i förnamn? ");
        string fornamn = Console.ReadLine();

        // Frågar efter användarens efternamn och sparar det i variabeln 'efternamn'
        Console.Write("Och efternamn? ");
        string efternamn = Console.ReadLine();

        // Skriver ut ett välkomstmeddelande med användarens fullständiga namn
        Console.WriteLine($"\nTrevligt att träffas, {fornamn} {efternamn}!");

        // Frågar efter ålder och sparar svaret som text i variabeln 'alderStr'
        Console.Write("\nHur gammal är du (i år)? ");
        string alderStr = Console.ReadLine();

        // Konverterar texten till ett heltal och sparar det i variabeln 'alder'
        int alder = int.Parse(alderStr);

        // Räknar ut hur många dagar användaren har levt (cirka)
        int dagarLevt = alder * 365;

        // Visar resultatet med en liten kommentar
        Console.WriteLine($"\nOj! Du har levt i ungefär {dagarLevt} dagar.");

        // Lägger till ett vänligt meddelande
        Console.WriteLine("Tänk så mycket du har hunnit uppleva! ");
    }
}
