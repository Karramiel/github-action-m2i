using System.Globalization;
using System.Security.AccessControl;
using System.Xml.Schema;


#region Exo1
string prenom = "Alice";
string nom = "Dupont";
int age = 30;
int salaire = 50000;
Console.WriteLine($"Nom complet: {prenom} {nom}, Âge: {age}, Salaire: {salaire} EUR.");
Console.WriteLine($"Nom complet: " + prenom + " " + nom + ", Âge: " + age + ", Salaire: " + salaire + " EUR.");


Console.WriteLine($"=== MENU PRINCIPAL ===");
Console.WriteLine($"\t1. Coca");
Console.WriteLine($"\t2. Coca");

Console.WriteLine(@"Le chemin du fichier est : C:\User\Administrateur\Descktop");

#endregion

#region exo2
int ageBis = 0;
int salaireBis = 0;
string prenomBis = "";
string nomFamilleBis = String.Empty;

Console.WriteLine($"Nom complet: {prenomBis} {nomFamilleBis}, Âge: {ageBis}, Salaire: {salaireBis} EUR.");


Console.Write($"Quel est ton age ?");
salaireBis= Convert.ToInt32(Console.ReadLine());


Console.Write($"Quel est ton Nom de famille ?");
nomFamilleBis = Console.ReadLine();


Console.WriteLine($"Nom : {nomFamilleBis}, Âge: {ageBis}");

#endregion


#region exo3


#endregion