using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interaccion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSaludo.Visible = false;
        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Visible = true;
            lblSaludo.Text = $"Hola {txtNombre.Text}";
        }
    }
}