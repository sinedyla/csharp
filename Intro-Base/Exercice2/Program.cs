// Fonction pour calculer le reste de la division de deux nombres

using System;
class Programme
{
    static int ResteDivision(int dividende, int diviseur){
        return dividende % diviseur;
    }
    static void Main(){
        int a = 17;
        int b = 5;
        int reste = ResteDivision(a, b);
        Console.WriteLine("Le reste de la division de " + a + " par " + b + " est : " + reste);
    }
}
