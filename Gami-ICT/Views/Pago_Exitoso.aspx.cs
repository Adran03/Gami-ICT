﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gami_ICT.Views
{
    public partial class Pago_Exitoso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Continuar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Nombre_Parque.aspx");
        }
    }
}