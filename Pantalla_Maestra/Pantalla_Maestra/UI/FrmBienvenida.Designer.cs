namespace Pantalla_Maestra.UI
{
    partial class FrmBienvenida
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
            this.lblLoginExitoso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginExitoso
            // 
            this.lblLoginExitoso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginExitoso.Location = new System.Drawing.Point(245, 171);
            this.lblLoginExitoso.Name = "lblLoginExitoso";
            this.lblLoginExitoso.Size = new System.Drawing.Size(239, 73);
            this.lblLoginExitoso.TabIndex = 0;
            this.lblLoginExitoso.Text = "Login Exitoso";
            this.lblLoginExitoso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_Maestra.Properties.Resources._0a1d67de76466edaa358e0b13d1adfd5;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.lblLoginExitoso);
            this.Name = "FrmBienvenida";
            this.Text = "FrmBienvenida";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginExitoso;
    }
}