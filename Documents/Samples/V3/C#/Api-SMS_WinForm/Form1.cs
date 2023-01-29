using Newtonsoft.Json;

namespace SMS_Webservice
{
    public partial class Form1 : Form
    {
        SMSWebservice smsWebservice;
        public Form1()
        {
            InitializeComponent();
             smsWebservice = new();
        }

        private async void btnGetAccountInfo_Click(object sender, EventArgs e)
        {

           var res = await smsWebservice.AccountInfo(new BaseUser() { ApiKey=txtApi.Text});
           txtRes_AcountInfo.Text = JsonConvert.SerializeObject(res, Formatting.Indented);

        }

        private async void btnSendSMS_Click(object sender, EventArgs e)

        {
            var res = await smsWebservice.SendSMSAsync(txtApi.Text,txtmsg.Text,long.Parse(txtSenderInput.Text),txtRecipient.Text);
            txtRes1.Text = JsonConvert.SerializeObject(res, Formatting.Indented);
        }

        private async void btnSend_Bulk_Click(object sender, EventArgs e)
        {
            var recipientArray = txtRecip_Bulk.Text.Split('-');
            SendBulkRecipient[] recipients = new SendBulkRecipient[recipientArray.Length];
            for (int i = 0; i < recipients.Length; i++)
            {

                recipients[i] = new SendBulkRecipient()
                {
                    Destination = long.Parse(recipientArray[i].Split(',')[0]),
                    UserTraceId = long.Parse(recipientArray[i].Split(',')[1])

                };
            }

            SendBulkSMSInput bulkSMSInput = new() { 
            ApiKey=txtApi.Text,
            Text=txtSenderInput.Text,
            Sender= long.Parse(txtsender_bulk.Text),
            Recipients= recipients
            }; 
            var res = await smsWebservice.SendBulkSMSAsync(bulkSMSInput);
            txtRes_Bulk.Text = JsonConvert.SerializeObject(res, Formatting.Indented);
        }
        private async void btnSendMulti_Click(object sender, EventArgs e)
         {

            SendMultipleRecipient []sendMultipleRecipients = new SendMultipleRecipient[dgmulti.RowCount];
            SendMultipleRecipient sendMultipleRecipient;
            for (int i = 0; i < dgmulti.RowCount; i++)
            {

                sendMultipleRecipient = new SendMultipleRecipient() {
                Destination=long.Parse(dgmulti.Rows[i].Cells["Destination_Multi"].Value.ToString()),
                Sender= long.Parse(dgmulti.Rows[i].Cells["Sender_multi"].Value.ToString()),
                Text = dgmulti.Rows[i].Cells["Text_Multi"].Value.ToString(),
                UserTraceId=long.Parse(dgmulti.Rows[i].Cells["userTraceId_multi"].Value.ToString())
                };

                sendMultipleRecipients[i] = sendMultipleRecipient;
            }
            SendMultipleSMSInput input = new SendMultipleSMSInput() { 
            ApiKey=txtApi.Text,
            Recipients=sendMultipleRecipients
            };
               
            

            var res = await smsWebservice.SendMultiPleSMSAsync(input);
            txtRes_Multi.Text = JsonConvert.SerializeObject(res, Formatting.Indented);

        }
        private async void btnTokenSingle_Click(object sender, EventArgs e)
        {
            var res = await smsWebservice.SendTokenSingle(txtApi.Text, txtTemplate.Text, long.Parse(txtDestination_token.Text), txt_p1.Text, txt_p2.Text, txt_p3.Text);

            txtres_TokenSingle.Text =JsonConvert.SerializeObject(res, Formatting.Indented);
        }
        private async void btnTokenMulti_Click(object sender, EventArgs e)
       {
            SendMultipleTokenRecipient[] sendMultipleRecipients = new SendMultipleTokenRecipient[dgMultitoken.RowCount-1];
            SendMultipleTokenRecipient sendMultipleRecipient;
            for (int i = 0; i < dgMultitoken.RowCount-1; i++)
            {

                sendMultipleRecipient = new SendMultipleTokenRecipient()
                {
                    Destination = long.Parse(dgMultitoken.Rows[i].Cells["Destination"].Value.ToString()),
                    UserTraceId = long.Parse(dgMultitoken.Rows[i].Cells["userTraceId"].Value.ToString()),
                    Parameters = new string[]{
                    dgMultitoken.Rows[i].Cells["p1"].Value?.ToString(),
                    dgMultitoken.Rows[i].Cells["p2"].Value?.ToString(),
                    dgMultitoken.Rows[i].Cells["p3"].Value?.ToString(),
                    }
                };
                sendMultipleRecipient.Parameters= sendMultipleRecipient.Parameters.Where(p => !string.IsNullOrEmpty(p)).ToArray();
                sendMultipleRecipients[i] = sendMultipleRecipient;
            }
            SendMultipleTokenInput input = new ()
            {
                ApiKey = txtApi.Text,
                TemplateKey = txtTemplateKey_multiToken.Text,
                Recipients = sendMultipleRecipients
            };



            var res = await smsWebservice.SendMultiPleTokenAsync(input);
            txtRes_tokenMulti.Text = JsonConvert.SerializeObject(res, Formatting.Indented);

        }

        private async void btnshowTokenList_Click(object sender, EventArgs e)
        {
            var res = await smsWebservice.TokenList(new BaseUser() { ApiKey = txtApi.Text });
            txtRes_TokenList.Text = JsonConvert.SerializeObject(res, Formatting.Indented);
        }

        private async void btnGetStatusById_Click(object sender, EventArgs e)
        {
            long [] Ids= txt_Ids.Text.Split(',').Select(i=>long.Parse(i)).ToArray();
           
            GetStatusByIdInput input = new GetStatusByIdInput() {
                ApiKey = txtApi.Text,
                Ids = Ids
            };

            var res = await smsWebservice.StatusById(input);
            txtRes_IdSt.Text = JsonConvert.SerializeObject(res, Formatting.Indented);

        }
        private async void btnStatusByTraceId_Click(object sender, EventArgs e)
  {

            long[] traceIds = txt_traceIds.Text.Split(',').Select(i => long.Parse(i)).ToArray();
          
            GetStatusByUserTraceIdsInput input = new GetStatusByUserTraceIdsInput()
            {
                ApiKey = txtApi.Text,
                UserTraceIds = traceIds
            };

            var res = await smsWebservice.StatusByUserTraceId(input);
            txtRes_TraceIds.Text = JsonConvert.SerializeObject(res, Formatting.Indented);

        }

       
    }
}