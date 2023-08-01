namespace Precentacion
{
    partial class frmPrimera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimera));
            this.lblComienzo = new System.Windows.Forms.Label();
            this.btnComienzoAceptar = new System.Windows.Forms.Button();
            this.btnComienzoCancelar = new System.Windows.Forms.Button();
            this.pbxImagenPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComienzo
            // 
            this.lblComienzo.AutoSize = true;
            this.lblComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComienzo.Location = new System.Drawing.Point(108, 9);
            this.lblComienzo.Name = "lblComienzo";
            this.lblComienzo.Size = new System.Drawing.Size(302, 42);
            this.lblComienzo.TabIndex = 0;
            this.lblComienzo.Text = "¿Comenzamos?";
            // 
            // btnComienzoAceptar
            // 
            this.btnComienzoAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComienzoAceptar.Location = new System.Drawing.Point(127, 398);
            this.btnComienzoAceptar.Name = "btnComienzoAceptar";
            this.btnComienzoAceptar.Size = new System.Drawing.Size(118, 36);
            this.btnComienzoAceptar.TabIndex = 1;
            this.btnComienzoAceptar.Text = "Aceptar";
            this.btnComienzoAceptar.UseVisualStyleBackColor = true;
            this.btnComienzoAceptar.Click += new System.EventHandler(this.btnComienzoAceptar_Click);
            // 
            // btnComienzoCancelar
            // 
            this.btnComienzoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComienzoCancelar.Location = new System.Drawing.Point(265, 398);
            this.btnComienzoCancelar.Name = "btnComienzoCancelar";
            this.btnComienzoCancelar.Size = new System.Drawing.Size(118, 36);
            this.btnComienzoCancelar.TabIndex = 2;
            this.btnComienzoCancelar.Text = "Cancelar";
            this.btnComienzoCancelar.UseVisualStyleBackColor = true;
            this.btnComienzoCancelar.Click += new System.EventHandler(this.btnComienzoCancelar_Click);
            // 
            // pbxImagenPrincipal
            // 
            this.pbxImagenPrincipal.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxImagenPrincipal.ErrorImage")));
            this.pbxImagenPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagenPrincipal.Image")));
            this.pbxImagenPrincipal.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxImagenPrincipal.InitialImage")));
            this.pbxImagenPrincipal.Location = new System.Drawing.Point(12, 54);
            this.pbxImagenPrincipal.Name = "pbxImagenPrincipal";
            this.pbxImagenPrincipal.Size = new System.Drawing.Size(472, 319);
            this.pbxImagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenPrincipal.TabIndex = 3;
            this.pbxImagenPrincipal.TabStop = false;
            // 
            // frmPrimera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 446);
            this.Controls.Add(this.pbxImagenPrincipal);
            this.Controls.Add(this.btnComienzoCancelar);
            this.Controls.Add(this.btnComienzoAceptar);
            this.Controls.Add(this.lblComienzo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrimera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComienzo;
        private System.Windows.Forms.Button btnComienzoAceptar;
        private System.Windows.Forms.Button btnComienzoCancelar;
        private System.Windows.Forms.PictureBox pbxImagenPrincipal;
    }
}