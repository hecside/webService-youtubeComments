using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace passwordClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string url = @"http://localhost:18572/Password.svc/ytComments/" + DropDownList1.Text;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);
            String json = reader.ReadToEnd();




            TextBox1.Text = processJsonNewtonSoft(json);

        }

        static string processJsonNewtonSoft(String data)
        {
            Comments c = JsonConvert.DeserializeObject<Comments>(data);
            
            return c.allComments;

        }

   
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        [Serializable]
        public class Comments
        {

            public string allComments { get; set; }

        }
    }
}