using Microsoft.AspNetCore.Mvc;
using mojeshahr.Services;
using mojeshahr.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mojeshahr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        public SMSWebservice smsWebservice = new SMSWebservice();

     
        [HttpGet]
        [Route("SendSMS")]
          public Task<SMSOutputGenericModel<List<SendSMSOutput>>> SendSMS([FromQuery]string ApiKey, [FromQuery] string Text, [FromQuery] long Sender, [FromQuery] string Recipients)
        {
          var response= smsWebservice.SendSMSAsync(ApiKey, Text, Sender, Recipients);   

           return response;
        }

        // POST api/<SMSController>
        [HttpPost]
        [Route("SendBulk")]
        public Task<SMSOutputGenericModel<List<SendSMSOutput>>> SendBulk([FromBody] SendBulkSMSInput value)
        {
            var response = smsWebservice.SendBulkSMSAsync(value);

            return response;

        }

        [HttpPost]
        [Route("SendMultiPleSMSAsync")]
        public Task<SMSOutputGenericModel<List<SendSMSOutput>>> SendMultiPleSMSAsync([FromBody] SendMultipleSMSInput value)
        {
            var response = smsWebservice.SendMultiPleSMSAsync(value);

            return response;

        }
        [HttpGet]
        [Route("TockenSingle")]
        public Task<SMSOutputGenericModel<List<SendTokenOutput>>> TockenSingle([FromQuery] string ApiKey, [FromQuery] string templateKey, [FromQuery] long Destination, [FromQuery] string p1, [FromQuery] string p2, [FromQuery] string p3)
        {
            var response = smsWebservice.SendTokenSingle(ApiKey, templateKey, Destination, p1, p2, p3);

            return response;
        }
        [HttpPost]
        [Route("SendMultipleToken")]
        public Task<SMSOutputGenericModel<List<SendTokenOutput>>> SendMultipleToken([FromBody] SendMultipleTokenInput value)
        {
            var response = smsWebservice.SendMultiPleTokenAsync(value);

            return response;

        }
        [HttpPost]
        [Route("ShowTokenList")]
        public Task<SMSOutputGenericModel<List<TokenListOutput>>> ShowTokenList([FromBody] BaseUser user)
        {
            var response = smsWebservice.TokenList(user);

            return response;

        }
        [HttpPost]
        [Route("StatusById")]
        public Task<SMSOutputGenericModel<List<SMSStatusOutput>>> StatusById([FromBody] GetStatusByIdInput value)
        {
            var response = smsWebservice.StatusById(value);

            return response;

        }
        [HttpPost]
        [Route("StatusByUserTraceId")]
        public Task<SMSOutputGenericModel<List<SMSStatusOutput>>> StatusByUserTraceId([FromBody] GetStatusByUserTraceIdsInput value)
        {
            var response = smsWebservice.StatusByUserTraceId(value);

            return response;

        }
        [HttpPost]
        [Route("AccountInfo")]
        public Task<SMSOutputGenericModel<SMSAcountIfoOutput>> AccountInfo([FromBody] BaseUser user)
        {
            var response = smsWebservice.AccountInfo(user);
            return response;

        }

    }
}
