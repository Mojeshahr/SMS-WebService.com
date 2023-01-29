namespace SMS_Webservice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtApi = new System.Windows.Forms.TextBox();
            this.btnGetAccountInfo = new System.Windows.Forms.Button();
            this.tabcontroller = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.txtRes1 = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            this.txtSenderInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSend_Bulk = new System.Windows.Forms.Button();
            this.txtRes_Bulk = new System.Windows.Forms.TextBox();
            this.txtRecip_Bulk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage_Bulk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsender_bulk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgmulti = new System.Windows.Forms.DataGridView();
            this.Sender_multi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text_Multi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination_Multi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTraceId_multi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendMulti = new System.Windows.Forms.Button();
            this.txtRes_Multi = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_p3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTokenSingle = new System.Windows.Forms.Button();
            this.txtres_TokenSingle = new System.Windows.Forms.TextBox();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDestination_token = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtRes_tokenMulti = new System.Windows.Forms.TextBox();
            this.btnTokenMulti = new System.Windows.Forms.Button();
            this.txtTemplateKey_multiToken = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgMultitoken = new System.Windows.Forms.DataGridView();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTraceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnshowTokenList = new System.Windows.Forms.Button();
            this.txtRes_TokenList = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtRes_IdSt = new System.Windows.Forms.TextBox();
            this.btnGetStatusById = new System.Windows.Forms.Button();
            this.btnMessageIds = new System.Windows.Forms.Label();
            this.txt_Ids = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.txtRes_TraceIds = new System.Windows.Forms.TextBox();
            this.btnStatusByTraceId = new System.Windows.Forms.Button();
            this.btnUserTraceId = new System.Windows.Forms.Label();
            this.txt_traceIds = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.txtRes_AcountInfo = new System.Windows.Forms.TextBox();
            this.tabcontroller.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmulti)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultitoken)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ApiKey";
            // 
            // txtApi
            // 
            this.txtApi.Location = new System.Drawing.Point(95, 37);
            this.txtApi.Name = "txtApi";
            this.txtApi.Size = new System.Drawing.Size(290, 23);
            this.txtApi.TabIndex = 1;
            // 
            // btnGetAccountInfo
            // 
            this.btnGetAccountInfo.Location = new System.Drawing.Point(79, 33);
            this.btnGetAccountInfo.Name = "btnGetAccountInfo";
            this.btnGetAccountInfo.Size = new System.Drawing.Size(129, 53);
            this.btnGetAccountInfo.TabIndex = 2;
            this.btnGetAccountInfo.Text = "GetAccountInfo";
            this.btnGetAccountInfo.UseVisualStyleBackColor = true;
            this.btnGetAccountInfo.Click += new System.EventHandler(this.btnGetAccountInfo_Click);
            // 
            // tabcontroller
            // 
            this.tabcontroller.Controls.Add(this.tabPage1);
            this.tabcontroller.Controls.Add(this.tabPage2);
            this.tabcontroller.Controls.Add(this.tabPage3);
            this.tabcontroller.Controls.Add(this.tabPage4);
            this.tabcontroller.Controls.Add(this.tabPage5);
            this.tabcontroller.Controls.Add(this.tabPage6);
            this.tabcontroller.Controls.Add(this.tabPage7);
            this.tabcontroller.Controls.Add(this.tabPage8);
            this.tabcontroller.Controls.Add(this.tabPage9);
            this.tabcontroller.Location = new System.Drawing.Point(12, 93);
            this.tabcontroller.Name = "tabcontroller";
            this.tabcontroller.SelectedIndex = 0;
            this.tabcontroller.Size = new System.Drawing.Size(1071, 389);
            this.tabcontroller.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSendSMS);
            this.tabPage1.Controls.Add(this.txtRes1);
            this.tabPage1.Controls.Add(this.txtRecipient);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtmsg);
            this.tabPage1.Controls.Add(this.Message);
            this.tabPage1.Controls.Add(this.txtSenderInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SendSMS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(341, 234);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(122, 51);
            this.btnSendSMS.TabIndex = 11;
            this.btnSendSMS.Text = "SendSMS";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // txtRes1
            // 
            this.txtRes1.Location = new System.Drawing.Point(551, 29);
            this.txtRes1.Multiline = true;
            this.txtRes1.Name = "txtRes1";
            this.txtRes1.Size = new System.Drawing.Size(410, 272);
            this.txtRes1.TabIndex = 10;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(79, 88);
            this.txtRecipient.Multiline = true;
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(189, 57);
            this.txtRecipient.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Recipient";
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(79, 179);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(189, 94);
            this.txtmsg.TabIndex = 7;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(19, 179);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(53, 15);
            this.Message.TabIndex = 6;
            this.Message.Text = "Message";
            // 
            // txtSenderInput
            // 
            this.txtSenderInput.Location = new System.Drawing.Point(79, 26);
            this.txtSenderInput.Name = "txtSenderInput";
            this.txtSenderInput.Size = new System.Drawing.Size(189, 23);
            this.txtSenderInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "sender";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSend_Bulk);
            this.tabPage2.Controls.Add(this.txtRes_Bulk);
            this.tabPage2.Controls.Add(this.txtRecip_Bulk);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtMessage_Bulk);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtsender_bulk);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SendBulk";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSend_Bulk
            // 
            this.btnSend_Bulk.Location = new System.Drawing.Point(384, 229);
            this.btnSend_Bulk.Name = "btnSend_Bulk";
            this.btnSend_Bulk.Size = new System.Drawing.Size(122, 51);
            this.btnSend_Bulk.TabIndex = 19;
            this.btnSend_Bulk.Text = "SendBulkSMS";
            this.btnSend_Bulk.UseVisualStyleBackColor = true;
            this.btnSend_Bulk.Click += new System.EventHandler(this.btnSend_Bulk_Click);
            // 
            // txtRes_Bulk
            // 
            this.txtRes_Bulk.Location = new System.Drawing.Point(594, 24);
            this.txtRes_Bulk.Multiline = true;
            this.txtRes_Bulk.Name = "txtRes_Bulk";
            this.txtRes_Bulk.Size = new System.Drawing.Size(410, 272);
            this.txtRes_Bulk.TabIndex = 18;
            // 
            // txtRecip_Bulk
            // 
            this.txtRecip_Bulk.Location = new System.Drawing.Point(122, 83);
            this.txtRecip_Bulk.Multiline = true;
            this.txtRecip_Bulk.Name = "txtRecip_Bulk";
            this.txtRecip_Bulk.PlaceholderText = "mobile,trace-";
            this.txtRecip_Bulk.Size = new System.Drawing.Size(189, 57);
            this.txtRecip_Bulk.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Recipient";
            // 
            // txtMessage_Bulk
            // 
            this.txtMessage_Bulk.Location = new System.Drawing.Point(122, 174);
            this.txtMessage_Bulk.Multiline = true;
            this.txtMessage_Bulk.Name = "txtMessage_Bulk";
            this.txtMessage_Bulk.Size = new System.Drawing.Size(189, 94);
            this.txtMessage_Bulk.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Message";
            // 
            // txtsender_bulk
            // 
            this.txtsender_bulk.Location = new System.Drawing.Point(122, 21);
            this.txtsender_bulk.Name = "txtsender_bulk";
            this.txtsender_bulk.Size = new System.Drawing.Size(189, 23);
            this.txtsender_bulk.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "sender";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgmulti);
            this.tabPage3.Controls.Add(this.btnSendMulti);
            this.tabPage3.Controls.Add(this.txtRes_Multi);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1063, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "sendMultipleSMSAsunc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgmulti
            // 
            this.dgmulti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmulti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender_multi,
            this.Text_Multi,
            this.Destination_Multi,
            this.userTraceId_multi});
            this.dgmulti.Location = new System.Drawing.Point(19, 18);
            this.dgmulti.Name = "dgmulti";
            this.dgmulti.RowTemplate.Height = 25;
            this.dgmulti.Size = new System.Drawing.Size(549, 263);
            this.dgmulti.TabIndex = 28;
            // 
            // Sender_multi
            // 
            this.Sender_multi.HeaderText = "Sender";
            this.Sender_multi.Name = "Sender_multi";
            // 
            // Text_Multi
            // 
            this.Text_Multi.HeaderText = "Text";
            this.Text_Multi.Name = "Text_Multi";
            this.Text_Multi.Width = 200;
            // 
            // Destination_Multi
            // 
            this.Destination_Multi.HeaderText = "Destination";
            this.Destination_Multi.Name = "Destination_Multi";
            // 
            // userTraceId_multi
            // 
            this.userTraceId_multi.HeaderText = "userTraceId";
            this.userTraceId_multi.Name = "userTraceId_multi";
            // 
            // btnSendMulti
            // 
            this.btnSendMulti.Location = new System.Drawing.Point(610, 35);
            this.btnSendMulti.Name = "btnSendMulti";
            this.btnSendMulti.Size = new System.Drawing.Size(122, 51);
            this.btnSendMulti.TabIndex = 27;
            this.btnSendMulti.Text = "SendMultiSMS";
            this.btnSendMulti.UseVisualStyleBackColor = true;
            this.btnSendMulti.Click += new System.EventHandler(this.btnSendMulti_Click);
            // 
            // txtRes_Multi
            // 
            this.txtRes_Multi.Location = new System.Drawing.Point(827, 9);
            this.txtRes_Multi.Multiline = true;
            this.txtRes_Multi.Name = "txtRes_Multi";
            this.txtRes_Multi.Size = new System.Drawing.Size(219, 272);
            this.txtRes_Multi.TabIndex = 26;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_p2);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txt_p3);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txt_p1);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btnTokenSingle);
            this.tabPage4.Controls.Add(this.txtres_TokenSingle);
            this.tabPage4.Controls.Add(this.txtTemplate);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtDestination_token);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1063, 361);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TokenSingle";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(120, 193);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(186, 23);
            this.txt_p2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "p2";
            // 
            // txt_p3
            // 
            this.txt_p3.Location = new System.Drawing.Point(120, 233);
            this.txt_p3.Name = "txt_p3";
            this.txt_p3.Size = new System.Drawing.Size(186, 23);
            this.txt_p3.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "p3";
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(120, 147);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(186, 23);
            this.txt_p1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "p1";
            // 
            // btnTokenSingle
            // 
            this.btnTokenSingle.Location = new System.Drawing.Point(384, 174);
            this.btnTokenSingle.Name = "btnTokenSingle";
            this.btnTokenSingle.Size = new System.Drawing.Size(122, 51);
            this.btnTokenSingle.TabIndex = 19;
            this.btnTokenSingle.Text = "TokenSingle";
            this.btnTokenSingle.UseVisualStyleBackColor = true;
            this.btnTokenSingle.Click += new System.EventHandler(this.btnTokenSingle_Click);
            // 
            // txtres_TokenSingle
            // 
            this.txtres_TokenSingle.Location = new System.Drawing.Point(594, 24);
            this.txtres_TokenSingle.Multiline = true;
            this.txtres_TokenSingle.Name = "txtres_TokenSingle";
            this.txtres_TokenSingle.Size = new System.Drawing.Size(410, 272);
            this.txtres_TokenSingle.TabIndex = 18;
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(120, 41);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(186, 23);
            this.txtTemplate.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "TemplateKey";
            // 
            // txtDestination_token
            // 
            this.txtDestination_token.Location = new System.Drawing.Point(120, 92);
            this.txtDestination_token.Name = "txtDestination_token";
            this.txtDestination_token.Size = new System.Drawing.Size(186, 23);
            this.txtDestination_token.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Destination";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtRes_tokenMulti);
            this.tabPage5.Controls.Add(this.btnTokenMulti);
            this.tabPage5.Controls.Add(this.txtTemplateKey_multiToken);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.dgMultitoken);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1063, 361);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SendMultipleToken";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtRes_tokenMulti
            // 
            this.txtRes_tokenMulti.Location = new System.Drawing.Point(782, 17);
            this.txtRes_tokenMulti.Multiline = true;
            this.txtRes_tokenMulti.Name = "txtRes_tokenMulti";
            this.txtRes_tokenMulti.Size = new System.Drawing.Size(267, 272);
            this.txtRes_tokenMulti.TabIndex = 33;
            // 
            // btnTokenMulti
            // 
            this.btnTokenMulti.Location = new System.Drawing.Point(637, 83);
            this.btnTokenMulti.Name = "btnTokenMulti";
            this.btnTokenMulti.Size = new System.Drawing.Size(122, 51);
            this.btnTokenMulti.TabIndex = 32;
            this.btnTokenMulti.Text = "SendTokenMulti";
            this.btnTokenMulti.UseVisualStyleBackColor = true;
            this.btnTokenMulti.Click += new System.EventHandler(this.btnTokenMulti_Click);
            // 
            // txtTemplateKey_multiToken
            // 
            this.txtTemplateKey_multiToken.Location = new System.Drawing.Point(116, 32);
            this.txtTemplateKey_multiToken.Name = "txtTemplateKey_multiToken";
            this.txtTemplateKey_multiToken.Size = new System.Drawing.Size(186, 23);
            this.txtTemplateKey_multiToken.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "TemplateKey";
            // 
            // dgMultitoken
            // 
            this.dgMultitoken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMultitoken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Destination,
            this.userTraceId,
            this.p1,
            this.p2,
            this.p3});
            this.dgMultitoken.Location = new System.Drawing.Point(47, 83);
            this.dgMultitoken.Name = "dgMultitoken";
            this.dgMultitoken.RowTemplate.Height = 25;
            this.dgMultitoken.Size = new System.Drawing.Size(549, 229);
            this.dgMultitoken.TabIndex = 29;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            // 
            // userTraceId
            // 
            this.userTraceId.HeaderText = "userTraceId";
            this.userTraceId.Name = "userTraceId";
            // 
            // p1
            // 
            this.p1.HeaderText = "p1";
            this.p1.Name = "p1";
            // 
            // p2
            // 
            this.p2.HeaderText = "p2";
            this.p2.Name = "p2";
            // 
            // p3
            // 
            this.p3.HeaderText = "p3";
            this.p3.Name = "p3";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnshowTokenList);
            this.tabPage6.Controls.Add(this.txtRes_TokenList);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1063, 361);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "showTokenList";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnshowTokenList
            // 
            this.btnshowTokenList.Location = new System.Drawing.Point(65, 46);
            this.btnshowTokenList.Name = "btnshowTokenList";
            this.btnshowTokenList.Size = new System.Drawing.Size(129, 53);
            this.btnshowTokenList.TabIndex = 35;
            this.btnshowTokenList.Text = "showTokenList";
            this.btnshowTokenList.UseVisualStyleBackColor = true;
            this.btnshowTokenList.Click += new System.EventHandler(this.btnshowTokenList_Click);
            // 
            // txtRes_TokenList
            // 
            this.txtRes_TokenList.Location = new System.Drawing.Point(563, 17);
            this.txtRes_TokenList.Multiline = true;
            this.txtRes_TokenList.Name = "txtRes_TokenList";
            this.txtRes_TokenList.Size = new System.Drawing.Size(410, 272);
            this.txtRes_TokenList.TabIndex = 34;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtRes_IdSt);
            this.tabPage7.Controls.Add(this.btnGetStatusById);
            this.tabPage7.Controls.Add(this.btnMessageIds);
            this.tabPage7.Controls.Add(this.txt_Ids);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1063, 361);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "StatusById";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtRes_IdSt
            // 
            this.txtRes_IdSt.Location = new System.Drawing.Point(583, 16);
            this.txtRes_IdSt.Multiline = true;
            this.txtRes_IdSt.Name = "txtRes_IdSt";
            this.txtRes_IdSt.Size = new System.Drawing.Size(410, 272);
            this.txtRes_IdSt.TabIndex = 37;
            // 
            // btnGetStatusById
            // 
            this.btnGetStatusById.Location = new System.Drawing.Point(410, 35);
            this.btnGetStatusById.Name = "btnGetStatusById";
            this.btnGetStatusById.Size = new System.Drawing.Size(129, 53);
            this.btnGetStatusById.TabIndex = 36;
            this.btnGetStatusById.Text = "GetStatusById";
            this.btnGetStatusById.UseVisualStyleBackColor = true;
            this.btnGetStatusById.Click += new System.EventHandler(this.btnGetStatusById_Click);
            // 
            // btnMessageIds
            // 
            this.btnMessageIds.AutoSize = true;
            this.btnMessageIds.Location = new System.Drawing.Point(40, 34);
            this.btnMessageIds.Name = "btnMessageIds";
            this.btnMessageIds.Size = new System.Drawing.Size(68, 15);
            this.btnMessageIds.TabIndex = 19;
            this.btnMessageIds.Text = "MessageIds";
            // 
            // txt_Ids
            // 
            this.txt_Ids.Location = new System.Drawing.Point(144, 31);
            this.txt_Ids.Multiline = true;
            this.txt_Ids.Name = "txt_Ids";
            this.txt_Ids.PlaceholderText = "seprate By \',\'";
            this.txt_Ids.Size = new System.Drawing.Size(189, 57);
            this.txt_Ids.TabIndex = 18;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.txtRes_TraceIds);
            this.tabPage8.Controls.Add(this.btnStatusByTraceId);
            this.tabPage8.Controls.Add(this.btnUserTraceId);
            this.tabPage8.Controls.Add(this.txt_traceIds);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1063, 361);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "StatusByUserId";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // txtRes_TraceIds
            // 
            this.txtRes_TraceIds.Location = new System.Drawing.Point(634, 27);
            this.txtRes_TraceIds.Multiline = true;
            this.txtRes_TraceIds.Name = "txtRes_TraceIds";
            this.txtRes_TraceIds.Size = new System.Drawing.Size(410, 272);
            this.txtRes_TraceIds.TabIndex = 38;
            // 
            // btnStatusByTraceId
            // 
            this.btnStatusByTraceId.Location = new System.Drawing.Point(424, 39);
            this.btnStatusByTraceId.Name = "btnStatusByTraceId";
            this.btnStatusByTraceId.Size = new System.Drawing.Size(129, 53);
            this.btnStatusByTraceId.TabIndex = 37;
            this.btnStatusByTraceId.Text = "StatusByTraceId";
            this.btnStatusByTraceId.UseVisualStyleBackColor = true;
            this.btnStatusByTraceId.Click += new System.EventHandler(this.btnStatusByTraceId_Click);
            // 
            // btnUserTraceId
            // 
            this.btnUserTraceId.AutoSize = true;
            this.btnUserTraceId.Location = new System.Drawing.Point(36, 39);
            this.btnUserTraceId.Name = "btnUserTraceId";
            this.btnUserTraceId.Size = new System.Drawing.Size(67, 15);
            this.btnUserTraceId.TabIndex = 21;
            this.btnUserTraceId.Text = "UserTraceId";
            // 
            // txt_traceIds
            // 
            this.txt_traceIds.Location = new System.Drawing.Point(140, 36);
            this.txt_traceIds.Multiline = true;
            this.txt_traceIds.Name = "txt_traceIds";
            this.txt_traceIds.PlaceholderText = "seprate By \',\'";
            this.txt_traceIds.Size = new System.Drawing.Size(189, 57);
            this.txt_traceIds.TabIndex = 20;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.txtRes_AcountInfo);
            this.tabPage9.Controls.Add(this.btnGetAccountInfo);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1063, 361);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "AccountInfo";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // txtRes_AcountInfo
            // 
            this.txtRes_AcountInfo.Location = new System.Drawing.Point(536, 19);
            this.txtRes_AcountInfo.Multiline = true;
            this.txtRes_AcountInfo.Name = "txtRes_AcountInfo";
            this.txtRes_AcountInfo.Size = new System.Drawing.Size(410, 272);
            this.txtRes_AcountInfo.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 519);
            this.Controls.Add(this.tabcontroller);
            this.Controls.Add(this.txtApi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SMS-Webservice";
            this.tabcontroller.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmulti)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultitoken)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtApi;
        private Button btnGetAccountInfo;
        private TabControl tabcontroller;
        private TabPage tabPage1;
        private Button btnSendSMS;
        private TextBox txtRes1;
        private TextBox txtRecipient;
        private Label label5;
        private TextBox txtmsg;
        private Label Message;
        private TextBox txtSenderInput;
        private Label label2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private Button btnSend_Bulk;
        private TextBox txtRes_Bulk;
        private TextBox txtRecip_Bulk;
        private Label label3;
        private TextBox txtMessage_Bulk;
        private Label label4;
        private TextBox txtsender_bulk;
        private Label label6;
        private DataGridView dgmulti;
        private DataGridViewTextBoxColumn Sender_multi;
        private DataGridViewTextBoxColumn Text_Multi;
        private DataGridViewTextBoxColumn Destination_Multi;
        private DataGridViewTextBoxColumn userTraceId_multi;
        private Button btnSendMulti;
        private TextBox txtRes_Multi;
        private Button btnTokenSingle;
        private TextBox txtres_TokenSingle;
        private TextBox txtTemplate;
        private Label label7;
        private TextBox txtDestination_token;
        private Label label8;
        private TextBox txtSender_token;
        private Label TemplateKey;
        private TextBox txt_p2;
        private Label label9;
        private TextBox txt_p3;
        private Label label10;
        private TextBox txt_p1;
        private Label label11;
        private TextBox txtTemplateKey_multiToken;
        private Label label12;
        private DataGridView dgMultitoken;
        private TextBox txtRes_tokenMulti;
        private Button btnTokenMulti;
        private Button btnshowTokenList;
        private TextBox txtRes_TokenList;
        private TextBox txtRes_AcountInfo;
        private Label btnMessageIds;
        private TextBox txt_Ids;
        private Label btnUserTraceId;
        private TextBox txt_traceIds;
        private Button btnGetStatusById;
        private Button btnStatusByTraceId;
        private TextBox txtRes_IdSt;
        private TextBox txtRes_TraceIds;
        private DataGridViewTextBoxColumn Destination;
        private DataGridViewTextBoxColumn userTraceId;
        private DataGridViewTextBoxColumn p1;
        private DataGridViewTextBoxColumn p2;
        private DataGridViewTextBoxColumn p3;
    }
}