using Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DAL
{
    public static class CFGReadHelper
    {
        public static string ReadCFG(out List<VcfStrStruct> vss)
        {
            vss = new List<VcfStrStruct>();
            try
            {
                string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "toolcfg" + "\\VCF.xml";
                //// 将XML文件加载进来
                XmlDocument document = new XmlDocument();
                document.Load(path);
                ////获取到XML的根元素进行操作
                XmlNodeList list = document.SelectNodes("/root/list/node");
                foreach (XmlNode item in list)
                {
                    string idstr = item.Attributes["id"].Value;
                    string keystr = item.Attributes["string"].Value;
                    int id = Convert.ToInt16(idstr);
                    DataType dt = (DataType)id;
                    VcfStrStruct tmp = new VcfStrStruct(dt, keystr);
                    vss.Add(tmp);
                }
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
    public static class TXTReadHelper
    {

        public static void CalIndex(ref List<VcfStrStruct> vss, string textFilePath)
        {
            var filestream = new System.IO.FileStream(textFilePath,
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read,
                                          System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.Default, true, 128);
            string lineOfText = file.ReadLine();
            while ((lineOfText != null))
            {
                if (lineOfText.Contains("￥"))
                {
                    Cal(ref vss, lineOfText);
                    break;
                }
                else
                {
                    lineOfText = file.ReadLine();
                }
            }
        }
        public static void Cal(ref List<VcfStrStruct> vss, string str)
        {
            for (int i = 0; i < vss.Count; i++)
            {
                int start = 0;
                CalStart(ref start, str, vss[i].KeyStr);
                vss[i].StartIndex = start;
            }
            for (int i = 0; i < vss.Count-1; i++)
            {
                vss[i].EndIndex = vss[i].StartIndex-2;
            }
        }
        public static void CalStart(ref int start, string s, string subs)
        {
            if(s.Contains(subs) == false)
            {
                return;
            }
            else
            {
                int[] res = GetSubStrCountInStr(s, subs, 0);
                if(res.Length == 1)
                {
                    start = res[0];
                }
                else
                {

                }
            }
        }

        public static int[] GetSubStrCountInStr(String str, String substr, int StartPos)
        {
            int foundPos = -1;
            int count = 0;
            List<int> foundItems = new List<int>();

            do
            {
                foundPos = str.IndexOf(substr, StartPos);
                if (foundPos > -1)
                {
                    StartPos = foundPos + 1;
                    count++;
                    foundItems.Add(foundPos);
                }
            } while (foundPos > -1 && StartPos < str.Length);

            return ((int[])foundItems.ToArray());
        }
    }
}
