// See https://aka.ms/new-console-template for more information
using POOsuite;

Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("Mon parc animal");
Console.WriteLine("-------------------------------------------------------------------------");


//Enclos
Enclos enclosNord = new Enclos("Enclos Nord", 2);

//Animal
Animal luna = new Animal("Luna", "Chat", 80);
Animal rex = new Animal("Rex", "Chien", 50);
Animal milo = new Animal("Milo", "Lapin", 30);

//Affichage Animal
Console.WriteLine("Informations des animaux:");
Console.WriteLine("");
luna.DisplayInfo();
rex.DisplayInfo();
milo.DisplayInfo();
Console.WriteLine("-------------------------------------------------------------------------");

//Ajouter des animaux à l'enclos
Console.WriteLine("Ajout des animaux à l'enclos:");
Console.WriteLine("");
enclosNord.AddAnimal(luna);
enclosNord.AddAnimal(rex);
enclosNord.AddAnimal(milo);
Console.WriteLine("-------------------------------------------------------------------------");

//Appeler les methodes Eat et Play
Console.WriteLine("Interaction avec les animaux:");
Console.WriteLine("");
luna.Play(40);
rex.Eat(60);
Console.WriteLine("-------------------------------------------------------------------------");

//Affiche l'état de l'enclos
Console.WriteLine("État de l'enclos:");
Console.WriteLine("");
enclosNord.PrintEnclosureStatus();
Console.WriteLine("-------------------------------------------------------------------------");

//Rapport vétérinaire
VetoReport rapportVeto1 = new VetoReport("Luna", "Fatigue aprés jeu", 2);
rapportVeto1.PrintReport();
Console.WriteLine("");
VetoReport rapportVeto2 = new VetoReport("Rex", "Trés bonne forme", 1);
rapportVeto2.PrintReport();
Console.WriteLine("");
VetoReport rapportVeto3 = new VetoReport("Milo", "Probléme de digestion", 7);
rapportVeto3.PrintReport();
Console.WriteLine("-------------------------------------------------------------------------");

//Retirer un animal de l'enclos
Console.WriteLine("Retrait d'un animal de l'enclos:");
Console.WriteLine("");
enclosNord.RemoveAnimal(rex);
enclosNord.GetAnimalList();
Console.WriteLine("-------------------------------------------------------------------------");





////// EXERCICE 2 ///////

Order order1 = new Order("alice", 150.75m);
Order order2 = new Order("Bob", 299.99m);
Order order3 = new Order("Charlie", 49.50m);

Console.WriteLine("------Commandes Créées------");
Console.WriteLine($"Total des commandes créées: {Order.CreatedOrdersCount}");
Console.WriteLine($"Montant total des commandes créées: {Order.TotalAmountCreated} $");
Console.WriteLine("");

order1.Cancel();
order2.Cancel();
Console.WriteLine("------Commandes Annulées------");
Console.WriteLine($"Total des commandes annulées: {Order.CancelledOrdersCount}");
Console.WriteLine($"Montant total des commandes créées après annulation: {Order.TotalAmountCreated} $");

Console.WriteLine("");
Console.WriteLine("------Etat des commandes en cours------");
order1.DisplayOrderInfo();
order2.DisplayOrderInfo();
order3.DisplayOrderInfo();

order1.CustomerName = OrderUtils.NormalizeCustomerName(order1.CustomerName);
Console.WriteLine($"Nom du client normalisé pour la commande 1: {order1.CustomerName}");