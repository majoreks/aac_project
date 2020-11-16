namespace aac_project
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsSameInputLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsLoadFromFileButton = new System.Windows.Forms.Button();
            this.controlsButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.conrolsSameInputCalculateButton = new System.Windows.Forms.Button();
            this.controlsInputGreedyGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsInputGreedyLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsInputGreedyButton = new System.Windows.Forms.Button();
            this.controlsInputGreedyTextBox = new System.Windows.Forms.TextBox();
            this.controlsInputBFGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsInputBFLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsInputBFTextBox = new System.Windows.Forms.TextBox();
            this.controlsInputBFButton = new System.Windows.Forms.Button();
            this.outputMainGroupBox = new System.Windows.Forms.GroupBox();
            this.outputLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputBFGroupBox = new System.Windows.Forms.GroupBox();
            this.outputBFLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bfDataGridView = new System.Windows.Forms.DataGridView();
            this.outputQOGroupBox = new System.Windows.Forms.GroupBox();
            this.outputGreedyLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.greedyDataGridView = new System.Windows.Forms.DataGridView();
            this.bfBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.greedyBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainLayoutPanel.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            this.controlsLayoutPanel.SuspendLayout();
            this.controlsSameInputLayoutPanel.SuspendLayout();
            this.controlsButtonsLayoutPanel.SuspendLayout();
            this.controlsInputGreedyGroupBox.SuspendLayout();
            this.controlsInputGreedyLayoutPanel.SuspendLayout();
            this.controlsInputBFGroupBox.SuspendLayout();
            this.controlsInputBFLayoutPanel.SuspendLayout();
            this.outputMainGroupBox.SuspendLayout();
            this.outputLayoutPanel.SuspendLayout();
            this.outputBFGroupBox.SuspendLayout();
            this.outputBFLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bfDataGridView)).BeginInit();
            this.outputQOGroupBox.SuspendLayout();
            this.outputGreedyLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greedyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSize = true;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.controlsGroupBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.outputMainGroupBox, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(804, 361);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsGroupBox.Controls.Add(this.controlsLayoutPanel);
            this.controlsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.controlsGroupBox.MaximumSize = new System.Drawing.Size(798, 129);
            this.controlsGroupBox.MinimumSize = new System.Drawing.Size(798, 129);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(798, 129);
            this.controlsGroupBox.TabIndex = 0;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // controlsLayoutPanel
            // 
            this.controlsLayoutPanel.ColumnCount = 2;
            this.controlsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsLayoutPanel.Controls.Add(this.controlsSameInputLayoutPanel, 0, 0);
            this.controlsLayoutPanel.Controls.Add(this.controlsButtonsLayoutPanel, 0, 1);
            this.controlsLayoutPanel.Controls.Add(this.controlsInputGreedyGroupBox, 1, 0);
            this.controlsLayoutPanel.Controls.Add(this.controlsInputBFGroupBox, 1, 1);
            this.controlsLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.controlsLayoutPanel.Name = "controlsLayoutPanel";
            this.controlsLayoutPanel.RowCount = 2;
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsLayoutPanel.Size = new System.Drawing.Size(788, 110);
            this.controlsLayoutPanel.TabIndex = 0;
            // 
            // controlsSameInputLayoutPanel
            // 
            this.controlsSameInputLayoutPanel.ColumnCount = 2;
            this.controlsSameInputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsSameInputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsSameInputLayoutPanel.Controls.Add(this.controlsLoadFromFileButton, 1, 0);
            this.controlsSameInputLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsSameInputLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.controlsSameInputLayoutPanel.Name = "controlsSameInputLayoutPanel";
            this.controlsSameInputLayoutPanel.RowCount = 1;
            this.controlsSameInputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsSameInputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsSameInputLayoutPanel.Size = new System.Drawing.Size(388, 49);
            this.controlsSameInputLayoutPanel.TabIndex = 0;
            // 
            // controlsLoadFromFileButton
            // 
            this.controlsLoadFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsLoadFromFileButton.Location = new System.Drawing.Point(197, 3);
            this.controlsLoadFromFileButton.Name = "controlsLoadFromFileButton";
            this.controlsLoadFromFileButton.Size = new System.Drawing.Size(188, 43);
            this.controlsLoadFromFileButton.TabIndex = 1;
            this.controlsLoadFromFileButton.Text = "Load from file";
            this.controlsLoadFromFileButton.UseVisualStyleBackColor = true;
            this.controlsLoadFromFileButton.Click += new System.EventHandler(this.controlsLoadFromFileButton_Click);
            // 
            // controlsButtonsLayoutPanel
            // 
            this.controlsButtonsLayoutPanel.ColumnCount = 2;
            this.controlsButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsButtonsLayoutPanel.Controls.Add(this.conrolsSameInputCalculateButton, 1, 0);
            this.controlsButtonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsButtonsLayoutPanel.Location = new System.Drawing.Point(3, 58);
            this.controlsButtonsLayoutPanel.Name = "controlsButtonsLayoutPanel";
            this.controlsButtonsLayoutPanel.RowCount = 1;
            this.controlsButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.controlsButtonsLayoutPanel.Size = new System.Drawing.Size(388, 49);
            this.controlsButtonsLayoutPanel.TabIndex = 1;
            // 
            // conrolsSameInputCalculateButton
            // 
            this.conrolsSameInputCalculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conrolsSameInputCalculateButton.Location = new System.Drawing.Point(197, 3);
            this.conrolsSameInputCalculateButton.Name = "conrolsSameInputCalculateButton";
            this.conrolsSameInputCalculateButton.Size = new System.Drawing.Size(188, 43);
            this.conrolsSameInputCalculateButton.TabIndex = 1;
            this.conrolsSameInputCalculateButton.Text = "Calculate both";
            this.conrolsSameInputCalculateButton.UseVisualStyleBackColor = true;
            this.conrolsSameInputCalculateButton.Click += new System.EventHandler(this.conrolsSameInputCalculateButton_Click);
            // 
            // controlsInputGreedyGroupBox
            // 
            this.controlsInputGreedyGroupBox.Controls.Add(this.controlsInputGreedyLayoutPanel);
            this.controlsInputGreedyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputGreedyGroupBox.Location = new System.Drawing.Point(397, 3);
            this.controlsInputGreedyGroupBox.Name = "controlsInputGreedyGroupBox";
            this.controlsInputGreedyGroupBox.Size = new System.Drawing.Size(388, 49);
            this.controlsInputGreedyGroupBox.TabIndex = 2;
            this.controlsInputGreedyGroupBox.TabStop = false;
            this.controlsInputGreedyGroupBox.Text = "Input greedy algorithm";
            // 
            // controlsInputGreedyLayoutPanel
            // 
            this.controlsInputGreedyLayoutPanel.ColumnCount = 2;
            this.controlsInputGreedyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputGreedyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputGreedyLayoutPanel.Controls.Add(this.controlsInputGreedyButton, 1, 0);
            this.controlsInputGreedyLayoutPanel.Controls.Add(this.controlsInputGreedyTextBox, 0, 0);
            this.controlsInputGreedyLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputGreedyLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.controlsInputGreedyLayoutPanel.Name = "controlsInputGreedyLayoutPanel";
            this.controlsInputGreedyLayoutPanel.RowCount = 1;
            this.controlsInputGreedyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputGreedyLayoutPanel.Size = new System.Drawing.Size(382, 30);
            this.controlsInputGreedyLayoutPanel.TabIndex = 0;
            // 
            // controlsInputGreedyButton
            // 
            this.controlsInputGreedyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputGreedyButton.Location = new System.Drawing.Point(194, 3);
            this.controlsInputGreedyButton.Name = "controlsInputGreedyButton";
            this.controlsInputGreedyButton.Size = new System.Drawing.Size(185, 24);
            this.controlsInputGreedyButton.TabIndex = 0;
            this.controlsInputGreedyButton.Text = "Calculate";
            this.controlsInputGreedyButton.UseVisualStyleBackColor = true;
            this.controlsInputGreedyButton.Click += new System.EventHandler(this.controlsInputGreedyButton_Click);
            // 
            // controlsInputGreedyTextBox
            // 
            this.controlsInputGreedyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputGreedyTextBox.Location = new System.Drawing.Point(3, 3);
            this.controlsInputGreedyTextBox.MaxLength = 40000;
            this.controlsInputGreedyTextBox.Name = "controlsInputGreedyTextBox";
            this.controlsInputGreedyTextBox.Size = new System.Drawing.Size(185, 20);
            this.controlsInputGreedyTextBox.TabIndex = 1;
            this.controlsInputGreedyTextBox.TextChanged += new System.EventHandler(this.controlsInputGreedyTextBox_TextChanged);
            // 
            // controlsInputBFGroupBox
            // 
            this.controlsInputBFGroupBox.Controls.Add(this.controlsInputBFLayoutPanel);
            this.controlsInputBFGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputBFGroupBox.Location = new System.Drawing.Point(397, 58);
            this.controlsInputBFGroupBox.Name = "controlsInputBFGroupBox";
            this.controlsInputBFGroupBox.Size = new System.Drawing.Size(388, 49);
            this.controlsInputBFGroupBox.TabIndex = 3;
            this.controlsInputBFGroupBox.TabStop = false;
            this.controlsInputBFGroupBox.Text = "Input brute force algorithm";
            // 
            // controlsInputBFLayoutPanel
            // 
            this.controlsInputBFLayoutPanel.ColumnCount = 2;
            this.controlsInputBFLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputBFLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputBFLayoutPanel.Controls.Add(this.controlsInputBFTextBox, 0, 0);
            this.controlsInputBFLayoutPanel.Controls.Add(this.controlsInputBFButton, 1, 0);
            this.controlsInputBFLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputBFLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.controlsInputBFLayoutPanel.Name = "controlsInputBFLayoutPanel";
            this.controlsInputBFLayoutPanel.RowCount = 1;
            this.controlsInputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.controlsInputBFLayoutPanel.Size = new System.Drawing.Size(382, 30);
            this.controlsInputBFLayoutPanel.TabIndex = 0;
            // 
            // controlsInputBFTextBox
            // 
            this.controlsInputBFTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsInputBFTextBox.Location = new System.Drawing.Point(3, 3);
            this.controlsInputBFTextBox.Name = "controlsInputBFTextBox";
            this.controlsInputBFTextBox.Size = new System.Drawing.Size(185, 20);
            this.controlsInputBFTextBox.TabIndex = 2;
            this.controlsInputBFTextBox.TextChanged += new System.EventHandler(this.controlsInputBFTextBox_TextChanged);
            // 
            // controlsInputBFButton
            // 
            this.controlsInputBFButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputBFButton.Location = new System.Drawing.Point(194, 3);
            this.controlsInputBFButton.Name = "controlsInputBFButton";
            this.controlsInputBFButton.Size = new System.Drawing.Size(185, 24);
            this.controlsInputBFButton.TabIndex = 0;
            this.controlsInputBFButton.Text = "Calculate";
            this.controlsInputBFButton.UseVisualStyleBackColor = true;
            this.controlsInputBFButton.Click += new System.EventHandler(this.controlsInputBFButton_Click);
            // 
            // outputMainGroupBox
            // 
            this.outputMainGroupBox.Controls.Add(this.outputLayoutPanel);
            this.outputMainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputMainGroupBox.Location = new System.Drawing.Point(3, 138);
            this.outputMainGroupBox.Name = "outputMainGroupBox";
            this.outputMainGroupBox.Size = new System.Drawing.Size(798, 220);
            this.outputMainGroupBox.TabIndex = 1;
            this.outputMainGroupBox.TabStop = false;
            this.outputMainGroupBox.Text = "Output";
            // 
            // outputLayoutPanel
            // 
            this.outputLayoutPanel.ColumnCount = 2;
            this.outputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outputLayoutPanel.Controls.Add(this.outputBFGroupBox, 0, 0);
            this.outputLayoutPanel.Controls.Add(this.outputQOGroupBox, 1, 0);
            this.outputLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.outputLayoutPanel.Name = "outputLayoutPanel";
            this.outputLayoutPanel.RowCount = 1;
            this.outputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outputLayoutPanel.Size = new System.Drawing.Size(792, 201);
            this.outputLayoutPanel.TabIndex = 0;
            // 
            // outputBFGroupBox
            // 
            this.outputBFGroupBox.Controls.Add(this.outputBFLayoutPanel);
            this.outputBFGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBFGroupBox.Location = new System.Drawing.Point(3, 3);
            this.outputBFGroupBox.Name = "outputBFGroupBox";
            this.outputBFGroupBox.Size = new System.Drawing.Size(390, 195);
            this.outputBFGroupBox.TabIndex = 0;
            this.outputBFGroupBox.TabStop = false;
            this.outputBFGroupBox.Text = "Brute force algorithm";
            // 
            // outputBFLayoutPanel
            // 
            this.outputBFLayoutPanel.ColumnCount = 1;
            this.outputBFLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outputBFLayoutPanel.Controls.Add(this.bfDataGridView, 0, 0);
            this.outputBFLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBFLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.outputBFLayoutPanel.Name = "outputBFLayoutPanel";
            this.outputBFLayoutPanel.RowCount = 1;
            this.outputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.outputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.outputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.outputBFLayoutPanel.Size = new System.Drawing.Size(384, 176);
            this.outputBFLayoutPanel.TabIndex = 0;
            // 
            // bfDataGridView
            // 
            this.bfDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bfDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bfDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bfDataGridView.Location = new System.Drawing.Point(3, 3);
            this.bfDataGridView.Name = "bfDataGridView";
            this.bfDataGridView.ReadOnly = true;
            this.bfDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bfDataGridView.Size = new System.Drawing.Size(378, 170);
            this.bfDataGridView.TabIndex = 2;
            this.bfDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.greedyDataGridView_CellDoubleClick);
            // 
            // outputQOGroupBox
            // 
            this.outputQOGroupBox.Controls.Add(this.outputGreedyLayoutPanel);
            this.outputQOGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputQOGroupBox.Location = new System.Drawing.Point(399, 3);
            this.outputQOGroupBox.Name = "outputQOGroupBox";
            this.outputQOGroupBox.Size = new System.Drawing.Size(390, 195);
            this.outputQOGroupBox.TabIndex = 1;
            this.outputQOGroupBox.TabStop = false;
            this.outputQOGroupBox.Text = "Greedy algorithm";
            // 
            // outputGreedyLayoutPanel
            // 
            this.outputGreedyLayoutPanel.ColumnCount = 1;
            this.outputGreedyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outputGreedyLayoutPanel.Controls.Add(this.greedyDataGridView, 0, 0);
            this.outputGreedyLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputGreedyLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.outputGreedyLayoutPanel.Name = "outputGreedyLayoutPanel";
            this.outputGreedyLayoutPanel.RowCount = 1;
            this.outputGreedyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.outputGreedyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.outputGreedyLayoutPanel.Size = new System.Drawing.Size(384, 176);
            this.outputGreedyLayoutPanel.TabIndex = 0;
            // 
            // greedyDataGridView
            // 
            this.greedyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.greedyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.greedyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.greedyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greedyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.greedyDataGridView.Name = "greedyDataGridView";
            this.greedyDataGridView.ReadOnly = true;
            this.greedyDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.greedyDataGridView.Size = new System.Drawing.Size(378, 170);
            this.greedyDataGridView.TabIndex = 1;
            this.greedyDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.greedyDataGridView_CellDoubleClick);
            // 
            // bfBackgroundWorker
            // 
            this.bfBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bfBackgroundWorker_DoWork);
            this.bfBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bfBackgroundWorker_RunWorkerCompleted);
            // 
            // greedyBackgroundWorker
            // 
            this.greedyBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.greedyBackgroundWorker_DoWork);
            this.greedyBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.greedyBackgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.mainLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 820);
            this.MinimumSize = new System.Drawing.Size(820, 400);
            this.Name = "Form1";
            this.Text = "A&C Project";
            this.mainLayoutPanel.ResumeLayout(false);
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsLayoutPanel.ResumeLayout(false);
            this.controlsSameInputLayoutPanel.ResumeLayout(false);
            this.controlsButtonsLayoutPanel.ResumeLayout(false);
            this.controlsInputGreedyGroupBox.ResumeLayout(false);
            this.controlsInputGreedyLayoutPanel.ResumeLayout(false);
            this.controlsInputGreedyLayoutPanel.PerformLayout();
            this.controlsInputBFGroupBox.ResumeLayout(false);
            this.controlsInputBFLayoutPanel.ResumeLayout(false);
            this.controlsInputBFLayoutPanel.PerformLayout();
            this.outputMainGroupBox.ResumeLayout(false);
            this.outputLayoutPanel.ResumeLayout(false);
            this.outputBFGroupBox.ResumeLayout(false);
            this.outputBFLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bfDataGridView)).EndInit();
            this.outputQOGroupBox.ResumeLayout(false);
            this.outputGreedyLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.greedyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.GroupBox outputMainGroupBox;
        private System.Windows.Forms.TableLayoutPanel outputLayoutPanel;
        private System.Windows.Forms.GroupBox outputBFGroupBox;
        private System.Windows.Forms.GroupBox outputQOGroupBox;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.TableLayoutPanel controlsLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel controlsSameInputLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel controlsButtonsLayoutPanel;
        private System.Windows.Forms.GroupBox controlsInputGreedyGroupBox;
        private System.Windows.Forms.TableLayoutPanel controlsInputGreedyLayoutPanel;
        private System.Windows.Forms.GroupBox controlsInputBFGroupBox;
        private System.Windows.Forms.TableLayoutPanel controlsInputBFLayoutPanel;
        private System.Windows.Forms.Button controlsInputGreedyButton;
        private System.Windows.Forms.TextBox controlsInputGreedyTextBox;
        private System.Windows.Forms.TextBox controlsInputBFTextBox;
        private System.Windows.Forms.Button controlsInputBFButton;
        private System.Windows.Forms.TableLayoutPanel outputBFLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel outputGreedyLayoutPanel;
        private System.Windows.Forms.Button conrolsSameInputCalculateButton;
        private System.Windows.Forms.DataGridView greedyDataGridView;
        private System.Windows.Forms.DataGridView bfDataGridView;
        private System.Windows.Forms.Button controlsLoadFromFileButton;
        private System.ComponentModel.BackgroundWorker bfBackgroundWorker;
        private System.ComponentModel.BackgroundWorker greedyBackgroundWorker;
    }
}

