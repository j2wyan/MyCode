using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YayoiHanbaiSDK
{
    public partial class Form1 : Form
    {
        public enum enumProductType : int
        {
            HANBAI_16 = 11,
            HANBAI_15 = 10,
            HANBAI_14 = 9,
            HANBAI_13 = 8,
            HANBAI_12 = 7,
            HANBAI_11 = 6,
            HANBAI_10 = 5,
            HANBAI_09 = 4,
            HANBAI_08 = 3,
            HANBAI_07 = 2,
            HANBAI_06 = 1,
            HANBAI_AUTO = -1
        }

        public enum enumTexType : int
        {
            CVS = 1,
            TAB,
            SPACE
        }


        public enum enumImportObject : int
        {
            Tokuisaki = 1,
            Shiiresaki,
            Shohin,
            Tantosha,
            Nonyusaki,
            TokuisakiKakakuhyo,
            ShiiresakiKakakuhyo,
            KoseiBuhinDaicho,
            SokoDaicho,
            JuchuDempyo = 101,
            HattchuDempyo,
            UriageDempyo,
            ShiireDempyo,
            NyukinDempyo,
            ShukkoDempyo,
            Mitsumorisho,
            SokoDempyo,
            SeisanDempyo
        }

        public enum enumAutoDemban : int
        {
            Yes = 1,
            No = 4
        }

        public enum enumManyWrite : int
        {
            Yes = 1,
            No
        }


        YHCSK.CYayoiHanbaiCommonSdk YayoiHanbaiSdk = new YHCSK.CYayoiHanbaiCommonSdk();
       
        //ＳＤＫコールバッククラスの宣言

        SdkCallback HanbaiCallback = new SdkCallback();


        bool bInitialized;

        //internal System.Windows.Forms.ComboBox ImportObejct;
        // データベース制御用フラグの宣言
        bool bOpened;


        public Form1()
        {

            InitializeComponent();// 呼び出しの後に初期化を追加します。

            // SDKとデータベースの制御フラグを初期化します。
            this.bInitialized = false;
            this.bOpened = false;

            // フォームの値を初期化します。
            this.ProductType.SelectedIndex = 0;
            this.TextType.SelectedIndex = 0;
            this.ImportObejct.SelectedIndex = 0;
            this.DbClose.Enabled = false;
            this.Import.Enabled = false;

            // 伝票編集に関する値の初期化
            this.EditTextType.SelectedIndex = 0;
            this.EditObejct.SelectedIndex = 0;
            this.Edit.Enabled = false;

            // 伝票削除に関する値の初期化
            this.DeleteObejct.SelectedIndex = 0;
            this.Delete.Enabled = false;

        }

        // SDK初期処理
        // アプリケーション起動中のSDK初期化処理は一度だけに制御する必要があります。
        private bool SDK_Initialize(enumProductType ProductType)
        {
            if (this.bInitialized == false)
            {
                this.bInitialized = YayoiHanbaiSdk.Initialize(Convert.ToInt32(ProductType));
            }
            return bInitialized;
        }

        // SDK終了処理
        // アプリケーション終了時に必ず実行してください。
        private void SDK_Terminate()
        {
            if (this.bInitialized == true)
            {
                YayoiHanbaiSdk.Terminate();
                this.bInitialized = false;
            }
        }


        // 作成するアプリケーションに合わせて変更してください。
        private bool InitSDK(enumProductType ProductType)
        {
            if (SDK_Initialize(ProductType) == true)
            {
                this.ProductType.Enabled = false;
                return true;
            }
            MessageBox.Show("SDKの初期化失敗しました。");
            return false;
        }


        // データベースを開く
        private bool OpenDataBase(enumProductType ProductType, string DatabaseName, string LoginUserName, string LoginPassword, int VenderId, object CallBack)
        {

            // データベースを使用する前にSDKを初期化します

            if (InitSDK(ProductType) == true)
            {
                // データベースを既に開いている状態の時に、さらに別のデータベースを開くことはできません

                if (this.bOpened == false)
                {
                    // SQLサーバー名の設定
                    YayoiHanbaiSdk.SetServerName(this.ServerName.Text);

                    // SQLサーバーへのログインユーザー設定
                    YayoiHanbaiSdk.SetSysUserName(this.SysUserName.Text);

                    // SQLサーバーへのログインユーザーパスワード設定
                    YayoiHanbaiSdk.SetSysPassword(this.SysPassword.Text);

                    // データベース名の設定
                    YayoiHanbaiSdk.SetDataName(DatabaseName);

                    // データログインユーザー名の設定
                    YayoiHanbaiSdk.SetLoginUserName(LoginUserName);

                    // データログインユーザーパスワードの設定
                    YayoiHanbaiSdk.SetLoginUserPwd(LoginPassword);

                    // VenderIDの設定
                    YayoiHanbaiSdk.SetVenderId(VenderId);

                    // 弥生販売SDKからの結果を受け取るCallBackクラスの設定
                    YayoiHanbaiSdk.SetSdkCallBack((SdkCallback)CallBack);

                    // データベースを開く
                    this.bOpened = YayoiHanbaiSdk.Open();
                    if (this.bOpened == false)
                    {
                        MessageBox.Show("データベースのオープンに失敗しました。");
                    }
                    return this.bOpened;
                }
            }
            return false;
        }

        // データベースを閉じる

        private void CloseDataBase()
        {
            // データベースが既に開かれている状態の時にのみ実行します
            if (this.bOpened == true)
            {
                YayoiHanbaiSdk.Close();
                this.bOpened = false;
            }
        }

        // コンボボックスの値とSDK初期化に使用する値の変換
        private enumProductType GetProductType()
        {
            enumProductType Type = default(enumProductType);
            switch (this.ProductType.SelectedIndex)
            {
                case 0:
                    Type = enumProductType.HANBAI_AUTO;
                    break;
                case 1:
                    Type = enumProductType.HANBAI_06;
                    break;
                case 2:
                    Type = enumProductType.HANBAI_07;
                    break;
                case 3:
                    Type = enumProductType.HANBAI_08;
                    break;
                case 4:
                    Type = enumProductType.HANBAI_09;
                    break;
                case 5:
                    Type = enumProductType.HANBAI_10;
                    break;
                case 6:
                    Type = enumProductType.HANBAI_11;
                    break;
                case 7:
                    Type = enumProductType.HANBAI_12;
                    break;
                case 8:
                    Type = enumProductType.HANBAI_13;
                    break;
                case 9:
                    Type = enumProductType.HANBAI_14;
                    break;
                case 10:
                    Type = enumProductType.HANBAI_15;
                    break;
                case 11:
                    Type = enumProductType.HANBAI_16;
                    break;
            }
            return Type;
        }



        private void LastInfo_Click(object sender, EventArgs e)
        {
            if (InitSDK(GetProductType()) == true)
            {
                this.ServerName.Text = YayoiHanbaiSdk.GetServerName();
                this.SysUserName.Text = YayoiHanbaiSdk.GetSysUserName();
                this.SysPassword.Text = YayoiHanbaiSdk.GetSysPassword();
                this.DatabaseName.Text = YayoiHanbaiSdk.GetDataName();
               
            }
            else
            {
                this.ServerName.Text = "";
                this.SysUserName.Text = "";
                this.SysPassword.Text = "";
                this.DatabaseName.Text = "";
            }

        }

        private void DbOpen_Click(object sender, EventArgs e)
        {
            HanbaiCallback.SetForm(this);
            if (OpenDataBase(GetProductType(), this.DatabaseName.Text, this.LoginUserName.Text, this.LoginPassword.Text, 100, HanbaiCallback) == true)
            {
                this.DbClose.Enabled = true;
                this.Import.Enabled = true;
                this.DbOpen.Enabled = false;
                this.Edit.Enabled = true;
                this.Delete.Enabled = true;
            }

        }

        private void DbClose_Click(object sender, EventArgs e)
        {
            CloseDataBase();
            this.DbOpen.Enabled = true;
            this.DbClose.Enabled = false;
            this.Import.Enabled = false;
            this.Edit.Enabled = false;
            this.Delete.Enabled = false;
        }

        private void TextFileBrowse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.DefaultExt = "txt";
            openFile.Filter = "Text File(*.txt)|*.txt";
            openFile.RestoreDirectory = true;
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                string filename = null;
                foreach (string filename_loopVariable in openFile.FileNames)
                {
                    filename = filename_loopVariable;
                    this.ImportTextFileName.Text = filename;
                }
            }

        }

        private void Import_Click(object sender, EventArgs e)
        {
            if (this.bInitialized == false | this.bOpened == false)
            {
                MessageBox.Show("データベースをオープンしてから実行してください");
            }
            else
            {
                this.ResultLog.Items.Clear();

                // インポートに使用するテキストファイル
                YayoiHanbaiSdk.SetTextFileName(this.ImportTextFileName.Text);

                // テキストファイルの形式
                switch (this.TextType.SelectedIndex)
                {
                    case 0:
                        YayoiHanbaiSdk.SetTextType(Convert.ToInt32(enumTexType.CVS));
                        break;
                    case 1:
                        YayoiHanbaiSdk.SetTextType(Convert.ToInt32(enumTexType.SPACE));
                        break;
                    case 2:
                        YayoiHanbaiSdk.SetTextType(Convert.ToInt32(enumTexType.TAB));
                        break;
                }

                // テキストファイルの読み込み開始行
                YayoiHanbaiSdk.SetStartLine(Convert.ToInt32(this.StartLine.Text));

                // インポート対象データ
                enumImportObject ImportSelectObject = default(enumImportObject);
                switch (this.ImportObejct.SelectedIndex)
                {
                    case 0:
                        ImportSelectObject = enumImportObject.Tokuisaki;
                        break;
                    case 1:
                        ImportSelectObject = enumImportObject.Shiiresaki;
                        break;
                    case 2:
                        ImportSelectObject = enumImportObject.Shohin;
                        break;
                    case 3:
                        ImportSelectObject = enumImportObject.Tantosha;
                        break;
                    case 4:
                        ImportSelectObject = enumImportObject.Nonyusaki;
                        break;
                    case 5:
                        ImportSelectObject = enumImportObject.TokuisakiKakakuhyo;
                        break;
                    case 6:
                        ImportSelectObject = enumImportObject.ShiiresakiKakakuhyo;
                        break;
                    case 7:
                        ImportSelectObject = enumImportObject.KoseiBuhinDaicho;
                        break;
                    case 8:
                        ImportSelectObject = enumImportObject.SokoDaicho;
                        break;
                    case 9:
                        ImportSelectObject = enumImportObject.JuchuDempyo;
                        break;
                    case 10:
                        ImportSelectObject = enumImportObject.HattchuDempyo;
                        break;
                    case 11:
                        ImportSelectObject = enumImportObject.UriageDempyo;
                        break;
                    case 12:
                        ImportSelectObject = enumImportObject.ShiireDempyo;
                        break;
                    case 13:
                        ImportSelectObject = enumImportObject.NyukinDempyo;
                        break;
                    case 14:
                        ImportSelectObject = enumImportObject.ShukkoDempyo;
                        break;
                    case 15:
                        ImportSelectObject = enumImportObject.Mitsumorisho;
                        break;
                    case 16:
                        ImportSelectObject = enumImportObject.SokoDempyo;
                        break;
                    case 17:
                        ImportSelectObject = enumImportObject.SeisanDempyo;
                        break;
                }
                YayoiHanbaiSdk.SetObjectType(Convert.ToInt32(ImportSelectObject));

                // 伝票番号自動付番の設定
                if (this.AutoDemban.Checked)
                {
                    YayoiHanbaiSdk.SetAutoDemban(Convert.ToInt32(enumAutoDemban.Yes));
                }
                else
                {
                    YayoiHanbaiSdk.SetAutoDemban(Convert.ToInt32(enumAutoDemban.No));
                }

                // 大量書き込みモードの設定
                if (this.ManyWrite.Checked)
                {
                    YayoiHanbaiSdk.SetWritingMode(Convert.ToInt32(enumManyWrite.Yes));
                }
                else
                {
                    YayoiHanbaiSdk.SetWritingMode(Convert.ToInt32(enumManyWrite.No));
                }

                // 実行権限の確認

                if (YayoiHanbaiSdk.IsExecute(Convert.ToInt32(ImportSelectObject)))
                {
                    // インポート実行
                    if (YayoiHanbaiSdk.Import())
                    {
                        MessageBox.Show("インポート成功");
                    }
                    else
                    {
                        MessageBox.Show("インポート失敗");
                    }
                }
                else
                {
                    MessageBox.Show("実行権限が無い");
                }
            }

        }

        private void EditTextFileBrowse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.DefaultExt = "txt";
            openFile.Filter = "Text File(*.txt)|*.txt";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                EditTextFileName.Text = openFile.FileName;
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (this.bInitialized == false || this.bOpened == false)
            {
                MessageBox.Show("データベースをオープンしてから実行してください");
            }
            else
            {
                this.ResultLog.Items.Clear();

                // インポートに使用するテキストファイル
                YayoiHanbaiSdk.SetTextFileName(this.EditTextFileName.Text);

                // テキストファイルの形式
                switch (this.EditTextType.SelectedIndex)
                {
                    case 0:
                        YayoiHanbaiSdk.SetTextType(Convert.ToInt32(enumTexType.CVS));
                        break;
                    case 1:
                        YayoiHanbaiSdk.SetTextType(Convert.ToInt32(enumTexType.SPACE));
                        break;
                    case 2:
                        YayoiHanbaiSdk.SetTextType(Convert.ToInt32(enumTexType.TAB));
                        break;
                }

                // テキストファイルの読み込み開始行
                YayoiHanbaiSdk.SetStartLine(Convert.ToInt32(this.EditStartLine.Text));

                // 伝票修正対象データ
                enumImportObject ImportSelectObject = default(enumImportObject);
                switch (this.EditObejct.SelectedIndex)
                {
                    case 0:
                        ImportSelectObject = enumImportObject.JuchuDempyo;
                        break;
                    case 1:
                        ImportSelectObject = enumImportObject.HattchuDempyo;
                        break;
                    case 2:
                        ImportSelectObject = enumImportObject.UriageDempyo;
                        break;
                    case 3:
                        ImportSelectObject = enumImportObject.ShiireDempyo;
                        break;
                    case 4:
                        ImportSelectObject = enumImportObject.NyukinDempyo;
                        break;
                    case 5:
                        ImportSelectObject = enumImportObject.ShukkoDempyo;
                        break;
                    case 6:
                        ImportSelectObject = enumImportObject.Mitsumorisho;
                        break;
                    case 7:
                        ImportSelectObject = enumImportObject.SokoDempyo;
                        break;
                    case 8:
                        ImportSelectObject = enumImportObject.SeisanDempyo;
                        break;
                }
                YayoiHanbaiSdk.SetObjectType(Convert.ToInt32(ImportSelectObject));

                // シリアルID
                int lSerialID = 0;
                if (!string.IsNullOrEmpty(this.EditSerialID.Text))
                {
                    lSerialID = Convert.ToInt32(this.EditSerialID.Text);
                }

                // 伝票編集可能かどうかの確認

                if (YayoiHanbaiSdk.CanEditDempyo(Convert.ToInt32(ImportSelectObject), lSerialID))
                {
                    // 実行権限の確認

                    if (YayoiHanbaiSdk.IsExecute(Convert.ToInt32(ImportSelectObject)))
                    {
                        // 伝票編集実行
                        if (YayoiHanbaiSdk.EditDempyo(lSerialID))
                        {
                            MessageBox.Show("伝票編集成功");
                        }
                        else
                        {
                            MessageBox.Show("伝票編集失敗");
                        }
                    }
                    else
                    {
                        MessageBox.Show("実行権限が無い");
                    }
                }
                else
                {
                    MessageBox.Show("伝票編集不可");
                }
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (this.bInitialized == false | this.bOpened == false)
            {
                MessageBox.Show("データベースをオープンしてから実行してください");
            }
            else
            {
                this.ResultLog.Items.Clear();

                // 伝票削除対象データ
                enumImportObject ImportSelectObject = default(enumImportObject);
                switch (this.DeleteObejct.SelectedIndex)
                {
                    case 0:
                        ImportSelectObject = enumImportObject.JuchuDempyo;
                        break;
                    case 1:
                        ImportSelectObject = enumImportObject.HattchuDempyo;
                        break;
                    case 2:
                        ImportSelectObject = enumImportObject.UriageDempyo;
                        break;
                    case 3:
                        ImportSelectObject = enumImportObject.ShiireDempyo;
                        break;
                    case 4:
                        ImportSelectObject = enumImportObject.NyukinDempyo;
                        break;
                    case 5:
                        ImportSelectObject = enumImportObject.ShukkoDempyo;
                        break;
                    case 6:
                        ImportSelectObject = enumImportObject.Mitsumorisho;
                        break;
                    case 7:
                        ImportSelectObject = enumImportObject.SokoDempyo;
                        break;
                    case 8:
                        ImportSelectObject = enumImportObject.SeisanDempyo;
                        break;
                }

                YayoiHanbaiSdk.SetObjectType(Convert.ToInt32(ImportSelectObject));

                // シリアルID
                //long lSerialID = 0;
                //if (!string.IsNullOrEmpty(this.DeleteSerialID1.Text))
                //{
                //    lSerialID = Convert.ToInt64(this.DeleteSerialID1.Text);
                //}

                DataTable dt;
                if (!checkBox1.Checked)
                {
                    if (DeleteSerialID1.Text.Equals(""))
                    {
                        DeleteSerialID1.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt64(DeleteSerialID1.Text);
                        }
                        catch (Exception)
                        {
                            DeleteSerialID1.Clear();
                            DeleteSerialID1.Focus();
                            return;
                        }
 
                    }


                    if (DeleteSerialID2.Text.Equals(""))
                    {
                        DeleteSerialID2.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt64(DeleteSerialID2.Text);
                        }
                        catch (Exception)
                        {
                            DeleteSerialID2.Clear();
                            DeleteSerialID2.Focus();
                            return;
                        }

                    }


                    if (ImportSelectObject.ToString() == "ShukkoDempyo" || ImportSelectObject.ToString() == "SeisanDempyo")
                    {
                        int type = ImportSelectObject.ToString() == "ShukkoDempyo" ? 5 : 6;

                        dt = getDempyo("ZAIKODEMPYO", Convert.ToInt32(DeleteSerialID1.Text), Convert.ToInt32(DeleteSerialID2.Text), "", "", type);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    deleteDempyo(Convert.ToInt32(ImportSelectObject), Convert.ToInt32(dt.Rows[i]["A"]), Convert.ToInt32(dt.Rows[i]["E"]), Convert.ToDateTime(dt.Rows[i]["D"]));
                                }

                                // MessageBox.Show("伝票削除成功");

                            }
                            else
                            {
                                MessageBox.Show("伝票がありません");
                            }
                        }
                    }
                    else
                    {

                        dt = getDempyo(ImportSelectObject.ToString(), Convert.ToInt32(DeleteSerialID1.Text), Convert.ToInt32(DeleteSerialID2.Text), "", "");
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    deleteDempyo(Convert.ToInt32(ImportSelectObject), Convert.ToInt32(dt.Rows[i]["A"]), Convert.ToInt32(dt.Rows[i]["D"]), Convert.ToDateTime(dt.Rows[i]["C"]));
                                }

                                // MessageBox.Show("伝票削除成功");

                            }
                            else
                            {
                                MessageBox.Show("伝票がありません");
                            }
                        }
                    }
                }
                else
                {
                    int id1 = 0;
                    int id2 = 0;


                    if (DeleteSerialID1.Text.Equals("") && !DeleteSerialID2.Text.Equals(""))
                    {
                        DeleteSerialID1.Focus();
                        return;
                    }
                    if (!DeleteSerialID1.Text.Equals("") && DeleteSerialID2.Text.Equals(""))
                    {
                        DeleteSerialID2.Focus();
                        return;
                    }
                    if (!DeleteSerialID1.Text.Equals("") && !DeleteSerialID2.Text.Equals(""))
                    {
                         id1 = Convert.ToInt32(DeleteSerialID1.Text);
                         id2 = Convert.ToInt32(DeleteSerialID2.Text);
                    }

                    if (ImportSelectObject.ToString() == "ShukkoDempyo" || ImportSelectObject.ToString() == "SeisanDempyo")
                    {
                        int type = ImportSelectObject.ToString() == "ShukkoDempyo" ? 5 : 6;

                        dt = getDempyo("ZAIKODEMPYO", id1, id2, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), type);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    deleteDempyo(Convert.ToInt32(ImportSelectObject), Convert.ToInt32(dt.Rows[i]["A"]), Convert.ToInt32(dt.Rows[i]["E"]), Convert.ToDateTime(dt.Rows[i]["D"]));
                                }

                               // MessageBox.Show("伝票削除成功");

                            }
                            else
                            {
                                MessageBox.Show("伝票がありません");
                            }
                        }
                    }
                    else
                    {
                        dt = getDempyo(ImportSelectObject.ToString(), id1, id2, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    deleteDempyo(Convert.ToInt32(ImportSelectObject), Convert.ToInt32(dt.Rows[i]["A"]), Convert.ToInt32(dt.Rows[i]["D"]), Convert.ToDateTime(dt.Rows[i]["C"]));
                                }

                               // MessageBox.Show("伝票削除成功");

                            }
                            else
                            {
                                MessageBox.Show("伝票がありません");
                            }
                        }
                    }
                }

              

               
            }

        }



        private void deleteDempyo(int ImportSelectObject, int lSerialID,int dempyoBango,DateTime d)
        {
            // 伝票削除可能かどうかの確認
            if (YayoiHanbaiSdk.CanDeleteDempyo(ImportSelectObject, lSerialID))
            {
                // 実行権限の確認

                if (YayoiHanbaiSdk.IsExecute(ImportSelectObject))
                {
                    // 伝票削除実行
                    if (YayoiHanbaiSdk.DeleteDempyo(lSerialID))
                    {
                       // MessageBox.Show("伝票削除成功");

                        
                        ResultLog.Items.Add(string.Format("伝票を削除しました 伝票日付={0} 伝票番号={1} 伝票ID={2}", d, dempyoBango, lSerialID));
                    }
                    else
                    {
                        ResultLog.Items.Add("伝票削除失敗 ID: " + lSerialID.ToString());
                    }
                }
                else
                {
                    ResultLog.Items.Add("実行権限が無い ID: " + lSerialID.ToString());
                }
            }
            else
            {
                ResultLog.Items.Add("伝票削除不可  ID: " + lSerialID.ToString());
            }
        }


        public DataTable getDempyo(string dempyoTB, int fromID, int toID,string fromDate,string toDate)
        {
            bool b = false;
            DataTable dt = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source="+ YayoiHanbaiSdk.GetServerName()  +";" +
            "Initial Catalog="+ YayoiHanbaiSdk.GetRealDataName() +";" +
            "User id="+ YayoiHanbaiSdk.GetSysUserName()  +";" +
            "Password="+ YayoiHanbaiSdk.GetSysPassword()  +";";
            
            try
            {
                conn.Open();
                string select_query = "select  * from [dbo].[" + dempyoTB.ToUpper() + "] where ";

                if(!fromID.Equals(0) && !toID.Equals(0))
                {
                   select_query += " (A between " + fromID + " and " + toID + ")  ";

                   if (!fromDate.Equals("") && !toDate.Equals(""))
                   {
                       b = true;
                   }
                }

                if (b)
                {
                    select_query += "  and  ";
                }


                if (!fromDate.Equals("") && !toDate.Equals(""))
                {
                    select_query += "   (convert(date,C) between convert(date,'" + fromDate + "') and convert(date,'" + toDate + "'))";
                }

                SqlDataAdapter dadapter = new SqlDataAdapter(select_query, conn);
                DataSet dset = new DataSet();

                dadapter.Fill(dset, "table");
                dt = dset.Tables[0];
                conn.Close();

            }
            catch (Exception)
            {
                conn.Close();
            }

            return dt;


        }


        public DataTable getDempyo(string dempyoTB, int fromID, int toID, string fromDate, string toDate,int dempyoType)
        {
            bool b = false;
            DataTable dt = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=" + YayoiHanbaiSdk.GetServerName() + ";" +
            "Initial Catalog=" + YayoiHanbaiSdk.GetRealDataName() + ";" +
            "User id=" + YayoiHanbaiSdk.GetSysUserName() + ";" +
            "Password=" + YayoiHanbaiSdk.GetSysPassword() + ";";

            try
            {
                conn.Open();
                string select_query = "select  * from [dbo].[" + dempyoTB.ToUpper() + "] where  C="+ dempyoType +" and  ";

                if (!fromID.Equals(0) && !toID.Equals(0))
                {
                    select_query += " (A between " + fromID + " and " + toID + ")  ";

                    if (!fromDate.Equals("") && !toDate.Equals(""))
                    {
                        b = true;
                    }
                }

                if (b)
                {
                    select_query += "  and  ";
                }


                if (!fromDate.Equals("") && !toDate.Equals(""))
                {
                    select_query += "   (convert(date,D) between convert(date,'" + fromDate + "') and convert(date,'" + toDate + "'))";
                }

                SqlDataAdapter dadapter = new SqlDataAdapter(select_query, conn);
                DataSet dset = new DataSet();

                dadapter.Fill(dset, "table");
                dt = dset.Tables[0];
                conn.Close();

            }
            catch (Exception)
            {
                conn.Close();
            }

            return dt;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {

                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
 
            }
        }
    }
}
