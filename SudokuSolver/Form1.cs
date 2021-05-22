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
         
            Solver s = new Solver(sudoku);
            s.Solve();

        }
    }


}
