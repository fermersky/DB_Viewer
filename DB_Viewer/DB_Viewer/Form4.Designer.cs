namespace DB_Viewer
{
    partial class Form4
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.title_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // cancel_but
            // 
            this.cancel_but.Depth = 0;
            this.cancel_but.Location = new System.Drawing.Point(408, 210);
            this.cancel_but.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel_but.Name = "cancel_but";
            this.cancel_but.Primary = true;
            this.cancel_but.Size = new System.Drawing.Size(142, 37);
            this.cancel_but.TabIndex = 19;
            this.cancel_but.Text = "Cancel";
            this.cancel_but.UseVisualStyleBackColor = true;
            this.cancel_but.Click += new System.EventHandler(this.cancel_but_Click);
            // 
            // ok_but
            // 
            this.ok_but.Depth = 0;
            this.ok_but.Location = new System.Drawing.Point(232, 210);
            this.ok_but.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_but.Name = "ok_but";
            this.ok_but.Primary = true;
            this.ok_but.Size = new System.Drawing.Size(142, 37);
            this.ok_but.TabIndex = 18;
            this.ok_but.Text = "Ok";
            this.ok_but.UseVisualStyleBackColor = true;
            this.ok_but.Click += new System.EventHandler(this.ok_but_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(61, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Title";
            // 
            // title_tb
            // 
            this.title_tb.Depth = 0;
            this.title_tb.Hint = "";
            this.title_tb.Location = new System.Drawing.Point(232, 103);
            this.title_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.title_tb.Name = "title_tb";
            this.title_tb.PasswordChar = '\0';
            this.title_tb.SelectedText = "";
            this.title_tb.SelectionLength = 0;
            this.title_tb.SelectionStart = 0;
            this.title_tb.Size = new System.Drawing.Size(318, 23);
            this.title_tb.TabIndex = 14;
            this.title_tb.UseSystemPasswordChar = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 317);
            this.Controls.Add(this.cancel_but);
            this.Controls.Add(this.ok_but);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.title_tb);
            this.Name = "Form4";
            this.Text = "Add new Book";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton cancel_but;
        private MaterialSkin.Controls.MaterialRaisedButton ok_but;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField title_tb;
    }
}