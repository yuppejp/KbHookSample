using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace KbHookSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKey = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.labelCtrl = new System.Windows.Forms.Label();
            this.labelAlt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(42, 25);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(52, 18);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = "label1";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Location = new System.Drawing.Point(45, 77);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(43, 18);
            this.labelShift.TabIndex = 1;
            this.labelShift.Text = "Shift";
            // 
            // labelCtrl
            // 
            this.labelCtrl.AutoSize = true;
            this.labelCtrl.Location = new System.Drawing.Point(130, 77);
            this.labelCtrl.Name = "labelCtrl";
            this.labelCtrl.Size = new System.Drawing.Size(36, 18);
            this.labelCtrl.TabIndex = 2;
            this.labelCtrl.Text = "Ctrl";
            // 
            // labelAlt
            // 
            this.labelAlt.AutoSize = true;
            this.labelAlt.Location = new System.Drawing.Point(219, 77);
            this.labelAlt.Name = "labelAlt";
            this.labelAlt.Size = new System.Drawing.Size(29, 18);
            this.labelAlt.TabIndex = 3;
            this.labelAlt.Text = "Alt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAlt);
            this.Controls.Add(this.labelCtrl);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.labelKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.Label labelCtrl;
        private System.Windows.Forms.Label labelAlt;
    }

}



