﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gami_ICT.Views
{
    public partial class Parq_Musep_Especifico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = ControladorDB.Instance.selectnombrehotel();
            GridView_Hotel.DataSource = dt;
            GridView_Hotel.DataBind();

            dt = ControladorDB.Instance.selectnombrerestaurante();
            GridView_Restaurante.DataSource = dt;
            GridView_Restaurante.DataBind();
        }

        protected void BTN_Parques_Click(object sender, EventArgs e)
        {

        }

        protected void GridView_Hotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        String nombre_Hotel;
        DateTime fechaInicial_Hotel;
        DateTime fechaFinal_Hotel;
        String tipo_Hotel;
        int cantidad_Hotel;

        DateTime fecha_Restaurante;
        String nombre_Restaurante;
        int cantidad_Restaurante;
        protected void Button_Hotel_Click(object sender, EventArgs e)
        {
            nombre_Hotel = GridView_Hotel.SelectedValue.ToString();
            fechaInicial_Hotel = Calendar_Hotel.SelectedDate;
            fechaFinal_Hotel = Calendar2_Hotel.SelectedDate;
            tipo_Hotel = 
        }

        protected void Button_Restaurante_Click(object sender, EventArgs e)
        {

        }
    }
}