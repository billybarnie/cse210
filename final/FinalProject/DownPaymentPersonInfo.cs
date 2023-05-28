class DownPayment : Information
{
    private int _downPaymentAmount;
    public DownPayment() {}

    public void DisplayGetDownPayment()
    {
        Console.WriteLine();
        Console.WriteLine("How much do you intend to put down on the vehicle that you desire? ");
        _downPaymentAmount = int.Parse(Console.ReadLine());
    }

    public int GetDownPayment()
    {
        return _downPaymentAmount;
    }
    
    public override void SaveToCSV()
    {
        if(GetFirstName() != "" && GetMiddleName() != "" && GetLastName() != "" && GetDateOfBirth() != "" &&
           GetHomeAddress() != "" && GetDriversID() != -1 && GetIDIssueDate() != "" && GetIDExpiration() != "" 
           && GetGender() != "" && GetClassID() != "" && GetHeight() != "" && GetEyeColor() != "")
        {
            string fullName = string.Format("{0}{1}{2}Info.txt", GetFirstName(), GetMiddleName(), GetLastName());
            using (StreamWriter newFile = new StreamWriter(fullName))
            {
                newFile.WriteLine(string.Format("First Name: {0}     Middle Name: {1}   Last Name: {2}",
                GetFirstName(), GetMiddleName(), GetLastName()));

                newFile.WriteLine();
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