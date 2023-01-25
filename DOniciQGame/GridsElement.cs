/*  DOniciQGame.sln
 *  PROG2370 - Assignment 2
 *  
 *  Created by Daniela Onici Student ID 8754297
 *  
 *  Revistion history:
 *      2022-11-03: created
 *      2022-11-05: bugs fixed and finished
 *      2022-11-06: completely finished
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOniciQGame
{
    /// <summary>
    /// GridsElement class inherited from Picturebox to define the properties of each picturebox created
    /// </summary>
    public class GridsElement : PictureBox
    {
        private Design mainDesign;

        public GridsElement(Design main)
        {
            this.mainDesign = main;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
