using System;
using System.Collections.Generic; //Pour pouvoir utiliser les dictionnaires
using System.Data; 

Console.WriteLine("Quel somme d'argent (en CHF) souhaitez vous convertir ?"); //Demande la somme d'argent à convertir et stocke la réponse dans une variable.
string SommeString = Console.ReadLine();

double Somme;
bool succes = double.TryParse(SommeString, out Somme); //TryParse retourne un booléans selon si l'opération fonctionne ou échoue.

while (succes == false) //Utilisation du boolean retourner par TryParse
{
    Console.Clear();
    Console.WriteLine("Quel somme d'argent (en CHF) souhaitez vous convertir (format accepté : 1, 1.0, 10, etc...) ?");
    SommeString = Console.ReadLine();
    succes = double.TryParse(SommeString, out Somme);
}




Console.Clear();

Dictionary<string, double> TauxDeChange = new Dictionary<string, double>(); //Les valeurs et les monnaies ont été généré par IA donc y a une probabilité pour que les données soient fausses.
TauxDeChange.Add("EUR", 0.933);
TauxDeChange.Add("USD", 1.204);
TauxDeChange.Add("GBP", 0.911);
TauxDeChange.Add("JPY", 190.47);
TauxDeChange.Add("CAD", 1.716);
TauxDeChange.Add("AUD", 1.735);
TauxDeChange.Add("NZD", 2.149);
TauxDeChange.Add("SEK", 12.11);
TauxDeChange.Add("NOK", 11.61);
TauxDeChange.Add("SGD", 1.543);

static string ListerLesClées(Dictionary<string, double> TauxDeChange) //Pour chaque clé dans le dicitonnaire, ajoute sa valeur suivit d'une valeur 1 incrémenter à chaque boucle (1,2,3,etc...) et concaténe tout ceci à une variable qui est retourner par la fonction.
{
    string ListeClé = "";
    int r = 1;


    foreach (string key in TauxDeChange.Keys)
    { 
        ListeClé = ListeClé + "\n" + $"{r}. {key}"; //Concaténe chaque clé à ListeClé
        r = r + 1;
        
    }

    return ListeClé;
}
;

Console.WriteLine($"Dans quel devise souhaitez vous convertir vos {Somme} CHF ? Veuillez choisir parmi les devises suivantes : {ListerLesClées(TauxDeChange)}");
string Devise = Console.ReadLine();

bool exists = TauxDeChange.ContainsKey(Devise); //La methode ContainsKey vérifie si mon dictionnaire contient bien la clé

while (exists == false) 
{
    Console.Clear();
    Console.WriteLine($"La devise {Devise} n'existe pas. Veuillez choisir une devise parmi les devises suivantes : {ListerLesClées(TauxDeChange)}");
    Devise = Console.ReadLine();
    exists = TauxDeChange.ContainsKey(Devise);

}

static void Conversion(double Somme, Dictionary<string, double> TauxDeChange, string Devise) //Methode de convertion
{
    double SommeConvertis = Somme * TauxDeChange[Devise];
    Console.WriteLine($"Vos {Somme} CHF valent {SommeConvertis} {Devise} ! ");
}

Conversion(Somme, TauxDeChange, Devise); //Appel de la methode Conversion 
