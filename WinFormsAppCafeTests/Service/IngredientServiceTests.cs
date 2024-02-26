using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsAppCafe.Models;

namespace WinFormsAppCafe.Service.Tests
{
	[TestClass()]
	public class IngredientServiceTests
	{
		// test d'ajout d'un ingredient
		[TestMethod()]
		public void AddIngredientTest()
		{
			var serviceIngredient = new IngredientService();
			var quantityBeforAdd = serviceIngredient.GetIngredients().Count();
			var ingredient = new Ingredient(30, "Soja", 4);
			serviceIngredient.AddIngredient(ingredient);
			var quantityAfterAdd = serviceIngredient.GetIngredients().Count();
			//si quantite apres ajout est superieur a quantite avant ajout alors ajout ok
			Assert.IsTrue(quantityAfterAdd>quantityBeforAdd);
		}
		// test d'extraction d'un ingredient via un nom 
		[TestMethod()]
		public void GetIngredientWithNameTest()
		{
			var serviceIngredient = new IngredientService();
			var ingredient = serviceIngredient.GetIngredient("Café");
			Assert.AreEqual("Café",ingredient.Nom);
		}
		// test d'extraction d'un ingredient via un id 
		[TestMethod()]
		public void GetIngredientWithIdTest()
		{
			var serviceIngredient = new IngredientService();
			var ingredient = serviceIngredient.GetIngredient(1);
			Assert.AreEqual(1, ingredient.Id);
		}
	}
}