/*  DOniciQGame.sln
 *  PROG2370 - Assignment 2
 *  
 *  Created by Daniela Onici Student ID 8754297
 *  
 *  Revistion history:
 *      2022-11-03: created
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOniciQGame
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            Design design = new Design();
            design.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }
    }
}
