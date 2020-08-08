namespace Projeto_Final
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRecebe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtTransmite = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBitsParada = new System.Windows.Forms.ComboBox();
            this.cbBitsDados = new System.Windows.Forms.ComboBox();
            this.cbParidade = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lb_velocidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 633);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnSair);
            this.tabPage1.Controls.Add(this.btnFechar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnAbrir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(844, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(668, 4);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRecebe);
            this.groupBox3.Location = new System.Drawing.Point(18, 293);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(724, 292);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recepção";
            // 
            // txtRecebe
            // 
            this.txtRecebe.Location = new System.Drawing.Point(14, 22);
            this.txtRecebe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRecebe.Multiline = true;
            this.txtRecebe.Name = "txtRecebe";
            this.txtRecebe.Size = new System.Drawing.Size(693, 252);
            this.txtRecebe.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Controls.Add(this.txtTransmite);
            this.groupBox2.Location = new System.Drawing.Point(18, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(724, 115);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transmissão";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(621, 67);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(86, 34);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // txtTransmite
            // 
            this.txtTransmite.Location = new System.Drawing.Point(14, 22);
            this.txtTransmite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTransmite.Name = "txtTransmite";
            this.txtTransmite.Size = new System.Drawing.Size(693, 20);
            this.txtTransmite.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(753, 532);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 34);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(746, 99);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 34);
            this.btnFechar.TabIndex = 25;
            this.btnFechar.Text = "FECHAR PORTA";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbBitsParada);
            this.groupBox1.Controls.Add(this.cbBitsDados);
            this.groupBox1.Controls.Add(this.cbParidade);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.cbPortas);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.lb_velocidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(724, 133);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "BIT DE PARADA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "BITS DE DADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "PARIDADE";
            // 
            // cbBitsParada
            // 
            this.cbBitsParada.FormattingEnabled = true;
            this.cbBitsParada.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cbBitsParada.Location = new System.Drawing.Point(609, 86);
            this.cbBitsParada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBitsParada.Name = "cbBitsParada";
            this.cbBitsParada.Size = new System.Drawing.Size(98, 21);
            this.cbBitsParada.TabIndex = 25;
            // 
            // cbBitsDados
            // 
            this.cbBitsDados.FormattingEnabled = true;
            this.cbBitsDados.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbBitsDados.Location = new System.Drawing.Point(463, 86);
            this.cbBitsDados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBitsDados.Name = "cbBitsDados";
            this.cbBitsDados.Size = new System.Drawing.Size(98, 21);
            this.cbBitsDados.TabIndex = 24;
            // 
            // cbParidade
            // 
            this.cbParidade.FormattingEnabled = true;
            this.cbParidade.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParidade.Location = new System.Drawing.Point(316, 86);
            this.cbParidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbParidade.Name = "cbParidade";
            this.cbParidade.Size = new System.Drawing.Size(98, 21);
            this.cbParidade.TabIndex = 23;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbBaud.Location = new System.Drawing.Point(166, 86);
            this.cbBaud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(98, 21);
            this.cbBaud.TabIndex = 22;
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Location = new System.Drawing.Point(14, 86);
            this.cbPortas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(98, 21);
            this.cbPortas.TabIndex = 21;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 36);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(254, 19);
            this.progressBar.TabIndex = 20;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // lb_velocidade
            // 
            this.lb_velocidade.AutoSize = true;
            this.lb_velocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_velocidade.Location = new System.Drawing.Point(176, 70);
            this.lb_velocidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_velocidade.Name = "lb_velocidade";
            this.lb_velocidade.Size = new System.Drawing.Size(85, 13);
            this.lb_velocidade.TabIndex = 19;
            this.lb_velocidade.Text = "VELOCIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "PORTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "STATUS COM SERIAL";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(746, 53);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(86, 34);
            this.btnAbrir.TabIndex = 24;
            this.btnAbrir.Text = "ABRIR PORTA";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(844, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motor de Indução";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePicker3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(844, 607);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gráfico da Tensão";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dateTimePicker4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(844, 607);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gráfico da Corrente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Serial
            // 
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_DataReceived);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dateTimePicker5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(844, 607);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Gráfico da Velocidade";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(668, 4);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(668, 4);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker3.TabIndex = 31;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(668, 4);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker4.TabIndex = 31;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(668, 5);
            this.dateTimePicker5.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker5.TabIndex = 31;
            this.dateTimePicker5.Value = new System.DateTime(2020, 8, 7, 20, 55, 51, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 631);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Supervisório";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRecebe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtTransmite;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBitsParada;
        private System.Windows.Forms.ComboBox cbBitsDados;
        private System.Windows.Forms.ComboBox cbParidade;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lb_velocidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
    }
}

