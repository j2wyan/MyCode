namespace YayoiHanbaiSDK
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Label2 = new System.Windows.Forms.Label();
            this.EditObejct = new System.Windows.Forms.ComboBox();
            this.ManyWrite = new System.Windows.Forms.CheckBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.AutoDemban = new System.Windows.Forms.CheckBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.StartLine = new System.Windows.Forms.TextBox();
            this.EditSerialID = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.EditStartLine = new System.Windows.Forms.TextBox();
            this.EditTextFileName = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.EditTextType = new System.Windows.Forms.ComboBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.EditTextFileBrowse = new System.Windows.Forms.Button();
            this.Label17 = new System.Windows.Forms.Label();
            this.DeleteSerialID1 = new System.Windows.Forms.TextBox();
            this.DeleteObejct = new System.Windows.Forms.ComboBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DeleteSerialID2 = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.tabCommand = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.ImportTextFileName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Import = new System.Windows.Forms.Button();
            this.TextType = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextFileBrowse = new System.Windows.Forms.Button();
            this.ProductType = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.DbClose = new System.Windows.Forms.Button();
            this.DbOpen = new System.Windows.Forms.Button();
            this.ResultLog = new System.Windows.Forms.ListBox();
            this.LastInfo = new System.Windows.Forms.Button();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginUserName = new System.Windows.Forms.TextBox();
            this.DatabaseName = new System.Windows.Forms.TextBox();
            this.SysPassword = new System.Windows.Forms.TextBox();
            this.SysUserName = new System.Windows.Forms.TextBox();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ImportObejct = new System.Windows.Forms.ComboBox();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.tabCommand.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(49, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "サーバー名";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditObejct
            // 
            this.EditObejct.DropDownHeight = 120;
            this.EditObejct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditObejct.IntegralHeight = false;
            this.EditObejct.Items.AddRange(new object[] {
            "受注伝票",
            "発注伝票",
            "売上伝票",
            "仕入伝票",
            "入金伝票",
            "出庫伝票",
            "見積書",
            "倉庫移動伝票",
            "生産伝票"});
            this.EditObejct.Location = new System.Drawing.Point(112, 88);
            this.EditObejct.Name = "EditObejct";
            this.EditObejct.Size = new System.Drawing.Size(160, 20);
            this.EditObejct.TabIndex = 8;
            // 
            // ManyWrite
            // 
            this.ManyWrite.Location = new System.Drawing.Point(360, 88);
            this.ManyWrite.Name = "ManyWrite";
            this.ManyWrite.Size = new System.Drawing.Size(104, 16);
            this.ManyWrite.TabIndex = 10;
            this.ManyWrite.Text = "大量書き込み";
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(8, 88);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(96, 16);
            this.Label12.TabIndex = 7;
            this.Label12.Text = "対象データ";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AutoDemban
            // 
            this.AutoDemban.Location = new System.Drawing.Point(360, 72);
            this.AutoDemban.Name = "AutoDemban";
            this.AutoDemban.Size = new System.Drawing.Size(128, 16);
            this.AutoDemban.TabIndex = 9;
            this.AutoDemban.Text = "伝票番号自動付番";
            // 
            // Label18
            // 
            this.Label18.Location = new System.Drawing.Point(8, 112);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(96, 16);
            this.Label18.TabIndex = 9;
            this.Label18.Text = "シリアルID";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(8, 88);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(96, 16);
            this.Label10.TabIndex = 7;
            this.Label10.Text = "対象データ";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartLine
            // 
            this.StartLine.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StartLine.Location = new System.Drawing.Point(112, 64);
            this.StartLine.Name = "StartLine";
            this.StartLine.Size = new System.Drawing.Size(56, 19);
            this.StartLine.TabIndex = 6;
            this.StartLine.Text = "1";
            // 
            // EditSerialID
            // 
            this.EditSerialID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EditSerialID.Location = new System.Drawing.Point(112, 112);
            this.EditSerialID.Name = "EditSerialID";
            this.EditSerialID.Size = new System.Drawing.Size(56, 19);
            this.EditSerialID.TabIndex = 10;
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(8, 64);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(96, 16);
            this.Label13.TabIndex = 5;
            this.Label13.Text = "開始行";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.EditSerialID);
            this.TabPage2.Controls.Add(this.Label18);
            this.TabPage2.Controls.Add(this.EditObejct);
            this.TabPage2.Controls.Add(this.Label12);
            this.TabPage2.Controls.Add(this.Label13);
            this.TabPage2.Controls.Add(this.EditStartLine);
            this.TabPage2.Controls.Add(this.EditTextFileName);
            this.TabPage2.Controls.Add(this.Label14);
            this.TabPage2.Controls.Add(this.Edit);
            this.TabPage2.Controls.Add(this.EditTextType);
            this.TabPage2.Controls.Add(this.Label15);
            this.TabPage2.Controls.Add(this.EditTextFileBrowse);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(512, 142);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "伝票修正";
            // 
            // EditStartLine
            // 
            this.EditStartLine.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EditStartLine.Location = new System.Drawing.Point(112, 64);
            this.EditStartLine.Name = "EditStartLine";
            this.EditStartLine.Size = new System.Drawing.Size(56, 19);
            this.EditStartLine.TabIndex = 6;
            this.EditStartLine.Text = "1";
            // 
            // EditTextFileName
            // 
            this.EditTextFileName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EditTextFileName.Location = new System.Drawing.Point(112, 16);
            this.EditTextFileName.Name = "EditTextFileName";
            this.EditTextFileName.Size = new System.Drawing.Size(312, 19);
            this.EditTextFileName.TabIndex = 1;
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(8, 16);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(96, 16);
            this.Label14.TabIndex = 0;
            this.Label14.Text = "テキストファイル名";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(360, 112);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(120, 23);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "修正開始";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // EditTextType
            // 
            this.EditTextType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditTextType.Items.AddRange(new object[] {
            "CSV",
            "SPACE",
            "TAB"});
            this.EditTextType.Location = new System.Drawing.Point(112, 40);
            this.EditTextType.Name = "EditTextType";
            this.EditTextType.Size = new System.Drawing.Size(160, 20);
            this.EditTextType.TabIndex = 4;
            // 
            // Label15
            // 
            this.Label15.Location = new System.Drawing.Point(8, 40);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(96, 16);
            this.Label15.TabIndex = 3;
            this.Label15.Text = "テキスト形式";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditTextFileBrowse
            // 
            this.EditTextFileBrowse.Location = new System.Drawing.Point(432, 16);
            this.EditTextFileBrowse.Name = "EditTextFileBrowse";
            this.EditTextFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.EditTextFileBrowse.TabIndex = 2;
            this.EditTextFileBrowse.Text = "参照";
            this.EditTextFileBrowse.Click += new System.EventHandler(this.EditTextFileBrowse_Click);
            // 
            // Label17
            // 
            this.Label17.Location = new System.Drawing.Point(8, 43);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(96, 16);
            this.Label17.TabIndex = 2;
            this.Label17.Text = "シリアルID";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteSerialID1
            // 
            this.DeleteSerialID1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DeleteSerialID1.Location = new System.Drawing.Point(112, 40);
            this.DeleteSerialID1.Name = "DeleteSerialID1";
            this.DeleteSerialID1.Size = new System.Drawing.Size(56, 19);
            this.DeleteSerialID1.TabIndex = 3;
            this.DeleteSerialID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DeleteObejct
            // 
            this.DeleteObejct.DropDownHeight = 120;
            this.DeleteObejct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteObejct.IntegralHeight = false;
            this.DeleteObejct.Items.AddRange(new object[] {
            "受注伝票",
            "発注伝票",
            "売上伝票",
            "仕入伝票",
            "入金伝票",
            "出庫伝票",
            "見積書",
            "倉庫移動伝票",
            "生産伝票"});
            this.DeleteObejct.Location = new System.Drawing.Point(112, 16);
            this.DeleteObejct.Name = "DeleteObejct";
            this.DeleteObejct.Size = new System.Drawing.Size(160, 20);
            this.DeleteObejct.TabIndex = 1;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.checkBox1);
            this.TabPage3.Controls.Add(this.dateTimePicker2);
            this.TabPage3.Controls.Add(this.dateTimePicker1);
            this.TabPage3.Controls.Add(this.label20);
            this.TabPage3.Controls.Add(this.label21);
            this.TabPage3.Controls.Add(this.label19);
            this.TabPage3.Controls.Add(this.Label17);
            this.TabPage3.Controls.Add(this.DeleteSerialID2);
            this.TabPage3.Controls.Add(this.DeleteSerialID1);
            this.TabPage3.Controls.Add(this.DeleteObejct);
            this.TabPage3.Controls.Add(this.Label16);
            this.TabPage3.Controls.Add(this.Delete);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(512, 142);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "伝票削除";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(405, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "日付使用";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(265, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 19);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 19);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 6;
            this.label20.Text = "日付";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(242, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "～";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(173, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 5;
            this.label19.Text = "～";
            // 
            // DeleteSerialID2
            // 
            this.DeleteSerialID2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DeleteSerialID2.Location = new System.Drawing.Point(194, 40);
            this.DeleteSerialID2.Name = "DeleteSerialID2";
            this.DeleteSerialID2.Size = new System.Drawing.Size(56, 19);
            this.DeleteSerialID2.TabIndex = 3;
            this.DeleteSerialID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.Location = new System.Drawing.Point(8, 16);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(96, 16);
            this.Label16.TabIndex = 0;
            this.Label16.Text = "対象データ";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(360, 112);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "削除開始";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(8, 64);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(96, 16);
            this.Label9.TabIndex = 5;
            this.Label9.Text = "開始行";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabCommand
            // 
            this.tabCommand.Controls.Add(this.TabPage1);
            this.tabCommand.Controls.Add(this.TabPage2);
            this.tabCommand.Controls.Add(this.TabPage3);
            this.tabCommand.Location = new System.Drawing.Point(49, 232);
            this.tabCommand.Name = "tabCommand";
            this.tabCommand.SelectedIndex = 0;
            this.tabCommand.Size = new System.Drawing.Size(520, 168);
            this.tabCommand.TabIndex = 33;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.ImportObejct);
            this.TabPage1.Controls.Add(this.ManyWrite);
            this.TabPage1.Controls.Add(this.AutoDemban);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.StartLine);
            this.TabPage1.Controls.Add(this.ImportTextFileName);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Import);
            this.TabPage1.Controls.Add(this.TextType);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.TextFileBrowse);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(512, 142);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "インポート";
            // 
            // ImportTextFileName
            // 
            this.ImportTextFileName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ImportTextFileName.Location = new System.Drawing.Point(112, 16);
            this.ImportTextFileName.Name = "ImportTextFileName";
            this.ImportTextFileName.Size = new System.Drawing.Size(312, 19);
            this.ImportTextFileName.TabIndex = 1;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(8, 16);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(96, 16);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "テキストファイル名";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(360, 112);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(120, 23);
            this.Import.TabIndex = 11;
            this.Import.Text = "インポート開始";
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // TextType
            // 
            this.TextType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextType.Items.AddRange(new object[] {
            "CSV",
            "SPACE",
            "TAB"});
            this.TextType.Location = new System.Drawing.Point(112, 40);
            this.TextType.Name = "TextType";
            this.TextType.Size = new System.Drawing.Size(160, 20);
            this.TextType.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "テキスト形式";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextFileBrowse
            // 
            this.TextFileBrowse.Location = new System.Drawing.Point(432, 14);
            this.TextFileBrowse.Name = "TextFileBrowse";
            this.TextFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.TextFileBrowse.TabIndex = 2;
            this.TextFileBrowse.Text = "参照";
            this.TextFileBrowse.Click += new System.EventHandler(this.TextFileBrowse_Click);
            // 
            // ProductType
            // 
            this.ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductType.Items.AddRange(new object[] {
            "自動検出",
            "販売06",
            "販売07",
            "販売08",
            "販売09",
            "販売10",
            "販売11",
            "販売12",
            "販売13",
            "販売14",
            "販売15",
            "販売16"});
            this.ProductType.Location = new System.Drawing.Point(153, 46);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(336, 20);
            this.ProductType.TabIndex = 20;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(49, 46);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(88, 16);
            this.Label11.TabIndex = 19;
            this.Label11.Text = "連動対象製品";
            // 
            // DbClose
            // 
            this.DbClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DbClose.Location = new System.Drawing.Point(497, 132);
            this.DbClose.Name = "DbClose";
            this.DbClose.Size = new System.Drawing.Size(75, 34);
            this.DbClose.TabIndex = 37;
            this.DbClose.Text = "切断";
            this.DbClose.UseVisualStyleBackColor = false;
            this.DbClose.Click += new System.EventHandler(this.DbClose_Click);
            // 
            // DbOpen
            // 
            this.DbOpen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DbOpen.Location = new System.Drawing.Point(497, 87);
            this.DbOpen.Name = "DbOpen";
            this.DbOpen.Size = new System.Drawing.Size(75, 34);
            this.DbOpen.TabIndex = 36;
            this.DbOpen.Text = "接続";
            this.DbOpen.UseVisualStyleBackColor = false;
            this.DbOpen.Click += new System.EventHandler(this.DbOpen_Click);
            // 
            // ResultLog
            // 
            this.ResultLog.ItemHeight = 12;
            this.ResultLog.Location = new System.Drawing.Point(49, 406);
            this.ResultLog.Name = "ResultLog";
            this.ResultLog.Size = new System.Drawing.Size(520, 292);
            this.ResultLog.TabIndex = 34;
            // 
            // LastInfo
            // 
            this.LastInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LastInfo.Location = new System.Drawing.Point(497, 46);
            this.LastInfo.Name = "LastInfo";
            this.LastInfo.Size = new System.Drawing.Size(75, 30);
            this.LastInfo.TabIndex = 35;
            this.LastInfo.Text = "前回情報";
            this.LastInfo.UseVisualStyleBackColor = false;
            this.LastInfo.Click += new System.EventHandler(this.LastInfo_Click);
            // 
            // LoginPassword
            // 
            this.LoginPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LoginPassword.Location = new System.Drawing.Point(153, 198);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(336, 19);
            this.LoginPassword.TabIndex = 32;
            this.LoginPassword.UseSystemPasswordChar = true;
            // 
            // LoginUserName
            // 
            this.LoginUserName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.LoginUserName.Location = new System.Drawing.Point(153, 174);
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(336, 19);
            this.LoginUserName.TabIndex = 30;
            this.LoginUserName.Text = "管理者";
            // 
            // DatabaseName
            // 
            this.DatabaseName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DatabaseName.Location = new System.Drawing.Point(153, 150);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(336, 19);
            this.DatabaseName.TabIndex = 28;
            // 
            // SysPassword
            // 
            this.SysPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SysPassword.Location = new System.Drawing.Point(153, 118);
            this.SysPassword.Name = "SysPassword";
            this.SysPassword.Size = new System.Drawing.Size(336, 19);
            this.SysPassword.TabIndex = 26;
            this.SysPassword.UseSystemPasswordChar = true;
            // 
            // SysUserName
            // 
            this.SysUserName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SysUserName.Location = new System.Drawing.Point(153, 94);
            this.SysUserName.Name = "SysUserName";
            this.SysUserName.Size = new System.Drawing.Size(336, 19);
            this.SysUserName.TabIndex = 24;
            // 
            // ServerName
            // 
            this.ServerName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ServerName.Location = new System.Drawing.Point(153, 70);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(336, 19);
            this.ServerName.TabIndex = 22;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(49, 198);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(96, 16);
            this.Label7.TabIndex = 31;
            this.Label7.Text = "ログインパスワード";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(49, 174);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(96, 16);
            this.Label6.TabIndex = 29;
            this.Label6.Text = "ログインユーザー名";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(49, 94);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "ユーザー名";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(49, 118);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 16);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "パスワード";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(49, 150);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 16);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "データ名";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportObejct
            // 
            this.ImportObejct.DropDownHeight = 240;
            this.ImportObejct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImportObejct.IntegralHeight = false;
            this.ImportObejct.Items.AddRange(new object[] {
            "得意先",
            "仕入先",
            "商品",
            "担当者",
            "納入先",
            "得意先別価格表",
            "仕入先別価格表",
            "構成部品台帳",
            "倉庫台帳",
            "受注伝票",
            "発注伝票",
            "売上伝票",
            "仕入伝票",
            "入金伝票",
            "出庫伝票",
            "見積書",
            "倉庫移動伝票",
            "生産伝票"});
            this.ImportObejct.Location = new System.Drawing.Point(112, 88);
            this.ImportObejct.Name = "ImportObejct";
            this.ImportObejct.Size = new System.Drawing.Size(160, 20);
            this.ImportObejct.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(604, 720);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tabCommand);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.DbClose);
            this.Controls.Add(this.DbOpen);
            this.Controls.Add(this.ResultLog);
            this.Controls.Add(this.LastInfo);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginUserName);
            this.Controls.Add(this.DatabaseName);
            this.Controls.Add(this.SysPassword);
            this.Controls.Add(this.SysUserName);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Name = "Form1";
            this.Text = "弥生SDK";
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.tabCommand.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox EditObejct;
        internal System.Windows.Forms.CheckBox ManyWrite;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.CheckBox AutoDemban;
        internal System.Windows.Forms.Label Label18;
     
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox StartLine;
        internal System.Windows.Forms.TextBox EditSerialID;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox EditStartLine;
        internal System.Windows.Forms.TextBox EditTextFileName;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button Edit;
        internal System.Windows.Forms.ComboBox EditTextType;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button EditTextFileBrowse;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox DeleteSerialID1;
        internal System.Windows.Forms.ComboBox DeleteObejct;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TabControl tabCommand;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TextBox ImportTextFileName;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button Import;
        internal System.Windows.Forms.ComboBox TextType;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button TextFileBrowse;
        internal System.Windows.Forms.ComboBox ProductType;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button DbClose;
        internal System.Windows.Forms.Button DbOpen;
        internal System.Windows.Forms.ListBox ResultLog;
        internal System.Windows.Forms.Button LastInfo;
        internal System.Windows.Forms.TextBox LoginPassword;
        internal System.Windows.Forms.TextBox LoginUserName;
        internal System.Windows.Forms.TextBox DatabaseName;
        internal System.Windows.Forms.TextBox SysPassword;
        internal System.Windows.Forms.TextBox SysUserName;
        internal System.Windows.Forms.TextBox ServerName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox DeleteSerialID2;
        internal System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.ComboBox ImportObejct;
    }
}

