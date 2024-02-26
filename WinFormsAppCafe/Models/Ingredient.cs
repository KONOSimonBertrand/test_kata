namespace WinFormsAppCafe.Models
{
	/// <summary>
	/// Représenter un ingredient
	/// </summary>
	public class Ingredient:IEquatable<Ingredient>
	{
		public int Id { get; set; }
		public string Nom { get; set; }
		public double Prix{ get; set; }
		public Ingredient(int id,string nom,double prix) { 
			Id = id;
			this.Nom = nom;
			this.Prix = prix;
		}

		bool IEquatable<Ingredient>.Equals(Ingredient other)
		{
			if(other == null) return false;
			return (other.Id == this.Id || other.Nom == this.Nom);
		}
	}
}
