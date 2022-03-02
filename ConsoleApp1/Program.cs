// See https://aka.ms/new-console-template for more information
using ConsoleApp1;



Player joueur1 = new("joueur1",(9,9));
Bot bot1 = new Bot((9,9));
Console.WriteLine("Bienvenue dans la bataille navale\n");


List<Tuple<int,int>> liste = new List<Tuple<int,int>>();
liste.Add(new Tuple<int, int>(3, 4));
liste.Add(new Tuple<int, int>(3, 5));
liste.Add(new Tuple<int, int>(3, 6));
liste.Add(new Tuple<int, int>(3, 7));
Boat tmpBoat = new Boat();
tmpBoat.AddFullBoat(liste);
joueur1.AddBoat(tmpBoat);
bot1.BotPlayer.AddBoat(tmpBoat);
Boolean run = true;
while (run)
{
    Console.WriteLine("Entrer une coordonné pour tirer");
    int inputX = 0;
    int inputY = 0;
    Boolean correct = true;
    while (correct)
    {
        string inputXstr = Console.ReadLine();
        string inputYstr = Console.ReadLine();
        Boolean testX = !int.TryParse(inputXstr, out inputX);
        Boolean testY = !int.TryParse(inputYstr, out inputY);


        if ((testX && testY))
        {
            Console.WriteLine("Rentrez des nombres convenables");
        }
        else { correct = false; }
    }
    Console.WriteLine(inputX.ToString());
    Console.WriteLine(inputY.ToString());   
    joueur1.Attack(bot1.BotPlayer, inputX, inputY);
    bot1.attack(joueur1);

    run = joueur1.estVivant() && bot1.BotPlayer.estVivant();
}
if (joueur1.vivant == false) { Console.WriteLine(joueur1.Nom + "a été éliminé\nVous avez perdu"); }
if (bot1.BotPlayer.vivant == false) { Console.WriteLine("Le bot a perdu, vous avez gagné"); }






