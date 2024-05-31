
//sous programme demande saisi entier a 
int Saisi()
{
    int a;
    Console.WriteLine("Entrez un entier a strictement positif");
    a = Convert.ToInt32(Console.ReadLine());
    return a;
}

//Création du tableau
int[] CréerTab(int taille)
{
    return new int[taille];
}

//Création suite harmonique
int[] NbHarmonique(int[] tab)
{
    int val = 0;
    for (int i = 1; i < tab.Length; i++)
    {
        val = val + 1 / tab[i];
    }
    return val;
}

//Création sous-programme pour afficher le tableau
void AfficherTab(int[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        Console.Write(tab[i] + " ");
    }
}






