
class Loan 
{
    private int _loanSize;
    private int _annualIncome;
    private string _insuranceName;
    private int _insuranceCostMonthly;

    // I plan on putting more information in here
    public Loan() {}

    public Loan(int loanSize, int annualIncome, int insuranceCostMonthly, string insuranceName) 
    {
        _loanSize                = loanSize;
        _annualIncome            = annualIncome;
        _insuranceCostMonthly    = insuranceCostMonthly;
        _insuranceName           = insuranceName;

    }

    

    public void DisplayGetDebtAmount()
    {
        Console.WriteLine();
        Console.WriteLine("Do you have any outstanding debts or unpayed loans if so put the total amount here: ");
        _loanSize = int.Parse(Console.ReadLine());
    }

    public void DisplayGetAnnualIncome()
    {
        Console.WriteLine();
        Console.WriteLine("What is your annual income? ");
        _annualIncome = int.Parse(Console.ReadLine());
    }
    public void DisplayGetInsuranceCompany()
    {
        Console.WriteLine();
        Console.WriteLine("What is the name of the insurance company that you are working with? ");
        _insuranceName = Console.ReadLine();
    }
    public void DisplayGetInsuranceCost()
    {
        Console.WriteLine();
        Console.WriteLine("What is your monthly insurance cost? ");
        _insuranceCostMonthly = int.Parse(Console.ReadLine());
    }

    public int GetDebtAmount()
    {
        return _loanSize;
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
    
    public void APRInfo()
    {
        DisplayGetDebtAmount();
        DisplayGetAnnualIncome();
        DisplayGetInsuranceCompany();
        DisplayGetInsuranceCost();
    }

}