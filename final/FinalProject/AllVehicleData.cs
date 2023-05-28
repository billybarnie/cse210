

using System.Collections.Generic;

class AllVehicleData
{   
    protected int _entireVehicleCost;
    protected string _model;
    private int _year;
    Dictionary<string, List<int>> vehicleDictionary = new Dictionary<string, List<int>>();

    public void VehicleLot()
    {
        

        Console.Clear();
        Console.Write("What is the model of the vehicle you desire? ");
        _model = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("What is the year of the vehicle desired? ");
        _year = int.Parse(Console.ReadLine());

        foreach (var list in vehicleDictionary)
        {

            if (_model == list.Key && _year == list.Value[0])
            {
                Console.WriteLine(list.Value[1]);
                _entireVehicleCost = 0;
                _entireVehicleCost = list.Value[1];
                break;
            }

            
        }
    }

    public void TradeInCalculations()
    {

    }

    public void DownPaymentCalculations()
    {
        
    }
    public void Vehicles()
    {
        vehicleDictionary.Add("kia sportage", new List<int> {2010, 16995});
        vehicleDictionary.Add("kia sportage", new List<int> {2011, 18295});
        vehicleDictionary.Add("kia sportage", new List<int> {2012, 18500});
        vehicleDictionary.Add("kia sportage", new List<int> {2013, 19000});
        vehicleDictionary.Add("kia sportage", new List<int> {2014, 21600});
        vehicleDictionary.Add("kia sportage", new List<int> {2015, 21900});
        vehicleDictionary.Add("kia sportage", new List<int> {2016, 22150});
        vehicleDictionary.Add("kia sportage", new List<int> {2017, 23200});
        vehicleDictionary.Add("kia sportage", new List<int> {2018, 23600});
        vehicleDictionary.Add("kia sportage", new List<int> {2019, 23750});
        vehicleDictionary.Add("kia sportage", new List<int> {2020, 23990});
        vehicleDictionary.Add("kia soul", new List<int> {2011, 13300});
        vehicleDictionary.Add("kia soul", new List<int> {2012, 13900});
        vehicleDictionary.Add("kia soul", new List<int> {2012, 14400});
        vehicleDictionary.Add("kia soul", new List<int> {2013, 14400});
        vehicleDictionary.Add("kia soul", new List<int> {2014, 14900});
        vehicleDictionary.Add("kia soul", new List<int> {2015, 15190});
        vehicleDictionary.Add("kia soul", new List<int> {2016, 15900});
        vehicleDictionary.Add("kia soul", new List<int> {2016, 16100});
        vehicleDictionary.Add("kia soul", new List<int> {2017, 16200});
        vehicleDictionary.Add("kia soul", new List<int> {2018, 16250});
        vehicleDictionary.Add("kia soul", new List<int> {2019, 16490});
        vehicleDictionary.Add("kia soul", new List<int> {2020, 17490});
        vehicleDictionary.Add("kia sorento", new List<int> {2011, });
        vehicleDictionary.Add("kia sorento", new List<int> {2012, });
        vehicleDictionary.Add("kia sorento", new List<int> {2013, });
        vehicleDictionary.Add("kia sorento", new List<int> {2014, });
        vehicleDictionary.Add("kia sorento", new List<int> {2015, });
        vehicleDictionary.Add("kia sorento", new List<int> {2016, });
        vehicleDictionary.Add("kia sorento", new List<int> {2017, });
        vehicleDictionary.Add("kia sorento", new List<int> {2018, });
        vehicleDictionary.Add("kia sorento", new List<int> {2019, });
        vehicleDictionary.Add("kia sorento", new List<int> {2020, });
        vehicleDictionary.Add("", new List<int> {2011, });
        vehicleDictionary.Add("", new List<int> {2012, });
        vehicleDictionary.Add("", new List<int> {2013, });
        vehicleDictionary.Add("", new List<int> {2014, });
        vehicleDictionary.Add("", new List<int> {2015, });
        vehicleDictionary.Add("", new List<int> {2016, });
        vehicleDictionary.Add("", new List<int> {2017, });
        vehicleDictionary.Add("", new List<int> {2018, });
        vehicleDictionary.Add("", new List<int> {2019, });
        vehicleDictionary.Add("", new List<int> {2020, });
        vehicleDictionary.Add("", new List<int> {2011, });
        vehicleDictionary.Add("", new List<int> {2012, });
        vehicleDictionary.Add("", new List<int> {2013, });
        vehicleDictionary.Add("", new List<int> {2014, });
        vehicleDictionary.Add("", new List<int> {2015, });
        vehicleDictionary.Add("", new List<int> {2016, });
        vehicleDictionary.Add("", new List<int> {2017, });
        vehicleDictionary.Add("", new List<int> {2018, });
        vehicleDictionary.Add("", new List<int> {2019, });
        vehicleDictionary.Add("", new List<int> {2020, });
        vehicleDictionary.Add("", new List<int> {2011, });
        vehicleDictionary.Add("", new List<int> {2012, });
        vehicleDictionary.Add("", new List<int> {2013, });
        vehicleDictionary.Add("", new List<int> {2014, });
        vehicleDictionary.Add("", new List<int> {2015, });
        vehicleDictionary.Add("", new List<int> {2016, });
        vehicleDictionary.Add("", new List<int> {2017, });
        vehicleDictionary.Add("", new List<int> {2018, });
        vehicleDictionary.Add("", new List<int> {2019, });
        vehicleDictionary.Add("", new List<int> {2020, });
        vehicleDictionary.Add("", new List<int> {2011, });
        vehicleDictionary.Add("", new List<int> {2012, });
        vehicleDictionary.Add("", new List<int> {2013, });
        vehicleDictionary.Add("", new List<int> {2014, });
        vehicleDictionary.Add("", new List<int> {2015, });
        vehicleDictionary.Add("", new List<int> {2016, });
        vehicleDictionary.Add("", new List<int> {2017, });
        vehicleDictionary.Add("", new List<int> {2018, });
        vehicleDictionary.Add("", new List<int> {2019, });
        vehicleDictionary.Add("", new List<int> {2020, });
        vehicleDictionary.Add("", new List<int> {2011, });
        vehicleDictionary.Add("", new List<int> {2012, });
        vehicleDictionary.Add("", new List<int> {2013, });
        vehicleDictionary.Add("", new List<int> {2014, });
        vehicleDictionary.Add("", new List<int> {2015, });
        vehicleDictionary.Add("", new List<int> {2016, });
        vehicleDictionary.Add("", new List<int> {2017, });
        vehicleDictionary.Add("", new List<int> {2018, });
        vehicleDictionary.Add("", new List<int> {2019, });
        vehicleDictionary.Add("", new List<int> {2020, });
        vehicleDictionary.Add("", new List<int> {2011, });
        vehicleDictionary.Add("", new List<int> {2012, });
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
        vehicleDictionary.Add("", new List<int> {});
    }

    
}