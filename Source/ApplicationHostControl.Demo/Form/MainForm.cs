using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationHostControl.Demo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			applicationHost1.File = "calc.exe";
			applicationHost1.HideApplicationTitleBar = true;
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			applicationHost1.LoadProcess();
		}

		private void btnUnLoad_Click(object sender, EventArgs e)
		{
			applicationHost1.UnloadProcess();
		}
	}
}
