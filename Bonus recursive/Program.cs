class Program
{
    static void Main(string[] args)
    {   
        int num;
        while (true) {
            Console.WriteLine("Enter a number (1 or less to exit): ");
            if (int.TryParse(Console.ReadLine(), out num)) {
                if (num <= 1) {
                    break;
                } else {
                    Console.WriteLine((isPrime(num))? "Prime" : "Not Prime");
                }
            } else {
                Console.WriteLine("Invalid input");
            }
        }
    }
    static bool isPrime(int num, int divisor = 2)
    {
        if (num == divisor) {
            //Prime numbers are only divisable by 1 and themselves;
            return true;
        } else if (num % divisor == 0) {
            //If the number is divisable by any number other than 1 or itself, it is not prime
            return false;
        } else {
            //If the number is not divisable by the current divisor, try the next one
            return isPrime(num, divisor + 1);
        }
    }
}
