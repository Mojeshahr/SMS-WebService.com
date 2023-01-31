var querystring = require('querystring');
const axios = require('axios');
// import axios from 'axios';
var express = require('express');
var app = express();
apiKey="XXXXXXXXXXXXXX";

host='http://api.sms-webservice.com/api/V3/';
function performRequest(endpoint, method, data) {
  if (method == 'GET') {
    endpoint += '?' + querystring.stringify(data); 
    data=null;
  }
 
 axios({
    method: method,
    url: host+endpoint,
    data: data
  }) .then(function (response) {
    console.log(endpoint);
    console.log( (response.data) );
   
  })
  .catch(function (error) {
    console.log(error);
  });


 
}

function SendSMS(Text,Sender,recipients) {
  performRequest('Send', 'GET', {
      ApiKey: apiKey,
      Text:Text,
      Sender:Sender,
      Recipients:recipients
  });
}
function SendBulk(Text,Sender,Recipients){
  performRequest('SendBulk','POST', {
      ApiKey:apiKey,
     Text:Text,
     Sender:Sender,
     Recipients:Recipients});
}



function SendMultiple(recipients) {
  performRequest('SendMultiple', 'POST', {
      
          ApiKey: apiKey,
          Recipients: recipients
                    
  });
}
function SendTokenSingle(templateKey,destination,p1,p2,p3) {
  performRequest('SendTokenSingle', 'GET', {
      ApiKey: apiKey,
      TemplateKey:templateKey,
      Destination:destination,
      p1:p1,
      p2:p2,
      p3:p3
  });
}

function SendTokenMultiple(templateKey,recipients) {
  performRequest('SendTokenMulti', 'POST', {
      
          ApiKey: apiKey,
          TemplateKey: templateKey,
          Recipients: recipients
                    
  });
}

function TokenList() {
  performRequest('TokenList', 'POST', {
      
          ApiKey: apiKey
                            
  });
}


function StatusById(ids) {
    performRequest('StatusById', 'POST', {
        
            ApiKey: apiKey,
            Ids:ids
                              
    });
  }
  function StatusByUserTraceId(userTraceIds) {
    performRequest('StatusByUserTraceId', 'POST', {
        
            ApiKey: apiKey,
            UserTraceIds:userTraceIds
                              
    });
  }
  function AccountInfo() {
    performRequest('AccountInfo', 'POST', {
        
            ApiKey: apiKey
                              
    });
  }

var server = app.listen(8081, function () {
  //SendSMS("متد اول",30001111111,'091111111,911111
 // SendBulk("متدارسال بالک",30001111111,[{Destination:91111111,UserTraceId: 1254 }]);
  // SendMultiple([
  //   {
  //     Sender: 30001111111,
  //     Text: "متد مالتی",
  //     Destination: 91111111,
  //     UserTraceId: 45621
  //   },{
  //     Sender: 30001111111,
  //     Text: "متد مالتی",
  //     Destination: 9111111,
  //     UserTraceId: 45622
  //   }
  // ]);
  //SendTokenSingle('digits',91111,'موج',123,1);

  // SendTokenMultiple('digits',[
  //   {
  //     Destination: 91111,
  //     UserTraceId: 32561,
  //     Parameters: [
  //       "موج",'1'
  //     ]
  //   }
  // ]);
  // TokenList();

  //  StatusById([13048933000,13048948000]);
   StatusByUserTraceId([1254,32561]);
   //AccountInfo();

  })

