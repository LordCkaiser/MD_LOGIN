
namespace MD_LOGIN.MODULOS
{
    partial class ALMACEN
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
            this.lblmensajealm = new System.Windows.Forms.Label();
            this.lBLALM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensajealm
            // 
            this.lblmensajealm.AutoSize = true;
            this.lblmensajealm.Location = new System.Drawing.Point(341, 71);
            this.lblmensajealm.Name = "lblmensajealm";
            this.lblmensajealm.Size = new System.Drawing.Size(0, 13);
            this.lblmensajealm.TabIndex = 0;
            // 
            // lBLALM
            // 
            this.lBLALM.AutoSize = true;
            this.lBLALM.Location = new System.Drawing.Point(341, 253);
            this.lBLALM.Name = "lBLALM";
            this.lBLALM.Size = new System.Drawing.Size(58, 13);
            this.lBLALM.TabIndex = 1;
            this.lBLALM.Text = "ALMACEN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ALMACEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lBLALM);
            this.Controls.Add(this.lblmensajealm);
            this.Name = "ALMACEN";
            this.Text = "ALMACEN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensajealm;
        private System.Windows.Forms.Label lBLALM;
        private System.Windows.Forms.Button button1;
    }
}