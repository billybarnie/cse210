class TradeInInfo : Information
{
    private int _entireVehicleCost;
    private int _vehicleYear;
    private string _modelYear;
    private string _vehicleTradeModel;
    private int _totalCost;
    private int _tradeIn;
    private string _model;
    AllVehicleData data = new AllVehicleData();
    public void TradeInVehicle()
    {
        Console.WriteLine();
        Console.WriteLine("What is the model of the vehicle being traded in? ");
        _vehicleTradeModel = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("What is the year of the vehicle being traded in? ");
        _vehicleYear = int.Parse(Console.ReadLine());

        if (_vehicleYear >= 2015 && _vehicleYear <= 2020)
        {
            _modelYear = _vehicleTradeModel + " " + _vehicleYear.ToString();
            tradeInVehicleDictionary.Add(_modelYear, 8000);
        }
        else if (_vehicleYear >= 2010 && _vehicleYear <= 2014)
        {
            _modelYear = _vehicleTradeModel + " " + _vehicleYear.ToString();
            tradeInVehicleDictionary.Add(_modelYear, 6000);
        }
        else if (_vehicleYear >= 2005 && _vehicleYear <= 2009)
        {
            _modelYear = _vehicleTradeModel + " " + _vehicleYear.ToString();
            tradeInVehicleDictionary.Add(_modelYear, 4000);
        }
        else if (_vehicleYear >= 1999 && _vehicleYear <= 2004)
        {
            _modelYear = _vehicleTradeModel + " " + _vehicleYear.ToString();
            tradeInVehicleDictionary.Add(_modelYear, 2000);
        }
        else if (_vehicleYear >= 2021 && _vehicleYear <= 2023)
        {
            _modelYear = _vehicleTradeModel + " " + _vehicleYear.ToString();
            tradeInVehicleDictionary.Add(_modelYear, 10000);
        }
        
    }

    public void DisplayGetModelYear()
    {
        Console.Clear();
        Console.Write("What is the model any year of the vehicle you desire? ");
        _model = Console.ReadLine();
    }

    public void DisplayMonthlyCost()
    {
        data.Vehicles();

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

                newFile.WriteLine();
                newFile.WriteLine("Information for Trade In Approved so far!");

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
                newFile.WriteLine($"{GetFirstName()} {GetMiddleName()} {GetLastName()}'s monthly payments on a {_model} are going to be ${_monthlyCost} after trade in and before insurance.");
            }

            fullName = string.Format("{0}{2}ApprovalLetter.txt", GetFirstName(), GetLastName());
            using (StreamWriter newFile = new StreamWriter(fullName))
            {
                newFile.WriteLine($"Dear {GetFirstName()} {GetLastName()},");
                newFile.WriteLine();

                newFile.WriteLine($"You have been approved for the {_model} based on your credit score and income with an estimated cost of ${_monthlyCost} monthly before insurance.");
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