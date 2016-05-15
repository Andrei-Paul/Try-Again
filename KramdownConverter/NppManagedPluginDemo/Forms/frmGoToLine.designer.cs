namespace Kbg.Demo.Namespace
{
	partial class frmGoToLine
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
            this.viewKramdownHTML = new System.Windows.Forms.WebBrowser();
            this.viewKramdownHTML.DocumentText = "<h4>Converted text</h4>";
            this.SuspendLayout();
            // 
            // viewKramdownHTML
            // 
            this.viewKramdownHTML.AllowNavigation = false;
            this.viewKramdownHTML.AllowWebBrowserDrop = false;
            this.viewKramdownHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewKramdownHTML.IsWebBrowserContextMenuEnabled = false;
            this.viewKramdownHTML.Location = new System.Drawing.Point(20, 22);
            this.viewKramdownHTML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewKramdownHTML.MinimumSize = new System.Drawing.Size(27, 25);
            this.viewKramdownHTML.Name = "viewKramdownHTML";
            this.viewKramdownHTML.ScrollBarsEnabled = false;
            this.viewKramdownHTML.Size = new System.Drawing.Size(640, 442);
            this.viewKramdownHTML.TabIndex = 3;
            this.viewKramdownHTML.WebBrowserShortcutsEnabled = false;
            // 
            // frmGoToLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 479);
            this.Controls.Add(this.viewKramdownHTML);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGoToLine";
            this.Text = "NppDockableForm";
            this.VisibleChanged += new System.EventHandler(this.FrmGoToLineVisibleChanged);
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.WebBrowser viewKramdownHTML;
    }
}