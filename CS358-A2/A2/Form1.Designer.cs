namespace A2SaladOrderingF23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clbMainFood = new System.Windows.Forms.CheckedListBox();
            this.sauceCB = new System.Windows.Forms.GroupBox();
            this.rbThousandIsand = new System.Windows.Forms.RadioButton();
            this.rbItalian = new System.Windows.Forms.RadioButton();
            this.rbHoneyMustard = new System.Windows.Forms.RadioButton();
            this.rbRanch = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btOrder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sauceCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // placeToolStripMenuItem
            // 
            this.placeToolStripMenuItem.Name = "placeToolStripMenuItem";
            this.placeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.placeToolStripMenuItem.Text = "&Place";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.displayToolStripMenuItem.Text = "&Display";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.Location = new System.Drawing.Point(13, 40);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(183, 277);
            this.lbDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // clbMainFood
            // 
            this.clbMainFood.FormattingEnabled = true;
            this.clbMainFood.Items.AddRange(new object[] {
            "A\t$1",
            "B\t$2",
            "C\t$3",
            "D\t$4",
            "E\t$5"});
            this.clbMainFood.Location = new System.Drawing.Point(219, 194);
            this.clbMainFood.Name = "clbMainFood";
            this.clbMainFood.Size = new System.Drawing.Size(177, 124);
            this.clbMainFood.TabIndex = 5;
            // 
            // sauceCB
            // 
            this.sauceCB.Controls.Add(this.rbThousandIsand);
            this.sauceCB.Controls.Add(this.rbItalian);
            this.sauceCB.Controls.Add(this.rbHoneyMustard);
            this.sauceCB.Controls.Add(this.rbRanch);
            this.sauceCB.Location = new System.Drawing.Point(447, 40);
            this.sauceCB.Name = "sauceCB";
            this.sauceCB.Size = new System.Drawing.Size(222, 138);
            this.sauceCB.TabIndex = 6;
            this.sauceCB.TabStop = false;
            this.sauceCB.Text = "Sauce";
            // 
            // rbThousandIsand
            // 
            this.rbThousandIsand.AutoSize = true;
            this.rbThousandIsand.Location = new System.Drawing.Point(33, 92);
            this.rbThousandIsand.Name = "rbThousandIsand";
            this.rbThousandIsand.Size = new System.Drawing.Size(133, 17);
            this.rbThousandIsand.TabIndex = 3;
            this.rbThousandIsand.TabStop = true;
            this.rbThousandIsand.Text = "One Thounsand Island";
            this.rbThousandIsand.UseVisualStyleBackColor = true;
            // 
            // rbItalian
            // 
            this.rbItalian.AutoSize = true;
            this.rbItalian.Location = new System.Drawing.Point(33, 68);
            this.rbItalian.Name = "rbItalian";
            this.rbItalian.Size = new System.Drawing.Size(53, 17);
            this.rbItalian.TabIndex = 2;
            this.rbItalian.TabStop = true;
            this.rbItalian.Text = "Italian";
            this.rbItalian.UseVisualStyleBackColor = true;
            // 
            // rbHoneyMustard
            // 
            this.rbHoneyMustard.AutoSize = true;
            this.rbHoneyMustard.Location = new System.Drawing.Point(33, 44);
            this.rbHoneyMustard.Name = "rbHoneyMustard";
            this.rbHoneyMustard.Size = new System.Drawing.Size(97, 17);
            this.rbHoneyMustard.TabIndex = 1;
            this.rbHoneyMustard.TabStop = true;
            this.rbHoneyMustard.Text = "Honey Mustard";
            this.rbHoneyMustard.UseVisualStyleBackColor = true;
            // 
            // rbRanch
            // 
            this.rbRanch.AutoSize = true;
            this.rbRanch.Location = new System.Drawing.Point(33, 20);
            this.rbRanch.Name = "rbRanch";
            this.rbRanch.Size = new System.Drawing.Size(57, 17);
            this.rbRanch.TabIndex = 0;
            this.rbRanch.TabStop = true;
            this.rbRanch.Text = "Ranch";
            this.rbRanch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spoons of Sauce";
            // 
            // cbSource
            // 
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSource.Location = new System.Drawing.Point(513, 191);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(121, 21);
            this.cbSource.TabIndex = 8;
            this.cbSource.SelectedIndexChanged += new System.EventHandler(this.cbSource_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "$1 / Spoon";
            // 
            // btOrder
            // 
            this.btOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.Location = new System.Drawing.Point(480, 268);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(143, 87);
            this.btOrder.TabIndex = 10;
            this.btOrder.Text = "Order";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 387);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sauceCB);
            this.Controls.Add(this.clbMainFood);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sauceCB.ResumeLayout(false);
            this.sauceCB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox clbMainFood;
        private System.Windows.Forms.GroupBox sauceCB;
        private System.Windows.Forms.RadioButton rbThousandIsand;
        private System.Windows.Forms.RadioButton rbItalian;
        private System.Windows.Forms.RadioButton rbHoneyMustard;
        private System.Windows.Forms.RadioButton rbRanch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Label label2;
    }
}

