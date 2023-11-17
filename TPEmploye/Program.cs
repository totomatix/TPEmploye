using System.Globalization;
using TPEmploye;

// récupération des données nécessaires
Console.Write("Matricule : ");
uint Matricule = uint.Parse(Console.ReadLine());
Console.Write("Nom : ");
string Nom = Console.ReadLine();
Console.Write("Prenom : ");
string Prenom = Console.ReadLine();
Console.Write("Date de naissance : ");
DateTime Naissance = DateTime.Parse(Console.ReadLine(),CultureInfo.GetCultureInfo("fr-FR"));
Console.Write("Date d'embauche : ");
DateTime Embauche = DateTime.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("fr-FR"));
Console.Write("Salaire : ");
decimal Salaire = decimal.Parse(Console.ReadLine());

// création de l'employé
Employe EMP1 = new Employe(Matricule, Nom, Prenom, Naissance, Embauche, Salaire);

// affichage de l'employé
EMP1.AfficherEmploye();
// augmentation du salaire
EMP1.AugmentationSalaire();
// affichage de l'employé
EMP1.AfficherEmploye();


