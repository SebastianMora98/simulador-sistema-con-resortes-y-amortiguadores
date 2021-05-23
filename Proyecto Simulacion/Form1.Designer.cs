
namespace Proyecto_Simulacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.m1_tb = new System.Windows.Forms.TextBox();
            this.m2_tb = new System.Windows.Forms.TextBox();
            this.k1_tb = new System.Windows.Forms.TextBox();
            this.m1 = new System.Windows.Forms.Label();
            this.m2 = new System.Windows.Forms.Label();
            this.variable_lb = new System.Windows.Forms.Label();
            this.k2_tb = new System.Windows.Forms.TextBox();
            this.k2 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numeroElementos_tb = new System.Windows.Forms.TextBox();
            this.elementos_lb = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.intervalo_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.b1_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidadSimulaciones_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.variable_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.respuestaAl_cb = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cantSimulacionesTxt_lb = new System.Windows.Forms.Label();
            this.masa2Pb = new System.Windows.Forms.PictureBox();
            this.masa1Pb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.amortiguadorb1_pb = new System.Windows.Forms.PictureBox();
            this.resorte_pb = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.resortek2_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa2Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortiguadorb1_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resorte_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortek2_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // m1_tb
            // 
            this.m1_tb.Location = new System.Drawing.Point(39, 13);
            this.m1_tb.Name = "m1_tb";
            this.m1_tb.Size = new System.Drawing.Size(100, 20);
            this.m1_tb.TabIndex = 0;
            this.m1_tb.Text = "100";
            // 
            // m2_tb
            // 
            this.m2_tb.Location = new System.Drawing.Point(39, 39);
            this.m2_tb.Name = "m2_tb";
            this.m2_tb.Size = new System.Drawing.Size(100, 20);
            this.m2_tb.TabIndex = 0;
            this.m2_tb.Text = "200";
            // 
            // k1_tb
            // 
            this.k1_tb.ForeColor = System.Drawing.Color.Red;
            this.k1_tb.Location = new System.Drawing.Point(170, 13);
            this.k1_tb.Name = "k1_tb";
            this.k1_tb.Size = new System.Drawing.Size(100, 20);
            this.k1_tb.TabIndex = 0;
            this.k1_tb.Text = "2";
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Location = new System.Drawing.Point(12, 16);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(21, 13);
            this.m1.TabIndex = 1;
            this.m1.Text = "m1";
            // 
            // m2
            // 
            this.m2.AutoSize = true;
            this.m2.Location = new System.Drawing.Point(12, 42);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(21, 13);
            this.m2.TabIndex = 1;
            this.m2.Text = "m2";
            // 
            // variable_lb
            // 
            this.variable_lb.AutoSize = true;
            this.variable_lb.ForeColor = System.Drawing.Color.Red;
            this.variable_lb.Location = new System.Drawing.Point(145, 16);
            this.variable_lb.Name = "variable_lb";
            this.variable_lb.Size = new System.Drawing.Size(19, 13);
            this.variable_lb.TabIndex = 1;
            this.variable_lb.Text = "k1";
            // 
            // k2_tb
            // 
            this.k2_tb.Location = new System.Drawing.Point(170, 39);
            this.k2_tb.Name = "k2_tb";
            this.k2_tb.Size = new System.Drawing.Size(100, 20);
            this.k2_tb.TabIndex = 0;
            this.k2_tb.Text = "10";
            // 
            // k2
            // 
            this.k2.AutoSize = true;
            this.k2.Location = new System.Drawing.Point(145, 42);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(19, 13);
            this.k2.TabIndex = 1;
            this.k2.Text = "k2";
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Location = new System.Drawing.Point(12, 68);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(19, 13);
            this.b1.TabIndex = 1;
            this.b1.Text = "b1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnProcesar);
            // 
            // numeroElementos_tb
            // 
            this.numeroElementos_tb.Location = new System.Drawing.Point(170, 176);
            this.numeroElementos_tb.Name = "numeroElementos_tb";
            this.numeroElementos_tb.Size = new System.Drawing.Size(100, 20);
            this.numeroElementos_tb.TabIndex = 0;
            this.numeroElementos_tb.Text = "1000";
            // 
            // elementos_lb
            // 
            this.elementos_lb.AutoSize = true;
            this.elementos_lb.Location = new System.Drawing.Point(12, 179);
            this.elementos_lb.Name = "elementos_lb";
            this.elementos_lb.Size = new System.Drawing.Size(56, 13);
            this.elementos_lb.TabIndex = 1;
            this.elementos_lb.Text = "Elementos";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(497, 13);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "G1(s)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "G2(s)";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(455, 213);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title1.Name = "Title Respuesta al paso";
            title1.Text = "Respuesta Al Paso";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.DockedToChartArea = "ChartArea1";
            title2.Name = "Title y";
            title2.Text = "y";
            title3.Alignment = System.Drawing.ContentAlignment.BottomRight;
            title3.DockedToChartArea = "ChartArea1";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Name = "Title1";
            title3.Text = "t";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // intervalo_tb
            // 
            this.intervalo_tb.Location = new System.Drawing.Point(170, 202);
            this.intervalo_tb.Name = "intervalo_tb";
            this.intervalo_tb.Size = new System.Drawing.Size(100, 20);
            this.intervalo_tb.TabIndex = 0;
            this.intervalo_tb.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Intervalo Timer";
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // b1_tb
            // 
            this.b1_tb.Location = new System.Drawing.Point(39, 65);
            this.b1_tb.Name = "b1_tb";
            this.b1_tb.Size = new System.Drawing.Size(100, 20);
            this.b1_tb.TabIndex = 0;
            this.b1_tb.Text = "10";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(497, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(455, 243);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Masa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 58;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "m1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 46;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "m2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 46;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "k2";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 44;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "variable";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 69;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Función Transferencia (G1(s))";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 157;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Función Transferencia (G2(s))";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 157;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Respuesta Al Impulso";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad Simulaciones";
            // 
            // cantidadSimulaciones_cb
            // 
            this.cantidadSimulaciones_cb.FormattingEnabled = true;
            this.cantidadSimulaciones_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cantidadSimulaciones_cb.Location = new System.Drawing.Point(170, 122);
            this.cantidadSimulaciones_cb.Name = "cantidadSimulaciones_cb";
            this.cantidadSimulaciones_cb.Size = new System.Drawing.Size(100, 21);
            this.cantidadSimulaciones_cb.TabIndex = 9;
            this.cantidadSimulaciones_cb.Text = "1";
            this.cantidadSimulaciones_cb.SelectedIndexChanged += new System.EventHandler(this.cantidadSimulaciones_cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variable";
            // 
            // variable_cb
            // 
            this.variable_cb.ForeColor = System.Drawing.Color.Red;
            this.variable_cb.FormattingEnabled = true;
            this.variable_cb.Items.AddRange(new object[] {
            "resorte",
            "amortiguador"});
            this.variable_cb.Location = new System.Drawing.Point(170, 97);
            this.variable_cb.Name = "variable_cb";
            this.variable_cb.Size = new System.Drawing.Size(100, 21);
            this.variable_cb.TabIndex = 9;
            this.variable_cb.Text = "resorte";
            this.variable_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Respuesta Al";
            // 
            // respuestaAl_cb
            // 
            this.respuestaAl_cb.FormattingEnabled = true;
            this.respuestaAl_cb.Items.AddRange(new object[] {
            "Paso",
            "Impulso"});
            this.respuestaAl_cb.Location = new System.Drawing.Point(170, 149);
            this.respuestaAl_cb.Name = "respuestaAl_cb";
            this.respuestaAl_cb.Size = new System.Drawing.Size(100, 21);
            this.respuestaAl_cb.TabIndex = 9;
            this.respuestaAl_cb.Text = "Paso";
            this.respuestaAl_cb.SelectedIndexChanged += new System.EventHandler(this.respuestaAl_cb_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Mostrar Animaciones";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cantSimulacionesTxt_lb
            // 
            this.cantSimulacionesTxt_lb.AutoSize = true;
            this.cantSimulacionesTxt_lb.Location = new System.Drawing.Point(293, 13);
            this.cantSimulacionesTxt_lb.Name = "cantSimulacionesTxt_lb";
            this.cantSimulacionesTxt_lb.Size = new System.Drawing.Size(131, 13);
            this.cantSimulacionesTxt_lb.TabIndex = 12;
            this.cantSimulacionesTxt_lb.Text = "Simulaciones Ejecutadas: ";
            // 
            // masa2Pb
            // 
            this.masa2Pb.BackColor = System.Drawing.Color.Red;
            this.masa2Pb.Image = global::Proyecto_Simulacion.Properties.Resources.masa2;
            this.masa2Pb.Location = new System.Drawing.Point(313, 270);
            this.masa2Pb.Name = "masa2Pb";
            this.masa2Pb.Size = new System.Drawing.Size(151, 45);
            this.masa2Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.masa2Pb.TabIndex = 4;
            this.masa2Pb.TabStop = false;
            // 
            // masa1Pb
            // 
            this.masa1Pb.BackColor = System.Drawing.Color.Yellow;
            this.masa1Pb.Image = global::Proyecto_Simulacion.Properties.Resources.masa1;
            this.masa1Pb.Location = new System.Drawing.Point(324, 122);
            this.masa1Pb.Name = "masa1Pb";
            this.masa1Pb.Size = new System.Drawing.Size(54, 45);
            this.masa1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.masa1Pb.TabIndex = 4;
            this.masa1Pb.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(313, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 19);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // amortiguadorb1_pb
            // 
            this.amortiguadorb1_pb.BackColor = System.Drawing.Color.Gray;
            this.amortiguadorb1_pb.BackgroundImage = global::Proyecto_Simulacion.Properties.Resources.b1_p;
            this.amortiguadorb1_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.amortiguadorb1_pb.Image = global::Proyecto_Simulacion.Properties.Resources.b1_p3;
            this.amortiguadorb1_pb.Location = new System.Drawing.Point(318, 165);
            this.amortiguadorb1_pb.Name = "amortiguadorb1_pb";
            this.amortiguadorb1_pb.Size = new System.Drawing.Size(54, 112);
            this.amortiguadorb1_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amortiguadorb1_pb.TabIndex = 6;
            this.amortiguadorb1_pb.TabStop = false;
            // 
            // resorte_pb
            // 
            this.resorte_pb.BackColor = System.Drawing.Color.Transparent;
            this.resorte_pb.BackgroundImage = global::Proyecto_Simulacion.Properties.Resources.k1;
            this.resorte_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resorte_pb.Location = new System.Drawing.Point(313, 55);
            this.resorte_pb.Name = "resorte_pb";
            this.resorte_pb.Size = new System.Drawing.Size(54, 72);
            this.resorte_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resorte_pb.TabIndex = 6;
            this.resorte_pb.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Simulacion.Properties.Resources.image3;
            this.pictureBox3.Location = new System.Drawing.Point(70, 303);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 178);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // resortek2_pb
            // 
            this.resortek2_pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resortek2_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resortek2_pb.Image = global::Proyecto_Simulacion.Properties.Resources.k2_p;
            this.resortek2_pb.Location = new System.Drawing.Point(406, 50);
            this.resortek2_pb.Name = "resortek2_pb";
            this.resortek2_pb.Size = new System.Drawing.Size(58, 227);
            this.resortek2_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resortek2_pb.TabIndex = 6;
            this.resortek2_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 493);
            this.Controls.Add(this.masa2Pb);
            this.Controls.Add(this.masa1Pb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.amortiguadorb1_pb);
            this.Controls.Add(this.resorte_pb);
            this.Controls.Add(this.cantSimulacionesTxt_lb);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.variable_cb);
            this.Controls.Add(this.respuestaAl_cb);
            this.Controls.Add(this.cantidadSimulaciones_cb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resortek2_pb);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elementos_lb);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.k2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.variable_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.numeroElementos_tb);
            this.Controls.Add(this.b1_tb);
            this.Controls.Add(this.k2_tb);
            this.Controls.Add(this.intervalo_tb);
            this.Controls.Add(this.k1_tb);
            this.Controls.Add(this.m2_tb);
            this.Controls.Add(this.m1_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa2Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masa1Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortiguadorb1_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resorte_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortek2_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m1_tb;
        private System.Windows.Forms.TextBox m2_tb;
        private System.Windows.Forms.TextBox k1_tb;
        private System.Windows.Forms.Label m1;
        private System.Windows.Forms.Label m2;
        private System.Windows.Forms.Label variable_lb;
        private System.Windows.Forms.TextBox k2_tb;
        private System.Windows.Forms.Label k2;
        private System.Windows.Forms.Label b1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numeroElementos_tb;
        private System.Windows.Forms.Label elementos_lb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox masa1Pb;
        private System.Windows.Forms.PictureBox masa2Pb;
        private System.Windows.Forms.PictureBox amortiguadorb1_pb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox intervalo_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox resorte_pb;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox b1_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cantidadSimulaciones_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox variable_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox respuestaAl_cb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label cantSimulacionesTxt_lb;
        private System.Windows.Forms.PictureBox resortek2_pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}

