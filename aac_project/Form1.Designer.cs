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
            this.outputMainGroupBox = new System.Windows.Forms.GroupBox();
            this.outputLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputBFGroupBox = new System.Windows.Forms.GroupBox();
            this.outputQOGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsSameInputLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsInputGreedyGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsInputBFGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsInputGreedyLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsInputBFLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsInputGreedyButton = new System.Windows.Forms.Button();
            this.controlsInputGreedyTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.controlsInputBFButton = new System.Windows.Forms.Button();
            this.outputBFLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputGreedyLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bruteForceProgressBar = new System.Windows.Forms.ProgressBar();
            this.greedyProgressBar = new System.Windows.Forms.ProgressBar();
            this.controlsSameInputCheckBox = new System.Windows.Forms.CheckBox();
            this.controlsSameInputTextBox = new System.Windows.Forms.TextBox();
            this.controlsLoadFromFileButton = new System.Windows.Forms.Button();
            this.conrolsSameInputCalculateButton = new System.Windows.Forms.Button();
            this.mainLayoutPanel.SuspendLayout();
            this.outputMainGroupBox.SuspendLayout();
            this.outputLayoutPanel.SuspendLayout();
            this.outputBFGroupBox.SuspendLayout();
            this.outputQOGroupBox.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            this.controlsLayoutPanel.SuspendLayout();
            this.controlsSameInputLayoutPanel.SuspendLayout();
            this.controlsButtonsLayoutPanel.SuspendLayout();
            this.controlsInputGreedyGroupBox.SuspendLayout();
            this.controlsInputBFGroupBox.SuspendLayout();
            this.controlsInputGreedyLayoutPanel.SuspendLayout();
            this.controlsInputBFLayoutPanel.SuspendLayout();
            this.outputBFLayoutPanel.SuspendLayout();
            this.outputGreedyLayoutPanel.SuspendLayout();
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
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // outputMainGroupBox
            // 
            this.outputMainGroupBox.Controls.Add(this.outputLayoutPanel);
            this.outputMainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputMainGroupBox.Location = new System.Drawing.Point(3, 138);
            this.outputMainGroupBox.Name = "outputMainGroupBox";
            this.outputMainGroupBox.Size = new System.Drawing.Size(794, 309);
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
            this.outputLayoutPanel.Size = new System.Drawing.Size(788, 290);
            this.outputLayoutPanel.TabIndex = 0;
            // 
            // outputBFGroupBox
            // 
            this.outputBFGroupBox.Controls.Add(this.outputBFLayoutPanel);
            this.outputBFGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBFGroupBox.Location = new System.Drawing.Point(3, 3);
            this.outputBFGroupBox.Name = "outputBFGroupBox";
            this.outputBFGroupBox.Size = new System.Drawing.Size(388, 284);
            this.outputBFGroupBox.TabIndex = 0;
            this.outputBFGroupBox.TabStop = false;
            this.outputBFGroupBox.Text = "Brute force algorithm";
            // 
            // outputQOGroupBox
            // 
            this.outputQOGroupBox.Controls.Add(this.outputGreedyLayoutPanel);
            this.outputQOGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputQOGroupBox.Location = new System.Drawing.Point(397, 3);
            this.outputQOGroupBox.Name = "outputQOGroupBox";
            this.outputQOGroupBox.Size = new System.Drawing.Size(388, 284);
            this.outputQOGroupBox.TabIndex = 1;
            this.outputQOGroupBox.TabStop = false;
            this.outputQOGroupBox.Text = "Greedy algorithm";
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.controlsLayoutPanel);
            this.controlsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(794, 129);
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
            this.controlsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.controlsSameInputLayoutPanel.Controls.Add(this.controlsSameInputCheckBox, 0, 0);
            this.controlsSameInputLayoutPanel.Controls.Add(this.controlsSameInputTextBox, 1, 0);
            this.controlsSameInputLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsSameInputLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.controlsSameInputLayoutPanel.Name = "controlsSameInputLayoutPanel";
            this.controlsSameInputLayoutPanel.RowCount = 1;
            this.controlsSameInputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsSameInputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsSameInputLayoutPanel.Size = new System.Drawing.Size(388, 49);
            this.controlsSameInputLayoutPanel.TabIndex = 0;
            // 
            // controlsButtonsLayoutPanel
            // 
            this.controlsButtonsLayoutPanel.ColumnCount = 2;
            this.controlsButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsButtonsLayoutPanel.Controls.Add(this.controlsLoadFromFileButton, 0, 0);
            this.controlsButtonsLayoutPanel.Controls.Add(this.conrolsSameInputCalculateButton, 1, 0);
            this.controlsButtonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsButtonsLayoutPanel.Location = new System.Drawing.Point(3, 58);
            this.controlsButtonsLayoutPanel.Name = "controlsButtonsLayoutPanel";
            this.controlsButtonsLayoutPanel.RowCount = 1;
            this.controlsButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsButtonsLayoutPanel.Size = new System.Drawing.Size(388, 49);
            this.controlsButtonsLayoutPanel.TabIndex = 1;
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
            // controlsInputBFLayoutPanel
            // 
            this.controlsInputBFLayoutPanel.ColumnCount = 2;
            this.controlsInputBFLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputBFLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputBFLayoutPanel.Controls.Add(this.textBox1, 0, 0);
            this.controlsInputBFLayoutPanel.Controls.Add(this.controlsInputBFButton, 1, 0);
            this.controlsInputBFLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputBFLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.controlsInputBFLayoutPanel.Name = "controlsInputBFLayoutPanel";
            this.controlsInputBFLayoutPanel.RowCount = 1;
            this.controlsInputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsInputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlsInputBFLayoutPanel.Size = new System.Drawing.Size(382, 30);
            this.controlsInputBFLayoutPanel.TabIndex = 0;
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
            // 
            // controlsInputGreedyTextBox
            // 
            this.controlsInputGreedyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsInputGreedyTextBox.Location = new System.Drawing.Point(3, 3);
            this.controlsInputGreedyTextBox.Name = "controlsInputGreedyTextBox";
            this.controlsInputGreedyTextBox.Size = new System.Drawing.Size(185, 20);
            this.controlsInputGreedyTextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 2;
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
            // 
            // outputBFLayoutPanel
            // 
            this.outputBFLayoutPanel.ColumnCount = 1;
            this.outputBFLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outputBFLayoutPanel.Controls.Add(this.bruteForceProgressBar, 0, 1);
            this.outputBFLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBFLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.outputBFLayoutPanel.Name = "outputBFLayoutPanel";
            this.outputBFLayoutPanel.RowCount = 2;
            this.outputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.outputBFLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.outputBFLayoutPanel.Size = new System.Drawing.Size(382, 265);
            this.outputBFLayoutPanel.TabIndex = 0;
            // 
            // outputGreedyLayoutPanel
            // 
            this.outputGreedyLayoutPanel.ColumnCount = 1;
            this.outputGreedyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outputGreedyLayoutPanel.Controls.Add(this.greedyProgressBar, 0, 1);
            this.outputGreedyLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputGreedyLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.outputGreedyLayoutPanel.Name = "outputGreedyLayoutPanel";
            this.outputGreedyLayoutPanel.RowCount = 2;
            this.outputGreedyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.outputGreedyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.outputGreedyLayoutPanel.Size = new System.Drawing.Size(382, 265);
            this.outputGreedyLayoutPanel.TabIndex = 0;
            // 
            // bruteForceProgressBar
            // 
            this.bruteForceProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bruteForceProgressBar.Location = new System.Drawing.Point(3, 241);
            this.bruteForceProgressBar.Name = "bruteForceProgressBar";
            this.bruteForceProgressBar.Size = new System.Drawing.Size(376, 21);
            this.bruteForceProgressBar.TabIndex = 0;
            // 
            // greedyProgressBar
            // 
            this.greedyProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greedyProgressBar.Location = new System.Drawing.Point(3, 241);
            this.greedyProgressBar.Name = "greedyProgressBar";
            this.greedyProgressBar.Size = new System.Drawing.Size(376, 21);
            this.greedyProgressBar.TabIndex = 0;
            // 
            // controlsSameInputCheckBox
            // 
            this.controlsSameInputCheckBox.AutoSize = true;
            this.controlsSameInputCheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsSameInputCheckBox.Location = new System.Drawing.Point(112, 3);
            this.controlsSameInputCheckBox.Name = "controlsSameInputCheckBox";
            this.controlsSameInputCheckBox.Size = new System.Drawing.Size(79, 43);
            this.controlsSameInputCheckBox.TabIndex = 0;
            this.controlsSameInputCheckBox.Text = "Same input";
            this.controlsSameInputCheckBox.UseVisualStyleBackColor = true;
            // 
            // controlsSameInputTextBox
            // 
            this.controlsSameInputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.controlsSameInputTextBox.Location = new System.Drawing.Point(197, 14);
            this.controlsSameInputTextBox.Name = "controlsSameInputTextBox";
            this.controlsSameInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.controlsSameInputTextBox.TabIndex = 1;
            // 
            // controlsLoadFromFileButton
            // 
            this.controlsLoadFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsLoadFromFileButton.Location = new System.Drawing.Point(3, 3);
            this.controlsLoadFromFileButton.Name = "controlsLoadFromFileButton";
            this.controlsLoadFromFileButton.Size = new System.Drawing.Size(188, 43);
            this.controlsLoadFromFileButton.TabIndex = 0;
            this.controlsLoadFromFileButton.Text = "Load from file";
            this.controlsLoadFromFileButton.UseVisualStyleBackColor = true;
            // 
            // conrolsSameInputCalculateButton
            // 
            this.conrolsSameInputCalculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conrolsSameInputCalculateButton.Location = new System.Drawing.Point(197, 3);
            this.conrolsSameInputCalculateButton.Name = "conrolsSameInputCalculateButton";
            this.conrolsSameInputCalculateButton.Size = new System.Drawing.Size(188, 43);
            this.conrolsSameInputCalculateButton.TabIndex = 1;
            this.conrolsSameInputCalculateButton.Text = "Calculate";
            this.conrolsSameInputCalculateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainLayoutPanel.ResumeLayout(false);
            this.outputMainGroupBox.ResumeLayout(false);
            this.outputLayoutPanel.ResumeLayout(false);
            this.outputBFGroupBox.ResumeLayout(false);
            this.outputQOGroupBox.ResumeLayout(false);
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsLayoutPanel.ResumeLayout(false);
            this.controlsSameInputLayoutPanel.ResumeLayout(false);
            this.controlsSameInputLayoutPanel.PerformLayout();
            this.controlsButtonsLayoutPanel.ResumeLayout(false);
            this.controlsInputGreedyGroupBox.ResumeLayout(false);
            this.controlsInputBFGroupBox.ResumeLayout(false);
            this.controlsInputGreedyLayoutPanel.ResumeLayout(false);
            this.controlsInputGreedyLayoutPanel.PerformLayout();
            this.controlsInputBFLayoutPanel.ResumeLayout(false);
            this.controlsInputBFLayoutPanel.PerformLayout();
            this.outputBFLayoutPanel.ResumeLayout(false);
            this.outputGreedyLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button controlsInputBFButton;
        private System.Windows.Forms.TableLayoutPanel outputBFLayoutPanel;
        private System.Windows.Forms.ProgressBar bruteForceProgressBar;
        private System.Windows.Forms.TableLayoutPanel outputGreedyLayoutPanel;
        private System.Windows.Forms.ProgressBar greedyProgressBar;
        private System.Windows.Forms.CheckBox controlsSameInputCheckBox;
        private System.Windows.Forms.TextBox controlsSameInputTextBox;
        private System.Windows.Forms.Button controlsLoadFromFileButton;
        private System.Windows.Forms.Button conrolsSameInputCalculateButton;
    }
}

