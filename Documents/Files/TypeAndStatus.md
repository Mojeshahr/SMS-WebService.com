# **وبسرویس سامانه پیامکی**
در این وبسرویس انواع ارسالهای تکی، گروهی ، ارسال چند به چند و ارسال با استفاده از الگو(ارسال سریع) و همچنین متدهایی جهت استعلام وضعیت پیام و پنل نیز ارائه شده است.
## متد های ارائه شده :
* 	متد ارسال یک متن به یک یا چند شماره با متد Get  (Send  )
* 	متد ارسال یک متن به یک یا چند شماره با متد post  (SendBulk  )   
*  	متد ارسال چند متن به چند گیرنده (SendMultiple)
* 	متد ارسال به یک شماره با استفاده از الگوی تعریف شده    (SendTokenSingle)
*  	متد ارسال یک الگو با متن های مختلف به چند شماره (SendTokenMulti)
*  	متد دریافت لیست الگوهای تعریف شده در پنل  (TokenList)
* 	متد دریافت وضعیت پیام های ارسالی (StatusById)
*  	متد دریافت وضعیت پیام های ارسالی (StatusByTraceId)
*  	متد دریافت مقدار اعتبار و لیست خطوط ارسال کننده فعال در پنل (AccountInfo)
 
## لیست کد خطا های دریافتی از سرویس
* {کد **1**} =>   کلید اتصال (ApiKey) نادرست است   
* {کد **2**} =>  ارسال از وبسرویس برای این کاربر فعال نشده است.    
* {کد **3**} =>  کاربر فعال نیست    
* {کد **4**} =>  ارسال از طریق Api موقتا غیر   فعال است.  
* {کد **5**} =>  ارسال از طریق این متد موقتا غیر فعال است.   
* {کد **6**} =>  تلفن همراه ثبت شده روی این اکانت تائید نشده است    
* {کد **7**} =>  ایمیل ثبت شده روی این اکانت تائید نشده است     
* {کد **8**} =>  اطلاعات هویتی کاربر به صورت کامل درج نشده است  
* {کد **9**} =>   مقادیر ورودی نادرست است.   
* {کد **10**} =>  آی پی درخواست دهنده در لیست آی پی های معتبر نیست   
* {کد **11**} =>  فرمت ورودی ApiKey نادرست است  
* {کد **12**} =>  شماره ارسال کننده نادرست است  
* {کد **13**} =>  شماره دریافت کننده باید با 9 یا 989 شروع شود  
* {کد **14**} =>  شما به این متد دسترسی ندارید  
* {کد **15**} =>  سقف ارسال روزانه به پایان رسید 

## وضعیت های الگوهای تعریف شده 

* {وضعیت **1**} => در انتظار تایید  
* {وضعیت **2**} => تایید شده 
* {وضعیت **3**} => رد شده 

## لیست وضعیت های پیامک ارسالی
* {وضعیت **0**} => در صف سامانه 
* {وضعیت **1**} => ارسال شده، بدون وضعیت
* {وضعیت **2**} => ارسال شده، در صف اپراتور 
* {وضعیت **3**} => درانتظار تحویل گوشی
* {وضعیت **4**} => تحویل به گوشی
* {وضعیت **5**} => نرسیده به گوشی
* {وضعیت **6**} => خطا در ارسال
* {وضعیت **7**} => گیرنده مسدود
* {وضعیت **8**} => شناسه پیدا نشد
* {وضعیت **9**} => منقضی
* {وضعیت **10**} => نامشخص
* {وضعیت **11**} => دریافت کننده نامعتبر
* {وضعیت **12**} => گیرنده در لیست سیاه اکانت شماست
* {وضعیت **13**} => گیرنده نامعتبر
* {وضعیت **14**} => متن بلاک
* {وضعیت **15**} => لغو دریافت توسط گیرنده
* {وضعیت **16**} => بلاک شده
* {وضعیت **17**} => محدودیت روزانه


      