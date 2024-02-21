using WinFormsAppCafe.Models;
using WinFormsAppCafe.Service;

namespace WinFormsAppCafe
{
	public partial class Form1 : Form
	{
		CommandeService commandeService;
		private List<Commande> commandes;
		public Form1()
		{
			InitializeComponent();
			commandes=new List<Commande>();
			commandeService = new CommandeService();
			// chargement des recettes
			commandes= commandeService.GetMenu();
			this.menuList.DataSource = commandes;
			this.menuList.DisplayMember = "Nom";
			this.menuList.ValueMember = "Id";
			this.menuList.SelectedIndexChanged += MenuList_SelectedIndexChanged;
			this.menuList.SelectedIndex = 0;
			// calculer le prix de vente
			CalculPrixVente((int)menuList.SelectedValue);
		}

		

		private void MenuList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var idMenu = (int)menuList.SelectedValue;
			// calculer le prix de vente
			CalculPrixVente(idMenu);
		}

		//calcul le prix de vente et affiche
		private void CalculPrixVente(int selectedMenu)
		{
			int idMenu = selectedMenu;
			var commande = commandes.SingleOrDefault(x => x.Id == idMenu);
			var recetteList = commandes.Where(x => x.Id == idMenu).Select(c => c.Recette);
			double prix = 0;
			foreach (var r in recetteList)
			{
				prix += r.Sum(item => item.Quantite * item.Ingredient.Prix);
			}
			var marge = prix * 0.3;

			labelOutputPrice.Text = (prix + marge).ToString("C");
		}
	}
}
