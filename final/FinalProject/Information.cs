
abstract class Information
{
    private double _driversLicenseID = -1;
    private string _driverClassOnID;
    private string _driversLicenseExpire;
    private string _driversLicenseIssue;
    private string _birthDate;
    private string _firstName;
    private string _middleName;
    private string _lastName;
    private string _homeAddress;
    private string _gender;
    private string _height;
    private string _eyeColor;
    protected int _monthlyCost;
    private int _loanSize;
    private int _annualIncome;
    private string _insuranceName;
    private int _creditScore = -1;
    private int _insuranceCostMonthly;
    private int _monthlyVehicleCost;
    private string _signature;
    private string _verifyVehicle;
    private string _vehicleTradeModel;
    private int _vehicleYear;
    protected Dictionary<string, int> _vehicleDictionary = new Dictionary<string, int>();
    protected Dictionary<string, int> _tradeInVehicleDictionary = new Dictionary<string, int>();
    public Information() {}

    public Information(float driversLicenseID, string driverClassOnID, string driversLicenseExpire, 
    string driversLicenseIssue, string birthDate, string firstName, string middleName, 
    string lastName, string homeAddress, string gender, string height, string eyeColor)
    {
        _driversLicenseID       = driversLicenseID;
        _driverClassOnID        = driverClassOnID;
        _driversLicenseExpire   = driversLicenseExpire;
        _driversLicenseIssue    = driversLicenseIssue;
        _birthDate              = birthDate;
        _firstName              = firstName;
        _middleName             = middleName;
        _lastName               = lastName;
        _homeAddress            = homeAddress;
        _gender                 = gender;
        _height                 = height;
        _eyeColor               = eyeColor;
    }

    public void DisplayGetDriversID()
    {
        Console.Clear();
        Console.Write("What is your drivers Identification number? ");
        _driversLicenseID = double.Parse(Console.ReadLine());
    }

    public void DisplayGetClassID()
    {
        Console.WriteLine();
        Console.Write("What is the classification on your drivers license? ");
        _driverClassOnID = Console.ReadLine();
    }

    public void DisplayGetIDIssueDate()
    {
        Console.WriteLine();
        Console.Write("What is the issue date on your drivers license?(MM/DD/YYYY) ");
        _driversLicenseIssue = Console.ReadLine();
    }

    public void DisplayGetIDExpiration()
    {
        Console.WriteLine();
        Console.Write("What is the expiration date on your drivers license?(MM/DD/YYYY) ");
        _driversLicenseExpire = Console.ReadLine();
    }

    public void DisplayGetDateOfBirth()
    {
        Console.WriteLine();
        Console.Write("What is your legal date of birth?(MM/DD/YYYY) ");
        _birthDate = Console.ReadLine();
    }

    public void DisplayGetFirstName()
    {
        Console.WriteLine();
        Console.Write("What is you legal first name? ");
        _firstName = Console.ReadLine();
    }

    public void DisplayGetMiddleName()
    {
        Console.WriteLine();
        Console.Write("What is your legal middle name? ");
        _middleName = Console.ReadLine();
    }

    public void DisplayGetLastName()
    {
        Console.WriteLine();
        Console.Write("What is your legal last name? ");
        _lastName = Console.ReadLine();
    }

    public void DisplayGetHomeAddress()
    {
        Console.WriteLine();
        Console.Write("What is your legal place of residence? (city, state and zip included) ");
        _homeAddress = Console.ReadLine();
    }

    public void DisplayGetGender()
    {
        Console.WriteLine();
        Console.Write("What is your gender?(M/F) ");
        _gender = Console.ReadLine();
    }

    public void DisplayGetHeight()
    {
        Console.WriteLine();
        Console.Write("What is your height displayed on your ID? Example:(5'10) ");
        _height = Console.ReadLine();
    }

    public void DisplayGetEyeColor()
    {
        Console.WriteLine();
        Console.Write("What is the color displayed on your ID? ");
        _eyeColor = Console.ReadLine();
    }

    public void DisplayGetSignature()
    {
        Console.WriteLine();
        Console.Write("Please sign your first and last name here: ");
        _signature = Console.ReadLine();
    }
    public void DisplayGetMonthlyCarCost()
    {
        Console.WriteLine();
        Console.Write("What was the cost of the vehicle before insurance?(enter dollar amount only) ");
        _monthlyVehicleCost = int.Parse(Console.ReadLine());
    }
    
