//Mes Variables
string OperationType;
double FirstNumber;
double LastNumber;
double Resultat;

Console.WriteLine("Quel type d'opération souhaitez vous effectuer ? 1. Addition 2. Soustraction 3. Multiplication 4. Division");
OperationType = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Quel est le premier nombre sur lequel vous souhaitez effectuer une {OperationType}  ?" );
FirstNumber = double.Parse(Console.ReadLine());

Console.WriteLine($"Quel est le deuxième nombre sur lequel vous souhaitez effectuer une {OperationType}  ?");
LastNumber = double.Parse(Console.ReadLine());


Console.Clear();

if (OperationType == "Addition")
{
    Resultat = FirstNumber + LastNumber;
    Console.WriteLine($"L'{OperationType} de {FirstNumber} et {LastNumber} est égale à : {Resultat}");
}
else if (OperationType == "Soustraction")
{
    Resultat = FirstNumber - LastNumber;
    Console.WriteLine($"La {OperationType} de {FirstNumber} et {LastNumber} est égale à : {Resultat}");
}
else if (OperationType == "Multiplication")
{
    Resultat = FirstNumber * LastNumber;
    Console.WriteLine($"La {OperationType} de {FirstNumber} par {LastNumber} est égale à : {Resultat}");
}
else if (OperationType == "Division")
{
    Resultat = FirstNumber / LastNumber;
    Console.WriteLine($"La {OperationType} de {FirstNumber} par {LastNumber} est égale à : {Resultat}");
}
else
{
    Console.WriteLine("Veuillez rentrer un type d'opération valide S.V.P (Addition, Soustraction, Multiplication ou Division");
    Environment.Exit(0);
}

Environment.Exit(1);
