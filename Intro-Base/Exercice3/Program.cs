using System;

class Programme {
    static int DernierElement(int[] tableau) {
        if (tableau.Length == 0) {
            throw new ArgumentException("Le tableau ne peut pas être vide.");
        }
        return tableau[tableau.Length - 1];
    }
    static void Main() {
        int[] nombres = { 3, 7, 12, 9 };
        int dernier = DernierElement(nombres);
        Console.WriteLine("Le dernier élément du tableau est : " + dernier);
    }
}