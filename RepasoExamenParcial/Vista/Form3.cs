using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

using Practica2.ServiceReference5;

namespace Vista
{
    public partial class formReporte : Form //#pregunta6
    {

        public string texto = "hola";
        Form parent;
        public Service2Client serviceTutor = new Service2Client();
        public formReporte(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            
        }

        private void Ventana_Paint(object sender, PaintEventArgs e)
        {
            decimal[] valores = new decimal[10];
            int i = 0;
            

            int total = (serviceTutor.getTutoresCount() >= 10) ? 10 : serviceTutor.getTutoresCount();

            //GestorTutores.Tutores.Sort((x, y) => y.cantidadReuniones().CompareTo(x.cantidadReuniones()));
            this.dataGridView1.Rows.Clear();
            string[] colores =
            {
                "Amarillo",
                "Verde",
                "Azul",
                "Turquesa",
                "Magenta",
                "Rojo",
                "Negro",
                "Plomo",
                "Marron",
                "Celeste"
            };
            for (int x = 0; x< total; x++)
            {
                Profesor selected  = serviceTutor.getTutor(x);

                valores[x] = 1; //selected.cantidadReuniones();
                
                this.dataGridView1.Rows.Add(selected.Codigo, selected.Nombre,valores[x],colores[x]);
            }

            Bitmap pie = Draw(Color.White, 300,300,valores);

            e.Graphics.DrawImage(pie,100,20);

        }

        public Bitmap Draw(Color bgColor, int width, int height,
           decimal[] vals)
        {
            
            Bitmap bitmap = new Bitmap(width, height,
                                       System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(bgColor);
            graphics.FillRectangle(brush, 0, 0, width, height);
            brush.Dispose();

            
            SolidBrush[] brushes = new SolidBrush[10];
            brushes[0] = new SolidBrush(Color.Yellow);
            brushes[1] = new SolidBrush(Color.Green);
            brushes[2] = new SolidBrush(Color.Blue);
            brushes[3] = new SolidBrush(Color.Cyan);
            brushes[4] = new SolidBrush(Color.Magenta);
            brushes[5] = new SolidBrush(Color.Red);
            brushes[6] = new SolidBrush(Color.Black);
            brushes[7] = new SolidBrush(Color.Gray);
            brushes[8] = new SolidBrush(Color.Maroon);
            brushes[9] = new SolidBrush(Color.LightBlue);

            
            decimal total = 0.0m;
            foreach (decimal val in vals)
                total += val;

            
            float start = 0.0f;
            float end = 0.0f;
            decimal current = 0.0m;
            for (int i = 0; i < vals.Length; i++)
            {
                current += vals[i];
                start = end;
                end = (float)(current / total) * 360.0f;
                graphics.FillPie(brushes[i % 10], 0.0f, 0.0f, width,
                                 height, start, end - start);
            }

            
            foreach (SolidBrush cleanBrush in brushes)
                cleanBrush.Dispose();

            return bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            decimal[] valores = new decimal[10];
            int i = 0;
            int codigo = Int32.Parse(textBox1.Text);
            Profesor profesor = serviceTutor.buscarProfesor(codigo);

            DateTime inicio = dateTimePickerInicio.Value;
            DateTime fin = dateTimePickerFin.Value;
            
            Dictionary<Alumno, int> relacionAlumnoReunion = new Dictionary<Alumno, int> { };
            List<Alumno> listaAlumnosElegidos = new List<Alumno> {}   ;
            int totalReuniones = 0;
            foreach(Alumno a in serviceTutor.getAlumnos(profesor))
            {
                foreach (Reunion r in a.ListaReuniones)
                {
                    if (r.Profesor.Codigo == codigo)
                    {
                        if (r.Fecha.CompareTo(inicio.ToString("YY-mm-dd")) >= 0 && r.Fecha.CompareTo(fin.ToString("YY-mm-dd")) <= 0)
                        {
                            totalReuniones++;
                        }
                    }
                }
                if (totalReuniones != 0)
                {
                    relacionAlumnoReunion.Add(a, totalReuniones);
                    listaAlumnosElegidos.Add(a);
                    totalReuniones = 0;
                }
            }
            
            
            int z = 0;
            
            foreach (Alumno a in listaAlumnosElegidos)
            {
                valores[z] = relacionAlumnoReunion[a];
                z++;
            }


            int total = (listaAlumnosElegidos.Count >= 10) ? 10 : listaAlumnosElegidos.Count;

           // GestorTutores.Tutores.Sort((x, y) => y.cantidadReuniones().CompareTo(x.cantidadReuniones())); esto era antes para conseguir los top prefesores
            this.dataGridView1.Rows.Clear();
            string[] colores =
            {
                "Amarillo",
                "Verde",
                "Azul",
                "Turquesa",
                "Magenta",
                "Rojo",
                "Negro",
                "Plomo",
                "Marron",
                "Celeste"
            };
            Font f = this.Font;
            Brush b = Brushes.Black;
            
            string titulo = "REUNION PROFESOR "+ codigo.ToString()+"-"+profesor.Nombre+":";
            string subtitulo = "del " + inicio.ToString("yyyy/mm/dd") + " al " + fin.ToString("yyyy/mm/dd");
            for (int x = 0; x < total; x++) // esto hara un grid view para listar a los alumnos que se tengan
            {
                Alumno selected = listaAlumnosElegidos[x];
                valores[x] = relacionAlumnoReunion[selected];

                this.dataGridView1.Rows.Add(selected.Nombre, valores[x], colores[x]);
            }

            Bitmap pie = Draw(Color.White, 300, 300, valores);

            
            Graphics grafico = this.CreateGraphics();
            label4.Text = titulo;
            label5.Text = subtitulo;
            label4.Visible = true;
            label5.Visible = true;

            grafico.DrawImage(pie, 100, 20);
        }
    }
}

