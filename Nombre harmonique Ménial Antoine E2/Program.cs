
int[] CreeTab()
{
    int a;
    Console.WriteLine("Entrez un entier a strictement positif : ");
    a = Convert.ToInt32(Console.ReadLine());
    int[] tab = new int[a];

    return tab;
}

void InitTab(int[] tab)
{
    double val = 1.0;
    for (int i = 1; i < tab.Length; i++)
    {
        val += 1.0 / i;
        tab[i - 1] = (int)val; 
    }
}

void AfficherTab(int[] tab)
{
    Console.WriteLine("Le tableau résultat contient :");
    for (int i = 0; i < tab.Length; i++) 
    {
        Console.Write(tab[i] + " ");
    }
}



int[] tab = CreeTab();
InitTab(tab);
AfficherTab(tab);

