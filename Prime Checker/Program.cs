namespace Check_Prime;
class Program
{
    static void Main(string[] args)
    {   
        while (true) {
            Console.WriteLine("Enter a number (1 or less to exit): ");
            if (int.TryParse(Console.ReadLine(), out int num) && num > 1) {
                Console.WriteLine(isPrime(num));
            } else {
                break;
            }
        }
    }
    static bool isPrime(int num) {
        for (int i = 2; i < num ; i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }
}
