namespace FarmingApp03
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Cow");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Livestock-Area", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Milk Storage");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Barn", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tractor");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tiller");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Storage Building", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Drone");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Command Center", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Soy Crop");
            this.visualizationPanel = new System.Windows.Forms.Panel();
            this.farmTreeView = new System.Windows.Forms.TreeView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PopulateFarmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualizationPanel
            // 
            this.visualizationPanel.AllowDrop = true;
            this.visualizationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visualizationPanel.Location = new System.Drawing.Point(409, 48);
            this.visualizationPanel.Name = "visualizationPanel";
            this.visualizationPanel.Size = new System.Drawing.Size(650, 525);
            this.visualizationPanel.TabIndex = 0;
            this.visualizationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.visualizationPanel_Paint);
            // 
            // farmTreeView
            // 
            this.farmTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.farmTreeView.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farmTreeView.HotTracking = true;
            this.farmTreeView.Location = new System.Drawing.Point(39, 48);
            this.farmTreeView.Name = "farmTreeView";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Cow";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Livestock-Area";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Milk Storage";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Barn";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Root";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Tractor";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Tiller";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Storage Building";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Drone";
            treeNode10.Name = "Node9";
            treeNode10.Text = "Command Center";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Soy Crop";
            this.farmTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode10,
            treeNode11});
            this.farmTreeView.Size = new System.Drawing.Size(331, 230);
            this.farmTreeView.TabIndex = 1;
            this.farmTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.farmTreeView_AfterSelect);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(39, 284);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Expand Tree\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PopulateFarmBtn
            // 
            this.PopulateFarmBtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulateFarmBtn.Location = new System.Drawing.Point(237, 284);
            this.PopulateFarmBtn.Name = "PopulateFarmBtn";
            this.PopulateFarmBtn.Size = new System.Drawing.Size(133, 23);
            this.PopulateFarmBtn.TabIndex = 3;
            this.PopulateFarmBtn.Text = "PopulateFarm";
            this.PopulateFarmBtn.UseVisualStyleBackColor = true;
            this.PopulateFarmBtn.Click += new System.EventHandler(this.PopulateFarmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items / Item Containers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Visualization";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(194, 23);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Visit Item / Container";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 140);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(230, 23);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Automatic Plant Watering";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(20, 178);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(297, 23);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Identify Unwanted Moving Objects";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 221);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Arduino/Microbit Device Actions";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 23);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Scan Farm";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 104);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(304, 23);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Check Soil Moisture / Crop Growth";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 585);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PopulateFarmBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.farmTreeView);
            this.Controls.Add(this.visualizationPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel visualizationPanel;
        private System.Windows.Forms.TreeView farmTreeView;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button PopulateFarmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

