namespace Generic;

public class ComparablePair<TFirst, TSecond> : IComparable<ComparablePair<TFirst, TSecond>> where TFirst : IComparable<TFirst> where TSecond : IComparable<TSecond>
{
    public TFirst First { get; set; }
    public TSecond Second { get; set; }

    public ComparablePair(TFirst first, TSecond second)
    {
        First = first;
        Second = second;
    }

    public int CompareTo(ComparablePair<TFirst, TSecond> input)
    {
        var firstComparison = First.CompareTo(input.First);
        return firstComparison == 0 ? Second.CompareTo(input.Second) : firstComparison;
    }
}