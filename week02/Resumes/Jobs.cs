using System;

public class Job
{
    //Function
    public string _company;
    public string _JobTitle;
    public int _startYear;
    public int _endYear;

    //Display, Output of Program
    public void Display()
    {
        Console.WriteLine($"{_JobTitle} ({_company}) ({_startYear})-({_endYear})");
    }
}