class DownPayment : Information
{
    private int _entireVehicleCost;
    private int _putDown;
    private int _totalCost;
    private string _model;
    private int _year;
    
    AllVehicleData data = new AllVehicleData();

    public void DisplayGetDownPayment()
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("How much are you putting down on said vehicle? ");
        _putDown = int.Parse(Console.ReadLine());

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
                }
                
            }
            
            _totalCost = _entireVehicleCost - _putDown;

            _monthlyCost = _totalCost / 72;

        Console.Clear();
        Console.WriteLine($"Your monthly payments after putting down {_putDown} on a {_model} is going to be ${_monthlyCost} before insurance. ");
        Thread.Sleep(7000);

    }



    public int GetMonthlyCost()
    {
        return _monthlyCost;
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
                newFile.WriteLine(string.Format("Home Address, City, and Zip Code: {0}", GetHomeAddress()));

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
                newFile.WriteLine("Information for a Down Payment Approved!");

                newFile.WriteLine();

                foreach (var list in data.GetVehicleDictionary())
                {
                    if (_model == list.Key)
                    {
                        _entireVehicleCost = list.Value;
                        break;
                    }
                    
                }
                
                _totalCost = _entireVehicleCost - _putDown;

                _monthlyCost = _totalCost / 72;

                newFile.WriteLine();
                newFile.WriteLine($"{GetFirstName()} {GetLastName()}'s monthly cost on a {_model} is ${_monthlyCost} before insurance. ");

            }
        }
        else
        {
            string fullName = string.Format("{0}{1}{2}Info.txt", GetFirstName(), GetMiddleName(), GetLastName());
            using (StreamWriter newFile = new StreamWriter(fullName))
            {
                newFile.WriteLine("Due to lack of personal information they have been DENIED for a down payment option.");
            }

        }

    }

}