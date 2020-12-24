using System;

public class Kata3
{
    public int DigitalRoot(long n)
    {
        int times = n.ToString().Length;

        while (times > 1)
        {
            n = SimpleDigitalRoot(n);
            times--;
        }
        return SimpleDigitalRoot(n);
    }

    public int SimpleDigitalRoot(long n)
    {
        int digits = n.ToString().Length;
        return (digits == 1) ? (int)n : (int)(n / Math.Pow(10, digits - 1)) + DigitalRoot(n % (long)Math.Pow(10, digits - 1));
    }
}
