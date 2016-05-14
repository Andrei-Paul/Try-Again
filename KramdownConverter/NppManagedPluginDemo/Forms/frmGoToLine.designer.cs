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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viewKramdownHTML = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Go to line:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(15, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(480, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGoToLine_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(73, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGoToLine_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // viewKramdownHTML
            // 
            this.viewKramdownHTML.AllowNavigation = false;
            this.viewKramdownHTML.AllowWebBrowserDrop = false;
            this.viewKramdownHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewKramdownHTML.IsWebBrowserContextMenuEnabled = false;
            this.viewKramdownHTML.Location = new System.Drawing.Point(15, 61);
            this.viewKramdownHTML.MinimumSize = new System.Drawing.Size(20, 20);
            this.viewKramdownHTML.Name = "viewKramdownHTML";
            this.viewKramdownHTML.ScrollBarsEnabled = false;
            this.viewKramdownHTML.Size = new System.Drawing.Size(480, 316);
            this.viewKramdownHTML.TabIndex = 3;
            this.viewKramdownHTML.Url = new System.Uri("https://google.ro", System.UriKind.Absolute);
            this.viewKramdownHTML.WebBrowserShortcutsEnabled = false;
            // 
            // frmGoToLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 389);
            this.Controls.Add(this.viewKramdownHTML);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmGoToLine";
            this.Text = "NppDockableForm";
            this.VisibleChanged += new System.EventHandler(this.FrmGoToLineVisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGoToLine_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser viewKramdownHTML;
    }
}