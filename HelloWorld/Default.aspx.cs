using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_valider_Click(object sender, EventArgs e)
        {
            this.Lbl_resultat.Text = "Vous avez saisie :" + this.Txt_saisie.Text;
        }

        protected void Txt_saisie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}