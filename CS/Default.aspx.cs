using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowLoadingPanelFromGrid {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridViewDemo.DataSource = Person.GetDemoData();
            ASPxGridViewDemo.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e) {
            if(!IsPostBack && !IsCallback)
                ASPxGridViewDemo.DetailRows.ExpandRow(0);
        }
        protected void ASPxCallbackDemo_Callback(object source, DevExpress.Web.ASPxCallback.CallbackEventArgs e) {
            // emulate a long lasting operation
            System.Threading.Thread.Sleep(3000);
        }
    }
}
