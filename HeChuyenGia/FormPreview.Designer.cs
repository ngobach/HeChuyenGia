﻿namespace HeChuyenGia
{
    partial class FormPreview
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
            this.edit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.edit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit.Location = new System.Drawing.Point(0, 0);
            this.edit.Name = "edit";
            this.edit.Properties.ReadOnly = true;
            this.edit.Size = new System.Drawing.Size(722, 597);
            this.edit.TabIndex = 0;
            // 
            // FormPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 597);
            this.Controls.Add(this.edit);
            this.Name = "FormPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem trước";
            ((System.ComponentModel.ISupportInitialize)(this.edit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit edit;
    }
}