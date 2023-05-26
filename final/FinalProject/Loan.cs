
class Loan 
{
    private int _loanSize;
    private int _annualIncome;
    private string _insuranceName;
    private int _insuranceCostMonthly;
    public Loan() {}

    public Loan(int loanSize, int annualIncome, int insuranceCostMonthly, string insuranceName) 
    {
        _loanSize                = loanSize;
        _annualIncome            = annualIncome;
        _insuranceCostMonthly    = insuranceCostMonthly;
        _insuranceName           = insuranceName;

    }

    
}