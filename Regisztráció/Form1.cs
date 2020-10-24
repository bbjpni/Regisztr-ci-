using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            { lboxHobby.Items.Add(hobby); }
            else { MessageBox.Show("A hobbi már létezik, nem veheti fel ismételten", "HIBA"); }
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
            bool name = !tbName.Text.Trim().Equals("") && !tbName.Text.Contains(';');
            if (!name)
            {
                MessageBox.Show("A név nem tartlmazhat pontos vesszőt", "HIBA");
            }
            else
            {
                SaveFileDialog saver = new SaveFileDialog();
                saver.Filter = "Szöveges fájl|*.txt";
                saver.Title = "Válasszon ki egy helyet";
                saver.FileName = tbName.Text + ".txt";
                if (saver.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saver.FileName);
                    string datum = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-" + dtpDate.Value.Day;
                    sw.WriteLine(tbName.Text+";"+datum+";"+(rbtnGenderMale.Checked ? "Férfi": "Nő"));
                    for (int i = 0; i < lboxHobby.Items.Count; i++)
                    {
                        sw.WriteLine(lboxHobby.Items[i]);
                    }
                    sw.Close();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            opener.Filter = "Szöveges fájl|*.txt";
            opener.Title = "Válasszon ki egy fájlt";
            if (opener.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(opener.FileName);
                    string[] adatok = sr.ReadLine().Split(';');
                    tbName.Text = adatok[0]; dtpDate.Value = Change(adatok[1]); if (adatok[2] != "Férfi") { rbtnGenerFemale.Checked = true; } else { rbtnGenerMale.Checked = true;  }
                    lboxHobby.Items.Clear();
                    while (!sr.EndOfStream)
                    {
                        lboxHobby.Items.Add(Changer(sr.ReadLine()));
                    }
                    sr.Close();
                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("A szükséges adatok nem találhatóak","Hiba történt");
                    this.Close();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("A fájl nem található","Hiba történt");
                    this.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("A fájl beolvasása hibás", "Hiba történt");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Általános hiba", "Hiba történt");
                    this.Close();
                }
            }
        }

        private DateTime Change(string line)
        {
            string[] all = line.Split('-');
            return new DateTime(Convert.ToInt32(all[0]), Convert.ToInt32(all[1]), Convert.ToInt32(all[2]));
        }
    }
}
