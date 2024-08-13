using Cellphoneapp;
using System.Text;
using System;

public class PayAsYouGo : Account
{
    public int CallType { get; set; }

    public PayAsYouGo(string cellphoneNumber, int totalCallTime, decimal totalCostOfCalls, int callType)
        : base(cellphoneNumber, totalCallTime, totalCostOfCalls)
    {
        CallType = callType;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Call Type: {CallType}");
        Console.WriteLine(sb.ToString());
    }
}