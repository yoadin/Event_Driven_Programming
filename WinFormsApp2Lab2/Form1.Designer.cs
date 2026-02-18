using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2Lab2
{
    partial class Form1
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
            cb1 = new CheckBox();
            cb2 = new CheckBox();
            cb3 = new CheckBox();
            cbDepartment = new ComboBox();
            dtp = new DateTimePicker();
            pbNum = new ProgressBar();
            rtb = new RichTextBox();
            rbF = new RadioButton();
            lv = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            rbM = new RadioButton();
            panel1 = new Panel();
            rdop2 = new RadioButton();
            rdop1 = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cb1
            // 
            cb1.AutoSize = true;
            cb1.Location = new Point(0, 0);
            cb1.Name = "cb1";
            cb1.Size = new Size(99, 29);
            cb1.TabIndex = 0;
            cb1.Text = "Student";
            cb1.UseVisualStyleBackColor = true;
            cb1.CheckedChanged += cb_CheckedChanged;
            // 
            // cb2
            // 
            cb2.AutoSize = true;
            cb2.Location = new Point(0, 44);
            cb2.Name = "cb2";
            cb2.Size = new Size(96, 29);
            cb2.TabIndex = 1;
            cb2.Text = "Teacher";
            cb2.UseVisualStyleBackColor = true;
            cb2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // cb3
            // 
            cb3.AutoSize = true;
            cb3.Location = new Point(0, 91);
            cb3.Name = "cb3";
            cb3.Size = new Size(62, 29);
            cb3.TabIndex = 2;
            cb3.Text = "HR";
            cb3.UseVisualStyleBackColor = true;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Items.AddRange(new object[] { "SE", "CS", "DS", "IS" });
            cbDepartment.Location = new Point(127, 0);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(182, 33);
            cbDepartment.TabIndex = 3;
            // 
            // dtp
            // 
            dtp.Location = new Point(329, 0);
            dtp.Name = "dtp";
            dtp.Size = new Size(300, 31);
            dtp.TabIndex = 4;
            dtp.ValueChanged += dtp_ValueChanged;
            // 
            // pbNum
            // 
            pbNum.Location = new Point(524, 44);
            pbNum.Name = "pbNum";
            pbNum.Size = new Size(150, 34);
            pbNum.TabIndex = 5;
            // 
            // rtb
            // 
            rtb.Location = new Point(478, 302);
            rtb.Name = "rtb";
            rtb.Size = new Size(286, 136);
            rtb.TabIndex = 6;
            rtb.Text = "";
            rtb.TextChanged += rtb_TextChanged;
            // 
            // rbF
            // 
            rbF.AutoSize = true;
            rbF.Location = new Point(136, 73);
            rbF.Name = "rbF";
            rbF.Size = new Size(93, 29);
            rbF.TabIndex = 7;
            rbF.TabStop = true;
            rbF.Text = "Female";
            rbF.UseVisualStyleBackColor = true;
            rbF.CheckedChanged += rbF_CheckedChanged;
            // 
            // lv
            // 
            lv.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lv.Location = new Point(12, 292);
            lv.Name = "lv";
            lv.Size = new Size(352, 146);
            lv.TabIndex = 8;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Gender";
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Location = new Point(269, 73);
            rbM.Name = "rbM";
            rbM.Size = new Size(75, 29);
            rbM.TabIndex = 9;
            rbM.TabStop = true;
            rbM.Text = "Male";
            rbM.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdop1);
            panel1.Controls.Add(rdop2);
            panel1.Location = new Point(478, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 10;
            // 
            // rdop2
            // 
            rdop2.AutoSize = true;
            rdop2.Location = new Point(104, 61);
            rdop2.Name = "rdop2";
            rdop2.Size = new Size(82, 29);
            rdop2.TabIndex = 8;
            rdop2.TabStop = true;
            rdop2.Text = "MALE";
            rdop2.UseVisualStyleBackColor = true;
            // 
            // rdop1
            // 
            rdop1.AutoSize = true;
            rdop1.Location = new Point(103, 26);
            rdop1.Name = "rdop1";
            rdop1.Size = new Size(100, 29);
            rdop1.TabIndex = 9;
            rdop1.TabStop = true;
            rdop1.Text = "FEMALE";
            rdop1.UseVisualStyleBackColor = true;
            rdop1.CheckedChanged += rdop1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(rbM);
            Controls.Add(lv);
            Controls.Add(rbF);
            Controls.Add(rtb);
            Controls.Add(pbNum);
            Controls.Add(dtp);
            Controls.Add(cbDepartment);
            Controls.Add(cb3);
            Controls.Add(cb2);
            Controls.Add(cb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cb1;
        private CheckBox cb2;
        private CheckBox cb3;
        private ComboBox cbDepartment;
        private DateTimePicker dtp;
        private ProgressBar pbNum;
        private RichTextBox rtb;
        private RadioButton rbF;
        private ListView lv;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private RadioButton rbM;
        private Panel panel1;
        private RadioButton rdop1;
        private RadioButton rdop2;
    }
}
