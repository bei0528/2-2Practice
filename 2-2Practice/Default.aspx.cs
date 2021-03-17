using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int i_n = 1000;
            bool a_IsLeap = false;

            if (i_n % 4 == 0)
            {
                a_IsLeap = true;

                if (i_n % 100 == 0)
                {
                    if (i_n % 400 == 0)
                    {
                        a_IsLeap = true;
                    }
                    else
                    {
                        a_IsLeap = false;
                    }
                }
            }

            if (a_IsLeap == true)
            {
                Response.Write("Y");
            }
            else
            {
                Response.Write("N");
            }
        }
    }
}