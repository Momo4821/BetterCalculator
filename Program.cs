// See https://aka.ms/new-console-template for more information

int num1;
int num2;

//list of Operations
List<string> Operation = new List<string>()
{
    "0.Addtion",  //index 0
    "1.Subtraction", //index 1
    "2.Multiplication", //index 2
    "3.Division" //index 3
    
};
for (int i = 0; i < Operation.Count; i++)
{
    Console.WriteLine(Operation[i]);
        
}
string choice = Console.ReadLine();




do
{
   
    
    switch (choice)

    {
        case "0":
            Console.WriteLine("Please enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plesae enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total {num1} + {num2} = {num1 + num2}");
            for (int i = 0; i < Operation.Count; i++)
            {
                Console.WriteLine(Operation[i]);
        
            }
            choice = Console.ReadLine();
            break;
        case "1":
            Console.WriteLine("Please enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plesae enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total {num1} - {num2} = {num1 - num2}");
            for (int i = 0; i < Operation.Count; i++)
            {
                Console.WriteLine(Operation[i]);
        
            }
            choice = Console.ReadLine();
            break;
        case "2":
            Console.WriteLine("Please enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plesae enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total {num1} * {num2} = {num1 * num2}");
            for (int i = 0; i < Operation.Count; i++)
            {
                Console.WriteLine(Operation[i]);
        
            }
            choice = Console.ReadLine();
            break;
        case "3": 
            Console.WriteLine("Please enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plesae enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total {num1} / {num2} = {num1 / num2}");
            for (int i = 0; i < Operation.Count; i++)
            {
                Console.WriteLine(Operation[i]);
        
            }
            choice = Console.ReadLine();
            break;
        default:
            Console.WriteLine("Invalid");
            
        return;
    }

} while (choice == Operation.Count.ToString());

    








