public enum ApiMessageStatus
    {
        [Description("در صف سامانه")]
        InQueue = 0,
        [Description("ارسال شده، بدون وضعیت")]
        SentNoStatus = 1,
        [Description("ارسال شده، در صف")]
        SentInQueue= 2,
        [Description("درانتظار تحویل گوشی")]
        SentPendingToDeliver= 3,
        [Description("تحویل به گوشی")]
        Delivered = 4,
        [Description("نرسیده به گوشی")]
        SentFailed = 5,
        [Description("خطا در ارسال")]
        Failed = 6,
        [Description("گیرنده مسدود")]
        BlackList = 7,
        [Description("شناسه پیدا نشد")]
        NotFound = 8,
        [Description("منقضی")]
        Expired = 9,     
        [Description("نامخصی")]
        Unknown = 10,


        [Description("دریاف کننده نامعتبر")]
        DeactiveDestination = 11,
        [Description("گیرنده در لیست سیاه اکانت شماست")]
        UserBlackList = 12,
        [Description("گیرنده نامعتبر")]
        InvalidDestinationForOperator = 13,
        [Description("متن بلاک")]
        HasBlockWord = 14,
        [Description("لغو دریافت توسط گیرنده")]
        UnsubscribedByRecepient = 15,
        [Description("بلاک شده")]
        BlockedByRequester = 16,
        [Description("محدودیت روزانه")]
        BlockedByRequester = 17,
    }