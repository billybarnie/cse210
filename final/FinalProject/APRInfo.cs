
class Loan : Information
{
    // I plan on putting more information in here
    public Loan() {}
    public void APRInfo()
    {
        DisplayGetCreditScore();
        DisplayGetDebtAmount();
        DisplayGetAnnualIncome();
        DisplayGetInsuranceCompany();
        DisplayGetInsuranceCost();

    }

    public int DownPaymentCredit()
    {
        return _monthlyWithInsurance = _monthlyCost + GetInsuranceCosts();
    }

    public override void SaveToCSV() {}
}