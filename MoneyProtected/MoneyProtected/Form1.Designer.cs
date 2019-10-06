namespace MoneyProtected
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
            this.button1 = new System.Windows.Forms.Button();
            this.Total_Grande = new System.Windows.Forms.Label();
            this.Total_Pequeno = new System.Windows.Forms.Label();
            this.Cambioo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Total_Grande
            // 
            this.Total_Grande.AutoSize = true;
            this.Total_Grande.Location = new System.Drawing.Point(627, 99);
            this.Total_Grande.Name = "Total_Grande";
            this.Total_Grande.Size = new System.Drawing.Size(51, 20);
            this.Total_Grande.TabIndex = 1;
            this.Total_Grande.Text = "label1";
            this.Total_Grande.Click += new System.EventHandler(this.label1_Click);
            // 
            // Total_Pequeno
            // 
            this.Total_Pequeno.AutoSize = true;
            this.Total_Pequeno.Location = new System.Drawing.Point(627, 173);
            this.Total_Pequeno.Name = "Total_Pequeno";
            this.Total_Pequeno.Size = new System.Drawing.Size(51, 20);
            this.Total_Pequeno.TabIndex = 2;
            this.Total_Pequeno.Text = "label2";
            // 
            // Cambioo
            // 
            this.Cambioo.AutoSize = true;
            this.Cambioo.Location = new System.Drawing.Point(627, 240);
            this.Cambioo.Name = "Cambioo";
            this.Cambioo.Size = new System.Drawing.Size(51, 20);
            this.Cambioo.TabIndex = 3;
            this.Cambioo.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cambioo);
            this.Controls.Add(this.Total_Pequeno);
            this.Controls.Add(this.Total_Grande);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Total_Grande;
        private System.Windows.Forms.Label Total_Pequeno;
        private System.Windows.Forms.Label Cambioo;
    }
}

