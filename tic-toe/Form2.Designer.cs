namespace tic_toe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Player2);
            this.panel1.Controls.Add(this.Player1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 430);
            this.panel1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Save.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Save.Location = new System.Drawing.Point(120, 310);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(114, 59);
            this.Save.TabIndex = 4;
            this.Save.Text = "Начать";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2.Location = new System.Drawing.Point(29, 225);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(280, 34);
            this.Player2.TabIndex = 3;
            // 
            // Player1
            // 
            this.Player1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1.Location = new System.Drawing.Point(29, 78);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(280, 34);
            this.Player1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите имя второго игрока:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя первого игрока:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 493);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Крестики-нолики";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}