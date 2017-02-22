using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YHCSK;

namespace YayoiHanbaiSDK
{
    public class SdkCallback : YHCSK.CYayoiHanbaiCommonSdkCallback
    {

        Form1 FormDialog;
        public void ErrorInfo(string ErrorMessage)
        {
          FormDialog.ResultLog.Items.Add(ErrorMessage);
        }

        public void ExecuteErrorInfo(string ErrorMessage)
        {
           FormDialog.ResultLog.Items.Add(ErrorMessage);
        }

        public void ImportErrorInfo(int ErrorLine, int ErrorCol, string ErrorItem, string ErrorMessage)
        {
            FormDialog.ResultLog.Items.Add(ErrorMessage);
        }

        public void DempyoImportInfo1(System.DateTime DempyoDate, int DempyoBango, int DempyoId, bool bResult)
        {
            if (bResult == true)
            {
                FormDialog.ResultLog.Items.Add(string.Format("伝票を登録しました 伝票日付={0} 伝票番号={1} 伝票ID={2}", DempyoDate, DempyoBango, DempyoId));
            }
            else
            {
              FormDialog.ResultLog.Items.Add(string.Format("伝票の登録に失敗しました 伝票日付={0} 伝票番号={1}", DempyoDate, DempyoBango));
            }
        }
        void YHCSK.IYayoiHanbaiCommonSdkCallback.DempyoImportInfo(System.DateTime DempyoDate, int DempyoBango, int DempyoId, bool bResult)
        {
            DempyoImportInfo1(DempyoDate, DempyoBango, DempyoId, bResult);
        }

        public void SetForm(Form1 Form)
        {
            FormDialog = Form;
        }

     


    }
}
