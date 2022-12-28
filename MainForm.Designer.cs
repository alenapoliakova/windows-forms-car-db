namespace lab_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.carBrandDataGridView = new System.Windows.Forms.DataGridView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horsepower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXMLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveXMLFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.carListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaderProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.FirstTimer = new System.Windows.Forms.Timer(this.components);
            this.carBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carBrandDataGridView)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carBrandDataGridView
            // 
            this.carBrandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carBrandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carBrandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.ModelName,
            this.Horsepower,
            this.MaxSpeed,
            this.Type});
            this.carBrandDataGridView.Location = new System.Drawing.Point(22, 164);
            this.carBrandDataGridView.Name = "carBrandDataGridView";
            this.carBrandDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carBrandDataGridView.Size = new System.Drawing.Size(381, 182);
            this.carBrandDataGridView.TabIndex = 0;
            this.carBrandDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.carBrandDataGridView_RowPrePaint);
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // ModelName
            // 
            this.ModelName.DataPropertyName = "ModelName";
            this.ModelName.HeaderText = "Model Name";
            this.ModelName.Name = "ModelName";
            // 
            // Horsepower
            // 
            this.Horsepower.DataPropertyName = "Horsepower";
            this.Horsepower.HeaderText = "Horse power";
            this.Horsepower.Name = "Horsepower";
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.DataPropertyName = "MaxSpeed";
            this.MaxSpeed.HeaderText = "Max speed";
            this.MaxSpeed.Name = "MaxSpeed";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "car",
            "track"});
            this.Type.Name = "Type";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(862, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // OpenXMLFileDialog
            // 
            this.OpenXMLFileDialog.FileName = "CarBrands";
            // 
            // carListDataGridView
            // 
            this.carListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.carListDataGridView.Location = new System.Drawing.Point(457, 164);
            this.carListDataGridView.Name = "carListDataGridView";
            this.carListDataGridView.Size = new System.Drawing.Size(381, 182);
            this.carListDataGridView.TabIndex = 4;
            this.carListDataGridView.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "No name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "No name";
            this.Column3.Name = "Column3";
            // 
            // LoaderProgressBar
            // 
            this.LoaderProgressBar.Location = new System.Drawing.Point(493, 261);
            this.LoaderProgressBar.Name = "LoaderProgressBar";
            this.LoaderProgressBar.Size = new System.Drawing.Size(317, 23);
            this.LoaderProgressBar.TabIndex = 5;
            this.LoaderProgressBar.Visible = false;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 300;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // FirstTimer
            // 
            this.FirstTimer.Enabled = true;
            this.FirstTimer.Interval = 1000;
            this.FirstTimer.Tick += new System.EventHandler(this.FirstTimer_Tick);
            // 
            // carBrandBindingSource
            // 
            this.carBrandBindingSource.AllowNew = true;
            this.carBrandBindingSource.DataSource = typeof(lab_3.ICarBrand);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(862, 534);
            this.Controls.Add(this.LoaderProgressBar);
            this.Controls.Add(this.carListDataGridView);
            this.Controls.Add(this.carBrandDataGridView);
            this.Controls.Add(this.mainMenu);
            this.Name = "MainForm";
            this.Text = "Car DB";
            ((System.ComponentModel.ISupportInitialize)(this.carBrandDataGridView)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carBrandDataGridView;
        private System.Windows.Forms.BindingSource carBrandBindingSource;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog OpenXMLFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveXMLFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horsepower;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSpeed;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridView carListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ProgressBar LoaderProgressBar;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Timer FirstTimer;
    }
}

