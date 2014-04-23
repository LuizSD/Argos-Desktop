namespace ProjetoArgos
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
            this.Lampada1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lampada2 = new System.Windows.Forms.Button();
            this.Lampada3 = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lampada1
            // 
            this.Lampada1.Location = new System.Drawing.Point(12, 25);
            this.Lampada1.Name = "Lampada1";
            this.Lampada1.Size = new System.Drawing.Size(75, 23);
            this.Lampada1.TabIndex = 0;
            this.Lampada1.Text = "Ligar";
            this.Lampada1.UseVisualStyleBackColor = true;
            this.Lampada1.Click += new System.EventHandler(this.Lampada1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lâmpada 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lâmpada 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lâmpada 3";
            // 
            // Lampada2
            // 
            this.Lampada2.Location = new System.Drawing.Point(12, 78);
            this.Lampada2.Name = "Lampada2";
            this.Lampada2.Size = new System.Drawing.Size(75, 23);
            this.Lampada2.TabIndex = 4;
            this.Lampada2.Text = "Ligar";
            this.Lampada2.UseVisualStyleBackColor = true;
            this.Lampada2.Click += new System.EventHandler(this.Lampada2_Click);
            // 
            // Lampada3
            // 
            this.Lampada3.Location = new System.Drawing.Point(12, 130);
            this.Lampada3.Name = "Lampada3";
            this.Lampada3.Size = new System.Drawing.Size(75, 23);
            this.Lampada3.TabIndex = 5;
            this.Lampada3.Text = "Ligar";
            this.Lampada3.UseVisualStyleBackColor = true;
            this.Lampada3.Click += new System.EventHandler(this.Lampada3_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(93, 197);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 6;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Lampada3);
            this.Controls.Add(this.Lampada2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lampada1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Argos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lampada1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Lampada2;
        private System.Windows.Forms.Button Lampada3;
        private System.Windows.Forms.Button Atualizar;
    }
}

