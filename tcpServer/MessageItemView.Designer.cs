﻿namespace tcpserver
{
    partial class MessageItemView
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_GroupName = new System.Windows.Forms.GroupBox();
            this.label_FlagStatus = new System.Windows.Forms.Label();
            this.label_LastConnectTime = new System.Windows.Forms.Label();
            this.label_ElapsedTime = new System.Windows.Forms.Label();
            this.label_LastMessage = new System.Windows.Forms.Label();
            this.button_Log = new System.Windows.Forms.Button();
            this.groupBox_GroupName.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_GroupName
            // 
            this.groupBox_GroupName.Controls.Add(this.button_Log);
            this.groupBox_GroupName.Controls.Add(this.label_LastMessage);
            this.groupBox_GroupName.Controls.Add(this.label_ElapsedTime);
            this.groupBox_GroupName.Controls.Add(this.label_LastConnectTime);
            this.groupBox_GroupName.Controls.Add(this.label_FlagStatus);
            this.groupBox_GroupName.Location = new System.Drawing.Point(5, 5);
            this.groupBox_GroupName.Name = "groupBox_GroupName";
            this.groupBox_GroupName.Size = new System.Drawing.Size(490, 95);
            this.groupBox_GroupName.TabIndex = 0;
            this.groupBox_GroupName.TabStop = false;
            this.groupBox_GroupName.Text = "GroupName";
            // 
            // label_FlagStatus
            // 
            this.label_FlagStatus.AutoSize = true;
            this.label_FlagStatus.Location = new System.Drawing.Point(6, 18);
            this.label_FlagStatus.Name = "label_FlagStatus";
            this.label_FlagStatus.Size = new System.Drawing.Size(73, 15);
            this.label_FlagStatus.TabIndex = 0;
            this.label_FlagStatus.Text = "FlagStatus";
            // 
            // label_LastConnectTime
            // 
            this.label_LastConnectTime.AutoSize = true;
            this.label_LastConnectTime.Location = new System.Drawing.Point(6, 45);
            this.label_LastConnectTime.Name = "label_LastConnectTime";
            this.label_LastConnectTime.Size = new System.Drawing.Size(120, 15);
            this.label_LastConnectTime.TabIndex = 0;
            this.label_LastConnectTime.Text = "LastConnectTime";
            // 
            // label_ElapsedTime
            // 
            this.label_ElapsedTime.AutoSize = true;
            this.label_ElapsedTime.Location = new System.Drawing.Point(6, 60);
            this.label_ElapsedTime.Name = "label_ElapsedTime";
            this.label_ElapsedTime.Size = new System.Drawing.Size(85, 15);
            this.label_ElapsedTime.TabIndex = 0;
            this.label_ElapsedTime.Text = "ElapsedTime";
            // 
            // label_LastMessage
            // 
            this.label_LastMessage.Location = new System.Drawing.Point(169, 17);
            this.label_LastMessage.Name = "label_LastMessage";
            this.label_LastMessage.Size = new System.Drawing.Size(290, 72);
            this.label_LastMessage.TabIndex = 1;
            this.label_LastMessage.Text = "Message";
            // 
            // button_Log
            // 
            this.button_Log.Location = new System.Drawing.Point(465, 9);
            this.button_Log.Name = "button_Log";
            this.button_Log.Size = new System.Drawing.Size(24, 80);
            this.button_Log.TabIndex = 2;
            this.button_Log.UseVisualStyleBackColor = true;
            this.button_Log.Click += new System.EventHandler(this.button_Log_Click);
            // 
            // MessageItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_GroupName);
            this.Name = "MessageItemView";
            this.Size = new System.Drawing.Size(500, 100);
            this.groupBox_GroupName.ResumeLayout(false);
            this.groupBox_GroupName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_ElapsedTime;
        private System.Windows.Forms.Button button_Log;
        public System.Windows.Forms.GroupBox groupBox_GroupName;
        public System.Windows.Forms.Label label_FlagStatus;
        public System.Windows.Forms.Label label_LastConnectTime;
        public System.Windows.Forms.Label label_LastMessage;
    }
}
