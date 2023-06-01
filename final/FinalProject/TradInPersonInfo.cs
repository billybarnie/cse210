class TradeInInfo : Information
{
    private int _entireVehicleCost;
    
    private string _modelYear;
    
    private int _totalCost;
    private int _tradeIn;
    private string _model;
    private int _year;
    AllVehicleData data = new AllVehicleData();
    public void TradeInVehicle()
    {
        DisplayGetTradeModel();
        DisplayGetTradeYear();

        if (GetTradeYear() >= 2015 && GetTradeYear() <= 2020)
        {
            _modelYear = GetTradeModel() + " " + GetTradeYear().ToString();
            _tradeInVehicleDictionary.Add(_modelYear, 8000);
        }
        else if (GetTradeYear() >= 2010 && GetTradeYear() <= 2014)
        {
            _modelYear = GetTradeModel() + " " + GetTradeYear().ToString();
            _tradeInVehicleDictionary.Add(_modelYear, 6000);
        }
        else if (GetTradeYear() >= 2005 && GetTradeYear() <= 2009)
        {
            _modelYear = GetTradeModel() + " " + GetTradeYear().ToString();
            _tradeInVehicleDictionary.Add(_modelYear, 4000);
        }
        else if (GetTradeYear() >= 1999 && GetTradeYear() <= 2004)
        {
            _modelYear = GetTradeModel() + " " + GetTradeYear().ToString();
            _tradeInVehicleDictionary.Add(_modelYear, 2000);
        }
        else if (GetTradeYear() >= 2021 && GetTradeYear() <= 2023)
        {
            _modelYear = GetTradeModel() + " " + GetTradeYear().ToString();
            _tradeInVehicleDictionary.Add(_modelYear, 10000);
        }
        
    }

    public void DisplayGetModel()
    {
        Console.Clear();
        Console.Write("What is the model of the vehicle you desire? ");
        _model = Console.ReadLine();
    }

    public void DisplayGetYear()
    {
        Console.WriteLine();
        Console.Write("What is the year of the vehicle you desire?");
        _year = int.Parse(Console.ReadLine());
    }

    public void DisplayMonthlyCost()
    {
        data.Vehicles();

        _model = _model.ToLower() + " " + _year.ToString();

        foreach (var list in data.GetVehicleDictionary())
            {
                if (_model == list.Key)
                {
                    _entireVehicleCost = list.Value;
                    break;
                }
                
            }
        foreach (var list in GetTradeInDictionary())
            {
                if (_modelYear == list.Key)
                {
                    _tradeIn = list.Value;
                }
            }
            
        _totalCost = _entireVehicleCost - _tradeIn;

        _monthlyCost = _totalCost / 72;

        Console.WriteLine();
        Console.WriteLine($"Your monthly cost for a {_model} is going to be ${_monthlyCost} after trade in.");
        Thread.Sleep(7000);

    }

    public override void SaveToCSV()
    {
        if(GetFirstName() != "" && GetMiddleName() != "" && GetLastName() != "" && GetDateOfBirth() != "" &&
           GetHomeAddress() != "" && GetDriversID() != -1 && GetIDIssueDate() != "" && GetIDExpiration() != "" 
           && GetGender() != "" && GetClassID() != "" && GetHeight() != "" && GetEyeColor() != "" && _model != "")
        {
            string fullName = string.Format("{0}{1}{2}Info.txt", GetFirstName(), GetMiddleName(), GetLastName());
            using (StreamWriter newFile = new StreamWriter(fullName))
            {
                newFile.WriteLine(string.Format("First Name: {0}     Middle Name: {1}   Last Name: {2}",
                GetFirstName(), GetMiddleName(), GetLastName()));

                newFile.WriteLine();

                newFile.WriteLine(string.Format("Date of Birth: {0}", GetDateOfBirth()));

                newFile.WriteLine();
                newFile.WriteLine(string.Format("Home Address, City, State, and Zip Code: {0}", GetHomeAddress()));

                newFile.WriteLine();
                newFile.WriteLine(string.Format("Drivers Identification: {0}", GetDriversID()));

                newFile.WriteLine();
                newFile.WriteLine(string.Format("Drivers Identification Issue Date: {0}", GetIDIssueDate()));

                newFile.WriteLine();
                newFile.WriteLine(string.Format("Drivers Identification Expiration Date: {0}", GetIDExpiration()));

                newFile.WriteLine();
                newFile.WriteLine(string.Format("Gender: {0}    Eye Color: {1}   Height: {2}", 
                GetGender(), GetEyeColor(), GetHeight()));

                foreach (var list in data.GetVehicleDictionary())
                {
                    if (_model == list.Key)
                    {
                        _entireVehicleCost = list.Value;
                        break;
                    }
                    
                }

                foreach (var list in GetTradeInDictionary())
                {
                    if (_modelYear == list.Key)
                    {
                        _tradeIn = list.Value;
                    }
                }
                    
                _totalCost = _entireVehicleCost - _tradeIn;

                _monthlyCost = _totalCost / 72;
                
                newFile.WriteLine();
                newFile.WriteLine($"TradeIn Vehicle: {GetTradeModel()}");
                newFile.WriteLine();
                newFile.WriteLine($"TradeIn Year: {GetTradeYear()}");
                newFile.WriteLine();
                newFile.WriteLine($"Trade In cost: ${_tradeIn}");
                newFile.WriteLine();
                newFile.WriteLine($"{GetFirstName()} {GetLastName()}'s monthly payments on a {_model} are going to be ${_monthlyCost} after trade in and before insurance.");
            }
        }
        else
        {
            string fullName = string.Format("{0}{1}{2}Info.txt", GetFirstName(), GetMiddleName(), GetLastName());
            using (StreamWriter newFile = new StreamWriter(fullName))
            {
                newFile.WriteLine("Due to lack of personal information they have been DENIED for a trade in option.");
            }
        }
    }
}