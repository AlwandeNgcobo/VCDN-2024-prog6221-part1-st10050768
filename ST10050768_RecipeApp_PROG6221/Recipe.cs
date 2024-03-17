using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10050768_RecipeApp_PROG6221
{
    public class Recipe
    {
        private string recipeDetails { get; set; }
        private List<string> ingredientName { get; set; }
        private List<string> ingredientQuantity { get; set; }
        private List<string> ingredientUnitOfMeasurement { get; set; }
        private List<string> recipeSteps { get; set; }

        public Recipe(string recipeDetails, List<string> ingredientName, List<string> ingredientQuantity, List<string> ingredientUnitOfMeasurement, List<string> recipeSteps)
        {
            this.recipeDetails = recipeDetails;
            this.ingredientName = ingredientName;
            this.ingredientQuantity = ingredientQuantity;
            this.ingredientUnitOfMeasurement = ingredientUnitOfMeasurement;
            this.recipeSteps = recipeSteps;
        }
        public string toString()
        {
            return "recipe: " + recipeDetails + "" +
                "\nIngredient name: " + string.Join(", ", ingredientName)+
                "\nIngredient Quantity: " + string.Join(", ", ingredientQuantity)+
                "\nIngredient Unit of Measurement: " + string.Join(", ", ingredientUnitOfMeasurement)+
                "\nSteps to take for "+recipeDetails+": "+string.Join(", ",recipeSteps);
            //string.Join(", ", ingredientName) from https://stackoverflow.com/questions/16106181/why-am-i-getting-system-collections-generic-list1system-string-instead-of-the
        }
    }
}
