class DownPayment : Information
{
    private int _entireVehicleCost;
    private int _putDown;
    private int _totalCost;
    private string _model;
    private int monthlyWithInsurance;
    AllVehicleData data = new AllVehicleData();
    Loan loanInfo = new Loan();

    public void DisplayGetDownPayment()
    {
        Console.WriteLine();
        Console.WriteLine("How much are you putting down on said vehicle? ");
        _putDown = int.Parse(Console.ReadLine());

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
                }
                
            }
            
            _totalCost = _entireVehicleCost - _putDown;

            _monthlyCost = _totalCost / 72;

        Console.WriteLine();
        Console.WriteLine($"Your monthly payments after putting down {_putDown} on a {_model} is going to be ${_monthlyCost} before insurance. ");
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
                newFile.WriteLine(_model);

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

                newFile.WriteLine();
                newFile.WriteLine($"Your monthly payments after insurance are {loanInfo.DownPaymentCredit()}");

            }

            fullName = string.Format("{0}{1}ApprovalLetter.txt", GetFirstName(), GetLastName());
            using (StreamWriter newFile = new StreamWriter(fullName))
            {
                newFile.WriteLine($"Dear {GetFirstName()} {GetLastName()},");
                newFile.WriteLine();

                newFile.WriteLine($"You have been approved for the {_model} based on your credit score and income with an estimated cost of ${_monthlyCost} monthly before insurance.");

                newFile.WriteLine();
            }
        }
        else
        {
            string fullName = string.Format("{0}{1}{2}Info.txt", GetFirstName(), GetMiddleName(), GetLastName());
            using (StreamWriter newFile = new StreamWriter(fullName))
            {
                newFile.WriteLine("Due to lack of personal information they have been DENIED for a down payment option.");
            }

            fullName = string.Format("{0}{1}DeniedLetter.txt", GetFirstName(), GetLastName());
            using (StreamWriter newFile = new StreamWriter(fullName))
            {
                newFile.WriteLine("We are sorry to tell you but the vehicle that you are trying to get is not in our inventory");
                newFile.WriteLine("that or your credit and income is too low or have neglected to give out any impairative basic information.");

                newFile.WriteLine();

            }

        }

    }

}