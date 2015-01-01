namespace AwardGet
{
    partial class showForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iTimer = new System.Windows.Forms.Timer(this.components);
            this.configEditorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlButton
            // 
            this.controlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlButton.Location = new System.Drawing.Point(202, 277);
            this.controlButton.Margin = new System.Windows.Forms.Padding(5);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(125, 40);
            this.controlButton.TabIndex = 0;
            this.controlButton.Text = "开始";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "配置文件";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(92, 4);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(100, 31);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "选取文件";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLabel.Font = new System.Drawing.Font("微软雅黑", 72F);
            this.textLabel.Location = new System.Drawing.Point(12, 38);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(523, 234);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "=w=";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = ".cfg";
            this.openFileDialog1.InitialDirectory = "C:\\Program Files\\Microsoft Visual Studio 11.0\\Common7\\IDE\\";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // iTimer
            // 
            this.iTimer.Tick += new System.EventHandler(this.iTimer_Tick);
            // 
            // configEditorButton
            // 
            this.configEditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configEditorButton.Location = new System.Drawing.Point(389, 4);
            this.configEditorButton.Name = "configEditorButton";
            this.configEditorButton.Size = new System.Drawing.Size(146, 31);
            this.configEditorButton.TabIndex = 4;
            this.configEditorButton.Text = "打开设置编辑器";
            this.configEditorButton.UseVisualStyleBackColor = true;
            this.configEditorButton.Click += new System.EventHandler(this.configEditorButton_Click);
            // 
            // showForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 331);
            this.Controls.Add(this.configEditorButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlButton);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "showForm";
            this.Text = "抽奖";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer iTimer;
        private System.Windows.Forms.Button configEditorButton;
    }
}

