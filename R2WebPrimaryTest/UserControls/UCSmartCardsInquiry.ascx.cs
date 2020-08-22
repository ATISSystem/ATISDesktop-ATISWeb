using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PayanehClassLibrary.CarTrucksManagement;
using PayanehClassLibrary.DriverTrucksManagement;

namespace R2WebPrimaryTest.UserControls
{
    public partial class UCSmartCardsInquiry : System.Web.UI.UserControl
    {
        public string UCGetTruckSmartCardNo()
        { return TxtTruckSmartCardNo.Text; }

        public string UCGetTruckDriverSmartCardNo()
        { return TxtTruckDriverSmartCardNo.Text; }

        private void UCRefreshInformation()
        {
            TxtTruckDriverSmartCardNo.Text = string.Empty;
            TxtTruckSmartCardNo.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BtnGetTruckSmartCardInfoFromRMTO.Click += BtnGetTruckSmartCardInfoFromRMTO_Click;
            BtnGetTruckSmartCardInfoFromPayaneh.Click += BtnGetTruckSmartCardInfoFromPayaneh_Click;
            BtnGetTruckDriverSmartCardInfoFromRMTO.Click += BtnGetTruckDriverSmartCardInfoFromRMTO_Click;
            BtnGetTruckDriverSmartCardInfoFromPayaneh.Click += BtnGetTruckDriverSmartCardInfoFromPayaneh_Click;
            LblMessage.Text = string.Empty;
        }

        private void BtnGetTruckDriverSmartCardInfoFromPayaneh_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruckDriver.Text = string.Empty;
                R2StandardDriverTruckStructure NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbySmartCardNo(TxtTruckDriverSmartCardNo.Text);
                LblTruckDriver.Text = NSS.NSSDriver.StrPersonFullName.Trim();
            }
            catch (Exception ex)
            { LblMessage.Text = ex.Message; }
        }

        private void BtnGetTruckDriverSmartCardInfoFromRMTO_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruckDriver.Text = string.Empty;
                R2StandardDriverTruckStructure NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetDriverTruckfromRMTOAndInsertUpdateLocalDataBase(TxtTruckDriverSmartCardNo.Text);
                LblTruckDriver.Text = NSS.NSSDriver.StrPersonFullName.Trim();
            }
            catch (Exception ex)
            { LblMessage.Text = ex.Message; }
        }

        private void BtnGetTruckSmartCardInfoFromPayaneh_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruck.Text = string.Empty;
                R2StandardCarTruckStructure NSS = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckbyBodyNo(TxtTruckSmartCardNo.Text);
                LblTruck.Text = NSS.NSSCar.GetCarPelakSerialComposit();
            }
            catch (Exception ex)
            { LblMessage.Text = ex.Message; }
        }

        private void BtnGetTruckSmartCardInfoFromRMTO_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruck.Text = string.Empty;
                R2StandardCarTruckStructure NSS = PayanehClassLibraryMClassCarTrucksManagement.GetCarTruckfromRMTOAndInsertUpdateLocalDataBase(TxtTruckSmartCardNo.Text);
                LblTruck.Text = NSS.NSSCar.GetCarPelakSerialComposit();
            }
            catch (Exception ex)
            { LblMessage.Text = ex.Message; }
        }


    }
}