namespace WinFormsAppCafe.Models
{
	/// <summary>
	/// Représenter une commande
	/// </summary>
	public class Commande:IEquatable<Commande>
	{public int Id { get; set; }
		public string Nom {  get; set; }	
		public List<LigneRecette> Recette { get; set; }

		public bool Equals(Commande other)
		{
			if(other == null) return false;
			return(other.Id == this.Id|| other.Nom == this.Nom);
		}
	}
}
