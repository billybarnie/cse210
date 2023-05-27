class CarLot
{
    protected Dictionary<string, KeyValuePair<int, int>> vehicleDictionary = new Dictionary<string, KeyValuePair<int, int>>();

    public void Vehicles()
    {
        vehicleDictionary.Add("Kia Sportage", new KeyValuePair<int, int>(2009, 11000));
    }
    
}