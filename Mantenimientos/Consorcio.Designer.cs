namespace Sistema_Loteria.Mantenimientos
{
    partial class Consorcio
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
            this.ConsorcioTextBox = new System.Windows.Forms.TextBox();
            this.IDEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.IDEmpleadoLabel = new System.Windows.Forms.Label();
            this.ConsorcioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 396);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 396);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 396);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 396);
            // 
            // ConsorcioTextBox
            // 
            this.ConsorcioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.ConsorcioTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsorcioTextBox.ForeColor = System.Drawing.Color.White;
            this.ConsorcioTextBox.Location = new System.Drawing.Point(208, 270);
            this.ConsorcioTextBox.Name = "ConsorcioTextBox";
            this.ConsorcioTextBox.Size = new System.Drawing.Size(247, 26);
            this.ConsorcioTextBox.TabIndex = 5;
            // 
            // IDEmpleadoTextBox
            // 
            this.IDEmpleadoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.IDEmpleadoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEmpleadoTextBox.ForeColor = System.Drawing.Color.White;
            this.IDEmpleadoTextBox.Location = new System.Drawing.Point(208, 332);
            this.IDEmpleadoTextBox.Name = "IDEmpleadoTextBox";
            this.IDEmpleadoTextBox.Size = new System.Drawing.Size(247, 26);
            this.IDEmpleadoTextBox.TabIndex = 6;
            // 
            // IDEmpleadoLabel
            // 
            this.IDEmpleadoLabel.AutoSize = true;
            this.IDEmpleadoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEmpleadoLabel.ForeColor = System.Drawing.Color.White;
            this.IDEmpleadoLabel.Location = new System.Drawing.Point(204, 310);
            this.IDEmpleadoLabel.Name = "IDEmpleadoLabel";
            this.IDEmpleadoLabel.Size = new System.Drawing.Size(97, 19);
            this.IDEmpleadoLabel.TabIndex = 8;
            this.IDEmpleadoLabel.Text = "ID Empleado";
            // 
            // ConsorcioLabel
            // 
            this.ConsorcioLabel.AutoSize = true;
            this.ConsorcioLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsorcioLabel.ForeColor = System.Drawing.Color.White;
            this.ConsorcioLabel.Location = new System.Drawing.Point(204, 248);
            this.ConsorcioLabel.Name = "ConsorcioLabel";
            this.ConsorcioLabel.Size = new System.Drawing.Size(76, 19);
            this.ConsorcioLabel.TabIndex = 9;
            this.ConsorcioLabel.Text = "Consorcio";
            // 
            // Consorcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.IDEmpleadoLabel);
            this.Controls.Add(this.ConsorcioLabel);
            this.Controls.Add(this.IDEmpleadoTextBox);
            this.Controls.Add(this.ConsorcioTextBox);
            this.Name = "Consorcio";
            this.Text = "Consorcio";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.ConsorcioTextBox, 0);
            this.Controls.SetChildIndex(this.IDEmpleadoTextBox, 0);
            this.Controls.SetChildIndex(this.ConsorcioLabel, 0);
            this.Controls.SetChildIndex(this.IDEmpleadoLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsorcioTextBox;
        private System.Windows.Forms.TextBox IDEmpleadoTextBox;
        private System.Windows.Forms.Label IDEmpleadoLabel;
        private System.Windows.Forms.Label ConsorcioLabel;
    }
}