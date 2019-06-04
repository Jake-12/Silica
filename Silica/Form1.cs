using XDevkit;
using JRPC_Client;
using DevExpress.XtraBars.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Silica
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        IXboxConsole xbox; 

        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            SkinHelper.InitSkinPopupMenu(SkinsLink);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (xbox.Connect(out xbox)){ //Connecting Console
                MessageBox.Show("Successfully Connected to Silica!");
                xbox.XNotify("Welcome to Silica (Beta)");
                xbox.XNotify("Created by Team Silica!");
                label1.ForeColor = Color.Green;
                label1.Text = "Status: Connected!";
                textEdit1.Text = "Kernal Version: " + xbox.GetKernalVersion();
                textEdit2.Text = "CPU Key: " + xbox.GetCPUKey();
                textEdit3.Text = "CPU Temperature: " + xbox.GetTemperature(JRPC.TemperatureType.CPU);
                textEdit4.Text = "GPU Temperature: " + xbox.GetTemperature(JRPC.TemperatureType.GPU);
                textEdit5.Text = "Motherboard Temperature: " + xbox.GetTemperature(JRPC.TemperatureType.MotherBoard);
                textEdit6.Text = "Xbox I.P Address: " + xbox.XboxIP();
            }else{
                MessageBox.Show("Error, Could not Locate Console!"); //This can be due to Neighborhood not installed, or JRPC2 not set as a plugin. 
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e){
            xbox.XNotify(" " + notify);
        }
    }
}
