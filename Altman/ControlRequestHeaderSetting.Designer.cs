﻿using Controls;

namespace Altman
{
    partial class ControlRequestHeaderSetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rightMenu_Header = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.item_add = new System.Windows.Forms.ToolStripMenuItem();
            this.item_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_header = new ListViewPlus();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightMenu_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightMenu_Header
            // 
            this.rightMenu_Header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_edit,
            this.item_add,
            this.item_delete});
            this.rightMenu_Header.Name = "rightMenu_Header";
            this.rightMenu_Header.ShowImageMargin = false;
            this.rightMenu_Header.Size = new System.Drawing.Size(76, 70);
            // 
            // item_edit
            // 
            this.item_edit.Name = "item_edit";
            this.item_edit.Size = new System.Drawing.Size(75, 22);
            this.item_edit.Text = "编辑";
            this.item_edit.Click += new System.EventHandler(this.item_edit_Click);
            // 
            // item_add
            // 
            this.item_add.Name = "item_add";
            this.item_add.Size = new System.Drawing.Size(75, 22);
            this.item_add.Text = "添加";
            this.item_add.Click += new System.EventHandler(this.item_add_Click);
            // 
            // item_delete
            // 
            this.item_delete.Name = "item_delete";
            this.item_delete.Size = new System.Drawing.Size(75, 22);
            this.item_delete.Text = "删除";
            this.item_delete.Click += new System.EventHandler(this.item_delete_Click);
            // 
            // lv_header
            // 
            this.lv_header.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_header.ContextMenuStrip = this.rightMenu_Header;
            this.lv_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_header.FullRowSelect = true;
            this.lv_header.GridLines = true;
            this.lv_header.Location = new System.Drawing.Point(0, 0);
            this.lv_header.MultiSelect = false;
            this.lv_header.Name = "lv_header";
            this.lv_header.Size = new System.Drawing.Size(489, 343);
            this.lv_header.TabIndex = 1;
            this.lv_header.UseCompatibleStateImageBehavior = false;
            this.lv_header.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 250;
            // 
            // ControlRequestHeaderSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lv_header);
            this.Name = "ControlRequestHeaderSetting";
            this.Size = new System.Drawing.Size(489, 343);
            this.rightMenu_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip rightMenu_Header;
        private System.Windows.Forms.ToolStripMenuItem item_edit;
        private System.Windows.Forms.ToolStripMenuItem item_add;
        private System.Windows.Forms.ToolStripMenuItem item_delete;
        private ListViewPlus lv_header;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
