namespace MethodOverloading
{
    public class Program
    {
        public static int Add( int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1 , decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2 , bool isTrue)
        {
            var sum = 0;
            var response = "";
            if (isTrue)

            {
                sum = num1 + num2;

                if( sum == 1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }

            }

            return response;
        }


        static void Main(string[] args)
          
        {

            int answer1 = Add(0, 1);
            int answer2 = Add(2,3);
            int answer3 = Add(7,9);

            Console.WriteLine(answer1);
            Console.WriteLine();
            Console.WriteLine(answer2);
            Console.WriteLine();
            Console.WriteLine(answer3);
            Console.WriteLine();

            Console.WriteLine(Add(0, 1 , true));

            Console.WriteLine();

            Console.WriteLine(Add(2, 3, true));

            Console.WriteLine();

            Console.WriteLine(Add(7, 9, true));

        }
    }
}
