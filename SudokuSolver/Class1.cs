using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    class Solver {

        private int[,] grid;

        public Solver(int[,] g) {
            Grid = g;
        }

        public int[,] Grid {
            get { return grid; }
            set { grid = value; }
        }

        public void test() {
            this.grid[0, 0] = -10;
        }

        public bool Solve() {

            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    if (this.grid[i, j] == 0) {
                        for (int k = 1; k < 10; k++) {
                            if (PossibleNum(i, j, k)) {
                                this.grid[i, j] = k;
                                if (this.Solve()) {
                                    return true;
                                } else {
                                    this.grid[i, j] = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        // Checks if it is possible to put num in a cell (x,y) of grid
        private bool PossibleNum(int r, int c, int num) {
            // Check for row 
            for (int i = 0; i < 9; i++) {
                if (grid[r, i] == num) {
                    return false;
                }
            }

            // Check for column 
            for (int i = 0; i < 9; i++) {
                if (grid[i, c] == num) {
                    return false;
                }
            }

            int boxPos = -1;

            // Determine the position of the box to check
            // [1, 2, 3]
            // [4, 5, 6]
            // [7, 8, 9]
            if (WithinRange(0, 2, r) && WithinRange(0, 2, c)) {
                boxPos = 1;
            } else if (WithinRange(0, 2, r) && WithinRange(3, 5, c)) {
                boxPos = 2;
            } else if (WithinRange(0, 2, r) && WithinRange(6, 8, c)) {
                boxPos = 3;
            } else if (WithinRange(3, 5, r) && WithinRange(0, 2, c)) {
                boxPos = 4;
            } else if (WithinRange(3, 5, r) && WithinRange(3, 5, c)) {
                boxPos = 5;
            } else if (WithinRange(3, 5, r) && WithinRange(6, 8, c)) {
                boxPos = 6;
            } else if (WithinRange(6, 8, r) && WithinRange(0, 2, c)) {
                boxPos = 7;
            } else if (WithinRange(6, 8, r) && WithinRange(3, 5, c)) {
                boxPos = 8;
            } else if (WithinRange(6, 8, r) && WithinRange(6, 8, c)) {
                boxPos = 9;
            }

            return this.CheckBox(boxPos, num);
        } 

        // Helper function that checks if lowLimit <= num <= highLimit 
        private static bool WithinRange(int lowLimit, int highLimit, int num) {
            if (num >= lowLimit && num <= highLimit) {
                return true;
            } else {
                return false;
            }
        }

        // Helper function that checks if num can be put into boxPos of grid
        private bool CheckBox(int boxPos, int num) {
            int startRow = -1;
            int startCol = -1;
            bool result = true;

            switch (boxPos) {
                case 1:
                    startRow = 0;
                    startCol = 0;
                    break;
                case 2:
                    startRow = 0;
                    startCol = 3;
                    break;
                case 3:
                    startRow = 0;
                    startCol = 6;
                    break;
                case 4:
                    startRow = 3;
                    startCol = 0;
                    break;
                case 5:
                    startRow = 3;
                    startCol = 3;
                    break;
                case 6:
                    startRow = 3;
                    startCol = 6;
                    break;
                case 7:
                    startRow = 6;
                    startCol = 0;
                    break;
                case 8:
                    startRow = 6;
                    startCol = 3;
                    break;
                case 9:
                    startRow = 6;
                    startCol = 6;
                    break;
            }

            for (int i = startRow; i < (startRow + 3); i++) {
                for (int j = startCol; j < (startCol + 3); j++) {
                    if (this.grid[i, j] == num) {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        public override string ToString() {
            string result = "";
            for (int i = 0; i < 9; i++) {
                result += "{ ";
                for (int j = 0; j < 9; j++) {
                    result += this.grid[i, j].ToString() + ", ";

                    if (j == 8) {
                        result += "}, " + "\n";
                    }

                }
            }
            return result;
        }
    }
}
