using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlGenerator
{
	public partial class frmWebBrowser : Form
	{
		public frmWebBrowser(String HTML)
		{
			InitializeComponent();

			Browser.DocumentText = HTML;
		}

	
		
	}
}
