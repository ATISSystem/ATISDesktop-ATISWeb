using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.TransportCompanies;

namespace R2WebPrimaryTest.UserControls
{

    public partial class UCViewerLoadCapacitorLoads : System.Web.UI.UserControl
    {

        #region "General Properties"

        private string _UCCaption = string.Empty;
        public string UCCaption
        {
            get { return _UCCaption; }
            set
            {
                _UCCaption = value;
                TblLoadCapacitorLoads.Caption = value;
            }
        }

        #endregion

        #region "Subroutins And Functions"

        private void UCViewInformation(List<R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure> YourLst)
        {
            try
            {
                while (TblLoadCapacitorLoads.Rows.Count > 1) TblLoadCapacitorLoads.Rows.RemoveAt(1);
                for (int Loopx = 0; Loopx <= YourLst.Count - 1; Loopx++)
                {
                    TableRow tempRow = new TableRow();
                    TableCell tempCell = null;
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].StrAddress; tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].StrDescription; tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].StrBarName; tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].StrPriceSug.ToString(); tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].nCarNumKol.ToString(); tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].LoaderTypeTitle; tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].LoadTargetTitle; tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].GoodTitle; tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell(); tempCell.Text = YourLst[Loopx].dDateElam + " - " + YourLst[Loopx].dTimeElam; tempRow.Cells.Add(tempCell);
                    tempCell = new TableCell();
                    LinkButton myLbnEstelamId = new LinkButton();
                    myLbnEstelamId.Click += LinkButtons_ClickHandler;
                    myLbnEstelamId.ForeColor = Color.Red;
                    myLbnEstelamId.Text = YourLst[Loopx].nEstelamId.ToString();
                    tempCell.Controls.Add(myLbnEstelamId);
                    tempRow.Cells.Add(tempCell);
                    TblLoadCapacitorLoads.Rows.Add(tempRow);
                }
                TableFooterRow tempFooterRow = new TableFooterRow();
                tempFooterRow.BackColor = Color.LightBlue;
                tempFooterRow.BorderColor = Color.LightBlue;
                TblLoadCapacitorLoads.Rows.Add(tempFooterRow);
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "/n/r" + ex.Message); }
        }

        public void UCViewNotSedimentedLoadCapacitorLoads(Int64 YourTransportCompanyId)
        {
            try
            {
                var Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNotSedimentedLoadCapacitorLoads(YourTransportCompanyId);
                UCViewInformation(Lst);
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "/n/r" + ex.Message); }
        }

        public void UCViewSedimentedLoadCapacitorLoads(Int64 YourTransportCompanyId)
        {
            try
            {
                var Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetSedimentedLoadCapacitorLoads(YourTransportCompanyId);
                UCViewInformation(Lst);
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "/n/r" + ex.Message); }
        }


        #endregion

        #region "Events"

        public class nEstelamIdEventArgs : EventArgs
        { public Int64 nEstelamId { get; set; } }

        public event EventHandler<nEstelamIdEventArgs> UCLoadCapacitorLoadSelectedEvent;


        #endregion

        #region "Event Handlers"

        private void LinkButtons_ClickHandler(Object sender, EventArgs e)
        {
            try
            { UCLoadCapacitorLoadSelectedEvent?.Invoke(this, new nEstelamIdEventArgs { nEstelamId = Convert.ToInt64(((LinkButton)sender).Text) }); }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region "Override Methods"
        #endregion

        #region "Abstract Methods"
        #endregion

        #region "Implemented Members"
        #endregion


    }
}