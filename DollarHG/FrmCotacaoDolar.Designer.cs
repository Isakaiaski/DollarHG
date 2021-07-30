
namespace DollarHG
{
    partial class FrmCotacaoDolar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblMstBuy = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblMstVariation = new MetroFramework.Controls.MetroTextBox();
            this.lblMstSell = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(44, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Buy:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblMstBuy
            // 
            // 
            // 
            // 
            this.lblMstBuy.CustomButton.Image = null;
            this.lblMstBuy.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.lblMstBuy.CustomButton.Name = "";
            this.lblMstBuy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblMstBuy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMstBuy.CustomButton.TabIndex = 1;
            this.lblMstBuy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMstBuy.CustomButton.UseSelectable = true;
            this.lblMstBuy.CustomButton.Visible = false;
            this.lblMstBuy.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.lblMstBuy.Lines = new string[] {
        "0,0"};
            this.lblMstBuy.Location = new System.Drawing.Point(156, 113);
            this.lblMstBuy.MaxLength = 32767;
            this.lblMstBuy.Name = "lblMstBuy";
            this.lblMstBuy.PasswordChar = '\0';
            this.lblMstBuy.ReadOnly = true;
            this.lblMstBuy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblMstBuy.SelectedText = "";
            this.lblMstBuy.SelectionLength = 0;
            this.lblMstBuy.SelectionStart = 0;
            this.lblMstBuy.ShortcutsEnabled = true;
            this.lblMstBuy.Size = new System.Drawing.Size(75, 23);
            this.lblMstBuy.TabIndex = 2;
            this.lblMstBuy.Text = "0,0";
            this.lblMstBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblMstBuy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblMstBuy.UseSelectable = true;
            this.lblMstBuy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblMstBuy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(235, 271);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel2.Location = new System.Drawing.Point(44, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Sell:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel3.Location = new System.Drawing.Point(44, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Variation:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblMstVariation
            // 
            // 
            // 
            // 
            this.lblMstVariation.CustomButton.Image = null;
            this.lblMstVariation.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.lblMstVariation.CustomButton.Name = "";
            this.lblMstVariation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblMstVariation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMstVariation.CustomButton.TabIndex = 1;
            this.lblMstVariation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMstVariation.CustomButton.UseSelectable = true;
            this.lblMstVariation.CustomButton.Visible = false;
            this.lblMstVariation.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.lblMstVariation.Lines = new string[] {
        "0,0"};
            this.lblMstVariation.Location = new System.Drawing.Point(156, 208);
            this.lblMstVariation.MaxLength = 32767;
            this.lblMstVariation.Name = "lblMstVariation";
            this.lblMstVariation.PasswordChar = '\0';
            this.lblMstVariation.ReadOnly = true;
            this.lblMstVariation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblMstVariation.SelectedText = "";
            this.lblMstVariation.SelectionLength = 0;
            this.lblMstVariation.SelectionStart = 0;
            this.lblMstVariation.ShortcutsEnabled = true;
            this.lblMstVariation.Size = new System.Drawing.Size(75, 23);
            this.lblMstVariation.TabIndex = 10;
            this.lblMstVariation.Text = "0,0";
            this.lblMstVariation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblMstVariation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblMstVariation.UseSelectable = true;
            this.lblMstVariation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblMstVariation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMstSell
            // 
            // 
            // 
            // 
            this.lblMstSell.CustomButton.Image = null;
            this.lblMstSell.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.lblMstSell.CustomButton.Name = "";
            this.lblMstSell.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblMstSell.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMstSell.CustomButton.TabIndex = 1;
            this.lblMstSell.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMstSell.CustomButton.UseSelectable = true;
            this.lblMstSell.CustomButton.Visible = false;
            this.lblMstSell.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.lblMstSell.Lines = new string[] {
        "0,0"};
            this.lblMstSell.Location = new System.Drawing.Point(156, 162);
            this.lblMstSell.MaxLength = 32767;
            this.lblMstSell.Name = "lblMstSell";
            this.lblMstSell.PasswordChar = '\0';
            this.lblMstSell.ReadOnly = true;
            this.lblMstSell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblMstSell.SelectedText = "";
            this.lblMstSell.SelectionLength = 0;
            this.lblMstSell.SelectionStart = 0;
            this.lblMstSell.ShortcutsEnabled = true;
            this.lblMstSell.Size = new System.Drawing.Size(75, 23);
            this.lblMstSell.TabIndex = 11;
            this.lblMstSell.Text = "0,0";
            this.lblMstSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblMstSell.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblMstSell.UseSelectable = true;
            this.lblMstSell.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblMstSell.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(386, 439);
            this.Controls.Add(this.lblMstSell);
            this.Controls.Add(this.lblMstVariation);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMstBuy);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "Dollar Stock Price";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox lblMstBuy;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox lblMstVariation;
        private MetroFramework.Controls.MetroTextBox lblMstSell;
    }
}

