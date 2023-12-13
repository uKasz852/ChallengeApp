var name = "Kamil";
string gender = "Man";
var age = 17;

if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender != "Woman" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}