DailyAccountState test = new DailyAccountState(1000, 200);
DailyAccountState test2 = new DailyAccountState(500, -200);
Console.WriteLine(test.Report());
Console.WriteLine(test2.Report());
public class DailyAccountState
{
    public int InitialState { get; }

    public int SumOfOperations { get; }

    public DailyAccountState(
        int initialState,
        int sumOfOperations)
    {
        InitialState = initialState;
        SumOfOperations = sumOfOperations;
    }

    public int EndOfDayState => InitialState + SumOfOperations;

    public string Report()
    {
        DateTime date = DateTime.Now;
        return ($"Day: {date.Day}, month: {date.Month}, " +
               $"year: {date.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}.");
    }
}
