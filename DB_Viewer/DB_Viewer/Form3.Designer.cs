namespace DB_Viewer
{
    partial class Form3
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
            this.cancel_but = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ok_but = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lastName_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.firstName_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // cancel_but
            // 
            this.cancel_but.Depth = 0;
            this.cancel_but.Location = new System.Drawing.Point(397, 254);
            this.cancel_but.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel_but.Name = "cancel_but";
            this.cancel_but.Primary = true;
            this.cancel_but.Size = new System.Drawing.Size(142, 37);
            this.cancel_but.TabIndex = 13;
            this.cancel_but.Text = "Cancel";
            this.cancel_but.UseVisualStyleBackColor = true;
            this.cancel_but.Click += new System.EventHandler(this.cancel_but_Click);
            // 
            // ok_but
            // 
            this.ok_but.Depth = 0;
            this.ok_but.Location = new System.Drawing.Point(221, 254);
            this.ok_but.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_but.Name = "ok_but";
            this.ok_but.Primary = true;
            this.ok_but.Size = new System.Drawing.Size(142, 37);
            this.ok_but.TabIndex = 12;
            this.ok_but.Text = "Ok";
            this.ok_but.UseVisualStyleBackColor = true;
            this.ok_but.Click += new System.EventHandler(this.ok_but_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(50, 159);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "LastName";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(50, 120);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "FirstName";
            // 
            // lastName_tb
            // 
            this.lastName_tb.Depth = 0;
            this.lastName_tb.Hint = "";
            this.lastName_tb.Location = new System.Drawing.Point(221, 159);
            this.lastName_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.PasswordChar = '\0';
            this.lastName_tb.SelectedText = "";
            this.lastName_tb.SelectionLength = 0;
            this.lastName_tb.SelectionStart = 0;
            this.lastName_tb.Size = new System.Drawing.Size(318, 23);
            this.lastName_tb.TabIndex = 9;
            this.lastName_tb.UseSystemPasswordChar = false;
            // 
            // firstName_tb
            // 
            this.firstName_tb.Depth = 0;
            this.firstName_tb.Hint = "";
            this.firstName_tb.Location = new System.Drawing.Point(221, 120);
            this.firstName_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.PasswordChar = '\0';
            this.firstName_tb.SelectedText = "";
            this.firstName_tb.SelectionLength = 0;
            this.firstName_tb.SelectionStart = 0;
            this.firstName_tb.Size = new System.Drawing.Size(318, 23);
            this.firstName_tb.TabIndex = 8;
            this.firstName_tb.UseSystemPasswordChar = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 377);
            this.Controls.Add(this.cancel_but);
            this.Controls.Add(this.ok_but);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.firstName_tb);
            this.Name = "Form3";
            this.Text = "Add new Author";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton cancel_but;
        private MaterialSkin.Controls.MaterialRaisedButton ok_but;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField lastName_tb;
        private MaterialSkin.Controls.MaterialSingleLineTextField firstName_tb;
    }
}