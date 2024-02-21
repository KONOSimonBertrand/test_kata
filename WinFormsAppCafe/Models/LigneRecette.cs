namespace WinFormsAppCafe.Models
{
	/// <summary>
	/// Représenter un élément de la recette
	/// </summary>
	public class LigneRecette
	{
		public int Quantite {  get; set; }
		public  Ingredient Ingredient { get; set; }
		public LigneRecette(int quantite, Ingredient ingredient)
		{
			Quantite = quantite;
			Ingredient = ingredient;
		}
	}
}
