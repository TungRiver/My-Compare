using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace My_Compare
{
    public static class UI
    {
        public static List<string> ShowPathList(string str,ComboBox cmb)
        {
            List<string> res = new List<string>();
            cmb.Items.Clear();
            cmb.Text = str;
            cmb.Select(str.Length, 0);
            string path =@str;
            //path = new Regex("[\\]+").Replace(@str, ",");
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo item in di.GetFiles())
                {
                    if(path.Substring(path.Length-2,1) == @"\")
                    {
                        
                    }
                    res.Add(@path +@"\"+item);
                }
                foreach (DirectoryInfo NextFolder in di.GetDirectories())
                {
                    if (path.Substring(path.Length - 2, 1) == "\\")
                    {
                        res.Add(@path + NextFolder.Name);
                    }
                    res.Add(@path + @"\" + NextFolder.Name);
                }
                return res;
            }
            catch (Exception)
            {
                return null;
            }          
        }
        
        public static string Split(string str)
        {
            int len = str.Length;
            if (len <= 1 || str.Substring(str.Length-2,1) != @"\")
            {
                return str;
            }
            else if(str.Substring(str.Length - 2, 1) == @"\")
            {
                str = str.Substring(0, str.Length - 2);
                Split(str);
            }
            return str;
        }
             

    }
}
