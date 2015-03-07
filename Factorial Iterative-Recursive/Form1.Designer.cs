namespace Factorial_Iterative_Recursive
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageLabel = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.iterativeButton = new System.Windows.Forms.Button();
            this.recursiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(17, 6);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(275, 23);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Please type a number";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataBox
            // 
            this.dataBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBox.Location = new System.Drawing.Point(14, 36);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(275, 29);
            this.dataBox.TabIndex = 1;
            this.dataBox.TextChanged += new System.EventHandler(this.dataBox_TextChanged);
            // 
            // iterativeButton
            // 
            this.iterativeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.iterativeButton.FlatAppearance.BorderSize = 0;
            this.iterativeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.iterativeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.iterativeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iterativeButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterativeButton.ForeColor = System.Drawing.Color.White;
            this.iterativeButton.Location = new System.Drawing.Point(52, 75);
            this.iterativeButton.Name = "iterativeButton";
            this.iterativeButton.Size = new System.Drawing.Size(83, 35);
            this.iterativeButton.TabIndex = 2;
            this.iterativeButton.Text = "Iterative";
            this.iterativeButton.UseVisualStyleBackColor = false;
            this.iterativeButton.Click += new System.EventHandler(this.iterativeButton_Click);
            // 
            // recursiveButton
            // 
            this.recursiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.recursiveButton.FlatAppearance.BorderSize = 0;
            this.recursiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.recursiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.recursiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recursiveButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recursiveButton.ForeColor = System.Drawing.Color.White;
            this.recursiveButton.Location = new System.Drawing.Point(170, 75);
            this.recursiveButton.Name = "recursiveButton";
            this.recursiveButton.Size = new System.Drawing.Size(83, 35);
            this.recursiveButton.TabIndex = 3;
            this.recursiveButton.Text = "Recursive";
            this.recursiveButton.UseVisualStyleBackColor = false;
            this.recursiveButton.Click += new System.EventHandler(this.recursiveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.recursiveButton);
            this.Controls.Add(this.iterativeButton);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.messageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorial - Pissurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.Button iterativeButton;
        private System.Windows.Forms.Button recursiveButton;
    }
}

