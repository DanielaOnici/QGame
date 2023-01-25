/*  DOniciQGame.sln
 *  PROG2370 - Assignment 2
 *  
 *  Created by Daniela Onici Student ID 8754297
 *  
 *  Revistion history:
 *      2022-11-03: created
 *      2022-11-05: bugs fixed and finished
 *      2022-11-06: completely finished
 * 
 */

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DOniciQGame
{
    /// <summary>
    /// Main class of the game containing the methods, logic and instantiated GridsElement class
    /// </summary>
    public partial class Design : Form
    {
        //Create global variables 
        const int GAP = 65;
        const int INITIAL_X = 248;
        const int INITIAL_Y = 126;
        const int WALL = 1;
        const int RED_DOOR = 2;
        const int GREEN_DOOR = 3;
        const int RED_BOX = 4;
        const int GREEN_BOX = 5;
        const int NONE = 6;
        int locationX = INITIAL_X;
        int locationY = INITIAL_Y;
        int numberOfRows = 0;
        int numberOfColumns = 0;
        int numberOfWalls = 0;
        int numberOfBoxes = 0;
        int numberOfDoors = 0;
        int element = 0;
        Image imageWall = DOniciQGame.Properties.Resources.wall;
        Image imageRedDoor = DOniciQGame.Properties.Resources.redDoor;
        Image imageGreenDoor = DOniciQGame.Properties.Resources.greenDoor;
        Image imageRedBox = DOniciQGame.Properties.Resources.redBox;
        Image imageGreenBox = DOniciQGame.Properties.Resources.greenBox;

        int[,] allElements;

        public Design()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Finds the index X of the pictureBox
        /// </summary>
        private int FindIndexX(int x)
        {
            return ((x - INITIAL_X) / GAP);
        }

        /// <summary>
        /// Finds the index Y of the pictureBox
        /// </summary>
        ///
        private int FindIndexY(int y)
        {
            return ((y - INITIAL_Y) / GAP);
        }

        /// <summary>
        /// The button generates a grid with the number of columns and rows input by the user.
        /// The input only accepts integers greater than 0.
        /// Then a for loop creates the grid with pictureBox (GridsElement class) as each element.
        /// Each element of the grid is created with the same event handler element_Click.
        /// </summary>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfRows = int.Parse(txtbRows.Text);
                if(numberOfRows <= 0)
                {
                    MessageBox.Show("Please provide valid data for rows. It must be greater than 0", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    numberOfColumns = int.Parse(txtbColumns.Text);
                    if(numberOfColumns <= 0)
                    {
                        MessageBox.Show("Please provide valid data for columns. It must be greater than 0", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    for (int i = 0; i < numberOfRows; i++)
                    {
                        locationX = INITIAL_X;

                        for (int j = 0; j < numberOfColumns; j++)
                        {
                            GridsElement eachElement = new GridsElement(this);
                            eachElement.Location = new System.Drawing.Point(locationX, locationY);
                            eachElement.Size = new System.Drawing.Size(60, 60);
                            this.Controls.Add(eachElement);
                            locationX += GAP;
                            eachElement.Click += element_Click;
                        }
                        locationY += GAP;
                    }

                    // Create a 2-dimensional array
                    allElements = new int[numberOfRows, numberOfColumns];

                }
                catch(Exception)
                {
                    MessageBox.Show("Please provide valid data for columns. It must be an integer", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please provide valid data for rows. It must be an integer", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Use the index X and Y of the PictureBox to include the type of image used to the 2-dimensional array
        /// </summary>
        private void ElementOfPictureBox(int x, int y, int tile)
        {
            allElements[y,x] = tile;
        }

        /// <summary>
        /// The element_click passes through a switch case (variable element) to define which image 
        /// is going to be shown (none, wall, red door, green door, red box and green box)
        /// according to the choice of the user.
        /// Also, it counts the total of Walls, Doors and Boxes
        /// </summary>
        private void element_Click(object sender, EventArgs e)
        {
            GridsElement gridsElement = (GridsElement)sender;

            switch(element)
            {
                case NONE:
                    if(gridsElement.Image == imageWall)
                    {
                        gridsElement.Image = null;
                        numberOfWalls--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), NONE);
                    }
                    else if(gridsElement.Image == imageGreenBox ||
                        gridsElement.Image == imageRedBox)
                    {
                        gridsElement.Image = null;
                        numberOfBoxes--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), NONE);
                    }
                    else if(gridsElement.Image == imageGreenDoor ||
                        gridsElement.Image== imageRedDoor)
                    {
                        gridsElement.Image = null;
                        numberOfDoors--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), NONE);
                    }
                    break;
                case WALL:
                    if(gridsElement.Image == null)
                    {
                        gridsElement.Image = imageWall;
                        numberOfWalls++;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), WALL);
                    }                    
                    break;
                case RED_DOOR:
                    if (gridsElement.Image == null)
                    {
                        gridsElement.Image = imageRedDoor;
                        numberOfDoors++;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_DOOR);
                    }
                    else if(gridsElement.Image == imageWall)
                    {
                        gridsElement.Image = imageRedDoor;
                        numberOfDoors++;
                        numberOfWalls--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_DOOR);
                    }
                    else if(gridsElement.Image == imageGreenDoor)
                    {
                        gridsElement.Image = imageRedDoor;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_DOOR);
                    }
                    else if(gridsElement.Image == imageGreenBox)
                    {
                        gridsElement.Image = imageRedDoor;
                        numberOfDoors++;
                        numberOfBoxes--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_DOOR);
                    }
                    else if(gridsElement.Image == imageRedBox)
                    {
                        gridsElement.Image = imageRedDoor;
                        numberOfDoors++;
                        numberOfBoxes--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_DOOR);
                    }
                    break;
                case GREEN_DOOR:
                    if (gridsElement.Image == null)
                    {
                        gridsElement.Image = imageGreenDoor;
                        numberOfDoors++;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_DOOR);
                    }
                    else if(gridsElement.Image == imageWall)
                    {
                        gridsElement.Image= imageGreenDoor;
                        numberOfWalls--;
                        numberOfDoors++;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_DOOR);
                    }
                    else if(gridsElement.Image == imageRedDoor)
                    {
                        gridsElement.Image = imageGreenDoor;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_DOOR);
                    }
                    else if(gridsElement.Image == imageRedBox)
                    {
                        gridsElement.Image = imageGreenDoor;
                        numberOfDoors++;
                        numberOfBoxes--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_DOOR);
                    }
                    else if(gridsElement.Image == imageGreenBox)
                    {
                        gridsElement.Image = imageGreenDoor;
                        numberOfDoors++;
                        numberOfBoxes--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_DOOR);
                    }
                    break;
                case RED_BOX:
                    if(gridsElement.Image == null)
                    {
                        gridsElement.Image = imageRedBox;
                        numberOfBoxes++;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_BOX);
                    }
                    else if(gridsElement.Image == imageGreenBox)
                    {
                        gridsElement.Image = imageRedBox;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_BOX);
                    }
                    else if(gridsElement.Image == imageGreenDoor)
                    {
                        gridsElement.Image = imageRedBox;
                        numberOfDoors--;
                        numberOfBoxes++;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_BOX);
                    }
                    else if(gridsElement.Image == imageRedDoor)
                    {
                        gridsElement.Image = imageRedBox;
                        numberOfDoors--;
                        numberOfBoxes++;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), RED_BOX);
                    }
                    break;
                case GREEN_BOX:
                    if(gridsElement.Image == null)
                    {
                        gridsElement.Image = imageGreenBox;
                        numberOfBoxes++;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_BOX);
                    }
                    else if(gridsElement.Image == imageRedBox)
                    {
                        gridsElement.Image = imageGreenBox;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_BOX);
                    }
                    else if(gridsElement.Image == imageRedDoor)
                    {
                        gridsElement.Image = imageGreenBox;
                        numberOfBoxes++;
                        numberOfDoors--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_BOX);
                    }
                    else if(gridsElement.Image == imageGreenDoor)
                    {
                        gridsElement.Image = imageGreenBox;
                        numberOfBoxes++;
                        numberOfDoors--;
                        ElementOfPictureBox(FindIndexX(gridsElement.Bounds.Location.X),
                            FindIndexY(gridsElement.Bounds.Location.Y), GREEN_BOX);
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Creates a IO writer to write in a file the number of rows, columns and each element (index and image)
        /// </summary>
        private void save(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine($"{numberOfRows}\n{numberOfColumns}");

            for(int i = 0; i < numberOfRows; i++)
            {
                for(int j = 0; j < numberOfColumns; j++)
                {
                    if(allElements[i, j] == 0)
                    {
                        allElements[i, j] = 6;
                    }
                    writer.WriteLine($"{i}\n{j}\n{allElements[i, j]}");
                }
            }
            writer.Close();
        }

        /// <summary>
        /// Open the 'dialog save' and save the document when no issue is found.
        /// A succesfull message is shown at the end.
        /// </summary>
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            dlgSave.Filter = "Text file|*.txt|All files|*.*";
            DialogResult result = dlgSave.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string fileName = dlgSave.FileName;
                        save(fileName);
                        MessageBox.Show($"File saved!\nNumber of walls: {numberOfWalls}\nNumber of doors: {numberOfDoors}\nNumber of boxes: {numberOfBoxes}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error in saving file:  + {ex.Message}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// Defines the variable element as a wall
        /// </summary>
        private void btnWall_Click(object sender, EventArgs e)
        {
            element = WALL;
        }

        /// <summary>
        /// Defines the variable element as a red door
        /// </summary>
        private void btnRedDoor_Click(object sender, EventArgs e)
        {
            element = RED_DOOR;
        }

        /// <summary>
        /// Defines the variable element as a green door
        /// </summary>
        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            element = GREEN_DOOR;
        }

        /// <summary>
        /// Defines the variable element as a red box
        /// </summary>
        private void btnRedBox_Click(object sender, EventArgs e)
        {
            element = RED_BOX;
        }

        /// <summary>
        /// Defines the variable element as a green box
        /// </summary>
        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            element = GREEN_BOX;
        }

        /// <summary>
        /// Defines the variable element as none
        /// </summary>
        private void btnNone_Click(object sender, EventArgs e)
        {
            element = NONE;
        }

    }
}
