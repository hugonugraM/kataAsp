using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataAsp
{
    class NashTvCompanies
    {
        private bool firstDoPublicity;
        private bool secondDoPublicity;
        private int firstWorstEarning;
        private int secondWorstEarning;


        public NashTvCompanies(bool firstDoPublicity, bool secondDoPublicity)
        {
            this.firstDoPublicity = firstDoPublicity;
            this.secondDoPublicity = secondDoPublicity;

            if (firstDoPublicity)
            {
                firstWorstEarning = 27;
            }
            else
            {
                firstWorstEarning = 20;
            }

            if (secondDoPublicity)
            {
                secondWorstEarning = 27;
            }
            else
            {
                secondWorstEarning = 20;
            }

        }

        public int[] GetEarnings()
        {
            int[] earnings = new int[2] { 0, 0 };
            if (firstDoPublicity)
            {
                if (secondDoPublicity)
                {
                    earnings = new int[2] { 27, 27 };
                }
                else
                {
                    earnings = new int[2] { 40, 20 };
                }
            }
            else
            {
                if (secondDoPublicity)
                {
                    earnings = new int[2] { 20, 40 };
                }
                else
                {
                    earnings = new int[2] { 50, 50 };
                }
            }
            return earnings;
        }

        public String GetStringEarnings()
        {
            int[] earnings = GetEarnings();
            return earnings[0].ToString() + "/" + earnings[1].ToString();
        }

        public static bool BestOption()
        {
            NashTvCompanies firstDoingPublicity = new NashTvCompanies(true, false);
            NashTvCompanies firstNotDoingPublicity = new NashTvCompanies(false, false);

            if (firstDoingPublicity.GetFirstWorstEarning() > firstNotDoingPublicity.GetFirstWorstEarning())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetFirstWorstEarning()
        {
            return firstWorstEarning;
        }

        public int GetSecondWorstPenalty()
        {
            return secondWorstEarning;
        }
    }
}
