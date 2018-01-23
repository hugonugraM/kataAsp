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
        private List<NashTvCompanies> nashTvCompanies;

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
            nashTvCompanies = new List<NashTvCompanies>();
            foreach (bool[] option in options)
            {
                nashTvCompanies.Add(new NashTvCompanies(option[0], option[1]));
            }
        }

        public List<String> ValuesMatrix()
        {
            List<String> list = new List<String>();
            foreach (NashTvCompanies prisioners in nashTvCompanies)
            {
                list.Add(prisioners.GetStringEarnings());
            }
            return list;
        }

        public bool[] NashValue()
        {
            bool[] options = new bool[2] { NashTvCompanies.BestOption(), NashTvCompanies.BestOption() };
            return options;
        }

        public string NashValueNums()
        {
            return new NashTvCompanies(NashTvCompanies.BestOption(), NashTvCompanies.BestOption()).GetStringEarnings();
        }
    }
}
