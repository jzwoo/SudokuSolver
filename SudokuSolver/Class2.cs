using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver {

    // Class that parses an input into a sudoku
    static class Helper {
       public static Control GetTextBox (Control control, string name) {
            try {
                foreach (Control c in control.Controls) {
                    if (c.Name == name) {
                        return c;
                    }
                }
            } catch (Exception e) {
                throw e;
            }

            // returns the given control if there is no match
            return control;
       }

    }
}
