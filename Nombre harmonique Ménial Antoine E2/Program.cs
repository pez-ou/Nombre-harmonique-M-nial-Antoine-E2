
////sous programme demande saisi entier a 
//int Saisi()
//{
//    int a;
//    Console.WriteLine("Entrez un entier a strictement positif");
//    a = Convert.ToInt32(Console.ReadLine());
//    return a;
//}

int[] CreeTab()
{
    int a;
    Console.WriteLine("Entrez un entier a strictement positif : ");
    a = Convert.ToInt32(Console.ReadLine());
    int[] tab = new int[a];

    return tab;

}


////Création suite harmonique
//int NbHarmonique(int[] tab)
//{
//    int val = 1;
//    for (int i = 1; i < tab.Length; i++)
//    {
//        val = val + 1 / i;
//    }
//    return val;
//}


////Création du tableau
//int[] CréerTab(int taille)
//{
//    return new int[taille];
//}

void InitTab(int[] tab)
{
    int val = 1;
    for (int i = 0; i < tab.Length; i++)
    {
        tab[i] = val + 1 / val;
    }
}



//Création sous-programme pour afficher le tableau
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









