using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 扫雷
{
    public partial class Form_Main : Form
    {
        public int nWidth;
        public int nHeight;
        public int nMineCnt;

        bool bMark;

        const int MAX_WIDTH = 64;
        const int MAX_HEIGHT = 32;

        /// <summary>
        /// 对于第一类数据，我们使用-1表示该区域有地雷，使用数字表示与它紧邻的八个格子中一共有多少地雷
        /// 对于第二类数据，我们使用0表示未点开，1表示点开，2表示红旗，3表示问号
        /// </summary>
        int[,] pMine = new int[MAX_WIDTH, MAX_HEIGHT];
        int[,] pState = new int[MAX_WIDTH, MAX_HEIGHT];

        int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
        int[] dy = new int[] { 1, 1, 1, 0, 0, -1, -1, -1 };

        Point MouseFocus;

        bool bMouseLeft;
        bool bMouseRight;

        int[] px = new int[] { 0,-1,1,0 };
        int[] py = new int[] { 1,0,0,-1 };

        bool bGame;

        public Form_Main()
        {
            InitializeComponent();
            MouseFocus.X = 0;
            MouseFocus.Y = 0;
            this.DoubleBuffered = true;

            nWidth = Properties.Settings.Default.Width;
            nHeight = Properties.Settings.Default.Height;
            nMineCnt = Properties.Settings.Default.MineCnt;

            bMark = Properties.Settings.Default.Mark;
            markToolStripMenuItem.Checked = bMark;

            UpdataSize();
            SelectLevel();

        }
        /// <summary>
        /// 游戏设置参数
        /// </summary>
        /// <param name="Width">雷区宽度</param>
        /// <param name="Height">雷区高度</param>
        /// <param name="MineCnt">地雷数量</param>
        private void SetGame(int Width, int Height, int MineCnt)
        {
            nWidth = Width;
            nHeight = Height;
            nMineCnt = MineCnt;
            UpdataSize();
        }
        /// <summary>
        /// 设置难度为初级
        /// </summary>
        private void SetGameBeginner()
        {
            SetGame(10, 10, 10);
        }
        private void SetGameMedium()
        {
            SetGame(20, 20, 10);
        }
        private void SetGameExpert()
        {
            SetGame(30, 30, 20);
        }

        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {
            PaintGame(e.Graphics);
        }
        /// <summary>
        /// 绘制雷区
        /// </summary>
        private void PaintGame(Graphics g)
        {
            g.Clear(Color.White);
            //Graphics g = this.CreateGraphics();
            //g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));
            int nOffsetX = 6;
            int nOffsetY = 54 + menuStrip1.Height;
            for(int i=1;i<=nWidth;i++)
            {
                for (int j = 1; j <= nHeight; j++)
                {
                    if (pState[i,j] != 1)//未点开
                    {
                        if (i == MouseFocus.X && j == MouseFocus.Y)//是否为高亮
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.SandyBrown)), 
                                            new Rectangle(nOffsetX + 34 * (i - 1) + 1, 
                                            nOffsetY + 34 * (j - 1) + 1, 
                                            32, 
                                            32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.Orange,
                                            new Rectangle(nOffsetX + 34 * (i - 1) + 1,
                                            nOffsetY + 34 * (j - 1) + 1,
                                            32,
                                            32));
                        }
                        if(pState[i,j]==2)//如果状态是旗子
                        {
                            g.DrawImage(Properties.Resources.map_marker,
                                        nOffsetX + 34 * (i - 1) + 1 + 4,
                                        nOffsetY + 34 * (j - 1) + 1 + 2);            
                        }
                        if(pState[i,j]==3)//如果是问号
                        {
                            g.DrawImage(Properties.Resources.placeholder,
                                        nOffsetX + 34 * (i - 1) + 1 + 4,
                                        nOffsetY + 34 * (j - 1) + 1 + 2);          
                        }
                    }
                    else if(pState[i,j]==1)//点开
                    {   /*
                        if(pMine[i,j]!=-1)
                        {
                        */
                            if(MouseFocus.X==i&&MouseFocus.Y==j)
                            {
                                g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.LightGray)), 
                                                new Rectangle(nOffsetX + 34 * (i - 1) + 1, 
                                                nOffsetY + 34 * (j - 1) + 1,
                                                32,
                                                32));
                            }
                            else
                            {
                                g.FillRectangle(Brushes.LightGray,
                                                new Rectangle(nOffsetX + 34 * (i - 1) + 1,
                                                nOffsetY + 34 * (j - 1) + 1, 
                                                32, 
                                                32));
                            }
                            if(pMine[i,j]>0)
                            {
                                Brush DrawBrush = new SolidBrush(Color.Blue);
                                /*
                                if (pMine[i, j] == 2) { DrawBrush = new SolidBrush(Color.Green); }
                                if (pMine[i, j] == 3) { DrawBrush = new SolidBrush(Color.Green); }
                                if (pMine[i, j] == 4) { DrawBrush = new SolidBrush(Color.Green); }
                                if (pMine[i, j] == 5) { DrawBrush = new SolidBrush(Color.Green); }
                                if (pMine[i, j] == 6) { DrawBrush = new SolidBrush(Color.Green); }
                                if (pMine[i, j] == 7) { DrawBrush = new SolidBrush(Color.Green); }
                                if (pMine[i, j] == 8) { DrawBrush = new SolidBrush(Color.Green); }
                                */
                                
                                switch(pMine[i,j])
                                {
                                    case 2:
                                        DrawBrush = new SolidBrush(Color.Green);
                                        break;
                                    case 3:
                                        DrawBrush = new SolidBrush(Color.Red);
                                        break;
                                    case 4:
                                        DrawBrush = new SolidBrush(Color.DarkBlue);
                                        break;
                                    case 5:
                                        DrawBrush = new SolidBrush(Color.DarkRed);
                                        break;
                                    case 6:
                                        DrawBrush = new SolidBrush(Color.DarkSeaGreen);
                                        break;
                                    case 7:
                                        DrawBrush = new SolidBrush(Color.Black);
                                        break;
                                    case 8:
                                        DrawBrush = new SolidBrush(Color.DarkGray);
                                        break;
                                }
                                
                                SizeF Size = g.MeasureString(pMine[i, j].ToString(), new Font("微软雅黑", 16));
                                g.DrawString(pMine[i, j].ToString(), 
                                             new Font("微软雅黑", 16),
                                             DrawBrush, 
                                             nOffsetX + 34 * (i - 1) + 1 + (32 - Size.Width) / 2, 
                                             nOffsetY + 34 * (j - 1) + 1 + (32 - Size.Height) / 2);

                            }
                        if(pMine[i,j]==-1)
                        {
                            g.DrawImage(Properties.Resources.mine,  //绘制地雷
                                         nOffsetX + 34 * (i - 1) + 1 + 4,
                                         nOffsetY + 34 * (j - 1) + 1 + 2);
                        }
                        
                    }
                }
            }
        }

        /// <summary>
        /// 自动调整窗口大小
        /// </summary>
        private void  UpdataSize()
        {
            int nOffsetX = this.Width - this.ClientSize.Width;
            int nOffsetY = this.Height - this.ClientSize.Height;
            int nAdditionY = menuStrip1.Height + tableLayoutPanel1.Height;
            this.Width = 12 + 34 * nWidth + nOffsetX;
            this.Height = 12 + 34 * nHeight + nAdditionY + nOffsetY;
            newGameToolStripMenuItem_Click(new object(), new EventArgs());
        }
        private void SelectLevel()
        {
            if (nWidth == 10 && nHeight == 10 && nMineCnt == 10)
            {
                beginnerToolStripMenuItem.Checked = true;
                settingToolStripMenuItem.Checked = false;
            }
            else
            {
                beginnerToolStripMenuItem.Checked = false;
                settingToolStripMenuItem.Checked = true;
            }
        }

        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 10;
            nHeight = 10;
            nMineCnt = 10;

            SelectLevel();
            UpdataSize();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit the game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// 系统对话框的api
        /// </summary>
        /// <param name="hWnd">窗口</param>
        /// <param name="szApp">标题文字</param>
        /// <param name="szOtherStuff">内容文字</param>
        /// <param name="hIcon">图标</param>
        /// <returns></returns>
        [DllImport("shell32.dll")]
        public extern static int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, "Minesweeper", "使用c#语言的扫雷游戏", this.Icon.Handle);
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markToolStripMenuItem.Checked = bMark = !bMark;
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting Setting = new Form_Setting(this);
            Setting.ShowDialog();
            UpdataSize();
        }

        public void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label_Mine.Text = nMineCnt.ToString();
            Label_Timer.Text = "0";
            Timer_Main.Enabled = true;
            bGame = false;

            Array.Clear(pMine, 0, pMine.Length);
            Array.Clear(pState, 0, pState.Length);

            Random random = new Random();
            for (int i = 1; i <= nMineCnt;)
            {
                int x = random.Next(nWidth) + 1;
                int y = random.Next(nHeight) + 1;

                if (pMine[x, y] != -1)
                {
                    pMine[x, y] = -1;//生成地雷
                    i++;
                }
            }
            for(int i =1;i<=nWidth;i++)
            {
                for(int j=1;j<=nHeight;j++)
                {
                   if(pMine[i,j]!=-1)
                    {
                        for(int k=0;k<8;k++)
                        {
                           if(pMine[i + dx[k], j + dy[k]] == -1)
                                pMine[i, j]++;
                        }
                    }
                 }
             }
       
        }

        private void Form_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 6 ||
                e.X > 6 + nWidth * 34 ||
                e.Y < 54 + menuStrip1.Height ||
                e.Y > 54 + menuStrip1.Height + nHeight * 34)
            {
                MouseFocus.X = 0;
                MouseFocus.Y = 0;
            }
            else
            {
                int x = (e.X - 6) / 34 +1;
                int y = (e.Y - menuStrip1.Height - 54) / 34 + 1;
                MouseFocus.X = x;
                MouseFocus.Y = y;
            }
            this.Refresh();
        }

        private void Timer_Main_Tick(object sender, EventArgs e)
        {
            Label_Timer.Text = Convert.ToString(Convert.ToInt32(Label_Timer.Text) + 1);
        }

        private void Form_Main_MouseDown(object sender, MouseEventArgs e)
        {
           if(e.Button==MouseButtons.Left)
            {
                bMouseLeft = true;
            }
           if(e.Button==MouseButtons.Right)
            {
                bMouseRight = true;
            }
        }

        private void Form_Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseFocus.X == 0 && MouseFocus.Y == 0||bGame)
                return;
            if (bMouseRight && bMouseLeft)//左右同时按下
            {

                if (pState[MouseFocus.X, MouseFocus.Y] == 1 && pMine[MouseFocus.X, MouseFocus.Y] > 0)
                {
                    int nFlagCnt = 0,
                        nDoubtCnt = 0,
                        nSysCnt = pMine[MouseFocus.X, MouseFocus.Y];
                    for (int i = 0; i < 8; i++)
                    {
                        int x = MouseFocus.X + dx[i];
                        int y = MouseFocus.Y + dy[i];
                        if (pState[x, y] == 2)
                        {
                            nFlagCnt++;
                        }
                        if (pState[x, y] == 3)
                        {
                            nDoubtCnt++;
                        }
                        if (nFlagCnt == nSysCnt || nFlagCnt + nDoubtCnt == nSysCnt)
                        {
                            bool bFlag = OpenMine(MouseFocus.X, MouseFocus.Y);
                            if (!bFlag)
                            {
                                //end
                                GameLost();
                            }
                        }
                    }
                }
            }
            else if (bMouseLeft)//左键被按下去
            {
                if (pMine[MouseFocus.X, MouseFocus.Y]!=-1)
                {
                    if (pState[MouseFocus.X, MouseFocus.Y] == 0)
                    {
                        dfs(MouseFocus.X, MouseFocus.Y);
                    } 
                }
                else
                {
                    //end
                    GameLost();
                }
            }
            else if (bMouseRight)
            {
                if (bMark)
                {
                    if (pState[MouseFocus.X, MouseFocus.Y] == 0)
                    {
                        if (Convert.ToInt32(Label_Mine.Text) > 0)
                        {
                            pState[MouseFocus.X, MouseFocus.Y] = 2;
                            Label_Mine.Text = Convert.ToString(Convert.ToInt32(Label_Mine.Text) - 1);
                        }
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 2)
                    {
                        pState[MouseFocus.X, MouseFocus.Y] = 3;
                        Label_Mine.Text = Convert.ToString(Convert.ToInt32(Label_Mine.Text) + 1);
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 3)
                    {
                        pState[MouseFocus.X, MouseFocus.Y] = 0;
                    }
                }
            }
            GameWin();
            this.Refresh();
            bMouseLeft = bMouseRight = false;
        }
       private void dfs(int sx,int sy)
       {
            pState[sx, sy] = 1;
            for(int i=0;i<4;i++)
            {
                int x = sx + px[i];
                int y = sy + py[i];
                if (x >= 1 && x <= nWidth && y >= 1 && y <= nHeight &&
                    pMine[x, y] != -1 && pMine[sx, sy] == 0 &&
                    (pState[x, y] == 0 || pState[x, y] == 3))
                {
                    dfs(x, y);  
                }
            }
       }
        private bool OpenMine(int sx,int sy)
        {
            bool bFlag = true;
            for (int i = 0; i < 8; i++) 
            {
                int x = MouseFocus.X + dx[i];
                int y = MouseFocus.Y + dy[i]; 
                if(pState[x,y]==0)
                {
                    pState[x, y] = 1;
                    if (pMine[x, y] != -1)
                    {
                        dfs(x, y);
                    }
                    else
                    { 
                        bFlag = false;
                        break;
                    }
                }
            }
            return bFlag;
        }
        private void GameLost()
        {
            for(int i=1;i<=nWidth;i++)
            {
                for(int j=1;j<=nHeight;j++)
                {
                    if(pMine[i,j]==-1&&(pState[i,j]==0||pState[i,j]==3))
                    {
                        pState[i, j] = 1;
                    }
                }
            }
            bGame = true;
        }
        /// <summary>
        /// 游戏胜利
        /// </summary>
        private void GameWin()
        {
            int nCnt = 0;
            for(int i=1;i<=nWidth;i++)
            {
                for(int j=1;j<=nHeight;j++)
                {
                    if(pState[i,j]==0||pState[i,j]==2||pState[i,j]==3)
                    {
                        nCnt++;
                    }
                }
            }
            if (nCnt == nMineCnt)
            {
                Timer_Main.Enabled = false;
                MessageBox.Show(string.Format("游戏胜利，耗时：{0} 秒 ", Label_Timer.Text), "提示", MessageBoxButtons.OK);

                //更新记录
                /*
                if (nWidth == 10 && nHeight == 10 && nMineCnt == 10) 
                {

                }
                */
                bGame =true;
            }
        }
    }
}
