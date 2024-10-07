namespace lab4
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            toolStrip1 = new ToolStrip();
            btnADD = new ToolStripButton();
            btnEDIT = new ToolStripButton();
            separator1 = new ToolStripSeparator();
            btnDEL = new ToolStripButton();
            btnCLEAR = new ToolStripButton();
            separator2 = new ToolStripSeparator();
            btnEXIT = new ToolStripButton();
            bindSRCDOC = new BindingSource(components);
            gvPerson = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindSRCDOC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvPerson).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnADD, btnEDIT, separator1, btnDEL, btnCLEAR, separator2, btnEXIT });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(892, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnADD
            // 
            btnADD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnADD.Image = (Image)resources.GetObject("btnADD.Image");
            btnADD.ImageTransparentColor = Color.Magenta;
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(29, 24);
            btnADD.Text = "Додати запис про персону";
            btnADD.Click += btnADD_Click;
            // 
            // btnEDIT
            // 
            btnEDIT.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEDIT.Image = (Image)resources.GetObject("btnEDIT.Image");
            btnEDIT.ImageTransparentColor = Color.Magenta;
            btnEDIT.Name = "btnEDIT";
            btnEDIT.Size = new Size(29, 24);
            btnEDIT.Text = "Редагувати запис";
            btnEDIT.Click += btnEDIT_Click;
            // 
            // separator1
            // 
            separator1.Name = "separator1";
            separator1.Size = new Size(6, 27);
            // 
            // btnDEL
            // 
            btnDEL.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDEL.Image = (Image)resources.GetObject("btnDEL.Image");
            btnDEL.ImageTransparentColor = Color.Magenta;
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(29, 24);
            btnDEL.Text = "Видалити запис";
            btnDEL.Click += btnDEL_Click;
            // 
            // btnCLEAR
            // 
            btnCLEAR.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCLEAR.Image = (Image)resources.GetObject("btnCLEAR.Image");
            btnCLEAR.ImageTransparentColor = Color.Magenta;
            btnCLEAR.Name = "btnCLEAR";
            btnCLEAR.Size = new Size(29, 24);
            btnCLEAR.Text = "Очистити дані";
            btnCLEAR.Click += btnCLEAR_Click;
            // 
            // separator2
            // 
            separator2.Name = "separator2";
            separator2.Size = new Size(6, 27);
            // 
            // btnEXIT
            // 
            btnEXIT.Alignment = ToolStripItemAlignment.Right;
            btnEXIT.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEXIT.Image = (Image)resources.GetObject("btnEXIT.Image");
            btnEXIT.ImageTransparentColor = Color.Magenta;
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(29, 24);
            btnEXIT.Text = "Вийти з програми";
            btnEXIT.Click += btnEXIT_Click;
            // 
            // gvPerson
            // 
            gvPerson.AllowUserToAddRows = false;
            gvPerson.AllowUserToDeleteRows = false;
            gvPerson.AutoGenerateColumns = false;
            gvPerson.BackgroundColor = SystemColors.AppWorkspace;
            gvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvPerson.DataSource = bindSRCDOC;
            gvPerson.Dock = DockStyle.Fill;
            gvPerson.Location = new Point(0, 27);
            gvPerson.Margin = new Padding(3, 4, 3, 4);
            gvPerson.Name = "gvPerson";
            gvPerson.ReadOnly = true;
            gvPerson.RowHeadersWidth = 51;
            gvPerson.Size = new Size(892, 461);
            gvPerson.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 488);
            ControlBox = false;
            Controls.Add(gvPerson);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота 4";
            Load += FORMMAIN_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindSRCDOC).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnADD;
        private ToolStripButton btnEDIT;
        private ToolStripSeparator separator1;
        private ToolStripButton btnDEL;
        private ToolStripButton btnCLEAR;
        private ToolStripSeparator separator2;
        private ToolStripButton btnEXIT;
        private BindingSource bindSRCDOC;
        private DataGridView gvPerson;
    }
}
