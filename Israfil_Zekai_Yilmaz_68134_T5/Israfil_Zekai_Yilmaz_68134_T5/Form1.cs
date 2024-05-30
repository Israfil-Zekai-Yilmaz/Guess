using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Israfil_Zekai_Yilmaz_68134_T5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtMin.Text);
            int max = int.Parse(txtMax.Text);
            string item = DiffBox1.SelectedItem.ToString();
            switch (item)
            {
                case "Easy":
                    Game.Timer = 90;
                    break;
                case "Medium":
                    Game.Timer = 60;
                    break;
                case "Hard":
                    Game.Timer = 40;
                    break;

            }
            Game.Min= min; Game.Max = max;
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
