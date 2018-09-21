namespace DB_Viewer
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editCusBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addCusBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delAuthorBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editAuthorBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addAuthorBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.delBookBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editBookBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addBookBut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(960, 52);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 120);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(934, 508);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.delBut);
            this.tabPage1.Controls.Add(this.editCusBut);
            this.tabPage1.Controls.Add(this.addCusBut);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 482);
            this.dataGridView1.TabIndex = 4;
            // 
            // delBut
            // 
            this.delBut.Depth = 0;
            this.delBut.Location = new System.Drawing.Point(707, 431);
            this.delBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.delBut.Name = "delBut";
            this.delBut.Primary = true;
            this.delBut.Size = new System.Drawing.Size(197, 45);
            this.delBut.TabIndex = 3;
            this.delBut.Text = "delete";
            this.delBut.UseVisualStyleBackColor = true;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // editCusBut
            // 
            this.editCusBut.Depth = 0;
            this.editCusBut.Location = new System.Drawing.Point(707, 62);
            this.editCusBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.editCusBut.Name = "editCusBut";
            this.editCusBut.Primary = true;
            this.editCusBut.Size = new System.Drawing.Size(197, 45);
            this.editCusBut.TabIndex = 2;
            this.editCusBut.Text = "Edit Customer";
            this.editCusBut.UseVisualStyleBackColor = true;
            this.editCusBut.Click += new System.EventHandler(this.editCusBut_Click);
            // 
            // addCusBut
            // 
            this.addCusBut.Depth = 0;
            this.addCusBut.Location = new System.Drawing.Point(707, 0);
            this.addCusBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCusBut.Name = "addCusBut";
            this.addCusBut.Primary = true;
            this.addCusBut.Size = new System.Drawing.Size(197, 45);
            this.addCusBut.TabIndex = 1;
            this.addCusBut.Text = "add customer";
            this.addCusBut.UseVisualStyleBackColor = true;
            this.addCusBut.Click += new System.EventHandler(this.addCusBut_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delAuthorBut);
            this.tabPage2.Controls.Add(this.editAuthorBut);
            this.tabPage2.Controls.Add(this.addAuthorBut);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delAuthorBut
            // 
            this.delAuthorBut.Depth = 0;
            this.delAuthorBut.Location = new System.Drawing.Point(706, 431);
            this.delAuthorBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.delAuthorBut.Name = "delAuthorBut";
            this.delAuthorBut.Primary = true;
            this.delAuthorBut.Size = new System.Drawing.Size(197, 45);
            this.delAuthorBut.TabIndex = 6;
            this.delAuthorBut.Text = "delete";
            this.delAuthorBut.UseVisualStyleBackColor = true;
            this.delAuthorBut.Click += new System.EventHandler(this.delAuthorBut_Click);
            // 
            // editAuthorBut
            // 
            this.editAuthorBut.Depth = 0;
            this.editAuthorBut.Location = new System.Drawing.Point(706, 62);
            this.editAuthorBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.editAuthorBut.Name = "editAuthorBut";
            this.editAuthorBut.Primary = true;
            this.editAuthorBut.Size = new System.Drawing.Size(197, 45);
            this.editAuthorBut.TabIndex = 5;
            this.editAuthorBut.Text = "Edit Author";
            this.editAuthorBut.UseVisualStyleBackColor = true;
            this.editAuthorBut.Click += new System.EventHandler(this.editAuthorBut_Click);
            // 
            // addAuthorBut
            // 
            this.addAuthorBut.Depth = 0;
            this.addAuthorBut.Location = new System.Drawing.Point(706, 0);
            this.addAuthorBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.addAuthorBut.Name = "addAuthorBut";
            this.addAuthorBut.Primary = true;
            this.addAuthorBut.Size = new System.Drawing.Size(197, 45);
            this.addAuthorBut.TabIndex = 4;
            this.addAuthorBut.Text = "add author";
            this.addAuthorBut.UseVisualStyleBackColor = true;
            this.addAuthorBut.Click += new System.EventHandler(this.addAuthorBut_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(677, 482);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.delBookBut);
            this.tabPage3.Controls.Add(this.editBookBut);
            this.tabPage3.Controls.Add(this.addBookBut);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(926, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Books";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // delBookBut
            // 
            this.delBookBut.Depth = 0;
            this.delBookBut.Location = new System.Drawing.Point(707, 434);
            this.delBookBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.delBookBut.Name = "delBookBut";
            this.delBookBut.Primary = true;
            this.delBookBut.Size = new System.Drawing.Size(197, 45);
            this.delBookBut.TabIndex = 9;
            this.delBookBut.Text = "delete";
            this.delBookBut.UseVisualStyleBackColor = true;
            this.delBookBut.Click += new System.EventHandler(this.delBookBut_Click);
            // 
            // editBookBut
            // 
            this.editBookBut.Depth = 0;
            this.editBookBut.Location = new System.Drawing.Point(707, 65);
            this.editBookBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.editBookBut.Name = "editBookBut";
            this.editBookBut.Primary = true;
            this.editBookBut.Size = new System.Drawing.Size(197, 45);
            this.editBookBut.TabIndex = 8;
            this.editBookBut.Text = "Edit Book";
            this.editBookBut.UseVisualStyleBackColor = true;
            this.editBookBut.Click += new System.EventHandler(this.editBookBut_Click);
            // 
            // addBookBut
            // 
            this.addBookBut.Depth = 0;
            this.addBookBut.Location = new System.Drawing.Point(707, 3);
            this.addBookBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBookBut.Name = "addBookBut";
            this.addBookBut.Primary = true;
            this.addBookBut.Size = new System.Drawing.Size(197, 45);
            this.addBookBut.TabIndex = 7;
            this.addBookBut.Text = "add book";
            this.addBookBut.UseVisualStyleBackColor = true;
            this.addBookBut.Click += new System.EventHandler(this.addBookBut_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(679, 479);
            this.dataGridView3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 640);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Form1";
            this.Text = "DB Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialRaisedButton addCusBut;
        private MaterialSkin.Controls.MaterialRaisedButton editCusBut;
        private MaterialSkin.Controls.MaterialRaisedButton delBut;
        private MaterialSkin.Controls.MaterialRaisedButton delAuthorBut;
        private MaterialSkin.Controls.MaterialRaisedButton editAuthorBut;
        private MaterialSkin.Controls.MaterialRaisedButton addAuthorBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton delBookBut;
        private MaterialSkin.Controls.MaterialRaisedButton editBookBut;
        private MaterialSkin.Controls.MaterialRaisedButton addBookBut;
    }
}

