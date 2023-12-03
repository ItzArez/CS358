
namespace A5RecycleShop
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbErrorMessage = new System.Windows.Forms.ListBox();
            this.btChangePrice = new System.Windows.Forms.Button();
            this.lbSaveTransaction = new System.Windows.Forms.ListBox();
            this.btTotal = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.tbPlate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSubstract = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNetWeight = new System.Windows.Forms.TextBox();
            this.btCalcuate = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbReceipt = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Type:";
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.FormattingEnabled = true;
            this.lbErrorMessage.Location = new System.Drawing.Point(509, 193);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(216, 95);
            this.lbErrorMessage.TabIndex = 3;
            // 
            // btChangePrice
            // 
            this.btChangePrice.Location = new System.Drawing.Point(509, 315);
            this.btChangePrice.Name = "btChangePrice";
            this.btChangePrice.Size = new System.Drawing.Size(199, 52);
            this.btChangePrice.TabIndex = 4;
            this.btChangePrice.Text = "Change Price";
            this.btChangePrice.UseVisualStyleBackColor = true;
            this.btChangePrice.Click += new System.EventHandler(this.btChangePrice_Click);
            // 
            // lbSaveTransaction
            // 
            this.lbSaveTransaction.FormattingEnabled = true;
            this.lbSaveTransaction.Location = new System.Drawing.Point(24, 210);
            this.lbSaveTransaction.Name = "lbSaveTransaction";
            this.lbSaveTransaction.Size = new System.Drawing.Size(265, 212);
            this.lbSaveTransaction.TabIndex = 5;
            // 
            // btTotal
            // 
            this.btTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTotal.ForeColor = System.Drawing.Color.Red;
            this.btTotal.Location = new System.Drawing.Point(509, 82);
            this.btTotal.Name = "btTotal";
            this.btTotal.Size = new System.Drawing.Size(241, 94);
            this.btTotal.TabIndex = 6;
            this.btTotal.Text = "$";
            this.btTotal.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(509, 12);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(157, 39);
            this.btPrint.TabIndex = 7;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // tbPlate
            // 
            this.tbPlate.Location = new System.Drawing.Point(137, 1);
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.Size = new System.Drawing.Size(100, 20);
            this.tbPlate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Plate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "color";
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(137, 31);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(100, 20);
            this.tbColor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Before";
            // 
            // tbBefore
            // 
            this.tbBefore.Location = new System.Drawing.Point(137, 57);
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.Size = new System.Drawing.Size(100, 20);
            this.tbBefore.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "after";
            // 
            // tbAfter
            // 
            this.tbAfter.Location = new System.Drawing.Point(137, 83);
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.Size = new System.Drawing.Size(100, 20);
            this.tbAfter.TabIndex = 15;
            this.tbAfter.TextChanged += new System.EventHandler(this.tbAfter_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "substract";
            // 
            // tbSubstract
            // 
            this.tbSubstract.Location = new System.Drawing.Point(137, 113);
            this.tbSubstract.Name = "tbSubstract";
            this.tbSubstract.Size = new System.Drawing.Size(100, 20);
            this.tbSubstract.TabIndex = 17;
            this.tbSubstract.TextChanged += new System.EventHandler(this.tbSubstract_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Netweight";
            // 
            // tbNetWeight
            // 
            this.tbNetWeight.Location = new System.Drawing.Point(137, 143);
            this.tbNetWeight.Name = "tbNetWeight";
            this.tbNetWeight.Size = new System.Drawing.Size(100, 20);
            this.tbNetWeight.TabIndex = 19;
            // 
            // btCalcuate
            // 
            this.btCalcuate.Location = new System.Drawing.Point(293, 366);
            this.btCalcuate.Name = "btCalcuate";
            this.btCalcuate.Size = new System.Drawing.Size(199, 52);
            this.btCalcuate.TabIndex = 21;
            this.btCalcuate.Text = "AddReceipt";
            this.btCalcuate.UseVisualStyleBackColor = true;
            this.btCalcuate.Click += new System.EventHandler(this.btCalcuate_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(295, 424);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(199, 52);
            this.btSave.TabIndex = 22;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbReceipt
            // 
            this.tbReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbReceipt.Location = new System.Drawing.Point(295, 12);
            this.tbReceipt.Multiline = true;
            this.tbReceipt.Name = "tbReceipt";
            this.tbReceipt.Size = new System.Drawing.Size(197, 334);
            this.tbReceipt.TabIndex = 8;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCalcuate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNetWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSubstract);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAfter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBefore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPlate);
            this.Controls.Add(this.tbReceipt);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btTotal);
            this.Controls.Add(this.lbSaveTransaction);
            this.Controls.Add(this.btChangePrice);
            this.Controls.Add(this.lbErrorMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbErrorMessage;
        private System.Windows.Forms.Button btChangePrice;
        private System.Windows.Forms.ListBox lbSaveTransaction;
        private System.Windows.Forms.Button btTotal;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.TextBox tbPlate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBefore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSubstract;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNetWeight;
        private System.Windows.Forms.Button btCalcuate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbReceipt;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

