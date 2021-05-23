using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Octave.NET;

namespace Proyecto_Simulacion
{
    public partial class Form1 : Form
    {
        string octaveCliPath = "C:/Program Files/GNU Octave/Octave-6.2.0/mingw64/bin/octave-cli.exe";
        int i = 0;
        double[] vectorg1y = new double[10];
        double[] vectorg2y = new double[10];
        double[] vectort = new double[10];

        int g1yinicial;
        int g2yinicial;

        int altoInicial;
        int altoInicialk2;

        int cantSimulaciones = 1;
        int index_row = 0;

        string respuestaAl = "step";

        bool mostrarAnimaciones = false;
        bool finalizado = false;

        char[] g1;
        char[] g2;

        string g1TextFunction = "";
        string g2TextFunction = "";

        string variable =  "a1=m1*s^2+k1b2+b1*s;" +
                    "a2=b1*s;" +
                    "a3=m2*s^2+k2+b1*s;" +
                    "a4=b1*s;" +
                    "g1=(a2)/(a3*a1-a2^2);" +
                    "g2=a1/(a3*(a1-(a2^2)));";

        public Form1()
        {
            InitializeComponent();
            resetearValores();
        }

        private void btnProcesar(object sender, EventArgs e)
        {
            OctaveContext.OctaveSettings.OctaveCliPath = octaveCliPath;
            OctaveContext octave = new OctaveContext();

            i = 0;
            timer1.Interval = Int32.Parse(intervalo_tb.Text);

            restablecerPosiciones();

            button1.Enabled = false;

            if (finalizado)
            {
                cantSimulacionesTxt_lb.Text = "Simulaciones Ejecutadas: ";
                chart1.Series["G1(s)"].Points.Clear();
                chart1.Series["G2(s)"].Points.Clear();

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }

            //step(g,tiempo simulacion,rango tiempo)
            octave.Execute("clear;" +
                "pkg load control;" +
                "s=tf('s');" +
                "m1="+m1_tb.Text+ ";m2=" + m2_tb.Text + ";" +
                "k1b2="+k1_tb.Text+";k2=" + k2_tb.Text + ";" +
                "b1="+b1_tb.Text+";" +
                variable+
                "[y,t]=" +respuestaAl+"(g1);"+
                "[y2,t]=" + respuestaAl + "(g2);" +
                "c=length(t);" +
                "tiempo=t(c)*1.2;" +
                "[y,t]="+respuestaAl+"(g1,tiempo,tiempo/" + numeroElementos_tb.Text+ ");"+
                "[y2,t]=" + respuestaAl + "(g2,tiempo,tiempo/" + numeroElementos_tb.Text + ");"
                );
           
            Array.Resize(ref vectorg1y, Int32.Parse(numeroElementos_tb.Text));
            Array.Resize(ref vectorg2y, Int32.Parse(numeroElementos_tb.Text));

            Array.Resize(ref vectort, Int32.Parse(numeroElementos_tb.Text));

           
            char[] delims = new[] { '\r', '\n' };

            string[] g1NumDem = octave.Execute("g1").Split(delims, StringSplitOptions.RemoveEmptyEntries);
            string[] g2NumDem = octave.Execute("g2").Split(delims, StringSplitOptions.RemoveEmptyEntries);

            g1TextFunction = g1NumDem[1].Trim() + "  /  " + g1NumDem[3].Trim();
            g2TextFunction = g2NumDem[1].Trim() + "  /  " + g2NumDem[3].Trim();

            vectorg1y = octave.Execute("y").AsVector();
            vectorg2y = octave.Execute("y2").AsVector();
            vectort = octave.Execute("t").AsVector();


            if (mostrarAnimaciones)
            {
                timer1.Enabled = true;
            }
            else {
                
                for (int i = 0; i < Int32.Parse(numeroElementos_tb.Text); i++)
                {
                    chart1.Series["G1(s)"].Points.AddXY(vectort[i], vectorg1y[i]);
                    chart1.Series["G2(s)"].Points.AddXY(vectort[i], vectorg2y[i]);
                }
                registrarSimulacion();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            chart1.Series["G1(s)"].Points.AddXY(vectort[i], vectorg1y[i]);
            chart1.Series["G2(s)"].Points.AddXY(vectort[i], vectorg2y[i]);
            i++;
     
            if (mostrarAnimaciones)
            {

                //modificando la posicion de la masa 1
                masa1Pb.Location = new Point(masa1Pb.Location.X, (g1yinicial + Convert.ToInt32(vectorg1y[i] * 1000)));

                //modificando la posicion de la masa 2
                masa2Pb.Location = new Point(masa2Pb.Location.X, (g2yinicial + Convert.ToInt32(vectorg2y[i] * 1000)));


                //modificando altura resorte
                resorte_pb.Height = altoInicial + Convert.ToInt32(vectorg1y[i] * 1000);

                amortiguadorb1_pb.Location = new Point(amortiguadorb1_pb.Location.X, (g1yinicial + Convert.ToInt32(vectorg1y[i] * 1000)));
                amortiguadorb1_pb.Height = (g2yinicial + Convert.ToInt32(vectorg2y[i] * 1000)) - (g1yinicial + Convert.ToInt32(vectorg1y[i] * 1000));

                resortek2_pb.Height = altoInicialk2 + Convert.ToInt32(vectorg2y[i] * 1000);
            }
            
            if (i == Int32.Parse(numeroElementos_tb.Text))
            {
                registrarSimulacion();
            }
        }

        private void registrarSimulacion() {

            cantSimulaciones -= 1;
            dataGridView1.Rows.Add();
            dataGridView1[0, index_row].Value = m1_tb.Text;

            dataGridView1[1, index_row].Value = m1_tb.Text;
            dataGridView1[2, index_row].Value = m2_tb.Text;
            dataGridView1[3, index_row].Value = k2_tb.Text;
            dataGridView1[4, index_row].Value = k1_tb.Text;
            dataGridView1[5, index_row].Value = g1TextFunction;
            dataGridView1[6, index_row].Value = g2TextFunction;
            //registrar imagen en la celda
            Bitmap captura_chart = new Bitmap(chart1.Width, chart1.Height);
            chart1.DrawToBitmap(captura_chart, chart1.DisplayRectangle);

            dataGridView1[7, index_row].Value = captura_chart;

            index_row += 1;

            cantSimulacionesTxt_lb.Text = "Simulaciones Ejecutadas: " + index_row.ToString();

            m1_tb.Text = (Int32.Parse(m1_tb.Text) * 2).ToString();

            chart1.Series["G1(s)"].Points.Clear();
            chart1.Series["G2(s)"].Points.Clear();

            if (cantSimulaciones > 0)
            {
                timer2.Enabled = true;
                finalizado = false;
            }
            else
            {
                resetearValores();
            
            }
            timer1.Enabled = false;
        }

        private void resetearValores() {

            button1.Enabled = true;
            finalizado = true;
            i = 0;
            vectorg1y = new double[10];
            vectorg2y = new double[10];
            vectort = new double[10];

            g1yinicial = masa1Pb.Location.Y;
            g2yinicial = masa2Pb.Location.Y;
            altoInicial = resorte_pb.Height;
            altoInicialk2 = resortek2_pb.Height;
            cantSimulaciones = Int32.Parse(cantidadSimulaciones_cb.SelectedItem.ToString());
            index_row = 0;

            respuestaAl = "step";

            m1_tb.Text = "100";
            m2_tb.Text = "200";
            k1_tb.Text = "2";
            k2_tb.Text = "10";
            b1_tb.Text = "1";
            numeroElementos_tb.Text = "1000";
            checkBox1.Checked = true;

        }

        private void restablecerPosiciones() {
            resorte_pb.Location = new Point(313, 55);
            resorte_pb.Size = new Size(54, 72);

            masa1Pb.Location = new Point(324, 122);
            masa1Pb.Size = new Size(54, 45);

            amortiguadorb1_pb.Location = new Point(318, 165);
            amortiguadorb1_pb.Size = new Size(54, 112);

            masa2Pb.Location = new Point(313, 270);
            masa2Pb.Size = new Size(151, 45);

            resortek2_pb.Location = new Point(406, 50);
            resortek2_pb.Size = new Size(58, 227);

            g1yinicial = masa1Pb.Location.Y;
            g2yinicial = masa2Pb.Location.Y;
            altoInicial = resorte_pb.Height;
            altoInicialk2 = resortek2_pb.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g1yinicial = masa1Pb.Location.Y;
            g2yinicial = masa2Pb.Location.Y;
            altoInicial = resorte_pb.Height;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.PerformClick();
            timer2.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(variable_cb.SelectedItem.ToString() == "resorte")
            {
                variable_lb.Text = "k1";
                resorte_pb.BackgroundImage = (Image)(Properties.Resources.k1_p);

                variable = "a1=m1*s^2+k1b2+b1*s;" +
                    "a2=b1*s;" +
                    "a3=m2*s^2+k2+b1*s;" +
                    "a4=b1*s;" +
                    "g1=(a2)/(a3*a1-a2^2);" +
                    "g2=a1/(a3*(a1-(a2^2)));";

            }
            if(variable_cb.SelectedItem.ToString() == "amortiguador")
            {
                variable_lb.Text = "b2";
                resorte_pb.BackgroundImage = (Image)(Properties.Resources.b2_p4);

                variable = "a1=m1*s^2+(k1b2*s)+b1*s;" +
                   "a2=b1*s;" +
                   "a3=m2*s^2+k2+k1b2*s;" +
                   "a4=k1b2*s;" +
                   "g1=(a4)/((a3*a1)-(a2*a4));" +
                   "g2=(a1)/(a3*(a1-(a2*a4)));";
            }
        }

        private void cantidadSimulaciones_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantSimulaciones = Convert.ToInt32(cantidadSimulaciones_cb.SelectedItem.ToString());
        }

        private void respuestaAl_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (respuestaAl_cb.SelectedItem.ToString() == "Paso")
            {
                respuestaAl = "step";
                chart1.Titles["Title Respuesta al paso"].Text = "Respuesta Al Paso";
            }
            if (respuestaAl_cb.SelectedItem.ToString() == "Impulso")
            {
                respuestaAl = "impulse";
                chart1.Titles["Title Respuesta al paso"].Text = "Respuesta Al Impulso";
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mostrarAnimaciones = true;
            }
            else {
                mostrarAnimaciones = false;
            }
        }

  

        private void amortiguadorb1_pb_Click(object sender, EventArgs e)
        {

        }
    }
}
