namespace Generic;

public class Pair<TFirst,TSecond>
{
    public TFirst FirstType { get; set; }
    public TSecond SecondType { get; set; }

    public Pair(TFirst firstType, TSecond secondType)
    {
        FirstType = firstType;
        SecondType = secondType;
    }
}