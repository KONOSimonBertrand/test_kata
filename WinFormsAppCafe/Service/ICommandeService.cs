
using WinFormsAppCafe.Models;

namespace WinFormsAppCafe.Service
{
	interface ICommandeService
	{
		public List<Commande> GetMenu();
		public void AddCommande(Commande commande);
		public Commande GetCommande(string nom);
		public Commande GetCommande(int id);
	}
}
