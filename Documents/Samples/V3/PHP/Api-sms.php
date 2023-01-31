<?php
   $ApiKey  = "YOUR API KEY";
   $Sender = "YOUR SMS SENDER NUMBER";
   $BaseUrl = "http://api.sms-webservice.com/api/V3/";


function Send($recipients , $text){
      
     
        $params = array(
            'ApiKey' =>$GLOBALS["ApiKey"] ,
            'Text' => urlencode($text),
            'Sender' => $GLOBALS['Sender'],
            'Recipients' => $recipients,
        );


        $url = $GLOBALS["BaseUrl"].'Send?' . http_build_query($params);
        $curl = curl_init();
        curl_setopt_array($curl, array(
          CURLOPT_URL => $url,
          CURLOPT_RETURNTRANSFER => true,
          CURLOPT_ENCODING => '',
          CURLOPT_MAXREDIRS => 10,
          CURLOPT_TIMEOUT => 0,
          CURLOPT_FOLLOWLOCATION => true,
          CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
          CURLOPT_CUSTOMREQUEST => 'GET',
        ));
        $response = curl_exec($curl);
        curl_close($curl);
        return $response;
} 

function SendBulk($Destination, $UserTraceId , $Text){
        class Recipients{
            public $Destination;
            public $UserTraceId;
        }    
        if(is_array($Destination) && is_array($UserTraceId)){
            $Receptor= [];
            for($i=0; $i < count($Destination) ; $i++){
                $Recipient = new Recipients();
                $Recipient->Destination = $Destination[$i];
                $Recipient->UserTraceId = $UserTraceId[$i];
                array_push($Receptor , $Recipient);
            }
            
        }else{
            $Recipient = new Recipients();
            $Recipient->Destination = $Destination;
            $Recipient->UserTraceId = $UserTraceId;
            $Receptor = array($Recipient);
        }
        $data = array(
            'ApiKey'=>$GLOBALS["ApiKey"],
            'Text'=> $Text, 
            'Sender' => $GLOBALS['Sender'],
            'Recipients'=>$Receptor
        );
        $data_json = json_encode($data);
    
        $url =  $GLOBALS["BaseUrl"].'SendBulk';
        $ch = curl_init();
        curl_setopt($ch, CURLOPT_URL, $url);
        curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
        curl_setopt($ch, CURLOPT_POST, 1);
        curl_setopt($ch, CURLOPT_POSTFIELDS,$data_json);
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
        $response  = curl_exec($ch);
        curl_close($ch);
        return $response;
}

function SendMultiple($Destination , $UserTraceId , $Text){
    class Recipients{
        public $Sender;
        public $Text;
        public $Destination;
        public $UserTraceId;
    }
    if(is_array($Destination) && is_array($UserTraceId) && is_array($Text)){
        $Receptor= [];
        for($i=0; $i < count($Destination) ; $i++ ){
            $Recipient = new Recipients();
            $Recipient->Sender = $GLOBALS['Sender'];
            $Recipient->Text = $Text[$i];
            $Recipient->Destination = $Destination[$i];
            $Recipient->UserTraceId = $UserTraceId[$i];
            array_push($Receptor , $Recipient);
        }
    }else{
        $Recipient = new Recipients();
        $Recipient->Sender = $GLOBALS['Sender'];
        $Recipient->Text = $Text;
        $Recipient->Destination = $Destination;
        $Recipient->UserTraceId = $UserTraceId;
        $Receptor = array($Recipient);
    }

    
    $data = array(
        'ApiKey'=>$GLOBALS["ApiKey"],
        'Recipients'=>$Receptor
    );
    $data_json = json_encode($data);
    
    $url = $GLOBALS["BaseUrl"].'SendMultiple';
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
    curl_setopt($ch, CURLOPT_POST, 1);
    curl_setopt($ch, CURLOPT_POSTFIELDS,$data_json);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    $response  = curl_exec($ch);
    curl_close($ch);
    return $response;
}    

