﻿namespace AdoNetDataSetWithoutBDApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployees).BeginInit();
            SuspendLayout();
            // 
            // dataGridEmployees
            // 
            dataGridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployees.Location = new Point(12, 12);
            dataGridEmployees.Name = "dataGridEmployees";
            dataGridEmployees.Size = new Size(520, 412);
            dataGridEmployees.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 450);
            Controls.Add(dataGridEmployees);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridEmployees;
    }
}