    public void DisplayGetCreditScore()
    {
        Console.Clear();
        Console.Write("What is your current credit score? ");
        _creditScore = int.Parse(Console.ReadLine());
    }
    public void DisplayGetDebtAmount()
    {
        Console.WriteLine();
        Console.Write("Do you have any outstanding debts or unpayed loans if so put the total amount here without commas: ");
        _loanSize = int.Parse(Console.ReadLine());
    }

    public void DisplayGetAnnualIncome()
    {
        Console.WriteLine();
        Console.Write("What is your annual income?(Enter without commas) ");
        _annualIncome = int.Parse(Console.ReadLine());
    }
    public void DisplayGetInsuranceCompany()
    {
        Console.WriteLine();
        Console.Write("What is the name of the insurance company that you are working with? ");
        _insuranceName = Console.ReadLine();
    }
    public void DisplayGetInsuranceCost()
    {
        Console.WriteLine();
        Console.Write("What is your monthly insurance cost?(Enter only dollar amount) ");
        _insuranceCostMonthly = int.Parse(Console.ReadLine());
    }

    public void DisplayGetVerifyVehicle()
    {
        Console.WriteLine();
        Console.Write("Verify the vehicle you are about to purchase by typing the brand, model and year here: ");
        _verifyVehicle = Console.ReadLine();

    }

    public void DisplayGetTradeModel()
    {
        Console.Clear();
        _tradeInVehicleDictionary.Clear();
        Console.Write("What is the model of the vehicle being traded in?(enter brand and model) ");
        _vehicleTradeModel = Console.ReadLine();
    }

    public void DisplayGetTradeYear()
    {
        Console.WriteLine();
        Console.Write("What is the year of the vehicle being traded in? ");
        _vehicleYear = int.Parse(Console.ReadLine());
    }

    public int GetTradeYear()
    {
        return _vehicleYear;
    }
    public string GetTradeModel()
    {
        return _vehicleTradeModel;
    }
    public string GetVerifyVehicle()
    {
        return _verifyVehicle;
    }
    public int GetDebtAmount()
    {
        return _loanSize;
    }

    public string GetSignature()
    {
        return _signature;
    }
    public int GetCarCost()
    {
        return _monthlyVehicleCost;
    }

    public int GetAnnualIncome()
    {
        return _annualIncome;
    }
    
    public string GetInsuranceCompany()
    {
        return _insuranceName;
    }

    public int GetInsuranceCosts()
    {
        return _insuranceCostMonthly;
    }

    public int GetCreditScore()
    {
        return _creditScore;
    }
    public double GetDriversID()
    {
        return _driversLicenseID;
    }

    public string GetClassID()
    {
        return _driverClassOnID;
    }
    public string GetIDIssueDate()
    {
        return _driversLicenseIssue;
    }

    public string GetIDExpiration()
    {
        return _driversLicenseExpire;
    }

    public string GetDateOfBirth()
    {
        return _birthDate;
    }

    public string GetFirstName()
    {
        return _firstName;
    }

    public string GetMiddleName()
    {
        return _middleName;
    }

    public string GetLastName()
    {
        return _lastName;
    }
    public string GetHeight()
    {
        return _height;
    }

    public string GetHomeAddress()
    {
        return _homeAddress;
    }

    public string GetGender()
    {
        return _gender;
    }

    public string GetEyeColor()
    {
        return _eyeColor;
    }

    public void PersonalInformation()
    {   
        Console.Clear();
        DisplayGetFirstName();
        DisplayGetMiddleName();
        DisplayGetLastName();
        DisplayGetGender();
        DisplayGetDateOfBirth();
        DisplayGetHomeAddress();
        Console.Clear();
        DisplayGetDriversID();
        DisplayGetClassID();
        DisplayGetIDIssueDate();
        DisplayGetIDExpiration();
        DisplayGetHeight();
        DisplayGetEyeColor();
        GetLastName();

    }

    public Dictionary<string, int> GetVehicleDictionary()
    {
        return _vehicleDictionary;
    }

    public Dictionary<string, int> GetTradeInDictionary()
    {
        return _tradeInVehicleDictionary;
    }

    public abstract void SaveToCSV();
}