function SendTokenSingle($TemplateKey , $Destination, $param1 , $param2 , $param3){
  
    $params = array(
        'ApiKey' => $GLOBALS["ApiKey"],
        'TemplateKey' => $TemplateKey,
        'Destination' => $Destination,
        'p1' => $param1,
        'p2' => $param2,
        'p3' => $param3,
    );

    $url = $GLOBALS["BaseUrl"].'SendTokenSingle?' . http_build_query($params);
    $curl = curl_init();
    curl_setopt_array($curl, array(
      CURLOPT_URL => $url,
      CURLOPT_RETURNTRANSFER => true,
      CURLOPT_ENCODING => '',
      CURLOPT_MAXREDIRS => 10,
      CURLOPT_TIMEOUT => 0,
      CURLOPT_FOLLOWLOCATION => true,
      CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
      CURLOPT_CUSTOMREQUEST => 'GET',
    ));

    $response = curl_exec($curl);
    curl_close($curl); 

    return $response;
}

function SendTokenMulti($TemplateKey , $Destination , $UserTraceId , $Parameters ){
    class Recipients{
        public $Destination;
        public $UserTraceId;
        public $Parameters;
    }
    if(is_array($Destination) && is_array($UserTraceId) && is_array($Parameters) ){
        $Receptor= [];
        for($i=0; $i< count($Destination); $i++){
            $Recipient = new Recipients();
            $Recipient->Destination = $GLOBALS['Sender'];
            $Recipient->UserTraceId = $UserTraceId[$i];
            $Recipient->Destination = $Destination[$i];
            $Recipient->Parameters = $Parameters[$i];
            array_push($Receptor , $Recipient);

        }
    }else{
        $Recipient = new Recipients();
        $Recipient->Destination = $Destination;
        $Recipient->UserTraceId = $UserTraceId;
        $Recipient->Parameters = $Parameters;
        
        $Receptor = array($Recipient);
    }


   
    
    $data = array(
        'ApiKey'=>$GLOBALS["ApiKey"],
        'TemplateKey'=>$TemplateKey,
        'Recipients'=>$Receptor
    );
    $data_json = json_encode($data);
    
    $url = $GLOBALS["BaseUrl"].'/SendTokenMulti';
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
    curl_setopt($ch, CURLOPT_POST, 1);
    curl_setopt($ch, CURLOPT_POSTFIELDS,$data_json);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    $response  = curl_exec($ch);
    curl_close($ch);
    return $response;
}

function TokenList(){
   
    $data = array(
        'ApiKey'=>$GLOBALS["ApiKey"]
    );
    $data_json = json_encode($data);

    $url = $GLOBALS["BaseUrl"].'TokenList';
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
    curl_setopt($ch, CURLOPT_POST, 1);
    curl_setopt($ch, CURLOPT_POSTFIELDS,$data_json);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    $response  = curl_exec($ch);
    curl_close($ch);
    return $response;
}

function StatusById($Ids){
  
    $data = array(
        'ApiKey'=>$GLOBALS["ApiKey"],
        'Ids'=> $Ids
    );
    $data_json = json_encode($data);

    $url = $GLOBALS["BaseUrl"].'StatusById';
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
    curl_setopt($ch, CURLOPT_POST, 1);
    curl_setopt($ch, CURLOPT_POSTFIELDS,$data_json);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    $response  = curl_exec($ch);
    curl_close($ch);
    return $response;
}

function StatusByUserTraceId($UserTraceIds){
   
    $data = array(
        'ApiKey'=>$GLOBALS["ApiKey"],
        'UserTraceIds'=> $UserTraceIds
    );
    $data_json = json_encode($data);

    $url = $GLOBALS["BaseUrl"].'StatusByUserTraceId';
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
    curl_setopt($ch, CURLOPT_POST, 1);
    curl_setopt($ch, CURLOPT_POSTFIELDS,$data_json);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    $response  = curl_exec($ch);
    curl_close($ch);
    return $response;
}

function AccountInfo(){
   
    $data = array(
        'ApiKey'=>$GLOBALS["ApiKey"]
    );
    $data_json = json_encode($data);

    $url =$GLOBALS["BaseUrl"].'AccountInfo';
    $ch = curl_init();
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_HTTPHEADER, array('Content-Type: application/json'));
    curl_setopt($ch, CURLOPT_POST, 1);
    curl_setopt($ch, CURLOPT_POSTFIELDS,$data_json);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    $response  = curl_exec($ch);
    curl_close($ch);
    return $response;
}