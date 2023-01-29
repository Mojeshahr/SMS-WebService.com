namespace mojeshahr.ViewModel
{
    public class SMSOutputGenericModel<T>
    {
        public bool Success { get; set; }

       public int? ErrorCode { get; set; }

       public string Error { get; set; }

        public T Result { get; set; }
    }

    public class SendSMSOutput
    {
        public long Id { get; set; }

        public long? UserTraceId { get; set; }
    }

    public class SendTokenOutput {
            public long Id { get; set; }
            public long? UserTraceId { get; set; }

           public long Sender { get; set; }

           public string FinalText { get; set; }
        
    }
    public class TokenListOutput {
        public string Key { get; set; }
       public string TextTemplate { get; set; }
        public string VoiceTemplate { get; set; }
       public long Status { get; set; }
    }
    public class SMSStatusOutput {
       public long Id { get; set; }
       public long? UserTraceId { get; set; }
        public long StatusCode { get; set; }
        public string Status { get; set; }
    }
    public class SMSAcountIfoOutput
    {
        public long Credit { get; set; }
        public long[] AvailableSenders { get; set; }
    }


    }
