namespace Practica2.Vista
{
    partial class CrearReunion
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
            this.buttonGuardarReunion = new System.Windows.Forms.Button();
            this.buttonCerrarReunion = new System.Windows.Forms.Button();
            this.dateTimePickerFechaReunion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Tema = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTema = new System.Windows.Forms.TextBox();
            this.richTextBoxSugerencias = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonGuardarReunion
            // 
            this.buttonGuardarReunion.Location = new System.Drawing.Point(142, 222);
            this.buttonGuardarReunion.Name = "buttonGuardarReunion";
            this.buttonGuardarReunion.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarReunion.TabIndex = 0;
            this.buttonGuardarReunion.Text = "Guardar";
            this.buttonGuardarReunion.UseVisualStyleBackColor = true;
            this.buttonGuardarReunion.Click += new System.EventHandler(this.buttonGuardarReunion_Click);
            // 
            // buttonCerrarReunion
            // 
            this.buttonCerrarReunion.Location = new System.Drawing.Point(299, 222);
            this.buttonCerrarReunion.Name = "buttonCerrarReunion";
            this.buttonCerrarReunion.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrarReunion.TabIndex = 1;
            this.buttonCerrarReunion.Text = "Cerrar";
            this.buttonCerrarReunion.UseVisualStyleBackColor = true;
            this.buttonCerrarReunion.Click += new System.EventHandler(this.buttonCerrarReunion_Click);
            // 
            // dateTimePickerFechaReunion
            // 
            this.dateTimePickerFechaReunion.Location = new System.Drawing.Point(285, 30);
            this.dateTimePickerFechaReunion.Name = "dateTimePickerFechaReunion";
            this.dateTimePickerFechaReunion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaReunion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // Tema
            // 
            this.Tema.AutoSize = true;
            this.Tema.Location = new System.Drawing.Point(45, 34);
            this.Tema.Name = "Tema";
            this.Tema.Size = new System.Drawing.Size(34, 13);
            this.Tema.TabIndex = 4;
            this.Tema.Text = "Tema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sugerencias:";
            // 
            // textBoxTema
            // 
            this.textBoxTema.Location = new System.Drawing.Point(85, 27);
            this.textBoxTema.Name = "textBoxTema";
            this.textBoxTema.Size = new System.Drawing.Size(153, 20);
            this.textBoxTema.TabIndex = 7;
            // 
            // richTextBoxSugerencias
            // 
            this.richTextBoxSugerencias.Location = new System.Drawing.Point(85, 71);
            this.richTextBoxSugerencias.Name = "richTextBoxSugerencias";
            this.richTextBoxSugerencias.Size = new System.Drawing.Size(400, 96);
            this.richTextBoxSugerencias.TabIndex = 8;
            this.richTextBoxSugerencias.Text = "";
            // 
            // CrearReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 271);
            this.Controls.Add(this.richTextBoxSugerencias);
            this.Controls.Add(this.textBoxTema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFechaReunion);
            this.Controls.Add(this.buttonCerrarReunion);
            this.Controls.Add(this.buttonGuardarReunion);
            this.Name = "CrearReunion";
            this.Text = "CrearReunion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardarReunion;
        private System.Windows.Forms.Button buttonCerrarReunion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaReunion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTema;
        private System.Windows.Forms.RichTextBox richTextBoxSugerencias;
    }
}