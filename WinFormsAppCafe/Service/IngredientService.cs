using WinFormsAppCafe.Models;

namespace WinFormsAppCafe.Service
{
	/// <summary>
	/// Gestion des ingredients 
	/// </summary>
	public class IngredientService
	{
		
		private  List<Ingredient> _ingredients = new();
		public IngredientService()
		{
			_ingredients = new()
			{
				new Ingredient(1,"Café", 1),
				new Ingredient(2,"Sucre", 0.1),
				new Ingredient(3,"Crème", 0.5),
				new Ingredient(4, "Thé", 2),
				new Ingredient(5,"Eau", 0.2),
				new Ingredient(6, "Chocolat", 1),
				new Ingredient(7,"Lait", 0.4)
			};
		}
		
		// retourne la liste des ingredients
		public List<Ingredient> GetIngredients()
		{
			return _ingredients;
		}
		//ajout d'un nouvel ingredient
		public  void AddIngredient(Ingredient ingredient)
		{
			_ingredients.Add(ingredient);
		}
		//extraction d'un ingredient  à partir  d'un nom
		public Ingredient GetIngredient(string nom)
		{
			return _ingredients.SingleOrDefault(i => i.Nom == nom);
		}
		//extraction d'un ingredient  à partir  d'un id
		public Ingredient GetIngredient(int id)
		{
			return _ingredients.SingleOrDefault(i => i.Id == id);
		}
	}
	
}
