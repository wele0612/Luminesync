using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
/*作者：wele 2020年12月
 * 原理：程序开始时会生成一个下位机对象，并在生成时枚举端口，挨个发送
 * 握手包。下位机收到握手包后将握手包第二个字节+1并返回。接收到握手包
 * 后连接建立完毕。upload方法将在设置发出后等待确认包（将收到的设置发
 * 回），如果发送失败或没有收到确认包，将尝试重建下位机对象&握手，如
 * 还不行则提示未连接，请检查连接后重试。
 * 不知道为啥arduino下位机代码必须用char储存串口收到的信息，byte不行
 * 串口波特率：38400 校验位偶 停止位1
 */
 //串口通信部分在这个文件里
namespace RGBpanel
{
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mainform = new Form1();
            Application.Run(mainform);
            }
        
    }
    
    public class Comport //串口对象，供RGBterminal调用
    {
        private bool isbusy = false;
        public byte[] recbuff = new byte[65];
        public SerialPort port = new SerialPort();
        public Comport()
        { 
        }
        public void setup()
        {
            port.StopBits = StopBits.One;//停止位为1
            port.Parity = Parity.Even;//校验位偶
            port.BaudRate = 38400;//波特率
            port.DataBits = 8;
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
            port.DiscardInBuffer();
        }
        public void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isbusy)
            {
                isbusy = true;
                System.Threading.Thread.Sleep(100); //等待消息传输完成
                port.Read(recbuff, 0, 64);
                string info = null;
                for (int i = 0; i < 15; i++)
                {
                    info += recbuff[i];
                    info += " ";
                }
                //MessageBox.Show("调试信息:" + port.PortName + "收到了" + info);
                port.DiscardInBuffer();
                isbusy = false;
            }
        }
        public void connect()//连接
        {
            try
            {
                port.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("尝试连接时出现问题。");
            }
        }
        public void disconnect()//断开连接
        {
            port.Close();
        }
        public bool sendmsg(byte[] msg)//发送消息并返回是否发送成功
        {
            try
            {
                //port.Open();
                port.Write(msg, 0, msg.Length);
            }
            catch (Exception)
            {
                MessageBox.Show(port.PortName+"尝试发送数据时出现问题。");
                return false;
            }
            string info = null;
            for (int i = 0; i < msg.Length; i++)
            {
                info += msg[i];
                info += " ";
            }
            //MessageBox.Show("调试信息："+ port.PortName + "发送了"+info);
            return true;
        }
        public bool handshake()//握手确认设备。下位机将握手包第二个字节+1后返回
        {
            byte[] hspack = { 100, 78 };
            sendmsg(hspack);
            System.Threading.Thread.Sleep(300);
            byte[] recpack = recbuff;
            return recpack[0] == hspack[1] + 1;
        }
        public string[] getcomlist()
        {
        string[] cnames = SerialPort.GetPortNames();
        if (cnames.Length <= 0)
        {
            MessageBox.Show("错误：未找到任何串口。请检查连接");
            Environment.Exit(0);
        }
        Array.Sort(cnames);
        return cnames;
        }
    }

    public class RGB//存储当前的设置
    {
        public byte[,] Color = new byte[10,3];//最多10个RGB值
        public byte Switchtime, speed = 5, numofcolor = 1, Mode = 0;
    }

    public class RGBterminal//下位机终端
    {
        public Comport Com = new Comport();
        public String infotext = "无提示";
        public RGBterminal()
        {//构造方法，初始化
            string[] portlist = Com.getcomlist();
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < portlist.Length; i++)
                {
                    try
                    {
                        Com.port = new SerialPort(portlist[i]);
                        Com.port.Open();
                        Com.setup();
                        if (Com.handshake())
                        {
                            //MessageBox.Show("调试信息：" + Com.port.PortName + "握手成功！");
                            infotext = "位于" + Com.port.PortName + "的控制器握手成功";
                            return;
                        }
                        Com.port.Close();
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            //MessageBox.Show("没有握手成功。最后测试的端口为" + Com.port.PortName);
            infotext = "没有握手成功。尝试至" + Com.port.PortName + "。别慌，很多时候重开下应用就好了";
        }
        public bool Upload(byte goal,RGB rgb)//与下位机的数据交互
        {
            byte[] msg = new byte[30];
            switch (goal)
            {
                case 1://发送设置用于预览
                case 2://发送设置并保存
                    infotext = "正在打包并上传";
                    msg[0] = Convert.ToByte(goal + 100);
                    msg[1] = 35;
                    msg[2] = rgb.Mode;
                    msg[3] = rgb.speed;
                    msg[4] = rgb.numofcolor;
                    for(int i = 0; i < rgb.numofcolor; i++)
                    {
                        msg[3 * (i + 1) + 2] = Convert.ToByte(rgb.Color[i, 0] / 4) ;
                        msg[3 * (i + 1) + 3] = Convert.ToByte(rgb.Color[i, 1] / 4);
                        msg[3 * (i + 1) + 4] = Convert.ToByte(rgb.Color[i, 2] / 4);
                    }
                    Com.sendmsg(msg);
                    System.Threading.Thread.Sleep(300);//等待下位机发送确认包
                    return Com.recbuff[0] == msg[1] + 1;//检查确认包
                case 3://取得当前设置并写入RGB对象
                    msg[0] = 103;
                    msg[1] = 78;
                    Com.sendmsg(msg);
                    return Com.recbuff[0] == msg[1] + 1;
            }
            return false;
        }
        private byte[] encodesetting(byte[] setting,int goal)
        {
            
            return setting;
        }
    }
}
