using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mode
{
    public enum DataType
    {
        RMBFlag,
        SigType,
        DeviceName,
        TypeCode,
        FileName,
        GenPara,
        KeppPara,
        TimePara,
        Input_1,
        Output_1,
        Input_2,
        Output_2,
        Input_3,
        Output_3,
        Input_4,
        Output_4,
        Input_5,
        Output_5,
        Remarks
    }
    public class VcfStrStruct
    {
        private DataType nowType;
        private string keyStr;
        private int startIndex;
        private int endIndex;

        public VcfStrStruct(DataType dt, string str)
        {
            this.nowType = dt;
            this.keyStr = str;
        }

        public DataType NowType
        {
            get
            {
                return nowType;
            }

            set
            {
                nowType = value;
            }
        }

        public string KeyStr
        {
            get
            {
                return keyStr;
            }

            set
            {
                keyStr = value;
            }
        }

        public int StartIndex
        {
            get
            {
                return startIndex;
            }

            set
            {
                startIndex = value;
            }
        }

        public int EndIndex
        {
            get
            {
                return endIndex;
            }

            set
            {
                endIndex = value;
            }
        }
    }

    public class VcfDataStruct
    {
        private int id;
        private List<Dictionary<DataType, string>> strDic;
        private int startLineNum;
        private int endLineNum;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public List<Dictionary<DataType, string>> StrDic
        {
            get
            {
                return strDic;
            }

            set
            {
                strDic = value;
            }
        }

        public int StartLineNum
        {
            get
            {
                return startLineNum;
            }

            set
            {
                startLineNum = value;
            }
        }

        public int EndLineNum
        {
            get
            {
                return endLineNum;
            }

            set
            {
                endLineNum = value;
            }
        }
    }
}
