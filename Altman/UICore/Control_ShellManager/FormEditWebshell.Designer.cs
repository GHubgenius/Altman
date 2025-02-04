﻿namespace Altman.UICore.Control_ShellManager
{
    partial class FormEditWebshell
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TargetID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_TargetLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ShellPath = new System.Windows.Forms.TextBox();
            this.textBox_ShellPass = new System.Windows.Forms.TextBox();
            this.comboBox_ScritpType = new System.Windows.Forms.ComboBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_ServerCoding = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Area = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_Alter = new System.Windows.Forms.Button();
            this.textBox_Remark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_Setting = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_WebCoding = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_IniType = new System.Windows.Forms.ComboBox();
            this.comboBox_Items = new System.Windows.Forms.ComboBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:*";
            // 
            // textBox_TargetID
            // 
            this.textBox_TargetID.Location = new System.Drawing.Point(44, 8);
            this.textBox_TargetID.Name = "textBox_TargetID";
            this.textBox_TargetID.Size = new System.Drawing.Size(118, 21);
            this.textBox_TargetID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level:";
            // 
            // comboBox_TargetLevel
            // 
            this.comboBox_TargetLevel.FormattingEnabled = true;
            this.comboBox_TargetLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "-"});
            this.comboBox_TargetLevel.Location = new System.Drawing.Point(212, 8);
            this.comboBox_TargetLevel.Name = "comboBox_TargetLevel";
            this.comboBox_TargetLevel.Size = new System.Drawing.Size(60, 20);
            this.comboBox_TargetLevel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Url:*";
            // 
            // textBox_ShellPath
            // 
            this.textBox_ShellPath.Location = new System.Drawing.Point(44, 35);
            this.textBox_ShellPath.Name = "textBox_ShellPath";
            this.textBox_ShellPath.Size = new System.Drawing.Size(314, 21);
            this.textBox_ShellPath.TabIndex = 7;
            this.textBox_ShellPath.Text = "http://";
            // 
            // textBox_ShellPass
            // 
            this.textBox_ShellPass.Location = new System.Drawing.Point(364, 35);
            this.textBox_ShellPass.Name = "textBox_ShellPass";
            this.textBox_ShellPass.Size = new System.Drawing.Size(105, 21);
            this.textBox_ShellPass.TabIndex = 9;
            this.textBox_ShellPass.Text = "passwd";
            // 
            // comboBox_ScritpType
            // 
            this.comboBox_ScritpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ScritpType.FormattingEnabled = true;
            this.comboBox_ScritpType.Location = new System.Drawing.Point(44, 63);
            this.comboBox_ScritpType.Name = "comboBox_ScritpType";
            this.comboBox_ScritpType.Size = new System.Drawing.Size(138, 20);
            this.comboBox_ScritpType.TabIndex = 11;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(371, 263);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(46, 23);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // comboBox_ServerCoding
            // 
            this.comboBox_ServerCoding.FormattingEnabled = true;
            this.comboBox_ServerCoding.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312"});
            this.comboBox_ServerCoding.Location = new System.Drawing.Point(80, 264);
            this.comboBox_ServerCoding.Name = "comboBox_ServerCoding";
            this.comboBox_ServerCoding.Size = new System.Drawing.Size(75, 20);
            this.comboBox_ServerCoding.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "Area:";
            // 
            // comboBox_Area
            // 
            this.comboBox_Area.FormattingEnabled = true;
            this.comboBox_Area.Items.AddRange(new object[] {
            "china",
            "foreign"});
            this.comboBox_Area.Location = new System.Drawing.Point(317, 8);
            this.comboBox_Area.Name = "comboBox_Area";
            this.comboBox_Area.Size = new System.Drawing.Size(60, 20);
            this.comboBox_Area.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "Remark:";
            // 
            // button_Alter
            // 
            this.button_Alter.Location = new System.Drawing.Point(423, 263);
            this.button_Alter.Name = "button_Alter";
            this.button_Alter.Size = new System.Drawing.Size(46, 23);
            this.button_Alter.TabIndex = 27;
            this.button_Alter.Text = "ALTER";
            this.button_Alter.UseVisualStyleBackColor = true;
            this.button_Alter.Click += new System.EventHandler(this.button_Alter_Click);
            // 
            // textBox_Remark
            // 
            this.textBox_Remark.Location = new System.Drawing.Point(44, 233);
            this.textBox_Remark.Name = "textBox_Remark";
            this.textBox_Remark.Size = new System.Drawing.Size(425, 21);
            this.textBox_Remark.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "ServerCode:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ini:";
            // 
            // richTextBox_Setting
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBox_Setting, 3);
            this.richTextBox_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Setting.Location = new System.Drawing.Point(0, 32);
            this.richTextBox_Setting.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.richTextBox_Setting.Name = "richTextBox_Setting";
            this.richTextBox_Setting.Size = new System.Drawing.Size(422, 102);
            this.richTextBox_Setting.TabIndex = 30;
            this.richTextBox_Setting.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "WebCode:*";
            // 
            // comboBox_WebCoding
            // 
            this.comboBox_WebCoding.FormattingEnabled = true;
            this.comboBox_WebCoding.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312"});
            this.comboBox_WebCoding.Location = new System.Drawing.Point(234, 264);
            this.comboBox_WebCoding.Name = "comboBox_WebCoding";
            this.comboBox_WebCoding.Size = new System.Drawing.Size(75, 20);
            this.comboBox_WebCoding.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_Setting, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_IniType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Items, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_insert, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 137);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // comboBox_IniType
            // 
            this.comboBox_IniType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_IniType.FormattingEnabled = true;
            this.comboBox_IniType.Location = new System.Drawing.Point(0, 3);
            this.comboBox_IniType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_IniType.Name = "comboBox_IniType";
            this.comboBox_IniType.Size = new System.Drawing.Size(115, 20);
            this.comboBox_IniType.TabIndex = 31;
            this.comboBox_IniType.SelectedIndexChanged += new System.EventHandler(this.comboBox_IniType_SelectedIndexChanged);
            // 
            // comboBox_Items
            // 
            this.comboBox_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Items.FormattingEnabled = true;
            this.comboBox_Items.Location = new System.Drawing.Point(121, 3);
            this.comboBox_Items.Name = "comboBox_Items";
            this.comboBox_Items.Size = new System.Drawing.Size(217, 20);
            this.comboBox_Items.TabIndex = 32;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(347, 3);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 33;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // FormEditWebshell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 299);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Remark);
            this.Controls.Add(this.button_Alter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox_Area);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_WebCoding);
            this.Controls.Add(this.comboBox_ServerCoding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox_ScritpType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ShellPass);
            this.Controls.Add(this.textBox_ShellPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_TargetLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TargetID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditWebshell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditWebshell";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TargetID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_TargetLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ShellPath;
        private System.Windows.Forms.TextBox textBox_ShellPass;
        private System.Windows.Forms.ComboBox comboBox_ScritpType;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBox_ServerCoding;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Area;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Alter;
        private System.Windows.Forms.TextBox textBox_Remark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_Setting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_WebCoding;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox_IniType;
        private System.Windows.Forms.ComboBox comboBox_Items;
        private System.Windows.Forms.Button btn_insert;
    }
}