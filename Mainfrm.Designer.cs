namespace HtmlGenerator
{
	partial class Mainfrm
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
			this.lblFindPath = new System.Windows.Forms.Label();
			this.txtFindPath = new System.Windows.Forms.TextBox();
			this.btnFindPath = new System.Windows.Forms.Button();
			this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.lblPageName = new System.Windows.Forms.Label();
			this.txtPageName = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.lblElement = new System.Windows.Forms.Label();
			this.droplistElements = new System.Windows.Forms.ComboBox();
			this.lblContent = new System.Windows.Forms.Label();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.gbElements = new System.Windows.Forms.GroupBox();
			this.btnPreviewCode = new System.Windows.Forms.Button();
			this.btnPreview = new System.Windows.Forms.Button();
			this.listViewElements = new System.Windows.Forms.ListView();
			this.elementType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.openFileImage = new System.Windows.Forms.OpenFileDialog();
			this.btnImage = new System.Windows.Forms.Button();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.addColor = new System.Windows.Forms.Button();
			this.gbElements.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFindPath
			// 
			this.lblFindPath.AutoSize = true;
			this.lblFindPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFindPath.Location = new System.Drawing.Point(22, 23);
			this.lblFindPath.Name = "lblFindPath";
			this.lblFindPath.Size = new System.Drawing.Size(70, 16);
			this.lblFindPath.TabIndex = 0;
			this.lblFindPath.Text = "Find Path: ";
			// 
			// txtFindPath
			// 
			this.txtFindPath.Location = new System.Drawing.Point(116, 20);
			this.txtFindPath.Name = "txtFindPath";
			this.txtFindPath.Size = new System.Drawing.Size(578, 20);
			this.txtFindPath.TabIndex = 1;
			// 
			// btnFindPath
			// 
			this.btnFindPath.Location = new System.Drawing.Point(700, 18);
			this.btnFindPath.Name = "btnFindPath";
			this.btnFindPath.Size = new System.Drawing.Size(88, 23);
			this.btnFindPath.TabIndex = 2;
			this.btnFindPath.Text = "...";
			this.btnFindPath.UseVisualStyleBackColor = true;
			this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
			// 
			// lblPageName
			// 
			this.lblPageName.AutoSize = true;
			this.lblPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPageName.Location = new System.Drawing.Point(22, 64);
			this.lblPageName.Name = "lblPageName";
			this.lblPageName.Size = new System.Drawing.Size(87, 16);
			this.lblPageName.TabIndex = 3;
			this.lblPageName.Text = "Page Name: ";
			// 
			// txtPageName
			// 
			this.txtPageName.Location = new System.Drawing.Point(116, 61);
			this.txtPageName.Name = "txtPageName";
			this.txtPageName.Size = new System.Drawing.Size(347, 20);
			this.txtPageName.TabIndex = 4;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(22, 106);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(40, 16);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "Tittle:";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(116, 103);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(347, 20);
			this.txtTitle.TabIndex = 6;
			// 
			// lblElement
			// 
			this.lblElement.AutoSize = true;
			this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblElement.Location = new System.Drawing.Point(22, 150);
			this.lblElement.Name = "lblElement";
			this.lblElement.Size = new System.Drawing.Size(95, 16);
			this.lblElement.TabIndex = 7;
			this.lblElement.Text = "Element Type:";
			// 
			// droplistElements
			// 
			this.droplistElements.FormattingEnabled = true;
			this.droplistElements.Items.AddRange(new object[] {
            "Heading1",
            "Heading2",
            "Heading3",
            "Paragraph",
            "Image",
            "Hyperlink"});
			this.droplistElements.Location = new System.Drawing.Point(116, 147);
			this.droplistElements.Name = "droplistElements";
			this.droplistElements.Size = new System.Drawing.Size(241, 21);
			this.droplistElements.TabIndex = 8;
			this.droplistElements.SelectedIndexChanged += new System.EventHandler(this.droplistElements_SelectedIndexChanged);
			// 
			// lblContent
			// 
			this.lblContent.AutoSize = true;
			this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContent.Location = new System.Drawing.Point(22, 182);
			this.lblContent.Name = "lblContent";
			this.lblContent.Size = new System.Drawing.Size(56, 16);
			this.lblContent.TabIndex = 9;
			this.lblContent.Text = "Content:";
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(25, 207);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtContent.Size = new System.Drawing.Size(438, 126);
			this.txtContent.TabIndex = 10;
			// 
			// gbElements
			// 
			this.gbElements.Controls.Add(this.btnPreviewCode);
			this.gbElements.Controls.Add(this.btnPreview);
			this.gbElements.Controls.Add(this.listViewElements);
			this.gbElements.Controls.Add(this.btnRemove);
			this.gbElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbElements.Location = new System.Drawing.Point(484, 61);
			this.gbElements.Name = "gbElements";
			this.gbElements.Size = new System.Drawing.Size(304, 320);
			this.gbElements.TabIndex = 11;
			this.gbElements.TabStop = false;
			this.gbElements.Text = "Elements to add:";
			// 
			// btnPreviewCode
			// 
			this.btnPreviewCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPreviewCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPreviewCode.Location = new System.Drawing.Point(87, 278);
			this.btnPreviewCode.Name = "btnPreviewCode";
			this.btnPreviewCode.Size = new System.Drawing.Size(104, 36);
			this.btnPreviewCode.TabIndex = 15;
			this.btnPreviewCode.Text = "Preview HTML";
			this.btnPreviewCode.UseVisualStyleBackColor = false;
			this.btnPreviewCode.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// btnPreview
			// 
			this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPreview.Location = new System.Drawing.Point(197, 278);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(101, 36);
			this.btnPreview.TabIndex = 14;
			this.btnPreview.Text = "Preview Page";
			this.btnPreview.UseVisualStyleBackColor = false;
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// listViewElements
			// 
			this.listViewElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.elementType,
            this.colContent});
			this.listViewElements.Location = new System.Drawing.Point(0, 25);
			this.listViewElements.Name = "listViewElements";
			this.listViewElements.Size = new System.Drawing.Size(292, 247);
			this.listViewElements.TabIndex = 0;
			this.listViewElements.UseCompatibleStateImageBehavior = false;
			this.listViewElements.View = System.Windows.Forms.View.Details;
			// 
			// elementType
			// 
			this.elementType.Text = "Element Type";
			this.elementType.Width = 87;
			// 
			// colContent
			// 
			this.colContent.Text = "Content";
			this.colContent.Width = 201;
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.Tomato;
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(6, 278);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 36);
			this.btnRemove.TabIndex = 13;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(377, 339);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(86, 36);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Maroon;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(12, 402);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(361, 36);
			this.btnExit.TabIndex = 14;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnGenerate
			// 
			this.btnGenerate.BackColor = System.Drawing.Color.DarkGreen;
			this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.ForeColor = System.Drawing.Color.White;
			this.btnGenerate.Location = new System.Drawing.Point(427, 402);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(361, 36);
			this.btnGenerate.TabIndex = 15;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = false;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// openFileImage
			// 
			this.openFileImage.FileName = "openFileImage";
			// 
			// btnImage
			// 
			this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImage.Location = new System.Drawing.Point(333, 219);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(99, 28);
			this.btnImage.TabIndex = 16;
			this.btnImage.Text = "Find Image Path";
			this.btnImage.UseVisualStyleBackColor = false;
			this.btnImage.Visible = false;
			this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
			// 
			// addColor
			// 
			this.addColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.addColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addColor.Location = new System.Drawing.Point(377, 145);
			this.addColor.Name = "addColor";
			this.addColor.Size = new System.Drawing.Size(86, 36);
			this.addColor.TabIndex = 17;
			this.addColor.Text = " Add Color";
			this.addColor.UseVisualStyleBackColor = false;
			this.addColor.Visible = false;
			this.addColor.Click += new System.EventHandler(this.button1_Click);
			// 
			// Mainfrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addColor);
			this.Controls.Add(this.btnImage);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.gbElements);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.lblContent);
			this.Controls.Add(this.droplistElements);
			this.Controls.Add(this.lblElement);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.txtPageName);
			this.Controls.Add(this.lblPageName);
			this.Controls.Add(this.btnFindPath);
			this.Controls.Add(this.txtFindPath);
			this.Controls.Add(this.lblFindPath);
			this.Name = "Mainfrm";
			this.Text = "Landing Page";
			this.gbElements.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFindPath;
		private System.Windows.Forms.TextBox txtFindPath;
		private System.Windows.Forms.Button btnFindPath;
		private System.Windows.Forms.FolderBrowserDialog folderDialog;
		private System.Windows.Forms.Label lblPageName;
		private System.Windows.Forms.TextBox txtPageName;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label lblElement;
		private System.Windows.Forms.ComboBox droplistElements;
		private System.Windows.Forms.Label lblContent;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.GroupBox gbElements;
		private System.Windows.Forms.ListView listViewElements;
		private System.Windows.Forms.ColumnHeader elementType;
		private System.Windows.Forms.ColumnHeader colContent;
		private System.Windows.Forms.Button btnPreview;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.OpenFileDialog openFileImage;
		private System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.Button btnPreviewCode;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Button addColor;
	}
}

