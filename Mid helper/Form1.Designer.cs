namespace Mid_helper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("tabPane1.Appearance.BackColor")));
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            resources.ApplyResources(this.tabPane1, "tabPane1");
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(618, 287);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("tabNavigationPage1.Appearance.BackColor")));
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.tabNavigationPage1, "tabNavigationPage1");
            this.tabNavigationPage1.Controls.Add(this.label2);
            this.tabNavigationPage1.Controls.Add(this.label1);
            this.tabNavigationPage1.Controls.Add(this.button1);
            this.tabNavigationPage1.Controls.Add(this.textBox1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("button1.Appearance.Font")));
            this.button1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("tabNavigationPage2.Appearance.BackColor")));
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.tabNavigationPage2, "tabNavigationPage2");
            this.tabNavigationPage2.Controls.Add(this.button2);
            this.tabNavigationPage2.Controls.Add(this.textBox2);
            this.tabNavigationPage2.Controls.Add(this.label3);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            // 
            // button2
            // 
            this.button2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("button2.Appearance.Font")));
            this.button2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // spreadsheetControl1
            // 
            resources.ApplyResources(this.spreadsheetControl1, "spreadsheetControl1");
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding")));
            this.spreadsheetControl1.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding")));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Name = "label4";
            // 
            // Form1
            // 
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("Form1.Appearance.BackColor")));
            this.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("Form1.Appearance.ForeColor")));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.tabPane1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton button2;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private System.Windows.Forms.Label label4;
    }
}

