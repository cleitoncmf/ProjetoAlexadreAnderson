﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projeto_Final
{
   public partial class Form1 : Form
{
    string RxString;
    string txt_Rec = string.Empty;

        List<string> TempList = new List<string>();

        string txt_List = string.Empty;

        int qtde_data = 0;
    
    public Form1()
    {
        InitializeComponent();
        getPortas();
        pictureBox1.Image = Image.FromFile("C:\\imagens\\bomba_desliga.png");
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        void getPortas()
        {
            string[] Portas = SerialPort.GetPortNames();
            cbPortas.Items.AddRange(Portas);
        }
        private void atualizaCom()
    {
        //Limpa todos os itens em cbPortas caso existam
        cbPortas.Items.Clear();

        /*Para cada nome de porta de comunicação serial identificado
         * serão atribuído à variável 's'*/
        foreach (string s in SerialPort.GetPortNames())
        {
            // adiciona a variável 's' a cada item de cbPortas
            cbPortas.Items.Add(s);
        }
        //Seleciona o item de índice 0 em cbPortas
        cbPortas.SelectedIndex = 0;
    }
    private void paridade()
    {
        int i = 0; //variável de controle de indice do combo

        //Limpa todos os itens em cb_paridade caso existam 
        cbParidade.Items.Clear();

        // Para cada nome de paridade identificado será atribuído 'a variável 's'
        foreach (string s in Enum.GetNames(typeof(Parity)))
        {
            //adiciona a variável 's' a cada item de cb_paridade
            cbParidade.Items.Add(s);
            /* verifica se o nome recebido é 'None',
             * caso seja, seleciona o seu índice para exibição*/
            if (s == "None")
                cbParidade.SelectedIndex = i;

            i++;  //incrementa a variável i
        }
    }
    private void bitsParada()
    {
        int i = 0; //variável de controle de índice do combo

        // Limpa todos os itens em cbBitsParada caso existam
        cbBitsParada.Items.Clear();

        //Cada nome de bits de parada identificado será atribuido à variável's'
        foreach (string str in Enum.GetNames(typeof(StopBits)))
        {
            //adiciona a variável 's' a cada item de cbBitsParada
            cbBitsParada.Items.Add(str);

            /*verifica se o nome recebido é 'One', caso seja, seleciona o seu índice para exibição*/
            if (str == "One") cbBitsParada.SelectedIndex = i;

            i++; //incrementa a variável i
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        atualizaCom();
        cbBaud.SelectedText = "9600";
        paridade();
        cbBitsDados.SelectedText = "8";
        bitsParada();

        btnFechar.Enabled = false;
        btnSair.Enabled = true;
        btnAbrir.Enabled = true;

        }
    private void btnAbrir_Click_1(object sender, EventArgs e)
    {
            if (Serial.IsOpen == true)
            {
                Serial.Close();
            }

        Serial.PortName = cbPortas.Text;
        Serial.BaudRate = Int32.Parse(cbBaud.Text);
        Serial.Parity = (Parity)cbParidade.SelectedIndex;
        Serial.DataBits = Int32.Parse(cbBitsDados.Text);
        Serial.StopBits = (StopBits)cbBitsParada.SelectedIndex;

        try
        {
            
            Serial.Open();
            progressBar.Value = 100;
            btnAbrir.Enabled = false;
            btnFechar.Enabled = true;
            btnSair.Enabled = false;
        }
        catch
        {
            MessageBox.Show("Não foi possível abrir a porta selecionada",
                             "ATENÇÂO",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);

            btnFechar.Enabled = false;
            btnAbrir.Enabled = true;
            btnSair.Enabled = false;
        }
    }
    private void btnFechar_Click(object sender, EventArgs e)
    {
        Serial.Close();
        progressBar.Value = 0;
        btnFechar.Enabled = false;
        btnSair.Enabled = true;
        btnAbrir.Enabled = true;
    }
    private void btnSair_Click_1(object sender, EventArgs e)
    {
        Serial.Close();
        Close();
    }
    private void btnEnviar_Click_1(object sender, EventArgs e)
    {
        if (Serial.IsOpen)
        {
            Serial.Write(txtTransmite.Text + "\r\n");
            txtTransmite.Text = "";
         }
    }
    private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        RxString = Serial.ReadExisting();
        /*chama outra thread para escrever o dado em alguma posição do Formulário*/
        this.Invoke(new EventHandler(trataDadoRecebido));
    }
    private void trataDadoRecebido(object sender, EventArgs e)
    {
           int rpm = 0;

        txtRecebe.Text += RxString;
        txt_Rec += RxString;

            if (txt_Rec.Length >= 8)
            {
                if(txt_Rec.Substring(0,1) == "A")
                {
                    lblLeitura.Text = txt_Rec.Substring(4, 4);
                    txt_List = txt_Rec.Substring(0, 8);
                    
                    rpm = Convert.ToInt32(txt_Rec.Substring(4, 4));
                    aGadc.Value = (Formula * 3000 ) / 1023;
                    lblLeitura.Text = aGadc.Value.ToString() + "rpm";
                }
                txt_Rec = string.Empty;
            }

    }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\imagens\\bomba_liga.png");            
  
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if(Serial.IsOpen)
            {
                Serial.Write("IN000000\r");
                tmrApp.Enabled = true;
            }

        }

        private void ptbPerfil_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\imagens\\bomba_desliga.png");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (Serial.IsOpen)
            {
                Serial.Write("FN000000\r");
                tmrApp.Enabled = false;
            }
        }

        private void tmrApp_Tick(object sender, EventArgs e)
        {
            TempList.Add(DateTime.Now + "-" + txt_List);
            qtde_data++;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter Arq;

            try
            {
                if (svArquivo.ShowDialog() == DialogResult.OK)
                {
                    Arq = File.AppendText(svArquivo.FileName);

                    for (int i = 0; i < qtde_data; i++)
                        Arq.WriteLine(TempList[i]);

                    Arq.Close();
                }

                MessageBox.Show("Cadastro realizado com sucesso!");

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void aGauge_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }
    }
    }
