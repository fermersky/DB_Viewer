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
    public partial class Form4 : MaterialForm
    {
        public int CurrIndex { get; set; }
        public Form4()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void ok_but_Click(object sender, EventArgs e)
        {
            Books cus = new Books
            {
                Title = title_tb.Text,
            };

            using (BestLibraryEntities db = new BestLibraryEntities())
            {
                if (this.Text == "Edit Books")
                {
                    var willEdit = db.Books
                        .Where(c => c.Id == CurrIndex + 1)
                        .FirstOrDefault();

                    willEdit.Title = cus.Title;


                    MessageBox.Show("Book has been edited!");
                }
                else
                {
                    db.Books.Add(cus);
                    MessageBox.Show("Book has been added!");
                }
                db.SaveChanges();
                this.Close();
            }
        }

        private void cancel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillTextBoxes(string _title)
        {
            title_tb.Text = _title;
        }
    }
}
