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


    }
}
