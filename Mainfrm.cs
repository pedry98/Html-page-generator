using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HtmlGenerator
{
	public partial class Mainfrm : Form
	{


		public Mainfrm()
		{
			InitializeComponent();
		}

		private void btnFindPath_Click(object sender, EventArgs e)
		{
			folderDialog.ShowDialog();
			txtFindPath.Text = folderDialog.SelectedPath;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				listViewElements.SelectedItems[0].Remove();
			}
			catch
			{
				MessageBox.Show("Removal Error! Please check if an item was selected!");
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(droplistElements.Text ==  "" || txtContent.Text == "")
			{
				MessageBox.Show("Please enter information before proceeding!");
				return;
			}
				
		

			//add element to the list
			ListViewItem litem = new ListViewItem(droplistElements.Text);
			litem.SubItems.Add(txtContent.Text);
			listViewElements.Items.Add(litem);

			clear_fields();
			addColor.Visible = false;
		}
		/// <summary>
		/// clears GUI
		/// </summary>
		private void clear_fields()
		{
			txtContent.Text = "";
			droplistElements.Text = "";
			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?","", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Application.Exit();
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}
			
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			try
			{
				if (listViewElements.Items.Count == 0)
					throw new Exception("List must have at least one element.");

				if (txtFindPath.Text == "")
					throw new Exception("Please select a file path");

				if (txtPageName.Text == "")
					throw new Exception("Please enter a page name");

				if (txtTitle.Text == "")
					throw new Exception("Please select a title");

				StreamWriter stream = new StreamWriter(txtFindPath.Text + "\\" + txtPageName.Text + ".html", false);
				stream.Write(create_HTML());
				stream.Close();

				MessageBox.Show("File Created!!!");

				clear_fields();
				txtFindPath.Text = "";
				txtPageName.Text = "";
				txtTitle.Text = "";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private String create_HTML()
		{
			StringBuilder HTML = new StringBuilder();
			try
			{
				//Open the HTML structure
				HTML.Append("<!DOCTYPE html>"+ Environment.NewLine);
				HTML.Append("<html>" + Environment.NewLine);
				HTML.Append("<head>" + Environment.NewLine);
				HTML.Append("\t<title>" + txtTitle.Text + "</title>" + Environment.NewLine);
				HTML.Append("</head>" + Environment.NewLine);

				//Add Body Elements
				HTML.Append("<body>" + Environment.NewLine);

				//If a color was selected append style to HTML inside the body
				if (colorDialog.Color.Name != "")
					HTML.Append("<style> .colortext { color: " + colorDialog.Color.Name + "; } </style>" + Environment.NewLine);

				foreach(ListViewItem item in listViewElements.Items)
				{
					switch(item.Text)
					{
						case "Heading1":
							HTML.Append("\t<h1 class = \"colortext\">" + item.SubItems[1].Text + "</h1>" + Environment.NewLine);
							break;
						case "Heading2":
							HTML.Append("\t<h2>" + item.SubItems[1].Text + "</h2>" + Environment.NewLine);
							break;
						case "Heading3":
							HTML.Append("\t<h3>" + item.SubItems[1].Text + "</h3>" + Environment.NewLine);
							break;
						case "Paragraph":
							HTML.Append("\t<p1>" + item.SubItems[1].Text + "</p1>" + Environment.NewLine);
							break;
						case "Image":
							HTML.Append("\t<img src = '" + item.SubItems[1].Text + "'>" + Environment.NewLine);
							break;
						case "Hyperlink":
							HTML.Append("\t<a href= "+ item.SubItems[1].Text + ">Click here to visit</a>" + Environment.NewLine);
							break;
						default:
							break;
						
					}
				}

				//Close HTML
				HTML.Append("</body>" + Environment.NewLine);
				HTML.Append("</html>" + Environment.NewLine);

				//return HTML string
				return HTML.ToString();
			}
			catch
			{
				return "";
			}
		}

		private void btnPreview_Click(object sender, EventArgs e)
		{
			frmWebBrowser browser = new frmWebBrowser(create_HTML());
			browser.ShowDialog();
		}

		private void btnImage_Click(object sender, EventArgs e)
		{
			openFileImage.ShowDialog();
			txtContent.Text = openFileImage.FileName;
		}

		private void droplistElements_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(droplistElements.Text == "Image")
			{
				btnImage.Visible = true;
			}else
			{
				btnImage.Visible = false;
			}
			//I could only make it work for one of the headings
			if (droplistElements.Text == "Heading1")
			{
				addColor.Visible = true;
			}else
			{
				addColor.Visible = false;
			}
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			MessageBox.Show(create_HTML());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//open color dialog
			colorDialog.ShowDialog();
		}

		
	}


}
