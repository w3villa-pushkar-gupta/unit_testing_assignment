public class Calculator
{
    public int Add(int a, int b)
    {
        return checked(a + b);
    }

    public int Subtract(int a, int b)
    {
        return checked(a - b);
    }
}
