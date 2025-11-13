
Console.WriteLine("Tu t'appelle comment ?");
string name = Console.ReadLine();
if (name == null)
{
    Console.WriteLine("invalid");
}

Console.WriteLine("Ta quel age ?");
string responceAge = Console.ReadLine(); int age = Convert.ToInt32(responceAge);

if(age < 18)
{
    Console.WriteLine("Tu n'est pas majeur quitte le programe en appuyant sur un touche ");
    Console.ReadLine();
}

Console.WriteLine($"Tu t'applle {name} et tu a {age}");



