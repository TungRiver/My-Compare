using DAL;
using Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BProcess
    {
        List<VcfStrStruct> VSS;
        List<VcfDataStruct> VDS;
        public string FileName;
        public string path1;

        public void Intila(string p)
        {
            path1 = p;
            CFGReadHelper.ReadCFG(out VSS);
            TXTReadHelper.CalIndex(ref VSS, path1);
        }


    }
}
