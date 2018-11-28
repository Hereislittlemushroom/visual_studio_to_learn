namespace 扫雷
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.beginnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.rankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Mine = new System.Windows.Forms.Label();
            this.Label_Timer = new System.Windows.Forms.Label();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.PictureBox_Mine = new System.Windows.Forms.PictureBox();
            this.PictureBox_Timer = new System.Windows.Forms.PictureBox();
            this.Button_face = new System.Windows.Forms.Button();
            this.toolStripMenuItem_medium = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_expert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameGToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameGToolStripMenuItem
            // 
            this.gameGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.beginnerToolStripMenuItem,
            this.toolStripMenuItem_medium,
            this.toolStripMenuItem_expert,
            this.toolStripMenuItem2,
            this.settingToolStripMenuItem,
            this.toolStripMenuItem3,
            this.markToolStripMenuItem,
            this.toolStripMenuItem4,
            this.rankToolStripMenuItem,
            this.toolStripMenuItem5,
            this.exitToolStripMenuItem});
            this.gameGToolStripMenuItem.Name = "gameGToolStripMenuItem";
            this.gameGToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.gameGToolStripMenuItem.Text = "游戏(&G)";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "新的游戏";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // beginnerToolStripMenuItem
            // 
            this.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            this.beginnerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beginnerToolStripMenuItem.Text = "初学者";
            this.beginnerToolStripMenuItem.Click += new System.EventHandler(this.beginnerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingToolStripMenuItem.Text = "设置";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markToolStripMenuItem.Text = "Mark(?)";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // rankToolStripMenuItem
            // 
            this.rankToolStripMenuItem.Name = "rankToolStripMenuItem";
            this.rankToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rankToolStripMenuItem.Text = "排名";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.helpHToolStripMenuItem.Text = "帮助(&H)";
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutAToolStripMenuItem.Text = "关于";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.aboutAToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.PictureBox_Mine, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PictureBox_Timer, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label_Mine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label_Timer, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_face, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 48);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Label_Mine
            // 
            this.Label_Mine.AutoSize = true;
            this.Label_Mine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Mine.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Mine.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Mine.Location = new System.Drawing.Point(51, 0);
            this.Label_Mine.Name = "Label_Mine";
            this.Label_Mine.Size = new System.Drawing.Size(54, 48);
            this.Label_Mine.TabIndex = 4;
            this.Label_Mine.Text = "Label_Mine";
            this.Label_Mine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Timer
            // 
            this.Label_Timer.AutoSize = true;
            this.Label_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Timer.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Timer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Timer.Location = new System.Drawing.Point(441, 0);
            this.Label_Timer.Name = "Label_Timer";
            this.Label_Timer.Size = new System.Drawing.Size(54, 48);
            this.Label_Timer.TabIndex = 5;
            this.Label_Timer.Text = "Label_Timer";
            this.Label_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Interval = 1000;
            this.Timer_Main.Tick += new System.EventHandler(this.Timer_Main_Tick);
            // 
            // PictureBox_Mine
            // 
            this.PictureBox_Mine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Mine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Mine.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Mine.Image")));
            this.PictureBox_Mine.Location = new System.Drawing.Point(3, 3);
            this.PictureBox_Mine.Name = "PictureBox_Mine";
            this.PictureBox_Mine.Size = new System.Drawing.Size(42, 42);
            this.PictureBox_Mine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Mine.TabIndex = 2;
            this.PictureBox_Mine.TabStop = false;
            // 
            // PictureBox_Timer
            // 
            this.PictureBox_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Timer.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Timer.Image")));
            this.PictureBox_Timer.Location = new System.Drawing.Point(501, 3);
            this.PictureBox_Timer.Name = "PictureBox_Timer";
            this.PictureBox_Timer.Size = new System.Drawing.Size(43, 42);
            this.PictureBox_Timer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Timer.TabIndex = 3;
            this.PictureBox_Timer.TabStop = false;
            // 
            // Button_face
            // 
            this.Button_face.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_face.BackgroundImage")));
            this.Button_face.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_face.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_face.Location = new System.Drawing.Point(252, 3);
            this.Button_face.Name = "Button_face";
            this.Button_face.Size = new System.Drawing.Size(42, 42);
            this.Button_face.TabIndex = 6;
            this.Button_face.UseVisualStyleBackColor = true;
            this.Button_face.Click += new System.EventHandler(this.Button_face_Click);
            // 
            // toolStripMenuItem_medium
            // 
            this.toolStripMenuItem_medium.Name = "toolStripMenuItem_medium";
            this.toolStripMenuItem_medium.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_medium.Text = "中等";
            // 
            // toolStripMenuItem_expert
            // 
            this.toolStripMenuItem_expert.Name = "toolStripMenuItem_expert";
            this.toolStripMenuItem_expert.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_expert.Text = "专家";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "扫雷";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem beginnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem rankToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PictureBox_Mine;
        private System.Windows.Forms.Timer Timer_Main;
        private System.Windows.Forms.PictureBox PictureBox_Timer;
        private System.Windows.Forms.Label Label_Mine;
        private System.Windows.Forms.Label Label_Timer;
        private System.Windows.Forms.Button Button_face;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_medium;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_expert;
    }
}

