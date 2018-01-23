using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kataAsp
{
    public partial class _Default : Page
    {
        private NashOptions nashOptions = new NashOptions();

        public List<String> Matrix()
        {
            return nashOptions.ValuesMatrix();
        }

        public bool[] NashValue()
        {
            return nashOptions.NashValue();
        }

        public string NashValueString()
        {
            return nashOptions.NashValueNums();
        }
    }
}