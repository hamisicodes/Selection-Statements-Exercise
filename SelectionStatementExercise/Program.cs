namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random(); // initialize a random number generator
            var favNumber = r.Next(1, 100) ; //generates random number >= 1 and < 100

            Console.WriteLine("Guess a random number:");
            var userInput = int.Parse(Console.ReadLine());

            if(favNumber > userInput){
                Console.WriteLine($"too low, the answer is {favNumber}");
            }
            else if(favNumber < userInput){
                Console.WriteLine($"too high, the number is {favNumber}");
            }
            else{
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}
