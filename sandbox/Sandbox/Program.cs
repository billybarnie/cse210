Dictionary<string, List<string>> vehicleDictionary = new Dictionary<string, List<string>>();

        

string _model;
string _year;



Console.WriteLine("What is the model and year of the vehicle you desire? ");
_model = Console.ReadLine();

Console.WriteLine("What is the year of the vehicle desired? ");
_year = Console.ReadLine();



if (int.Parse(_year) > 2015 && int.Parse(_year) < 2020)
{
    int cost = 15000;
}





/*foreach (var list in vehicleDictionary)
{
    Console.WriteLine(list.Key);

    foreach(string item in list.Value)
    {
        Console.WriteLine(item);
    }
}
*/