using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiaWeb2._0
{
    public partial class WebForm24 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var b = Request.QueryString["id"];
            if (b != null)
                ((TIA)(this.Master)).accordion_selectedIndexChanged(System.Convert.ToInt16(b));          
        }
    }
}