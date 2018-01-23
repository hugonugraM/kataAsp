using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataAsp
{
    class NashPrisioners
    {
        private bool firstConfess;
        private bool secondConfess;
        private int firstWorstPenalty;
        private int secondWorstPenalty;


        public NashPrisioners(bool firstConfess, bool secondConfess)
        {
            this.firstConfess = firstConfess;
            this.secondConfess = secondConfess;

            if (firstConfess)
            {
                firstWorstPenalty = 5;
            }
            else
            {
                firstWorstPenalty = 10;
            }

            if (secondConfess)
            {
                secondWorstPenalty = 10;
            }
            else
            {
                secondWorstPenalty = 5;
            }

        }

        public int[] GetPenalties()
        {
            int[] penalties = new int[2] { 0,0 };
            if (firstConfess)
            {
                if (secondConfess)
                {
                    penalties = new int[2] { 5, 5 };
                }
                else
                {
                    penalties = new int[2] { 0, 10 };
                }
            } 
            else
            {
                if (secondConfess)
                {
                    penalties = new int[2] { 10, 0 };
                }
                else
                {
                    penalties = new int[2] { 1, 1 };
                }
            }
            return penalties;
        }

        public int WorstPenaltiesSum()
        {
            return firstWorstPenalty + secondWorstPenalty;
        }

        public String GetStringPenalties()
        {
            int[] penalties = GetPenalties();
            return penalties[0].ToString() + "/" + penalties[1].ToString();
        }

        public static bool BestOption()
        {
            NashPrisioners firstConfessing = new NashPrisioners(true, false);
            NashPrisioners firstNotConfessing = new NashPrisioners(false, false);

            if (firstConfessing.GetFirstWorstPenalty() < firstNotConfessing.GetFirstWorstPenalty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetFirstWorstPenalty()
        {
            return firstWorstPenalty;
        }

        public int GetSecondWorstPenalty()
        {
            return secondWorstPenalty;
        }
    }
}
