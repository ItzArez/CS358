namespace A1_BFP_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHeightFt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHeightIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.tbBMI = new System.Windows.Forms.TextBox();
            this.tbBFP = new System.Windows.Forms.TextBox();
            this.tbIdealWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Fat Percentage Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(139, 108);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(104, 35);
            this.tbAge.TabIndex = 2;
            // 
            // tbSex
            // 
            this.tbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSex.Location = new System.Drawing.Point(710, 108);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(104, 35);
            this.tbSex.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sex:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbHeightFt
            // 
            this.tbHeightFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeightFt.Location = new System.Drawing.Point(235, 168);
            this.tbHeightFt.Name = "tbHeightFt";
            this.tbHeightFt.Size = new System.Drawing.Size(104, 35);
            this.tbHeightFt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height(FT):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbHeightIn
            // 
            this.tbHeightIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeightIn.Location = new System.Drawing.Point(710, 165);
            this.tbHeightIn.Name = "tbHeightIn";
            this.tbHeightIn.Size = new System.Drawing.Size(104, 35);
            this.tbHeightIn.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Height(IN)";
            // 
            // tbWeight
            // 
            this.tbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeight.Location = new System.Drawing.Point(465, 240);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(104, 35);
            this.tbWeight.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Weight(LB):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculate.Location = new System.Drawing.Point(321, 334);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(221, 53);
            this.btCalculate.TabIndex = 11;
            this.btCalculate.Text = "Calculate BFP";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.calculateBFP);
            // 
            // tbBMI
            // 
            this.tbBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBMI.Location = new System.Drawing.Point(45, 419);
            this.tbBMI.Name = "tbBMI";
            this.tbBMI.Size = new System.Drawing.Size(172, 38);
            this.tbBMI.TabIndex = 12;
            this.tbBMI.Text = "BMI: ";
            // 
            // tbBFP
            // 
            this.tbBFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBFP.Location = new System.Drawing.Point(321, 419);
            this.tbBFP.Name = "tbBFP";
            this.tbBFP.Size = new System.Drawing.Size(188, 38);
            this.tbBFP.TabIndex = 13;
            this.tbBFP.Text = "BFP: ";
            // 
            // tbIdealWeight
            // 
            this.tbIdealWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdealWeight.Location = new System.Drawing.Point(601, 419);
            this.tbIdealWeight.Name = "tbIdealWeight";
            this.tbIdealWeight.ReadOnly = true;
            this.tbIdealWeight.Size = new System.Drawing.Size(229, 38);
            this.tbIdealWeight.TabIndex = 14;
            this.tbIdealWeight.Text = "Ideal Weight: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 499);
            this.Controls.Add(this.tbIdealWeight);
            this.Controls.Add(this.tbBFP);
            this.Controls.Add(this.tbBMI);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHeightIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbHeightFt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Body Fat Percentage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHeightFt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHeightIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.TextBox tbBMI;
        private System.Windows.Forms.TextBox tbBFP;
        private System.Windows.Forms.TextBox tbIdealWeight;
    }
}

