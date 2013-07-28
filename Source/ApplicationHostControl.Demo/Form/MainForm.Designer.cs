namespace ApplicationHostControl.Demo
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
			this.btnUnLoad = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.applicationHost1 = new ApplicationHostControl.ApplicationHost();
			this.SuspendLayout();
			// 
			// btnUnLoad
			// 
			this.btnUnLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnUnLoad.Location = new System.Drawing.Point(0, 325);
			this.btnUnLoad.Name = "btnUnLoad";
			this.btnUnLoad.Size = new System.Drawing.Size(393, 32);
			this.btnUnLoad.TabIndex = 1;
			this.btnUnLoad.Text = "UnLoad";
			this.btnUnLoad.UseVisualStyleBackColor = true;
			this.btnUnLoad.Click += new System.EventHandler(this.btnUnLoad_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnLoad.Location = new System.Drawing.Point(0, 293);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(393, 32);
			this.btnLoad.TabIndex = 2;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// applicationHost1
			// 
			this.applicationHost1.Arguments = "";
			this.applicationHost1.AutoLoadProcess = true;
			this.applicationHost1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.applicationHost1.File = "";
			this.applicationHost1.HideApplicationTitleBar = false;
			this.applicationHost1.Location = new System.Drawing.Point(0, 0);
			this.applicationHost1.Name = "applicationHost1";
			this.applicationHost1.Size = new System.Drawing.Size(393, 293);
			this.applicationHost1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 357);
			this.Controls.Add(this.applicationHost1);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnUnLoad);
			this.Name = "Form1";
			this.Text = "ApplicationHostControl Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ApplicationHost applicationHost1;
		private System.Windows.Forms.Button btnUnLoad;
		private System.Windows.Forms.Button btnLoad;
	}
}

