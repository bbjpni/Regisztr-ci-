using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regisztráció
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lboxHobby.Items.Add("Uszás");
            lboxHobby.Items.Add("Horgászás");
            lboxHobby.Items.Add("Futás");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hobby = Changer(tbHobby.Text);
            if (!lboxHobby.Items.Contains(hobby) && !(hobby.Trim().Equals("")))
            {
                lboxHobby.Items.Add(hobby);
            }
        }

        private string Changer(string word)
        {
            string back = "";
            for (int i = 0; i < word.Length; i++)
            {
                back += i == 0 ? word.ToUpper()[i] : word.ToLower()[i];
            }
            return back;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool date = CheckingDate();
            bool name = !tbName.Text.Trim().Equals("");
            if (!(date && name))
            {
                MessageBox.Show("Nem helyes a beviteli adatok", "HIBA");
            }
        }

        private bool CheckingDate() {
            string[] datum = tbDate.Text.Split('-');
            bool back = datum.Length == 3;
            if (back)
            {
                if (int.TryParse(datum[0], out int year))
                { back = year > 0 && year >= DateTime.Now.Year-300; }
                if (back && int.TryParse(datum[1], out int month))
                { back = month < 13 || month > 0; }
                if (back && int.TryParse(datum[2], out int day))
                {
                    switch (Convert.ToInt32(datum[1]))
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            back = !(day > 0 && day < 32);
                            break;
                        case 2:
                            back = !(day > 0 && day < 29);
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            back = !(day > 0 && day < 31);
                            break;
                    }
                    back = !back;
                }
            }
            if (!back) { tbDate.Text = "éééé-hh-nn"; }
            return back;
        }
    }
}
