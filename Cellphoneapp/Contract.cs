using Cellphoneapp;
using System.Text;
using System;

public class Contract : Account
{
    public string AccountHolderName { get; set; }
    public string Address { get; set; }
    public int ContractLength { get; set; }

    public Contract(string cellphoneNumber, int totalCallTime, decimal totalCostOfCalls, string accountHolderName, string address, int contractLength)
        : base(cellphoneNumber, totalCallTime, totalCostOfCalls)
    {
        AccountHolderName = accountHolderName;
        Address = address;
        ContractLength = contractLength;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Account Holder: {AccountHolderName}");
        sb.AppendLine($"Address: {Address}");
        sb.AppendLine($"Contract Length: {ContractLength} months");
        Console.WriteLine(sb.ToString());
    }
}
