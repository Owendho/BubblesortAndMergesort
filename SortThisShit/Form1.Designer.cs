namespace SortThisShit
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
            this.components = new System.ComponentModel.Container();
            this.btnOne = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.UnsortedList = new System.Windows.Forms.ListBox();
            this.sortedList = new System.Windows.Forms.ListBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.lblArraystørelse = new System.Windows.Forms.Label();
            this.lblMS = new System.Windows.Forms.Label();
            this.lblAntalTal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(321, 14);
            this.btnOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(155, 113);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "buttblesort";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(321, 185);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(155, 22);
            this.txtBox1.TabIndex = 1;
            // 
            // UnsortedList
            // 
            this.UnsortedList.FormattingEnabled = true;
            this.UnsortedList.ItemHeight = 16;
            this.UnsortedList.Location = new System.Drawing.Point(37, 14);
            this.UnsortedList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnsortedList.Name = "UnsortedList";
            this.UnsortedList.Size = new System.Drawing.Size(145, 292);
            this.UnsortedList.TabIndex = 2;
            // 
            // sortedList
            // 
            this.sortedList.FormattingEnabled = true;
            this.sortedList.ItemHeight = 16;
            this.sortedList.Location = new System.Drawing.Point(641, 22);
            this.sortedList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortedList.Name = "sortedList";
            this.sortedList.Size = new System.Drawing.Size(135, 292);
            this.sortedList.TabIndex = 3;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(321, 257);
            this.txtBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(155, 22);
            this.txtBox2.TabIndex = 4;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(321, 325);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(155, 91);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "MergeSort";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(37, 359);
            this.txtTimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(132, 22);
            this.txtTimer.TabIndex = 6;
            // 
            // lblArraystørelse
            // 
            this.lblArraystørelse.AutoSize = true;
            this.lblArraystørelse.Location = new System.Drawing.Point(204, 261);
            this.lblArraystørelse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArraystørelse.Name = "lblArraystørelse";
            this.lblArraystørelse.Size = new System.Drawing.Size(113, 17);
            this.lblArraystørelse.TabIndex = 7;
            this.lblArraystørelse.Text = "Størelse af array";
            // 
            // lblMS
            // 
            this.lblMS.AutoSize = true;
            this.lblMS.Location = new System.Drawing.Point(177, 359);
            this.lblMS.Name = "lblMS";
            this.lblMS.Size = new System.Drawing.Size(26, 17);
            this.lblMS.TabIndex = 8;
            this.lblMS.Text = "ms";
            // 
            // lblAntalTal
            // 
            this.lblAntalTal.AutoSize = true;
            this.lblAntalTal.Location = new System.Drawing.Point(251, 188);
            this.lblAntalTal.Name = "lblAntalTal";
            this.lblAntalTal.Size = new System.Drawing.Size(64, 17);
            this.lblAntalTal.TabIndex = 9;
            this.lblAntalTal.Text = "Antal Tal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 473);
            this.Controls.Add(this.lblAntalTal);
            this.Controls.Add(this.lblMS);
            this.Controls.Add(this.lblArraystørelse);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.sortedList);
            this.Controls.Add(this.UnsortedList);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnOne);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.ListBox UnsortedList;
        private System.Windows.Forms.ListBox sortedList;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label lblArraystørelse;
        private System.Windows.Forms.Label lblMS;
        private System.Windows.Forms.Label lblAntalTal;
    }
}

