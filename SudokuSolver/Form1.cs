using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Input;

namespace SudokuSolver {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e) {
            int[,] sudoku = { { 0, 0, 0, 2, 6, 0, 7, 0, 1 },
         { 6, 8, 0, 0, 7, 0, 0, 9, 0 },
         { 1, 9, 0, 0, 0, 4, 5, 0, 0 },
         { 8, 2, 0, 1, 0, 0, 0, 4, 0 },
         { 0, 0, 4, 6, 0, 2, 9, 0, 0 },
         { 0, 5, 0, 0, 0, 3, 0, 2, 8 },
         { 0, 0, 9, 3, 0, 0, 0, 7, 4 },
         { 0, 4, 0, 0, 5, 0, 0, 3, 6 },
         { 7, 0, 3, 0, 1, 8, 0, 0, 0 } };

            Solver s = new Solver(sudoku);
            s.Solve();
            Console.WriteLine(s.ToString());
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
                int boxNum = 0;

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
                Console.WriteLine(s.ToString());


                Task t = Task.Run(() => { s.Solve(); });
                TimeSpan ts = TimeSpan.FromMilliseconds(500);
                if (!t.Wait(ts)) {
                    throw new Exception("Timeout, something is wrong with the sudoku!");
                }

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

        private void textBoxFocus_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            Control table = null;

            foreach (Control c in Controls) {
                // Find the table layout which contains the textboxes
                if (c.Name == "tableLayoutPanel1") {
                    table = c;
                }
            }

            // Currently active control
            string currActive = this.ActiveControl.Name;
            string header = "textBox";
            int boxNum = Convert.ToInt32(currActive.Substring(7, currActive.Length - 7));
            string nextBoxNum = String.Empty;

            if (e.KeyData == Keys.Right || e.KeyData == Keys.Enter) {
                if (boxNum != 81) {
                    nextBoxNum = (boxNum + 1).ToString();
                } else {
                    nextBoxNum = "1";
                }
            } else if (e.KeyData == Keys.Left) {
                if (boxNum != 1) {
                    nextBoxNum = (boxNum - 1).ToString();
                } else {
                    nextBoxNum = "81";
                }
            } else {
                nextBoxNum = boxNum.ToString();
            }

            Control tb = Helper.GetTextBox(table, header + nextBoxNum);
            Console.WriteLine(tb.Name);
            tb.Focus();
        }
    }

}
