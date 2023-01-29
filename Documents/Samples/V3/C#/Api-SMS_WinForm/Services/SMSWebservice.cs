using Newtonsoft.Json;
using RestSharp;

namespace SMS_Webservice
{
    public class SMSWebservice
    {
        private RestClient _client = new("http://api.sms-webservice.com/api/V3/");


        public async Task<SMSOutputGenericModel<List<SendSMSOutput>>> SendSMSAsync(string ApiKey, string Text, long Sender, string Recipients)
        {
            var request = new RestRequest($"Send").AddQueryParameter("ApiKey", ApiKey,true);
            request.AddQueryParameter("Text", Text,true);
            request.AddQueryParameter("Sender", Sender);
            request.AddQueryParameter("Recipients", Recipients);
          
            var response = await _client.ExecuteGetAsync(request);
            SMSOutputGenericModel<List<SendSMSOutput>> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<List<SendSMSOutput>>>(response.Content);
            return finalresult;


        }

        public async Task<SMSOutputGenericModel<List<SendSMSOutput>>> SendBulkSMSAsync(SendBulkSMSInput Input)
        {
            var request = new RestRequest($"SendBulk").AddJsonBody(Input);
            var response = await _client.ExecutePostAsync(request);
            SMSOutputGenericModel<List<SendSMSOutput>> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<List<SendSMSOutput>>>(response.Content);
            return finalresult;

        }

        public async Task<SMSOutputGenericModel<List<SendSMSOutput>>> SendMultiPleSMSAsync(SendMultipleSMSInput Input)
        {
            var request = new RestRequest($"SendMultiple").AddJsonBody(Input);
            var response = await _client.ExecutePostAsync(request);
            SMSOutputGenericModel<List<SendSMSOutput>> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<List<SendSMSOutput>>>(response.Content);
            return finalresult;

        }

        public async Task<SMSOutputGenericModel<List<SendTokenOutput>>> SendTokenSingle(string ApiKey, string TemplateKey, long Destination, string p1, string p2, string p3)
        {
            var request = new RestRequest($"SendTokenSingle").AddQueryParameter("ApiKey", ApiKey, true);
            request.AddQueryParameter("TemplateKey", TemplateKey);
            request.AddQueryParameter("Destination", Destination);
            if (p1.Length > 0) request.AddQueryParameter("p1", p1);
            if (p1.Length > 0) request.AddQueryParameter("p2", p2);
            if (p1.Length > 0) request.AddQueryParameter("p3", p3);

           var response = await _client.ExecuteGetAsync(request);
            SMSOutputGenericModel<List<SendTokenOutput>> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<List<SendTokenOutput>>>(response.Content);
            return finalresult;

        }

        public async Task<SMSOutputGenericModel<List<SendTokenOutput>>> SendMultiPleTokenAsync(SendMultipleTokenInput Input)
        {
            var request = new RestRequest($"SendTokenMulti").AddJsonBody(Input);
            var response = await _client.ExecutePostAsync(request);
            SMSOutputGenericModel<List<SendTokenOutput>> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<List<SendTokenOutput>>>(response.Content);
            return finalresult;

        }

        public async Task<SMSOutputGenericModel<List<TokenListOutput>>> TokenList(BaseUser user)
        {
            var request = new RestRequest($"TokenList").AddJsonBody(user);
            var response = await _client.ExecutePostAsync(request);
            SMSOutputGenericModel<List<TokenListOutput>> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<List<TokenListOutput>>>(response.Content);
            return finalresult;

        }

        public async Task<SMSOutputGenericModel<List<SMSStatusOutput>>> StatusById(GetStatusByIdInput input)
        {
            var request = new RestRequest($"StatusById").AddJsonBody(input);
            var response = await _client.ExecutePostAsync(request);
            SMSOutputGenericModel<List<SMSStatusOutput>> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<List<SMSStatusOutput>>>(response.Content);
            return finalresult;

        }
        public async Task<SMSOutputGenericModel<List<SMSStatusOutput>>> StatusByUserTraceId(GetStatusByUserTraceIdsInput input)
        {
            var request = new RestRequest($"StatusByUserTraceId").AddJsonBody(input);
            var response = await _client.ExecutePostAsync(request);
            SMSOutputGenericModel<List<SMSStatusOutput>> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<List<SMSStatusOutput>>>(response.Content);
            return finalresult;

        }

        public async Task<SMSOutputGenericModel<SMSAcountIfoOutput>> AccountInfo(BaseUser user)
        {
            var request = new RestRequest($"AccountInfo").AddJsonBody(user);
            var response = await _client.ExecutePostAsync(request);
            SMSOutputGenericModel<SMSAcountIfoOutput> finalresult = JsonConvert.DeserializeObject<SMSOutputGenericModel<SMSAcountIfoOutput>>(response.Content);
            return finalresult;

        }

    }
}
