using System;

namespace Generic_Class 
{ 
public class PairTS<T, S>
{
    private T first;
    private S second;

    public PairTS(T first, S second)
    {
        this.first = first; this.second = second;
    }

    public T First
    {
        get { return first; }
    }

    public S Second
    {
        get { return second; }
    }
   }
}