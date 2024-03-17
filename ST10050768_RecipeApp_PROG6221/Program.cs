namespace ST10050768_RecipeApp_PROG6221
{
    public class Program
    {
        static string? recipeDetails;
        static int noOfIngredients;
        static string? name;
        static List<string> ingredientName =new List<string>();
        static string? noOfSteps;
        static List<string>? recipeSteps;
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
            }
            new Recipe(recipeDetails, ingredientName);
            Console.WriteLine(new Recipe(recipeDetails, ingredientName).toString());
        }
    }
}
