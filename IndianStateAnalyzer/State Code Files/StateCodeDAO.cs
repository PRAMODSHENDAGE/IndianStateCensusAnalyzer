using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyzer.State_Code_Files
{
    internal class StateCodeDAO
    {
        public string SrNo;
        public long StateName;
        public long TIN;
        public long StateCode;
        public StateCodeDAO(string SrNo, string StateName, string TIN, string StateCode)
        {
            this.SrNo = SrNo;
            this.StateName = Convert.ToUInt32(StateName);
            this.TIN = Convert.ToUInt32(TIN);
            this.StateCode = Convert.ToUInt32(StateCode);
        }
    }
}
