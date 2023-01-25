/*  Tile class
 *  PROG2370 - Assignment 3
 *  
 *  Created by Daniela Onici Student ID 8754297
 *  
 *  Revistion history:
 *      2022-11-24: created
 *      2022-11-27: bugs fixed
 *      2022-11-28: finished
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOniciQGame
{
    public class Tile : PictureBox
    {
        public int row { get; set; }
        public int col { get; set; }
        public int tileType { get; set; }

        Game game;

        public Tile(Game game)
        {
            this.game = game;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.tileType = tileType;
        }
    }
}
