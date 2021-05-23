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
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.solveSudokuButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // solveSudokuButton
            // 
            this.solveSudokuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.solveSudokuButton.Location = new System.Drawing.Point(405, 573);
            this.solveSudokuButton.Name = "solveSudokuButton";
            this.solveSudokuButton.Size = new System.Drawing.Size(100, 30);
            this.solveSudokuButton.TabIndex = 0;
            this.solveSudokuButton.Text = "Solve";
            this.solveSudokuButton.UseVisualStyleBackColor = true;
            this.solveSudokuButton.Click += new System.EventHandler(this.solveSudokuButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.textBox81, 8, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox80, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox79, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox78, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox77, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox76, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox75, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox74, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox73, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox72, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox71, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox70, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox69, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox68, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox67, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox66, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox65, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox64, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox63, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox62, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox61, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox60, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox59, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox58, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox57, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox56, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox55, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox54, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox53, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox52, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox51, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox50, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox49, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox48, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox47, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox46, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox45, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox44, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox43, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox42, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox41, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox40, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox39, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox38, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox37, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox36, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox35, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox34, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox33, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox32, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox31, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox30, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox29, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox28, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox27, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox26, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox25, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox24, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox23, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox22, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox21, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox20, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox19, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox18, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox17, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox16, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox15, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox14, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 483);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox81
            // 
            this.textBox81.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox81.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox81.Location = new System.Drawing.Point(436, 428);
            this.textBox81.MaxLength = 1;
            this.textBox81.Multiline = true;
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(55, 51);
            this.textBox81.TabIndex = 80;
            this.textBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox81.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox80
            // 
            this.textBox80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox80.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox80.Location = new System.Drawing.Point(382, 428);
            this.textBox80.MaxLength = 1;
            this.textBox80.Multiline = true;
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(47, 51);
            this.textBox80.TabIndex = 79;
            this.textBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox80.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox79
            // 
            this.textBox79.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox79.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox79.Location = new System.Drawing.Point(328, 428);
            this.textBox79.MaxLength = 1;
            this.textBox79.Multiline = true;
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(47, 51);
            this.textBox79.TabIndex = 78;
            this.textBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox79.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox78
            // 
            this.textBox78.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox78.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox78.Location = new System.Drawing.Point(274, 428);
            this.textBox78.MaxLength = 1;
            this.textBox78.Multiline = true;
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(47, 51);
            this.textBox78.TabIndex = 77;
            this.textBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox78.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox77
            // 
            this.textBox77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox77.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox77.Location = new System.Drawing.Point(220, 428);
            this.textBox77.MaxLength = 1;
            this.textBox77.Multiline = true;
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(47, 51);
            this.textBox77.TabIndex = 76;
            this.textBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox77.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox76
            // 
            this.textBox76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox76.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox76.Location = new System.Drawing.Point(166, 428);
            this.textBox76.MaxLength = 1;
            this.textBox76.Multiline = true;
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(47, 51);
            this.textBox76.TabIndex = 75;
            this.textBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox76.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox75
            // 
            this.textBox75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox75.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox75.Location = new System.Drawing.Point(112, 428);
            this.textBox75.MaxLength = 1;
            this.textBox75.Multiline = true;
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(47, 51);
            this.textBox75.TabIndex = 74;
            this.textBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox75.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox74
            // 
            this.textBox74.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox74.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox74.Location = new System.Drawing.Point(58, 428);
            this.textBox74.MaxLength = 1;
            this.textBox74.Multiline = true;
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(47, 51);
            this.textBox74.TabIndex = 73;
            this.textBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox74.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox73
            // 
            this.textBox73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox73.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox73.Location = new System.Drawing.Point(4, 428);
            this.textBox73.MaxLength = 1;
            this.textBox73.Multiline = true;
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(47, 51);
            this.textBox73.TabIndex = 72;
            this.textBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox73.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox72
            // 
            this.textBox72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox72.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox72.Location = new System.Drawing.Point(436, 375);
            this.textBox72.MaxLength = 1;
            this.textBox72.Multiline = true;
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(55, 46);
            this.textBox72.TabIndex = 71;
            this.textBox72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox72.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox71
            // 
            this.textBox71.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox71.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox71.Location = new System.Drawing.Point(382, 375);
            this.textBox71.MaxLength = 1;
            this.textBox71.Multiline = true;
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(47, 46);
            this.textBox71.TabIndex = 70;
            this.textBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox71.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox70
            // 
            this.textBox70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox70.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox70.Location = new System.Drawing.Point(328, 375);
            this.textBox70.MaxLength = 1;
            this.textBox70.Multiline = true;
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(47, 46);
            this.textBox70.TabIndex = 69;
            this.textBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox70.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox69
            // 
            this.textBox69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox69.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox69.Location = new System.Drawing.Point(274, 375);
            this.textBox69.MaxLength = 1;
            this.textBox69.Multiline = true;
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(47, 46);
            this.textBox69.TabIndex = 68;
            this.textBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox69.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox68
            // 
            this.textBox68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox68.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox68.Location = new System.Drawing.Point(220, 375);
            this.textBox68.MaxLength = 1;
            this.textBox68.Multiline = true;
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(47, 46);
            this.textBox68.TabIndex = 67;
            this.textBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox68.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox67
            // 
            this.textBox67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox67.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox67.Location = new System.Drawing.Point(166, 375);
            this.textBox67.MaxLength = 1;
            this.textBox67.Multiline = true;
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(47, 46);
            this.textBox67.TabIndex = 66;
            this.textBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox67.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox66
            // 
            this.textBox66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox66.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox66.Location = new System.Drawing.Point(112, 375);
            this.textBox66.MaxLength = 1;
            this.textBox66.Multiline = true;
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(47, 46);
            this.textBox66.TabIndex = 65;
            this.textBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox66.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox65
            // 
            this.textBox65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox65.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox65.Location = new System.Drawing.Point(58, 375);
            this.textBox65.MaxLength = 1;
            this.textBox65.Multiline = true;
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(47, 46);
            this.textBox65.TabIndex = 64;
            this.textBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox65.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox64
            // 
            this.textBox64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox64.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox64.Location = new System.Drawing.Point(4, 375);
            this.textBox64.MaxLength = 1;
            this.textBox64.Multiline = true;
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(47, 46);
            this.textBox64.TabIndex = 63;
            this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox64.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox63
            // 
            this.textBox63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox63.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox63.Location = new System.Drawing.Point(436, 322);
            this.textBox63.MaxLength = 1;
            this.textBox63.Multiline = true;
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(55, 46);
            this.textBox63.TabIndex = 62;
            this.textBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox63.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox62
            // 
            this.textBox62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox62.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox62.Location = new System.Drawing.Point(382, 322);
            this.textBox62.MaxLength = 1;
            this.textBox62.Multiline = true;
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(47, 46);
            this.textBox62.TabIndex = 61;
            this.textBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox62.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox61
            // 
            this.textBox61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox61.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox61.Location = new System.Drawing.Point(328, 322);
            this.textBox61.MaxLength = 1;
            this.textBox61.Multiline = true;
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(47, 46);
            this.textBox61.TabIndex = 60;
            this.textBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox61.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox60
            // 
            this.textBox60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox60.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox60.Location = new System.Drawing.Point(274, 322);
            this.textBox60.MaxLength = 1;
            this.textBox60.Multiline = true;
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(47, 46);
            this.textBox60.TabIndex = 59;
            this.textBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox60.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox59
            // 
            this.textBox59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox59.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox59.Location = new System.Drawing.Point(220, 322);
            this.textBox59.MaxLength = 1;
            this.textBox59.Multiline = true;
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(47, 46);
            this.textBox59.TabIndex = 58;
            this.textBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox59.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox58
            // 
            this.textBox58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox58.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox58.Location = new System.Drawing.Point(166, 322);
            this.textBox58.MaxLength = 1;
            this.textBox58.Multiline = true;
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(47, 46);
            this.textBox58.TabIndex = 57;
            this.textBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox58.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox57
            // 
            this.textBox57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox57.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox57.Location = new System.Drawing.Point(112, 322);
            this.textBox57.MaxLength = 1;
            this.textBox57.Multiline = true;
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(47, 46);
            this.textBox57.TabIndex = 56;
            this.textBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox57.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox56
            // 
            this.textBox56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox56.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox56.Location = new System.Drawing.Point(58, 322);
            this.textBox56.MaxLength = 1;
            this.textBox56.Multiline = true;
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(47, 46);
            this.textBox56.TabIndex = 55;
            this.textBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox56.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox55
            // 
            this.textBox55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox55.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox55.Location = new System.Drawing.Point(4, 322);
            this.textBox55.MaxLength = 1;
            this.textBox55.Multiline = true;
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(47, 46);
            this.textBox55.TabIndex = 54;
            this.textBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox55.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox54
            // 
            this.textBox54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox54.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox54.Location = new System.Drawing.Point(436, 269);
            this.textBox54.MaxLength = 1;
            this.textBox54.Multiline = true;
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(55, 46);
            this.textBox54.TabIndex = 53;
            this.textBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox54.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox53
            // 
            this.textBox53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox53.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox53.Location = new System.Drawing.Point(382, 269);
            this.textBox53.MaxLength = 1;
            this.textBox53.Multiline = true;
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(47, 46);
            this.textBox53.TabIndex = 52;
            this.textBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox53.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox52
            // 
            this.textBox52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox52.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox52.Location = new System.Drawing.Point(328, 269);
            this.textBox52.MaxLength = 1;
            this.textBox52.Multiline = true;
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(47, 46);
            this.textBox52.TabIndex = 51;
            this.textBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox52.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox51
            // 
            this.textBox51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox51.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox51.Location = new System.Drawing.Point(274, 269);
            this.textBox51.MaxLength = 1;
            this.textBox51.Multiline = true;
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(47, 46);
            this.textBox51.TabIndex = 50;
            this.textBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox51.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox50
            // 
            this.textBox50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox50.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox50.Location = new System.Drawing.Point(220, 269);
            this.textBox50.MaxLength = 1;
            this.textBox50.Multiline = true;
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(47, 46);
            this.textBox50.TabIndex = 49;
            this.textBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox50.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox49
            // 
            this.textBox49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox49.Location = new System.Drawing.Point(166, 269);
            this.textBox49.MaxLength = 1;
            this.textBox49.Multiline = true;
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(47, 46);
            this.textBox49.TabIndex = 48;
            this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox49.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox48
            // 
            this.textBox48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox48.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox48.Location = new System.Drawing.Point(112, 269);
            this.textBox48.MaxLength = 1;
            this.textBox48.Multiline = true;
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(47, 46);
            this.textBox48.TabIndex = 47;
            this.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox48.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox47
            // 
            this.textBox47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox47.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox47.Location = new System.Drawing.Point(58, 269);
            this.textBox47.MaxLength = 1;
            this.textBox47.Multiline = true;
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(47, 46);
            this.textBox47.TabIndex = 46;
            this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox47.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox46
            // 
            this.textBox46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox46.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox46.Location = new System.Drawing.Point(4, 269);
            this.textBox46.MaxLength = 1;
            this.textBox46.Multiline = true;
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(47, 46);
            this.textBox46.TabIndex = 45;
            this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox46.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox45
            // 
            this.textBox45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox45.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox45.Location = new System.Drawing.Point(436, 216);
            this.textBox45.MaxLength = 1;
            this.textBox45.Multiline = true;
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(55, 46);
            this.textBox45.TabIndex = 44;
            this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox45.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox44
            // 
            this.textBox44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox44.Location = new System.Drawing.Point(382, 216);
            this.textBox44.MaxLength = 1;
            this.textBox44.Multiline = true;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(47, 46);
            this.textBox44.TabIndex = 43;
            this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox44.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox43
            // 
            this.textBox43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox43.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox43.Location = new System.Drawing.Point(328, 216);
            this.textBox43.MaxLength = 1;
            this.textBox43.Multiline = true;
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(47, 46);
            this.textBox43.TabIndex = 42;
            this.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox43.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox42
            // 
            this.textBox42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox42.Location = new System.Drawing.Point(274, 216);
            this.textBox42.MaxLength = 1;
            this.textBox42.Multiline = true;
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(47, 46);
            this.textBox42.TabIndex = 41;
            this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox42.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox41
            // 
            this.textBox41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox41.Location = new System.Drawing.Point(220, 216);
            this.textBox41.MaxLength = 1;
            this.textBox41.Multiline = true;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(47, 46);
            this.textBox41.TabIndex = 40;
            this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox41.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox40
            // 
            this.textBox40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox40.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox40.Location = new System.Drawing.Point(166, 216);
            this.textBox40.MaxLength = 1;
            this.textBox40.Multiline = true;
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(47, 46);
            this.textBox40.TabIndex = 39;
            this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox40.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox39
            // 
            this.textBox39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox39.Location = new System.Drawing.Point(112, 216);
            this.textBox39.MaxLength = 1;
            this.textBox39.Multiline = true;
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(47, 46);
            this.textBox39.TabIndex = 38;
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox39.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox38
            // 
            this.textBox38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox38.Location = new System.Drawing.Point(58, 216);
            this.textBox38.MaxLength = 1;
            this.textBox38.Multiline = true;
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(47, 46);
            this.textBox38.TabIndex = 37;
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox38.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox37
            // 
            this.textBox37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox37.Location = new System.Drawing.Point(4, 216);
            this.textBox37.MaxLength = 1;
            this.textBox37.Multiline = true;
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(47, 46);
            this.textBox37.TabIndex = 36;
            this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox37.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox36
            // 
            this.textBox36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox36.Location = new System.Drawing.Point(436, 163);
            this.textBox36.MaxLength = 1;
            this.textBox36.Multiline = true;
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(55, 46);
            this.textBox36.TabIndex = 35;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox36.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox35
            // 
            this.textBox35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox35.Location = new System.Drawing.Point(382, 163);
            this.textBox35.MaxLength = 1;
            this.textBox35.Multiline = true;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(47, 46);
            this.textBox35.TabIndex = 34;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox35.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox34
            // 
            this.textBox34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox34.Location = new System.Drawing.Point(328, 163);
            this.textBox34.MaxLength = 1;
            this.textBox34.Multiline = true;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(47, 46);
            this.textBox34.TabIndex = 33;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox34.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox33
            // 
            this.textBox33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox33.Location = new System.Drawing.Point(274, 163);
            this.textBox33.MaxLength = 1;
            this.textBox33.Multiline = true;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(47, 46);
            this.textBox33.TabIndex = 32;
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox33.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox32
            // 
            this.textBox32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox32.Location = new System.Drawing.Point(220, 163);
            this.textBox32.MaxLength = 1;
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(47, 46);
            this.textBox32.TabIndex = 31;
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox32.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox31
            // 
            this.textBox31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox31.Location = new System.Drawing.Point(166, 163);
            this.textBox31.MaxLength = 1;
            this.textBox31.Multiline = true;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(47, 46);
            this.textBox31.TabIndex = 30;
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox31.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox30
            // 
            this.textBox30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox30.Location = new System.Drawing.Point(112, 163);
            this.textBox30.MaxLength = 1;
            this.textBox30.Multiline = true;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(47, 46);
            this.textBox30.TabIndex = 29;
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox30.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox29
            // 
            this.textBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox29.Location = new System.Drawing.Point(58, 163);
            this.textBox29.MaxLength = 1;
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(47, 46);
            this.textBox29.TabIndex = 28;
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox29.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox28
            // 
            this.textBox28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox28.Location = new System.Drawing.Point(4, 163);
            this.textBox28.MaxLength = 1;
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(47, 46);
            this.textBox28.TabIndex = 27;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox28.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox27
            // 
            this.textBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox27.Location = new System.Drawing.Point(436, 110);
            this.textBox27.MaxLength = 1;
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(55, 46);
            this.textBox27.TabIndex = 26;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox27.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox26
            // 
            this.textBox26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(382, 110);
            this.textBox26.MaxLength = 1;
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(47, 46);
            this.textBox26.TabIndex = 25;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox26.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox25
            // 
            this.textBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.Location = new System.Drawing.Point(328, 110);
            this.textBox25.MaxLength = 1;
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(47, 46);
            this.textBox25.TabIndex = 24;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox25.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox24
            // 
            this.textBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(274, 110);
            this.textBox24.MaxLength = 1;
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(47, 46);
            this.textBox24.TabIndex = 23;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox24.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox23
            // 
            this.textBox23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(220, 110);
            this.textBox23.MaxLength = 1;
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(47, 46);
            this.textBox23.TabIndex = 22;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox23.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox22
            // 
            this.textBox22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(166, 110);
            this.textBox22.MaxLength = 1;
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(47, 46);
            this.textBox22.TabIndex = 21;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox21
            // 
            this.textBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(112, 110);
            this.textBox21.MaxLength = 1;
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(47, 46);
            this.textBox21.TabIndex = 20;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox20
            // 
            this.textBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(58, 110);
            this.textBox20.MaxLength = 1;
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(47, 46);
            this.textBox20.TabIndex = 19;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox19
            // 
            this.textBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(4, 110);
            this.textBox19.MaxLength = 1;
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(47, 46);
            this.textBox19.TabIndex = 18;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox18
            // 
            this.textBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(436, 57);
            this.textBox18.MaxLength = 1;
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(55, 46);
            this.textBox18.TabIndex = 17;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox18.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox17
            // 
            this.textBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(382, 57);
            this.textBox17.MaxLength = 1;
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(47, 46);
            this.textBox17.TabIndex = 16;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox17.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox16
            // 
            this.textBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(328, 57);
            this.textBox16.MaxLength = 1;
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(47, 46);
            this.textBox16.TabIndex = 15;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox15
            // 
            this.textBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(274, 57);
            this.textBox15.MaxLength = 1;
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(47, 46);
            this.textBox15.TabIndex = 14;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox14
            // 
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(220, 57);
            this.textBox14.MaxLength = 1;
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(47, 46);
            this.textBox14.TabIndex = 13;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox13
            // 
            this.textBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(166, 57);
            this.textBox13.MaxLength = 1;
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(47, 46);
            this.textBox13.TabIndex = 12;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox12
            // 
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(112, 57);
            this.textBox12.MaxLength = 1;
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(47, 46);
            this.textBox12.TabIndex = 11;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox11
            // 
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(58, 57);
            this.textBox11.MaxLength = 1;
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(47, 46);
            this.textBox11.TabIndex = 10;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox10
            // 
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(4, 57);
            this.textBox10.MaxLength = 1;
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(47, 46);
            this.textBox10.TabIndex = 9;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(436, 4);
            this.textBox9.MaxLength = 1;
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(55, 46);
            this.textBox9.TabIndex = 8;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(382, 4);
            this.textBox8.MaxLength = 1;
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 46);
            this.textBox8.TabIndex = 7;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(328, 4);
            this.textBox7.MaxLength = 1;
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(47, 46);
            this.textBox7.TabIndex = 6;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(274, 4);
            this.textBox6.MaxLength = 1;
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(47, 46);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(220, 4);
            this.textBox5.MaxLength = 1;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(47, 46);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(166, 4);
            this.textBox4.MaxLength = 1;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 46);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(112, 4);
            this.textBox3.MaxLength = 1;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 46);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(58, 4);
            this.textBox2.MaxLength = 1;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 46);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.MaxLength = 1;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 46);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFocus_KeyDown);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(13, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(462, 39);
            this.topLabel.TabIndex = 2;
            this.topLabel.Text = "Enter your unsolved sudoku!";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(12, 573);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 615);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.solveSudokuButton);
            this.MaximumSize = new System.Drawing.Size(533, 654);
            this.MinimumSize = new System.Drawing.Size(533, 654);
            this.Name = "Form1";
            this.Text = "i can solve your sudoku";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solveSudokuButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox81;
        private System.Windows.Forms.TextBox textBox80;
        private System.Windows.Forms.TextBox textBox79;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.TextBox textBox70;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label topLabel;
        private Button clearButton;
    }
}

