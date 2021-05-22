using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void solveSudokuButton_Click(object sender, EventArgs e) {
            try {
                Control table = null;
                int[,] sudoku = new int[9, 9];

                foreach (Control c in Controls) {
                    // Find the table layout which contains the textboxes
                    if (c.Name == "tableLayoutPanel1") {
                        table = c;
                    }
                }

                string currBox = "textBox";
                int boxNum = 1;

                // Extracts value from each text box and transform into sudoku
                for (int i = 0; i < 9; i++) {
                    boxNum++;
                    for (int j = 0; j < 9; j++) {
                        string currSearch = currBox + Convert.ToString(boxNum);
                        Control tb = Helper.GetTextBox(table, currSearch);
                        int tbVal = 0;

                        if (!(tb.Text == "" || tb.Text == "0")) {
                            tbVal = Convert.ToInt32(tb.Text);
                        }

                        sudoku[i, j] = tbVal;
                        if (j != 8) {
                            boxNum++;
                        }
                    }
                }

                // Solving the sudoku
                Solver s = new Solver(sudoku);
                s.Solve();

                // Displaying the sudoku
                boxNum = 0;

                for (int i = 0; i < 9; i++) {
                    boxNum++;
                    for (int j = 0; j < 9; j++) {
                        string currSearch = currBox + Convert.ToString(boxNum);
                        Control tb = Helper.GetTextBox(table, currSearch);
                        tb.Text = s.Grid[i, j].ToString();
                        
                        if (j != 8) {
                            boxNum++;
                        }
                    }
                }

            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e) {
            Control table = null;

            foreach (Control c in Controls) {
                // Find the table layout which contains the textboxes
                if (c.Name == "tableLayoutPanel1") {
                    table = c;
                }
            }

            foreach (Control c in table.Controls) {
                if (c is TextBox) {
                    c.Text = String.Empty;
                }
            }
        }
    }


}
