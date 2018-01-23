using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataAsp
{
    class NashOptions
    {
        private List<bool[]> options;
        private List<NashPrisioners> nashPrisioners;

        public NashOptions()
        {
            options = new List<bool[]>
            {
                new bool[2] { false, false },
                new bool[2] { false, true },
                new bool[2] { true, false },
                new bool[2] { true, true }
            };
            NashValues();
        }

        public void NashValues()
        {
            nashPrisioners = new List<NashPrisioners>();
            foreach (bool [] option in options)
            {
                nashPrisioners.Add(new NashPrisioners(option[0], option[1]));
            }
        }

        public List<String> ValuesMatrix()
        {
            List<String> list = new List<String>();
            foreach (NashPrisioners prisioners in nashPrisioners)
            {
                list.Add(prisioners.GetStringPenalties());
            }
            return list;
        }

        public bool[] NashValue()
        {
            bool[] options = new bool[2] { NashPrisioners.BestOption(), NashPrisioners.BestOption() };
            return options;
        }

        public string NashValueNums()
        {
            return new NashPrisioners(NashPrisioners.BestOption(), NashPrisioners.BestOption()).GetStringPenalties();
        }
    }
}
