using _1_2;

Service bureauPoste = new Service("Poste Canada Granby", "297 rue Principale");
Vehicule auto2032 = new Vehicule("Y0P 7A1", bureauPoste);
Facteur bernard = new Facteur(bureauPoste, 10232, auto2032);

Service uniprix = new Service("Uniprix Granby", "320 bd Leclerd O");
Employe robert = new Employe(uniprix, 3201);

Console.WriteLine("Bienvenu au service pour les facteurs !");
Console.WriteLine(bernard.NoEmploye + " est actuellement connecté.");

// menu
while(true)
{
    Console.WriteLine("*****************************************************");
    Console.WriteLine("Choisissez un des choix ci-dessous : ");
    Console.WriteLine("1. Se rendre à une adresse");
    Console.WriteLine("2. Livrer un colis");
    Console.WriteLine("3. Punch in");
    Console.WriteLine("4. Punch out");
    Console.WriteLine("*****************************************************");

    int choix = int.Parse(Console.ReadLine());
    switch(choix)
    {
        case 1: seRendreAdresse(bernard); break;
        case 2: livrerColis(bernard); break;
        case 3: punchIn(ref bernard); break;
        default: punchOut(ref bernard); break;
    }
}

// se rendre à une adresse
void seRendreAdresse(Facteur facteur)
{
    Console.WriteLine("Quelle adresse?");
    string adresse = Console.ReadLine();
    if(adresse.Length  > 0 )
        Console.WriteLine(facteur.NoEmploye + " se rend à l'adresse " + adresse);
}

// livrer un colis
void livrerColis(Facteur facteur)
{
    seRendreAdresse(facteur);
    Console.WriteLine("Quel numéro de colis?");
    int colis = int.Parse(Console.ReadLine());
    Console.WriteLine("Voulez-vous déposer à un point de service? (o/N)");
    string reponse = Console.ReadLine();

    if(reponse.ToLower() == "o")
    {
        laisserPointDeService(facteur, colis);
    }
    else
    {
        Console.WriteLine(facteur.NoEmploye + " livre le colis #" + colis);
    }
}

// laisser au point de service
void laisserPointDeService(Facteur facteur, int colis)
{
    Console.WriteLine(facteur.NoEmploye + " dépose le colis #" + colis + " au pds " + uniprix.Nom + " au " + uniprix.Adresse + " géré par " + robert.NoEmploye);
}

// punch in
void punchIn(ref Facteur facteur)
{
    if(facteur.Punchs.Count > 0)
    {
        if (facteur.Punchs[facteur.Punchs.Count - 1].DateHeureSortie == null)
        {
            Console.WriteLine("Vous tentez de punch in sans avoir punch out !");
        }
        else
        {
            Console.WriteLine(facteur.NoEmploye + " punch in à " + DateTime.Now.ToShortTimeString());
            facteur.Punchs.Add(new Punch(DateTime.Now, 20.00, facteur));
        }
    }
    else
    {
        Console.WriteLine(facteur.NoEmploye + " punch in à " + DateTime.Now.ToShortTimeString());
        facteur.Punchs.Add(new Punch(DateTime.Now, 20.00, facteur));
    }
}

// punch out
void punchOut(ref Facteur facteur)
{
    if(facteur.Punchs.Count > 0)
    {
        if (facteur.Punchs[facteur.Punchs.Count - 1].DateHeureSortie == null)
        {
            Console.WriteLine(facteur.NoEmploye + " punch out à " + DateTime.Now.ToShortTimeString());
            facteur.Punchs[facteur.Punchs.Count - 1].DateHeureSortie = DateTime.Now;
        }
    }
}