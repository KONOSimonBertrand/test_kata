using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsAppCafe.Models;
using WinFormsAppCafe.Service;

namespace WinFormsAppCafeTests.Service
{
	/// <summary>
	/// Test des méthode de la classe CommandeService
	/// </summary>
	[TestClass()]
	public class CommandeServiceTests
	{
		// test d'ajout d'une commande
		[TestMethod()]
		public void AddCommandeServiceTest()
		{
			var commandeService = new CommandeService();
			var cmd=new Commande();
			cmd.Id = 6;
			cmd.Nom = "Jus orange";
			// creation d'un ingredient
			var ingredient = new Ingredient(30, "Orange", 5);
			var ingredientService= new IngredientService();
			ingredientService.AddIngredient(ingredient);
			cmd.Recette = new List<LigneRecette> {
				new(1, ingredientService.GetIngredient("Orange")),
				new(1, ingredientService.GetIngredient("Eau"))
			};
			var quantityBeforAdd = commandeService.GetMenu().Count();
			//ajout de la commande
			commandeService.AddCommande(cmd);
			var quantityAfterAdd = commandeService.GetMenu().Count();
			//si quantite apres ajout est superieur a quantite avant ajout alors ajout ok
			Assert.IsTrue(quantityAfterAdd > quantityBeforAdd);
		}

		// test d'extraction d'une commande via un id
		[TestMethod()]
		public void GetCommandeWithIdTest()
		{
			var serviceCommande = new CommandeService();
			var commande = serviceCommande.GetCommande(1);
			Assert.AreEqual(1, commande.Id);
		}
		// test d'extraction d'une commande via le nom
		[TestMethod()]
		public void GetCommandeWithNameTest()
		{
			var serviceCommande = new CommandeService();
			var commande = serviceCommande.GetCommande("Expresso");
			Assert.AreEqual("Expresso", commande.Nom);
		}
		// test calcul prix de vente
		[TestMethod()]
		public void GetPrixVenteTest()
		{
			var serviceCommande = new CommandeService();
			var commande = serviceCommande.GetCommande("Expresso");
			Assert.AreEqual(1.56, serviceCommande.GetPrixVente(commande.Id));
		}
	}
}
