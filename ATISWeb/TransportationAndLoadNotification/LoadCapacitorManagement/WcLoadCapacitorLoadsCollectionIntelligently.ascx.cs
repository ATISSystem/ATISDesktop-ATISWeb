using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;
using ATISWeb.LoginManagement;
using R2Core.PublicProc;
using R2Core.UserManagement;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
 
namespace ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement
{
    public partial class WcLoadCapacitorLoadsCollectionIntelligently : UserControl
    {
        #region "General Properties"


        public LoadCapacitorLoadsListType WcCurrentListType = LoadCapacitorLoadsListType.None;

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

        public void WcViewInformation()
        {
            try
            {
                var TCId = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(ATISWebMClassLoginManagement.GetNSSCurrentUser()).TCId;
                List<R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure> Lst = null;
                if (WcCurrentListType == LoadCapacitorLoadsListType.NotSedimented)
                {
                    LblCaption.Text = "لیست بار موجود";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNotSedimentedLoadCapacitorLoads(TCId);
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.Sedimented)
                {
                    LblCaption.Text = "لیست بار رسوب شده";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetSedimentedLoadCapacitorLoads(TCId);
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.TommorowLoad)
                {
                    LblCaption.Text = "لیست بار فردا";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTommorowLoadCapacitorLoads(TCId);
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.None)
                { throw new Exception("نوع لیست بار صحیح نیست"); }

                while (TblLoadCapacitorLoads.Rows.Count > 1) TblLoadCapacitorLoads.Rows.RemoveAt(1);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    TableRow tempRow = new TableRow();
                    TableCell tempCell = null;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].StrAddress; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].StrBarName; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].StrDescription; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Lst[Loopx].StrPriceSug); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].nCarNum.ToString(); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].nCarNumKol.ToString(); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].LoaderTypeTitle; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].LoadTargetTitle; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].GoodTitle; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].dDateElam + " - " + Lst[Loopx].dTimeElam; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].nEstelamId.ToString(); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    TblLoadCapacitorLoads.Rows.Add(tempRow);
                }
                TableFooterRow tempFooterRow = new TableFooterRow();
                tempFooterRow.BackColor = Color.LightBlue;
                tempFooterRow.BorderColor = Color.LightBlue;
                TblLoadCapacitorLoads.Rows.Add(tempFooterRow);
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        #endregion

        #region "Events"

        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try { BtnRefresh.Click += BtnRefresh_Click; }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            try { WcViewInformation(); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
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