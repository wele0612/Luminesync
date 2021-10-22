using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBpanel
{
    class RGBconvert
    {
        #region [颜色：16进制转成RGB]
        public static Color color16toRGB(string strHxColor)
        {
            try
            {
                if (strHxColor.Length == 0)
                {//如果为空
                    return System.Drawing.Color.FromArgb(102,204,255);//设为默认
                }
                else
                {//转换颜色
                    return System.Drawing.Color.FromArgb(System.Int32.Parse(
                        strHxColor.Substring(1, 2), System.Globalization.NumberStyles.AllowHexSpecifier), 
                        System.Int32.Parse(strHxColor.Substring(3, 2), System.Globalization.NumberStyles.AllowHexSpecifier), 
                        System.Int32.Parse(strHxColor.Substring(5, 2), System.Globalization.NumberStyles.AllowHexSpecifier));
                }
            }
            catch
            {//设为默认
                return System.Drawing.Color.FromArgb(102,204,255);
            }
        }
        #endregion 
        #region [颜色：RGB转成16进制]
        public static string colorRGBto16(int R, int G, int B)
        {
            return System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(R, G, B));
        }
        #endregion

    }

}
