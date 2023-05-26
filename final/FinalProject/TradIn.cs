class TradeIn : Information
{
    
    public TradeIn() {}

    public void PersonalInformation()
    {   
        DisplayGetFirstName();
        DisplayGetMiddleName();
        DisplayGetLastName();
        DisplayGetGender();
        DisplayGetDateOfBirth();
        DisplayGetHomeAddress();
        DisplayGetDriversID();
        DisplayGetClassID();
        DisplayGetIDIssueDate();
        DisplayGetIDExpiration();
        DisplayGetHeight();
        DisplayGetEyeColor();
    }
    public override string CreditScore()
    {
        throw new NotImplementedException();
    }
}