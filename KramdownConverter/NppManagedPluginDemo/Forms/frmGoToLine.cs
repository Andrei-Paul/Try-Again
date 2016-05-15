using System;
using System.Windows.Forms;
using Kbg.NppPluginNET;

namespace Kbg.Demo.Namespace
{
	partial class frmGoToLine : Form
    {
        public frmGoToLine()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && (e.KeyChar != '\b')
                && (e.KeyChar != '\t')) 
                e.Handled = true;
        }
        
        void FrmGoToLineVisibleChanged(object sender, EventArgs e)
        {
        	if (!Visible)
        	{
                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_SETMENUITEMCHECK,
                                  PluginBase._funcItems.Items[Main.idFrmGotToLine]._cmdID, 0);
        	}
        }
    }
}
