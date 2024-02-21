using System.Net.NetworkInformation;
using WinFormsAppCafe.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppCafe.Service
{
	/// <summary>
	/// Gestion des commandes 
	/// </summary>
	public class CommandeService
	{


		private List<Commande> _commandes = new()	;
		private IngredientService _ingredientService = new IngredientService();
		public CommandeService() {
			InitCommandes();
		}


		//Chargement des recettes initiales
		private void InitCommandes()
		{
			// Ajouter le recette Expresso
			Commande expresso = new Commande();
			expresso.Id = 1;
			expresso.Nom = "Expresso";
			expresso.Recette = new List<LigneRecette> {
				new LigneRecette(1, _ingredientService.GetIngredient("Café")),
				new LigneRecette(1, _ingredientService.GetIngredient("Eau"))
			};
			_commandes.Add(expresso);
			// Ajouter le recette Allongé
			Commande allonge = new Commande();
			allonge.Id = 2;
			allonge.Nom = "Allongé";
			allonge.Recette = new List<LigneRecette> {
				new LigneRecette(1, _ingredientService.GetIngredient("Café")),
				new LigneRecette(2, _ingredientService.GetIngredient("Eau"))
			};
			_commandes.Add(allonge);
			// Ajouter le recette Capuccino
			Commande capuccino = new Commande();
			capuccino.Id = 3;
			capuccino.Nom = "Capuccino";
			capuccino.Recette = new List<LigneRecette> {
				new LigneRecette(1, _ingredientService.GetIngredient("Café")),
				new LigneRecette(1, _ingredientService.GetIngredient("Chocolat")),
				new LigneRecette(1, _ingredientService.GetIngredient("Eau")),
				new LigneRecette(1, _ingredientService.GetIngredient("Crème"))
			};
			_commandes.Add(capuccino);
			// Ajouter le recette Chocolat
			Commande chocolat = new Commande();
			chocolat.Id = 4;
			chocolat.Nom = "Chocolat";
			chocolat.Recette = new List<LigneRecette> {
				new LigneRecette(3, _ingredientService.GetIngredient("Chocolat")),
				new LigneRecette(2, _ingredientService.GetIngredient("Lait")),
				new LigneRecette(1, _ingredientService.GetIngredient("Eau")),
				new LigneRecette(1, _ingredientService.GetIngredient("Sucre"))
			};
			_commandes.Add(chocolat);
			// Ajouter le recette Thé
			Commande the = new Commande();
			the.Id = 5;
			the.Nom = "Thé";
			the.Recette = new List<LigneRecette> {
				new LigneRecette(1, _ingredientService.GetIngredient("Thé")),
				new LigneRecette(1, _ingredientService.GetIngredient("Eau"))
			};
			_commandes.Add(the);
		}

		// renvoi la liste des recettes
		public List<Commande> GetMenu()
		{
			return _commandes ;
			
		}
		//ajout d'une recette
		public void AddCommande(Commande commande)
		{
			_commandes .Add(commande);
		}
		// extraction d'une recette à partir  d'un nom
		public Commande GetCommande(string nom)
		{
			return _commandes.SingleOrDefault(c=>c.Nom==nom);
		}
		// extraction d'une recette à partir  d'un id
		public Commande GetCommande(int id)
		{
			return _commandes.SingleOrDefault(c => c.Id == id);
		}
	}
}
