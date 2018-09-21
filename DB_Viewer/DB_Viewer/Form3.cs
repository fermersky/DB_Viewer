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
    public partial class Form3 : MaterialForm
    {
        public int CurrIndex { get; set; }
        public Form3()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ok_but_Click(object sender, EventArgs e)
        {
            Authors cus = new Authors
            {
                FirstName = firstName_tb.Text,
                LastName = lastName_tb.Text,
            };

            using (BestLibraryEntities db = new BestLibraryEntities())
            {
                if (this.Text == "Edit Authors")
                {
                    var willEdit = db.Authors
                        .Where(c => c.Id == CurrIndex + 1)
                        .FirstOrDefault();

                    willEdit.FirstName = cus.FirstName;
                    willEdit.LastName = cus.LastName;

                    MessageBox.Show("Author has been edited!");
                }
                else
                {
                    db.Authors.Add(cus);
                    MessageBox.Show("Author has been added!");
                }
                db.SaveChanges();
                this.Close();
            }
        }

        private void cancel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillTextBoxes(string _firstname, string _lastname)
        {
            firstName_tb.Text = _firstname;
            lastName_tb.Text = _lastname;
        }
    }
}
