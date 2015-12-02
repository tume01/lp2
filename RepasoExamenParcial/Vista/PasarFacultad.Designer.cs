namespace Vista
{
    partial class PasarFacultad
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
            this.resumenText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveResumen = new System.Windows.Forms.Button();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resumenText
            // 
            this.resumenText.Location = new System.Drawing.Point(147, 39);
            this.resumenText.Name = "resumenText";
            this.resumenText.Size = new System.Drawing.Size(510, 176);
            this.resumenText.TabIndex = 0;
            this.resumenText.Text = "";
            this.resumenText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resumen Reuniones";
            // 
            // saveResumen
            // 
            this.saveResumen.Location = new System.Drawing.Point(180, 291);
            this.saveResumen.Name = "saveResumen";
            this.saveResumen.Size = new System.Drawing.Size(75, 23);
            this.saveResumen.TabIndex = 2;
            this.saveResumen.Text = "Guardar";
            this.saveResumen.UseVisualStyleBackColor = true;
            this.saveResumen.Click += new System.EventHandler(this.saveResumen_Click);
            // 
            // cerrarButton
            // 
            this.cerrarButton.Location = new System.Drawing.Point(355, 291);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(75, 23);
            this.cerrarButton.TabIndex = 3;
            this.cerrarButton.Text = "Cerrar";
            this.cerrarButton.UseVisualStyleBackColor = true;
            this.cerrarButton.Click += new System.EventHandler(this.cerrarButton_Click);
            // 
            // PasarFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 372);
            this.Controls.Add(this.cerrarButton);
            this.Controls.Add(this.saveResumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resumenText);
            this.Name = "PasarFacultad";
            this.Text = "PasarFacultad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resumenText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveResumen;
        private System.Windows.Forms.Button cerrarButton;
    }
}