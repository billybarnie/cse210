
abstract class Information
{
    private int _driversLicenseID = -1;
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

    public Information() {}

    public Information(int driversLicenseID, string driverClassOnID, string driversLicenseExpire, 
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
        _driversLicenseID = int.Parse(Console.ReadLine());
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
        Console.Write("What is the issue date on your drivers license? ");
        _driversLicenseIssue = Console.ReadLine();
    }

    public void DisplayGetIDExpiration()
    {
        Console.WriteLine();
        Console.Write("What is the expiration date on your drivers license? ");
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
        Console.Write("What is your legal place of residence? (city, state and zip as well) ");
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

    public int GetDriversID()
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
        
        SaveToCSV();

    }

    public abstract void SaveToCSV();
}