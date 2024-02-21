namespace WinFormsAppCafe
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			menuList = new ListBox();
			label2 = new Label();
			labelOutputPrice = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(27, 29);
			label1.Name = "label1";
			label1.Size = new Size(46, 20);
			label1.TabIndex = 0;
			label1.Text = "Menu";
			// 
			// menuList
			// 
			menuList.FormattingEnabled = true;
			menuList.ItemHeight = 20;
			menuList.Location = new Point(27, 52);
			menuList.Name = "menuList";
			menuList.Size = new Size(199, 244);
			menuList.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(274, 52);
			label2.Name = "label2";
			label2.Size = new Size(33, 20);
			label2.TabIndex = 3;
			label2.Text = "Prix";
			// 
			// labelOutputPrice
			// 
			labelOutputPrice.AutoSize = true;
			labelOutputPrice.Location = new Point(343, 52);
			labelOutputPrice.Name = "labelOutputPrice";
			labelOutputPrice.Size = new Size(41, 20);
			labelOutputPrice.TabIndex = 4;
			labelOutputPrice.Text = "0000";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(labelOutputPrice);
			Controls.Add(label2);
			Controls.Add(menuList);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ListBox menuList;
		private Label label2;
		private Label labelOutputPrice;
	}
}
