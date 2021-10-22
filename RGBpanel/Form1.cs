using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//UI相关操作在这个文件里
namespace RGBpanel
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]//实现窗口无边框拖动
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        public static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);
        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);//实现点击取色功能

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private bool inopration = false;
        RGB rgb = new RGB();
        public RGBterminal terminal= new RGBterminal();
        private const byte TotalColorBlocks = 6;//自定义颜色区最多颜色数
        public Colorblock[] colorblocks = new Colorblock[TotalColorBlocks];
        public int numsofblock = 1, selectedblock = 0;//生效的颜色块总数，当前选中的颜色块。前者从1开始后者从0
        public Form1()
        {
            InitializeComponent();
            RGBmodebox.SelectedIndex = 0;
            //子线程需要访问控件对象，需禁用跨线程安全检查
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread refreshThread = new Thread(Refreshinfo);
            refreshThread.Start();
            //初始化颜色显示框
            colorblocks[0] = new Colorblock(this);
            Updatecolor(colorblocks[selectedblock].BackColor);
            this.Controls.Add(colorblocks[0]);
            for(int i = 1; i < TotalColorBlocks; i++)
            {
                colorblocks[i] = new Colorblock(colorblocks[i - 1],this);
                this.Controls.Add(colorblocks[i]);
            }
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
        }
        //同步颜色预览到所有控件
        public void Updatecolor(Color color)
        {
            RedDisplay.Text = Convert.ToString(color.R);
            GreenDisplay.Text = Convert.ToString(color.G);
            BlueDisplay.Text = Convert.ToString(color.B);
            Color16Display.Text = RGBconvert.colorRGBto16(color.R, color.G, color.B);
            colorblocks[selectedblock].BackColor = color;
            rgb.Color[selectedblock, 0] = color.R;
            rgb.Color[selectedblock, 1] = color.G;
            rgb.Color[selectedblock, 2] = color.B;
            rgb.numofcolor = Convert.ToByte(numsofblock);
        }
        //用于展示颜色的框
        public class Colorblock : PictureBox
        {
            public int index = 0;
            private const int width = 100;
            public int ylocation = 425;
            Form1 thisform;
            public Colorblock(Colorblock preblock,Form1 form)
            {
                thisform = form;
                Size = new System.Drawing.Size(width, 50);
                BackColor = Color.FromArgb(102,204,255);
                index = preblock.index+1;
                Click += new System.EventHandler(Blockclicked);
                Location = new System.Drawing.Point(preblock.Location.X + width + 20, ylocation);
                Visible = false;
            }
            private void Blockclicked(object sender, EventArgs e)
            {
               //MessageBox.Show("Clicked!");
               thisform.selectedblock = this.index;
               thisform.selectedicon.Location = new Point(thisform.colorblocks[thisform.selectedblock].Location.X - 10,
                    thisform.colorblocks[thisform.selectedblock].Location.Y + 50 + 15);
               thisform.Updatecolor(thisform.colorblocks[thisform.selectedblock].BackColor);
            }
            public Colorblock(Form1 form)
            {
                thisform = form;
                Size = new System.Drawing.Size(width, 50);
                BackColor = Color.FromArgb(102, 204, 255);
                Location = new System.Drawing.Point(375, ylocation);
                Click += new System.EventHandler(Blockclicked);
                Visible = true;
            }
        }
        private void Closebuttonclick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Refreshinfo()
        {
            while (true)//循环刷新左下角提示和中间的动画
            {
                Thread.Sleep(200);
                infobox.Text = terminal.infotext;
                selectedicon.Visible = !selectedicon.Visible;
                Thread.Sleep(200);
                infobox.Text = terminal.infotext;
            }
        }

        private void Uploadsaveclick(object sender, EventArgs e)
        {
            if (!inopration)
            {
                inopration = true;
                this.uploadsave.BackgroundImage = global::RGBpanel.Properties.Resources.上传并保存1;
                if (!terminal.Upload(2, rgb))
                {
                    terminal.infotext = "没有收到控制器回应，可能没有上传成功";
                }
                else
                {
                    terminal.infotext = "设置上传成功。没看到期望中的颜色？再点一下上传试试。";
                }
                this.uploadsave.BackgroundImage = global::RGBpanel.Properties.Resources.上传并保存0;
                inopration = false;
            }
        }

        private void Uploadtempclick(object sender, EventArgs e)
        {
            if (!inopration)
            {
                inopration = true;
                this.uploadtemp.BackgroundImage = global::RGBpanel.Properties.Resources.上传并预览1;
                if (!terminal.Upload(1, rgb))
                {
                    terminal.infotext = "没有收到控制器回应，可能没有上传成功";
                }
                else
                {
                    terminal.infotext = "设置上传成功。当前预览中，加载当前设置可撤销。";
                }
                this.uploadtemp.BackgroundImage = global::RGBpanel.Properties.Resources.上传并预览0;
                inopration = false;
            }
        }

        private void MouseDownatMain(object sender, MouseEventArgs e)
        {//拖动窗体
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void Modechanged(object sender, EventArgs e)
        {
            RGBmodebox.Enabled = false;
            RGBmodebox.Enabled = true;//好烦啊这个蓝色的填充效果
            rgb.Mode = Convert.ToByte(RGBmodebox.SelectedIndex);
        }

        private void SpeedsetChanged(object sender, EventArgs e)
        {
            speedset.Enabled = false;
            speedset.Enabled = true;
            rgb.speed = Convert.ToByte(speedset.Value);
        }

        private void Minusbuttonclick(object sender, EventArgs e)
        {
            if (numsofblock > 1 && !inopration)
            {
                inopration = true;
                DecreaseColorBlock();
                inopration = false;
            }
        }
        private void DecreaseColorBlock()
        {
            numsofblock--;
            colorblocks[numsofblock].Visible = false;
            plusbutton.Location = new Point(colorblocks[numsofblock - 1].Location.X
                + colorblocks[numsofblock - 1].Width + 20, colorblocks[numsofblock - 1].ylocation);
            if (selectedblock >= numsofblock)
            {
                selectedblock = numsofblock - 1;
                selectedicon.Location = new Point(colorblocks[selectedblock].Location.X - 10,
                    colorblocks[selectedblock].Location.Y + 50 + 15);
                Updatecolor(colorblocks[selectedblock].BackColor);
            }
        }
        private void IncreaseColorBlock()
        {
            colorblocks[numsofblock].Visible = true;
            plusbutton.Location = new Point(colorblocks[numsofblock].Location.X
                + colorblocks[numsofblock].Width + 20, colorblocks[numsofblock].ylocation);
            selectedblock = numsofblock;
            numsofblock++;
            selectedicon.Location = new Point(colorblocks[selectedblock].Location.X - 10,
                colorblocks[selectedblock].Location.Y + 50 + 15);
            Updatecolor(colorblocks[selectedblock].BackColor);
        }
        private void Colorchartclicked(object sender, EventArgs e)
        {//单击取色
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, Control.MousePosition.X, Control.MousePosition.Y);
            ReleaseDC(IntPtr.Zero, hdc);
            colorblocks[selectedblock].BackColor = 
                Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
            Updatecolor(colorblocks[selectedblock].BackColor);
        }

        private void RGBmodebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            Updatecolor(RGBconvert.color16toRGB(Color16Display.Text));
        }

        private void LoadCurrentSettingClick(object sender, EventArgs e)
        {
            if (!inopration)
            {
                inopration = true;
                LoadCurrentSetting.BackgroundImage = global::RGBpanel.Properties.Resources.加载当前设定1;
                if (terminal.Upload(3, rgb))
                {
                    infobox.Text = "设置获取成功";
                    while (numsofblock != terminal.Com.recbuff[3])//调整颜色块数量
                    {
                        if(numsofblock > terminal.Com.recbuff[3])
                        {
                            MessageBox.Show(numsofblock.ToString() + terminal.Com.recbuff[3].ToString());
                            DecreaseColorBlock();
                        }
                        else
                        {
                            IncreaseColorBlock();
                        }
                    }
                    for(int i = 0; i < numsofblock; i++)
                    {
                        selectedblock = i;
                        Updatecolor(Color.FromArgb(terminal.Com.recbuff[3 + i * 3],
                            terminal.Com.recbuff[4 + i * 3], terminal.Com.recbuff[5 + i * 3]));
                        selectedicon.Location = new Point(colorblocks[selectedblock].Location.X - 10,
                            colorblocks[selectedblock].Location.Y + 50 + 15);
                    }
                    numsofblock = terminal.Com.recbuff[3];
                    RGBmodebox.SelectedIndex = terminal.Com.recbuff[1];
                    speedset.Value = terminal.Com.recbuff[2];
                }
                else
                {
                    infobox.Text = "设置获取失败";
                }
                LoadCurrentSetting.BackgroundImage = global::RGBpanel.Properties.Resources.加载当前设定0;
                inopration = false;
            }
        }

        private void Plusbuttonclick(object sender, EventArgs e)
        {
            if(numsofblock < TotalColorBlocks && !inopration)
            {
                inopration = true;
                IncreaseColorBlock();
                inopration = false;
            }
        }
    }
}
