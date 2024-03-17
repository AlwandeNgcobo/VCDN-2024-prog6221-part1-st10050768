namespace ST10050768_RecipeApp_PROG6221
{
    public class Program
    {
        //Variable Declarations
        static string? recipeDetails;
        static int noOfIngredients;
        static string? name;
        static string? quantity;
        static string? unitOfMeasurement;
        static string? steps;
        static List<string> ingredientName =new List<string>();
        static List<string> ingredientQuantity = new List<string>();
        static List<string> ingredientUnitOfMeasurement = new List<string>();
        static int noOfSteps;
        static List<string>? recipeSteps = new List<string>();
        static void Main(string[] args)
        {
            //Allows users to enter their recipe name as well as the number of ingredients needed for that recipe
            Console.WriteLine("Enter Recipe");
            recipeDetails = Console.ReadLine();
            Console.WriteLine("Enter number of ingredients");
            noOfIngredients = int.Parse(Console.ReadLine());

            //Amount of times users will be able to enter their ingredients info and add it into their respective arrays
            for (int i = 0; i < noOfIngredients; i++)
            {
                Console.WriteLine("Enter name of ingredient");
                name = Console.ReadLine();
                ingredientName.Add(name);
                Console.WriteLine("Enter quantity of ingredient");
                quantity = Console.ReadLine();
                ingredientQuantity.Add(quantity);
                Console.WriteLine("Enter unit of measurement for ingredient");
                unitOfMeasurement = Console.ReadLine();
                ingredientUnitOfMeasurement.Add(unitOfMeasurement);
            }
            //Allows user to enter number of steps needed to take to make recipe
            Console.WriteLine($"Enter number of steps for {recipeDetails} recipe");
            noOfSteps = int.Parse(Console.ReadLine());

            //Amount of times users will be able to write the steps needed to take to make recipe and add it to the array
            for (int i = 0;i < noOfSteps;i++)
            {
                Console.WriteLine($"Enter step {i+1}");
                steps = Console.ReadLine();
                recipeSteps.Add(steps);
            }
            
            //Displays the recipe information
            Console.WriteLine(new Recipe(recipeDetails, ingredientName,ingredientQuantity,ingredientUnitOfMeasurement,recipeSteps).toString());
        }
    }
}
