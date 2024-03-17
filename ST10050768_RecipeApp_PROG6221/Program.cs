namespace ST10050768_RecipeApp_PROG6221
{
    public class Program
    {
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
            Console.WriteLine("Enter Recipe");
            recipeDetails = Console.ReadLine();
            Console.WriteLine("Enter number of ingredients");
            noOfIngredients = int.Parse(Console.ReadLine());
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

            Console.WriteLine($"Enter number of steps for {recipeDetails} recipe");
            noOfSteps = int.Parse(Console.ReadLine());
            for (int i = 0;i < noOfSteps;i++)
            {
                Console.WriteLine($"Enter step {i+1}");
                steps = Console.ReadLine();
                recipeSteps.Add(steps);
            }
            
            Console.WriteLine(new Recipe(recipeDetails, ingredientName,ingredientQuantity,ingredientUnitOfMeasurement,recipeSteps).toString());
        }
    }
}
