namespace Backend
{
    public class FactorialCalculator
    {
        public int factorialRecursive(int factorial)
        {
            if (factorial == 1 || factorial == 0)
            {
                return 1;
            }
            else
            {
                return factorial * factorialRecursive(factorial - 1);
            }
        }
    }
}