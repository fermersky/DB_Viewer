namespace DB_Viewer
{
    partial class Form2
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.firstName_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lastName_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ok_but = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancel_but = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.checkDebtor = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstName_tb
            // 
            this.firstName_tb.Depth = 0;
            this.firstName_tb.Hint = "";
            this.firstName_tb.Location = new System.Drawing.Point(226, 118);
            this.firstName_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.PasswordChar = '\0';
            this.firstName_tb.SelectedText = "";
            this.firstName_tb.SelectionLength = 0;
            this.firstName_tb.SelectionStart = 0;
            this.firstName_tb.Size = new System.Drawing.Size(318, 23);
            this.firstName_tb.TabIndex = 0;
            this.firstName_tb.UseSystemPasswordChar = false;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Depth = 0;
            this.lastName_tb.Hint = "";
            this.lastName_tb.Location = new System.Drawing.Point(226, 157);
            this.lastName_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.PasswordChar = '\0';
            this.lastName_tb.SelectedText = "";
            this.lastName_tb.SelectionLength = 0;
            this.lastName_tb.SelectionStart = 0;
            this.lastName_tb.Size = new System.Drawing.Size(318, 23);
            this.lastName_tb.TabIndex = 1;
            this.lastName_tb.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(55, 118);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "FirstName";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(55, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "LastName";
            // 
            // ok_but
            // 
            this.ok_but.Depth = 0;
            this.ok_but.Location = new System.Drawing.Point(226, 252);
            this.ok_but.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_but.Name = "ok_but";
            this.ok_but.Primary = true;
            this.ok_but.Size = new System.Drawing.Size(142, 37);
            this.ok_but.TabIndex = 4;
            this.ok_but.Text = "Ok";
            this.ok_but.UseVisualStyleBackColor = true;
            this.ok_but.Click += new System.EventHandler(this.ok_but_Click);
            // 
            // cancel_but
            // 
            this.cancel_but.Depth = 0;
            this.cancel_but.Location = new System.Drawing.Point(402, 252);
            this.cancel_but.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel_but.Name = "cancel_but";
            this.cancel_but.Primary = true;
            this.cancel_but.Size = new System.Drawing.Size(142, 37);
            this.cancel_but.TabIndex = 5;
            this.cancel_but.Text = "Cancel";
            this.cancel_but.UseVisualStyleBackColor = true;
            this.cancel_but.Click += new System.EventHandler(this.cancel_but_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(56, 202);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "IsDeptor";
            // 
            // checkDebtor
            // 
            this.checkDebtor.AutoSize = true;
            this.checkDebtor.Depth = 0;
            this.checkDebtor.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkDebtor.Location = new System.Drawing.Point(226, 202);
            this.checkDebtor.Margin = new System.Windows.Forms.Padding(0);
            this.checkDebtor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkDebtor.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkDebtor.Name = "checkDebtor";
            this.checkDebtor.Ripple = true;
            this.checkDebtor.Size = new System.Drawing.Size(82, 30);
            this.checkDebtor.TabIndex = 7;
            this.checkDebtor.Text = "IsDebtor";
            this.checkDebtor.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 377);
            this.Controls.Add(this.checkDebtor);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cancel_but);
            this.Controls.Add(this.ok_but);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.firstName_tb);
            this.Name = "Form2";
            this.Text = "Add new customer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField firstName_tb;
        private MaterialSkin.Controls.MaterialSingleLineTextField lastName_tb;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton ok_but;
        private MaterialSkin.Controls.MaterialRaisedButton cancel_but;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCheckBox checkDebtor;
    }
}