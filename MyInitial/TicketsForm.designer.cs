﻿namespace Ticketing
{
    partial class TicketsForm
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.radBalcony = new System.Windows.Forms.RadioButton();
            this.radGeneral = new System.Windows.Forms.RadioButton();
            this.radBox = new System.Windows.Forms.RadioButton();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.chkChildDiscount = new System.Windows.Forms.CheckBox();
            this.radStalls = new System.Windows.Forms.RadioButton();
            this.grpSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(64, 59);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(148, 59);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(325, 59);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(86, 17);
            this.lblAmountDue.TabIndex = 2;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(436, 65);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 17);
            this.lblAmount.TabIndex = 3;
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(148, 117);
            this.chkDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(132, 21);
            this.chkDiscount.TabIndex = 5;
            this.chkDiscount.Text = "Senior / Student";
            this.chkDiscount.UseVisualStyleBackColor = true;
            // 
            // radBalcony
            // 
            this.radBalcony.AutoSize = true;
            this.radBalcony.Location = new System.Drawing.Point(35, 21);
            this.radBalcony.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBalcony.Name = "radBalcony";
            this.radBalcony.Size = new System.Drawing.Size(79, 21);
            this.radBalcony.TabIndex = 6;
            this.radBalcony.Text = "Balcony";
            this.radBalcony.UseVisualStyleBackColor = true;
            // 
            // radGeneral
            // 
            this.radGeneral.AutoSize = true;
            this.radGeneral.Checked = true;
            this.radGeneral.Location = new System.Drawing.Point(35, 49);
            this.radGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGeneral.Name = "radGeneral";
            this.radGeneral.Size = new System.Drawing.Size(80, 21);
            this.radGeneral.TabIndex = 7;
            this.radGeneral.TabStop = true;
            this.radGeneral.Text = "General";
            this.radGeneral.UseVisualStyleBackColor = true;
            // 
            // radBox
            // 
            this.radBox.AutoSize = true;
            this.radBox.Location = new System.Drawing.Point(35, 78);
            this.radBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBox.Name = "radBox";
            this.radBox.Size = new System.Drawing.Size(92, 21);
            this.radBox.TabIndex = 8;
            this.radBox.Text = "Box Seats";
            this.radBox.UseVisualStyleBackColor = true;
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.radBox);
            this.grpSection.Controls.Add(this.radStalls);
            this.grpSection.Controls.Add(this.radGeneral);
            this.grpSection.Controls.Add(this.radBalcony);
            this.grpSection.Location = new System.Drawing.Point(69, 174);
            this.grpSection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSection.Name = "grpSection";
            this.grpSection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSection.Size = new System.Drawing.Size(185, 137);
            this.grpSection.TabIndex = 9;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "Section";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(392, 330);
            this.cmdCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(144, 43);
            this.cmdCalculate.TabIndex = 10;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // chkChildDiscount
            // 
            this.chkChildDiscount.AutoSize = true;
            this.chkChildDiscount.Location = new System.Drawing.Point(358, 117);
            this.chkChildDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.chkChildDiscount.Name = "chkChildDiscount";
            this.chkChildDiscount.Size = new System.Drawing.Size(61, 21);
            this.chkChildDiscount.TabIndex = 11;
            this.chkChildDiscount.Text = "Child";
            this.chkChildDiscount.UseVisualStyleBackColor = true;
            // 
            // radStalls
            // 
            this.radStalls.AutoSize = true;
            this.radStalls.Location = new System.Drawing.Point(35, 107);
            this.radStalls.Margin = new System.Windows.Forms.Padding(4);
            this.radStalls.Name = "radStalls";
            this.radStalls.Size = new System.Drawing.Size(98, 21);
            this.radStalls.TabIndex = 9;
            this.radStalls.Text = "Back Stalls";
            this.radStalls.UseVisualStyleBackColor = true;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 548);
            this.Controls.Add(this.chkChildDiscount);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.grpSection);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketsForm";
            this.Text = "Theater Ticket Purchase";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.RadioButton radBalcony;
        private System.Windows.Forms.RadioButton radGeneral;
        private System.Windows.Forms.RadioButton radBox;
        private System.Windows.Forms.GroupBox grpSection;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.CheckBox chkChildDiscount;
        private System.Windows.Forms.RadioButton radStalls;
    }
}

