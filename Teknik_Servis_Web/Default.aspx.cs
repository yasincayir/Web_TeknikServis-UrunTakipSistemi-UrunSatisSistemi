using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Teknik_Servis_Web.Entity;
namespace Teknik_Servis_Web
{
    public partial class Default : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblHakkımızda.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TblUrun.ToList();
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tblİletisim t = new Tblİletisim();
            t.ADSOYAD = TextBox1.Text;
            t.MAİL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            db.Tblİletisim.Add(t);
            db.SaveChanges();
        }
    }
}