/*  Game class
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DOniciQGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        // Global variables and constants
        const int INITIAL_X = 136;
        const int INITIAL_Y = 123;
        const int GAP = 65;
        const int NUMBER_OF_ATTRIBUTES_PER_ELEMENT = 3;
        const int WALL = 1;
        const int RED_DOOR = 2;
        const int GREEN_DOOR = 3;
        const int RED_BOX = 4;
        const int GREEN_BOX = 5;
        const int NONE = 6;
        const int HEIGHT = 60;
        const int WIDTH = 60;
        const int ARRAY_LENGTH_DEFINER = 1;
        int locationX = INITIAL_X;
        int locationY = INITIAL_Y;
        int pointer = 0;
        int indicate = 0;
        int numberOfRows = 0;
        int numberOfColumns = 0;
        int row = 0;
        int col = 0;
        int numberOfMoves = 0;
        bool clicked = false;
        Image imageWall = DOniciQGame.Properties.Resources.wall;
        Image imageRedDoor = DOniciQGame.Properties.Resources.redDoor;
        Image imageGreenDoor = DOniciQGame.Properties.Resources.greenDoor;
        Image imageRedBox = DOniciQGame.Properties.Resources.redBox;
        Image imageGreenBox = DOniciQGame.Properties.Resources.greenBox;

        int[,] tileTypes;
        Tile[,] allTiles;

        Tile tile;

        /// <summary>
        /// Clear all the tiles from the panel to load a new game and zero all variables used in the logic
        /// </summary>
        private void init()
        {
            panel.Controls.Clear();
            txtbNumberMoves.Text = "0";
            txtbRemainingBoxes.Text = "0";
            locationX = INITIAL_X;
            locationY = INITIAL_Y;
            pointer = 0;
            indicate = 0;
            numberOfRows = 0;
            numberOfColumns = 0;
            row = 0;
            col = 0;
            numberOfMoves = 0;
            clicked = false;
            btnDown.Enabled = false;
            btnUp.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
        }

        /// <summary>
        /// Load the file and recognize the number of rows and columns.
        /// Create a 2-dimensional array to store the tile type integer.
        /// Then this 2-dimensional array is used to create the grid with the correct tile from the file.
        /// </summary>
        /// <param name="fileName">file path</param>
        private void load(string fileName)
        {
            init();

            try
            {
                StreamReader reader = new StreamReader(fileName);

                try
                {
                    numberOfRows = int.Parse(reader.ReadLine());

                    if(numberOfRows <= 0)
                    {
                        throw new Exception("The number of rows must be greater than 0.");
                    }

                    try
                    {
                        numberOfColumns = int.Parse(reader.ReadLine());

                        if(numberOfColumns <= 0)
                        {
                            throw new Exception("The number of columns must be greater than 0.");
                        }

                        // create 2-dimensional arrays. The first one stores the tile types and the second one the tiles created
                        tileTypes = new int[numberOfRows, numberOfColumns];
                        allTiles = new Tile[numberOfRows, numberOfColumns];

                        for (int i = 0; i < numberOfRows; i++)
                        {
                            for (int j = 0; j < numberOfColumns * NUMBER_OF_ATTRIBUTES_PER_ELEMENT; j++)
                            {
                                int types = int.Parse(reader.ReadLine());

                                // The pointer is used to count the lines read
                                pointer++;

                                // when the third line is counted, it means it is the tile type
                                if (pointer == NUMBER_OF_ATTRIBUTES_PER_ELEMENT)
                                {
                                    pointer = 0;
                                    tileTypes[i, j / NUMBER_OF_ATTRIBUTES_PER_ELEMENT] = types;
                                }
                            }
                        }


                        // Each tile will be created according to the image specified by the integer 
                        // Then it will be added to the Game only allowing the boxes to be clicked.
                        // All the tiles are added to a new 2-dimensional array
                        for (int i = 0; i < numberOfRows; i++)
                        {
                            locationX = INITIAL_X;

                            for (int j = 0; j < numberOfColumns; j++)
                            {
                                Tile tl = new Tile(this);

                                if (tileTypes[i, j] == WALL)
                                {
                                    tl.tileType = WALL;
                                    tl.Location = new System.Drawing.Point(locationX, locationY);
                                    tl.Size = new System.Drawing.Size(60, 60);
                                    tl.Image = imageWall;
                                    panel.Controls.Add(tl);
                                    allTiles[i, j] = tl;
                                    tl.BringToFront();
                                    locationX += GAP;
                                }
                                else if (tileTypes[i, j] == RED_DOOR)
                                {
                                    tl.tileType = RED_DOOR;
                                    tl.Location = new System.Drawing.Point(locationX, locationY);
                                    tl.Size = new System.Drawing.Size(60, 60);
                                    tl.Image = imageRedDoor;
                                    panel.Controls.Add(tl);
                                    allTiles[i, j] = tl;
                                    tl.BringToFront();
                                    locationX += GAP;
                                }
                                else if (tileTypes[i, j] == RED_BOX)
                                {
                                    tl.tileType = RED_BOX;
                                    tl.Location = new System.Drawing.Point(locationX, locationY);
                                    tl.Size = new System.Drawing.Size(60, 60);
                                    tl.Image = imageRedBox;
                                    panel.Controls.Add(tl);
                                    allTiles[i, j] = tl;
                                    tl.BringToFront();
                                    locationX += GAP;
                                    tl.Click += tile_Click;
                                }
                                else if (tileTypes[i, j] == GREEN_DOOR)
                                {
                                    tl.tileType = GREEN_DOOR;
                                    tl.Location = new System.Drawing.Point(locationX, locationY);
                                    tl.Size = new System.Drawing.Size(60, 60);
                                    tl.Image = imageGreenDoor;
                                    panel.Controls.Add(tl);
                                    allTiles[i, j] = tl;
                                    tl.BringToFront();
                                    locationX += GAP;
                                }
                                else if (tileTypes[i, j] == GREEN_BOX)
                                {
                                    tl.tileType = GREEN_BOX;
                                    tl.Location = new System.Drawing.Point(locationX, locationY);
                                    tl.Size = new System.Drawing.Size(60, 60);
                                    tl.Image = imageGreenBox;
                                    panel.Controls.Add(tl);
                                    allTiles[i, j] = tl;
                                    tl.BringToFront();
                                    locationX += GAP;
                                    tl.Click += tile_Click;
                                }
                                else if (tileTypes[i, j] == NONE)
                                {
                                    tl.tileType = NONE;
                                    tl.Location = new System.Drawing.Point(locationX, locationY);
                                    tl.Size = new System.Drawing.Size(60, 60);
                                    this.Controls.Add(tl);
                                    allTiles[i, j] = tl;
                                    locationX += GAP;
                                }
                            }
                            locationY += GAP;
                        }

                        // Include the number of boxes to the textbox 
                        getNumberOfBoxes();

                        // Enabling the direction buttons
                        btnDown.Enabled = true;
                        btnUp.Enabled = true;
                        btnLeft.Enabled = true;
                        btnRight.Enabled = true;
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("The column is invalid. It must be a number.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("The row is invalid. It must be a number.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error loading the file: {ex}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Count the number of boxes in the game. When zero, the user wins the game, a message is shown.
        /// </summary>
        private void getNumberOfBoxes()
        {
            int totalOfBoxes = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (allTiles[i,j].tileType == GREEN_BOX)
                    {
                        totalOfBoxes++;
                    }
                    if(allTiles[i, j].tileType == RED_BOX)
                    {
                        totalOfBoxes++;
                    }
                }
            }
            txtbRemainingBoxes.Text = totalOfBoxes.ToString();

            if(totalOfBoxes == 0)
            {
                MessageBox.Show("Congratulations! You won!");
                init();
            }
        }


        /// <summary>
        /// Return the tile located in the row and column added as parameters.
        /// If the row and col are outside of the array's boundaries the method return null.
        /// </summary>
        /// <param name="row">number of the row</param>
        /// <param name="col">number of the column</param>
        /// <returns>the tile located in the row and column</returns>
        private Tile getTile(int row, int col)
        {
            if(row < 0 || col < 0)
            {
                return null;
            }
            else if(row > allTiles.GetLength(0) - ARRAY_LENGTH_DEFINER || 
                col > allTiles.GetLength(1) - ARRAY_LENGTH_DEFINER)
            {
                return null;
            }
            else
            {
                return allTiles[row, col];
            }

        }


        /// <summary>
        /// When the tile box is clicked, the column and row of its position is stored in its variables
        /// </summary>
        private void tile_Click(object sender, EventArgs e)
        {
            clicked = true;
            tile = (Tile)sender;
            tile.BorderStyle = BorderStyle.Fixed3D;
            col = (tile.Left - INITIAL_X) / WIDTH;
            row = (tile.Top - INITIAL_Y) / HEIGHT;
        }

        /// <summary>
        /// The load game option from the menu opens the dialog box to select the game to be loaded.
        /// When the file is selected, it calls the load function.
        /// </summary>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpen.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string filename = dlgOpen.FileName;
                        load(filename);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// The Load Game has the direction buttons disabled until the game is loaded
        /// </summary>
        private void Game_Load(object sender, EventArgs e)
        {
            btnDown.Enabled = false;
            btnUp.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
        }

        /// <summary>
        /// Verifiy if the box was selected first, then checks if the next tile is tileTyle None.
        /// If it is, the tile goes up until a wall, a null or box is on the way, then counts one move.
        /// Update the tiles in the 2-dimensional array and add a move to the variable.
        /// If the box and the door match colors, the box disappear and the remaining number of boxes is updated as well as the number of moves.
        /// </summary>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if(clicked == false)
            {
                MessageBox.Show("Please, select a box", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                while (true)
                {
                    Tile nextTile = getTile(row - 1, col);

                    if (nextTile == null)
                    {
                        allTiles[row, col] = tile;

                        if (indicate > 0)
                        {
                            numberOfMoves++;
                            txtbNumberMoves.Text = numberOfMoves.ToString();
                            indicate = 0;
                            MessageBox.Show("Level without limit. Please, consider adding boundaries to your level.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }

                        MessageBox.Show("Level without limit. Please, consider adding boundaries to your level.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else if (nextTile.tileType == NONE)
                    {
                        allTiles[row, col] = nextTile;
                        tile.Top -= GAP;
                        row--;
                        allTiles[row, col] = tile;
                        indicate++;
                    }
                    else if (tile.tileType == RED_BOX && nextTile.tileType == RED_DOOR)
                    {
                        allTiles[row, col].tileType = NONE;
                        tile.Top -= GAP;
                        tile.SendToBack();
                        row--;
                        allTiles[row, col].tileType = RED_DOOR;
                        this.Controls.Remove(tile);
                        numberOfMoves++;
                        txtbNumberMoves.Text = numberOfMoves.ToString();
                        getNumberOfBoxes();
                        break;
                    }
                    else if (tile.tileType == GREEN_BOX && nextTile.tileType == GREEN_DOOR)
                    {
                        allTiles[row, col].tileType = NONE;
                        tile.Top -= GAP;
                        tile.SendToBack();
                        row--;
                        allTiles[row, col].tileType = GREEN_DOOR;
                        numberOfMoves++;
                        this.Controls.Remove(tile);
                        txtbNumberMoves.Text = numberOfMoves.ToString();
                        getNumberOfBoxes();
                        break;
                    }
                    else if(nextTile.tileType == GREEN_BOX || nextTile.tileType == RED_BOX ||
                        nextTile.tileType == WALL || tile.tileType == RED_BOX && nextTile.tileType == GREEN_DOOR ||
                        tile.tileType == GREEN_BOX && nextTile.tileType == RED_DOOR)
                    {
                        if(indicate > 0)
                        {
                            numberOfMoves++;
                            txtbNumberMoves.Text = numberOfMoves.ToString();
                            indicate = 0;
                            break;
                        }
                        break;
                    }
                }
            }
        }


        /// <summary>
        /// Verifiy if the box was selected first, then checks if the next tile is tileTyle None.
        /// If it is, the tile goes up until a wall, a null or box is on the way, then counts one move.
        /// Update the tiles in the 2-dimensional array and add a move to the variable.
        /// If the box and the door match colors, the box disappear and the remaining number of boxes is updated as well as the number of moves.
        /// </summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if(clicked == false)
            {
                MessageBox.Show("Please, select a box", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                while(true)
                {
                    Tile nextTile = getTile(row + 1, col);

                    if(nextTile == null)
                    {
                        allTiles[row, col] = tile;

                        if (indicate > 0)
                        {
                            numberOfMoves++;
                            txtbNumberMoves.Text = numberOfMoves.ToString();
                            indicate = 0;
                            MessageBox.Show("Level without limit. Please, consider adding boundaries to your level.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        MessageBox.Show("Level without limit. Please, consider adding boundaries to your level.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else if (nextTile.tileType == NONE)
                    {
                        allTiles[row, col] = nextTile;
                        tile.Top += GAP;
                        row++;
                        allTiles[row, col] = tile;
                        indicate++;
                    }
                    else if (tile.tileType == RED_BOX && nextTile.tileType == RED_DOOR)
                    {
                        allTiles[row, col].tileType = NONE;
                        tile.Top += GAP;
                        tile.SendToBack();
                        row++;
                        allTiles[row, col].tileType = RED_DOOR;
                        this.Controls.Remove(tile);
                        numberOfMoves++;
                        txtbNumberMoves.Text = numberOfMoves.ToString();
                        getNumberOfBoxes();
                        break;
                    }
                    else if (tile.tileType == GREEN_BOX && nextTile.tileType == GREEN_DOOR)
                    {
                        allTiles[row, col].tileType = NONE;
                        tile.Top += GAP;
                        tile.SendToBack();
                        row++;
                        allTiles[row, col].tileType = GREEN_DOOR;
                        this.Controls.Remove(tile);
                        numberOfMoves++;
                        txtbNumberMoves.Text = numberOfMoves.ToString();
                        getNumberOfBoxes();
                        break;
                    }
                    else if (nextTile.tileType == GREEN_BOX || nextTile.tileType == RED_BOX ||
                        nextTile.tileType == WALL || tile.tileType == RED_BOX && nextTile.tileType == GREEN_DOOR ||
                        tile.tileType == GREEN_BOX && nextTile.tileType == RED_DOOR)
                    {
                        if (indicate > 0)
                        {
                            numberOfMoves++;
                            txtbNumberMoves.Text = numberOfMoves.ToString();
                            indicate = 0;
                            break;
                        }
                        break;
                    }
                }
            }

        }


        /// <summary>
        /// Verifiy if the box was selected first, then checks if the next tile is tileTyle None.
        /// If it is, the tile goes up until a wall, a null or box is on the way, then counts one move.
        /// Update the tiles in the 2-dimensional array and add a move to the variable.
        /// If the box and the door match colors, the box disappear and the remaining number of boxes is updated as well as the number of moves.
        /// </summary>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                MessageBox.Show("Please, select a box", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                while(true)
                {
                    Tile nextTile = getTile(row, col - 1);

                    if (nextTile == null)
                    {
                        allTiles[row, col] = tile;

                        if (indicate > 0)
                        {
                            numberOfMoves++;
                            txtbNumberMoves.Text = numberOfMoves.ToString();
                            indicate = 0;
                            MessageBox.Show("Level without limit. Please, consider adding boundaries to your level.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        MessageBox.Show("Level without limit. Please, consider adding boundaries to your level.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else if (nextTile.tileType == NONE)
                    {
                        allTiles[row, col] = nextTile;
                        tile.Left -= GAP;
                        col--;
                        allTiles[row, col] = tile;
                        indicate++;
                    }
                    else if (tile.tileType == RED_BOX && nextTile.tileType == RED_DOOR)
                    {
                        allTiles[row, col].tileType = NONE;
                        tile.Left -= GAP;
                        tile.SendToBack();
                        col--;
                        allTiles[row, col].tileType = RED_DOOR;
                        this.Controls.Remove(tile);
                        numberOfMoves++;
                        txtbNumberMoves.Text = numberOfMoves.ToString();
                        getNumberOfBoxes();
                        break;
                    }
                    else if (tile.tileType == GREEN_BOX && nextTile.tileType == GREEN_DOOR)
                    {
                        allTiles[row, col].tileType = NONE;
                        tile.Left -= GAP;
                        tile.SendToBack();
                        col--;
                        allTiles[row, col].tileType = GREEN_DOOR;
                        this.Controls.Remove(tile);
                        numberOfMoves++;
                        txtbNumberMoves.Text = numberOfMoves.ToString();
                        getNumberOfBoxes();
                        break;
                    }
                    else if (nextTile.tileType == GREEN_BOX || nextTile.tileType == RED_BOX ||
                        nextTile.tileType == WALL || tile.tileType == RED_BOX && nextTile.tileType == GREEN_DOOR ||
                        tile.tileType == GREEN_BOX && nextTile.tileType == RED_DOOR)
                    {
                        if (indicate > 0)
                        {
                            numberOfMoves++;
                            txtbNumberMoves.Text = numberOfMoves.ToString();
                            indicate = 0;
                            break;
                        }
                        break;
                    }
                }
            }

        }


        /// <summary>
        /// Verifiy if the box was selected first, then checks if the next tile is tileTyle None.
        /// If it is, the tile goes up until a wall, a null or box is on the way, then counts one move.
        /// Update the tiles in the 2-dimensional array and add a move to the variable.
        /// If the box and the door match colors, the box disappear and the remaining number of boxes is updated as well as the number of moves.
        /// </summary>
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                MessageBox.Show("Please, select a box", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                while(true)
                {
                    Tile nextTile = getTile(row, col + 1);

                    if (nextTile == null)
                    {
                        allTiles[row, col] = tile;

                        if (indicate > 0)
                        {
                            numberOfMoves++;
                            txtbNumberMoves.Text = numberOfMoves.ToString();
                            indicate = 0;
                            MessageBox.Show("Level without limit. Please, consider adding boundaries to your level.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        MessageBox.Show("Level without limit. Please, consider adding boundaries to your level.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else if (nextTile.tileType == NONE)
                    {
                        allTiles[row, col] = nextTile;
                        tile.Left += GAP;
                        col++;
                        allTiles[row, col] = tile;
                        indicate++;
                    }
                    else if (tile.tileType == RED_BOX && nextTile.tileType == RED_DOOR)
                    {
                        allTiles[row, col].tileType = NONE;
                        tile.Left += GAP;
                        tile.SendToBack();
                        col++;
                        allTiles[row, col].tileType = RED_DOOR;
                        this.Controls.Remove(tile);
                        numberOfMoves++;
                        txtbNumberMoves.Text = numberOfMoves.ToString();
                        getNumberOfBoxes();
                        break;
                    }
                    else if (tile.tileType == GREEN_BOX && nextTile.tileType == GREEN_DOOR)
                    {
                        allTiles[row, col].tileType = NONE;
                        tile.Left += GAP;
                        tile.SendToBack();
                        col++;
                        allTiles[row, col].tileType = GREEN_DOOR;
                        this.Controls.Remove(tile);
                        numberOfMoves++;
                        txtbNumberMoves.Text = numberOfMoves.ToString();
                        getNumberOfBoxes();
                        break;
                    }
                    else if (nextTile.tileType == GREEN_BOX || nextTile.tileType == RED_BOX ||
                        nextTile.tileType == WALL || tile.tileType == RED_BOX && nextTile.tileType == GREEN_DOOR ||
                        tile.tileType == GREEN_BOX && nextTile.tileType == RED_DOOR)
                    {
                        if (indicate > 0)
                        {
                            numberOfMoves++;
                            txtbNumberMoves.Text = numberOfMoves.ToString();
                            indicate = 0;
                            break;
                        }
                        break;
                    }
                }
            }

        }
    }
}
