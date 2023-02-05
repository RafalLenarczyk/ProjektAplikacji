string name = "Ewa";
bool isWoman = true;
int age = 33;

if (isWoman == false && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

