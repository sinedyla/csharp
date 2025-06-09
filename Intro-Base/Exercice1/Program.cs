// Fonction pour calculer la surface d'un triangle

using System;

class Programme{
    static double SurfaceTriangle(double baseTriangle, double hauteur){
        return (baseTriangle * hauteur) / 2;
    }

    static void Main()
    {
        double baseT = 10;
        double hauteur = 5;

        double surface = SurfaceTriangle(baseT, hauteur);
        Console.WriteLine("La surface du triangle est : " + surface);
    }
}
