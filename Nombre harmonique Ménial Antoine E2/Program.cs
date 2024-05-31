
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




