namespace GaSIM_Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.RuntimeConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.SourceConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.接收端配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预测命中率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RuntimeConfig,
            this.报表ToolStripMenuItem,
            this.其他ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(622, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // RuntimeConfig
            // 
            this.RuntimeConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SourceConfig,
            this.接收端配置ToolStripMenuItem});
            this.RuntimeConfig.Name = "RuntimeConfig";
            this.RuntimeConfig.Size = new System.Drawing.Size(80, 21);
            this.RuntimeConfig.Text = "运行时配置";
            // 
            // SourceConfig
            // 
            this.SourceConfig.Name = "SourceConfig";
            this.SourceConfig.Size = new System.Drawing.Size(152, 22);
            this.SourceConfig.Text = "运行参数配置";
            this.SourceConfig.Click += new System.EventHandler(this.SourceConfigClick);
            // 
            // 接收端配置ToolStripMenuItem
            // 
            this.接收端配置ToolStripMenuItem.Name = "接收端配置ToolStripMenuItem";
            this.接收端配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.接收端配置ToolStripMenuItem.Text = "接收端配置";
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.历史KToolStripMenuItem,
            this.预测命中率ToolStripMenuItem});
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // 历史KToolStripMenuItem
            // 
            this.历史KToolStripMenuItem.Name = "历史KToolStripMenuItem";
            this.历史KToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.历史KToolStripMenuItem.Text = "历史K线图";
            // 
            // 预测命中率ToolStripMenuItem
            // 
            this.预测命中率ToolStripMenuItem.Name = "预测命中率ToolStripMenuItem";
            this.预测命中率ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.预测命中率ToolStripMenuItem.Text = "预测命中率";
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出数据ToolStripMenuItem,
            this.导入数据ToolStripMenuItem});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // 导出数据ToolStripMenuItem
            // 
            this.导出数据ToolStripMenuItem.Name = "导出数据ToolStripMenuItem";
            this.导出数据ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.导出数据ToolStripMenuItem.Text = "导出数据";
            // 
            // 导入数据ToolStripMenuItem
            // 
            this.导入数据ToolStripMenuItem.Name = "导入数据ToolStripMenuItem";
            this.导入数据ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.导入数据ToolStripMenuItem.Text = "导入数据";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 395);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.Text = "黄金股票短线精灵";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem RuntimeConfig;
        private System.Windows.Forms.ToolStripMenuItem SourceConfig;
        private System.Windows.Forms.ToolStripMenuItem 接收端配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史KToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预测命中率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入数据ToolStripMenuItem;
    }
}

