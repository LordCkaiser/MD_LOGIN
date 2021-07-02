
namespace MD_LOGIN.MODULOS
{
    partial class GERENCIA
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
            this.lblmensajegerencia = new System.Windows.Forms.Label();
            this.lblgerencia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensajegerencia
            // 
            this.lblmensajegerencia.AutoSize = true;
            this.lblmensajegerencia.Location = new System.Drawing.Point(221, 106);
            this.lblmensajegerencia.Name = "lblmensajegerencia";
            this.lblmensajegerencia.Size = new System.Drawing.Size(0, 13);
            this.lblmensajegerencia.TabIndex = 0;
            // 
            // lblgerencia
            // 
            this.lblgerencia.AutoSize = true;
            this.lblgerencia.Location = new System.Drawing.Point(187, 235);
            this.lblgerencia.Name = "lblgerencia";
            this.lblgerencia.Size = new System.Drawing.Size(62, 13);
            this.lblgerencia.TabIndex = 1;
            this.lblgerencia.Text = "GERENCIA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GERENCIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblgerencia);
            this.Controls.Add(this.lblmensajegerencia);
            this.Name = "GERENCIA";
            this.Text = "GERENCIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensajegerencia;
        private System.Windows.Forms.Label lblgerencia;
        private System.Windows.Forms.Button button1;
    }
}