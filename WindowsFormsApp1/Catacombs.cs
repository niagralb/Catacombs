using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GameEngine;

namespace WindowsFormsApp1
{
    public partial class Catacombs : Form
    {
        private CharacterBodyFactory cbf = new CharacterBodyFactory();
        private Character Char1;

        public Catacombs()
        {
            InitializeComponent();


            Char1 = new Character("Saga", 10, 23, 2);
            CharacterBody Char1Body = cbf.createDragonoidBody("human");

            //lblLevelValue.Text = char1.CurLevel.ToString();
        }

        private void Catacombs_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblLevelValue.Text = "1";

            lblHealthValue.Text = "10";
        }
    }
}
