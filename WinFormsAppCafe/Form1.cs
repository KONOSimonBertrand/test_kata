using WinFormsAppCafe.Models;
using WinFormsAppCafe.Service;

namespace WinFormsAppCafe
{
	public partial class Form1 : Form
	{
		CommandeService commandeService=new CommandeService();
		private List<Commande> commandes;
		public Form1()
		{
			InitializeComponent();
			commandes=new List<Commande>();
			// chargement des recettes
			commandes= commandeService.GetMenu();
			this.menuList.DataSource = commandes;
			this.menuList.DisplayMember = "Nom";
			this.menuList.ValueMember = "Id";
			this.menuList.SelectedIndexChanged += MenuList_SelectedIndexChanged;
			this.menuList.SelectedIndex = 0;
			// calculer le prix de vente
			labelOutputPrice.Text = commandeService.GetPrixVente(menuList.SelectedValue != null ? (int)menuList.SelectedValue : 0).ToString("C");
		}

		

		private void MenuList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var idMenu = menuList.SelectedValue!=null?(int)menuList.SelectedValue:0;
			// calculer le prix de vente
			labelOutputPrice.Text=commandeService.GetPrixVente(idMenu).ToString("C");
		}

	}
}
