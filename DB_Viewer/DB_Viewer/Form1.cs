using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Viewer
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void RefreshTables()
        {
            using (BestLibraryEntities db = new BestLibraryEntities())
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.Customers.Select(a => new { a.Id, a.FirstName, a.LastName, a.IsDebtor }).ToList();
                dataGridView1.DataSource = bs;

                BindingSource bs1 = new BindingSource();
                bs1.DataSource = db.Authors.Select(a => new { a.Id, a.FirstName, a.LastName }).ToList();
                dataGridView2.DataSource = bs1;

                BindingSource bs2 = new BindingSource();
                bs2.DataSource = db.Books.Select(a => new { a.Id, a.Title }).ToList();
                dataGridView3.DataSource = bs2;
            }
        }

        /* --- Customers --- */

        private void addCusBut_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            RefreshTables();
        }

        private void editCusBut_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (dataGridView1.CurrentRow.Index != -1)
            {
                // MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                string firstname = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                string lastname = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                bool isdebtor = Convert.ToBoolean(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
                form2.FillTextBoxes(firstname, lastname, isdebtor);
                form2.CurrIndex = dataGridView1.CurrentRow.Index;
                form2.Text = "Edit Customer";
                form2.ShowDialog();
                RefreshTables();
                //MessageBox.Show(); // 1, 2
            }
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Customer?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    using (BestLibraryEntities db = new BestLibraryEntities())
                    {
                        Customers toDelete = db.Customers.Where(c => c.Id == dataGridView1.CurrentRow.Index + 1).FirstOrDefault();
                        db.Customers.Remove(toDelete);
                        db.SaveChanges();
                        RefreshTables();
                    }
                }
            }
        }

        /* --- Authors --- */

        private void addAuthorBut_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            RefreshTables();
        }

        private void editAuthorBut_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            if (dataGridView2.CurrentRow.Index != -1)
            {
                // MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                string firstname = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString();
                string lastname = dataGridView2[2, dataGridView2.CurrentRow.Index].Value.ToString();
                
                form3.FillTextBoxes(firstname, lastname);
                form3.CurrIndex = dataGridView2.CurrentRow.Index;
                form3.Text = "Edit Authors";
                form3.ShowDialog();
                RefreshTables();
                //MessageBox.Show(); // 1, 2
            }
        }

        private void delAuthorBut_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Author?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    using (BestLibraryEntities db = new BestLibraryEntities())
                    {
                        Authors toDelete = db.Authors.Where(c => c.Id == dataGridView2.CurrentRow.Index + 1).FirstOrDefault();
                        db.Authors.Remove(toDelete);
                        db.SaveChanges();
                        RefreshTables();
                    }
                }
            }
        }

        /* --- Books --- */

        private void addBookBut_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            RefreshTables();
        }

        private void editBookBut_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            if (dataGridView3.CurrentRow.Index != -1)
            {
                // MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                string title = dataGridView3[1, dataGridView3.CurrentRow.Index].Value.ToString();

                form4.FillTextBoxes(title);
                form4.CurrIndex = dataGridView3.CurrentRow.Index;
                form4.Text = "Edit Books";
                form4.ShowDialog();
                RefreshTables();
                //MessageBox.Show(); // 1, 2
            }
        }

        private void delBookBut_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow.Index != -1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Book?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    using (BestLibraryEntities db = new BestLibraryEntities())
                    {
                        Books toDelete = db.Books.Where(c => c.Id == dataGridView3.CurrentRow.Index + 1).FirstOrDefault();
                        db.Books.Remove(toDelete);
                        db.SaveChanges();
                        RefreshTables();
                    }
                }
            }
        }
    }
}
