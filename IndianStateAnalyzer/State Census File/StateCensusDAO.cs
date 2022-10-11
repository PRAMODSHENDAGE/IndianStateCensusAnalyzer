using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyzer
{
    internal class StateCensusDAO
    {
        public string State;
        public long Population;
        public long AreaInSqKm;
        public long DensityPerSqKm;
        public StateCensusDAO(string State, string Population, string AreaInSqKm, string DensityPerSqKm)
        {
            this.State = State;
            this.Population = Convert.ToUInt32(Population);
            this.AreaInSqKm = Convert.ToUInt32(AreaInSqKm);
            this.DensityPerSqKm = Convert.ToUInt32(DensityPerSqKm);
        }
    }
}
