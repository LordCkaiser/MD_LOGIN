
namespace MD_LOGIN.PANEL_DE_ADMINISTRACION_DEL_SOFTWARE
{
    partial class CONEXION_MANUAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONEXION_MANUAL));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btbGenerarCon = new System.Windows.Forms.Button();
            this.txtCnString = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datalistado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cadena de conexion local";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Una vez que estes listo dale a \"Generar cadena de conexion, se creara un archivo " +
    "que contendra tu conexion Encryptada. Ahora tu conexión es mas segura anta posib" +
    "les hakers";
            this.label2.UseWaitCursor = true;
            // 
            // btbGenerarCon
            // 
            this.btbGenerarCon.Location = new System.Drawing.Point(27, 234);
            this.btbGenerarCon.Name = "btbGenerarCon";
            this.btbGenerarCon.Size = new System.Drawing.Size(198, 48);
            this.btbGenerarCon.TabIndex = 2;
            this.btbGenerarCon.Text = "Generar cadena de conexion";
            this.btbGenerarCon.UseVisualStyleBackColor = true;
            this.btbGenerarCon.Click += new System.EventHandler(this.btbGenerarCon_Click);
            // 
            // txtCnString
            // 
            this.txtCnString.Location = new System.Drawing.Point(36, 127);
            this.txtCnString.Multiline = true;
            this.txtCnString.Name = "txtCnString";
            this.txtCnString.Size = new System.Drawing.Size(521, 100);
            this.txtCnString.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(561, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // datalistado
            // 
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(315, 250);
            this.datalistado.Name = "datalistado";
            this.datalistado.Size = new System.Drawing.Size(220, 63);
            this.datalistado.TabIndex = 5;
            // 
            // CONEXION_MANUAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.datalistado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCnString);
            this.Controls.Add(this.btbGenerarCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CONEXION_MANUAL";
            this.Text = "CONEXION_MANUAL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbGenerarCon;
        private System.Windows.Forms.TextBox txtCnString;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datalistado;
    }
}