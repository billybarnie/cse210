
class Loan : Information
{
    
    private int _carCostWithInsurance;
   
    private string _signatureConcatinate;
    // I plan on putting more information in here
    public Loan() {}

    public void APRInfo()
    {
        DisplayGetCreditScore();
        DisplayGetDebtAmount();
        DisplayGetAnnualIncome();
        DisplayGetInsuranceCompany();
        DisplayGetInsuranceCost();
        DisplayGetMonthlyCarCost();
        DisplayGetVerifyVehicle();
        DisplayGetSignature();

        _carCostWithInsurance = GetCarCost() + GetInsuranceCosts();

        Console.Clear();
        Console.WriteLine($"The monthly cost of your vehicle with insurance is ${_carCostWithInsurance}");
        Thread.Sleep(7000);

    }

    public override void SaveToCSV()
    {
        if (GetCreditScore() >= 600 && GetAnnualIncome() >= 25000 && GetDebtAmount() <= 8000 
            && GetCarCost() != 0 && GetInsuranceCompany() != "" && GetInsuranceCosts() != 0 
            && GetSignature() != "")
        {   
            _signatureConcatinate = string.Format("{0}InsuranceInfo.txt", GetSignature().Split(" "));
            using (StreamWriter newFile = new StreamWriter(_signatureConcatinate))
            {
                newFile.WriteLine($"Credit Score: {GetCreditScore()}");
                newFile.WriteLine();

                newFile.WriteLine($"Outstanding debts/unpaid loans: ${GetDebtAmount()}");
                newFile.WriteLine();

                newFile.WriteLine($"Annual Income: ${GetAnnualIncome()}");
                newFile.WriteLine();

                newFile.WriteLine($"Insurance Company: {GetInsuranceCompany()}");
                newFile.WriteLine();

                newFile.WriteLine($"Monthly Insurance payments: ${GetInsuranceCosts()}");
                newFile.WriteLine();

                newFile.WriteLine($"Monthly Case payment cost: ${GetCarCost()}");
                newFile.WriteLine();

                newFile.WriteLine($"Total Monthly payments due: ${_carCostWithInsurance}");
                newFile.WriteLine();

                newFile.WriteLine($"Vehicle: {GetVerifyVehicle()}");
                newFile.WriteLine();

                newFile.WriteLine($"Electronic Signature: {GetSignature()}");
                newFile.WriteLine();
            }

            _signatureConcatinate = string.Format("{0}ApprovalLetter.txt", GetSignature().Split(" "));
            using (StreamWriter newFile = new StreamWriter(_signatureConcatinate))
            {
                newFile.WriteLine($"Dear {GetSignature()},");
                newFile.WriteLine();

                newFile.WriteLine($"You have been approved for the {GetVerifyVehicle()} based on your credit score and income with an estimated cost of ${_carCostWithInsurance} monthly with insurance.");

                newFile.WriteLine();
                newFile.WriteLine("Congradulations on getting your new car!!!");

                newFile.WriteLine();
                newFile.WriteLine();
                newFile.WriteLine("Sincerely, Kia Auto");
            }
        }
        else
        {
            _signatureConcatinate = string.Format("{0}DenialLetter.txt", GetSignature().Split(" "));
            using (StreamWriter newFile = new StreamWriter(_signatureConcatinate))
            {
                newFile.WriteLine($"Dear {GetSignature()}");
                newFile.WriteLine();

                newFile.WriteLine($"We regret to inform you that you have been denied to get the {GetVerifyVehicle()}");
                newFile.WriteLine("This is in part by either your credit being too low, your income being too low, or not providing any insurance.");
                newFile.WriteLine();

                newFile.WriteLine("Sincerely, Kia Auto");
            }
        }
    }
}