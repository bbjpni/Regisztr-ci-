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
            string hobby = Convert(tbHobby.Text);
            if (!lboxHobby.Items.Contains(hobby))
            {
                lboxHobby.Items.Add(hobby);
            }
        }

        private string Convert(string word)
        {
            string back = "";
            for (int i = 0; i < word.Length; i++)
            {
                back += i == 0 ? word.ToUpper()[i] : word.ToLower()[i];
            }
            return back;
        }
    }
}
