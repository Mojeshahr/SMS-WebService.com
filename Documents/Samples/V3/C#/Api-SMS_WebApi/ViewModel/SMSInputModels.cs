namespace mojeshahr.ViewModel
{
    public class BaseUser {
        public string ApiKey { get; set; }
    }
         
    public class SendBulkSMSInput: BaseUser
    {        
        public string Text { get; set; }
        public long Sender { get; set; }
        public SendBulkRecipient[] Recipients { get; set; }
    }

    public partial class SendBulkRecipient
    {
        public long Destination { get; set; }
        public long? UserTraceId { get; set; }
    }

    public class SendMultipleSMSInput : BaseUser
    {
       public SendMultipleRecipient[] Recipients { get; set; }
    }
    public partial class SendMultipleRecipient
    {
       public long Sender { get; set; }
       public string Text { get; set; }
        public long Destination { get; set; }
        public long UserTraceId { get; set; }
    }

    public class SendMultipleTokenInput : BaseUser
    {
        public SendMultipleTokenRecipient[] Recipients { get; set; }
        public string TemplateKey { get; set; }
    }
    public partial class SendMultipleTokenRecipient
    {
        public long Destination { get; set; }
        public long UserTraceId { get; set; }
        public string[] Parameters { get; set; }
    }

    public class GetStatusByIdInput : BaseUser
    {
        public long[] Ids { get; set; }
    }
    public class GetStatusByUserTraceIdsInput : BaseUser
    {
       public long[] UserTraceIds { get; set; }
    }

}
