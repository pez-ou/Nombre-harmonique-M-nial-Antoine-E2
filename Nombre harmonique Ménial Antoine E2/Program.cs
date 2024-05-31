//Sous programme permettant de créer le tableau
//Paramètre a strictement positif
//Création du tableau de taille a
int[] CreeTab()
{
    int a;
    Console.WriteLine("Entrez un entier positif ");
    a = Convert.ToInt32(Console.ReadLine());
    int[] tab = new int[a];

    return tab;
}

//Sous programme d'initialisation du tableau
//Le tableau prends val et val s'incrémente suivant le nombre harmonique Hn
void InitTab(int[] tab)
{
    double val = 0.00;
    for (int i = 1; i <= tab.Length; i++)
    {
        val += 1.00 / i;
        tab[i - 1] = (int)val;
    }
}

//Sous programme principale permettant d'afficher le tableau
void AfficherTab(int[] tab)
{
    Console.WriteLine("Le résultat contient : ");
    foreach (int val in tab)
    {
        Console.Write(val + " ");
    }
}

//Programme principale
//Appel de chaque fonction/procedure
int[] tab = CreeTab();
InitTab(tab);
AfficherTab(tab);