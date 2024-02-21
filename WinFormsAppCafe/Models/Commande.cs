namespace WinFormsAppCafe.Models
{
	/// <summary>
	/// Représenter une commande
	/// </summary>
	public class Commande
	{public int Id { get; set; }
		public string Nom {  get; set; }	
		public List<LigneRecette> Recette { get; set; }	
	}
}
