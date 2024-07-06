  WebProxy ConfigProxy(string Proxy)
  {
      if (Proxy.Split(':').Length == 4)
      {
          WebProxy proxy = new WebProxy(Proxy.Split(':')[0], Convert.ToInt32(Proxy.Split(':')[1]))
          {
              Credentials = new NetworkCredential(Proxy.Split(':')[2], Proxy.Split(':')[3])
          };
          return proxy;

      }
      else if (Proxy.Split(':').Length == 2)
      {
          WebProxy proxy = new WebProxy(Proxy.Split(':')[0], Convert.ToInt32(Proxy.Split(':')[1]));
          return proxy;
      }
      else
      {
          WebProxy proxy = null;
          return proxy;
      }


  }



string StartFarmingBlum(string Token, string ProxyNe)
 {
     var options = new RestClientOptions("https://game-domain.blum.codes")
     {
         MaxTimeout = -1,
         UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36",
         Proxy = ConfigProxy(ProxyNe)
     };
     var client = new RestClient(options);
     var request = new RestRequest("/api/v1/farming/start", Method.Post);
     request.AddHeader("Host", "game-domain.blum.codes");
     request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"124\", \"Google Chrome\";v=\"124\", \"Not-A.Brand\";v=\"99\"");
     request.AddHeader("Accept", "application/json, text/plain, */*");
     request.AddHeader("sec-ch-ua-mobile", "?0");
     request.AddHeader("Authorization", "Bearer " + Token);
     request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
     request.AddHeader("Origin", "https://telegram.blum.codes");
     request.AddHeader("Sec-Fetch-Site", "same-site");
     request.AddHeader("Sec-Fetch-Mode", "cors");
     request.AddHeader("Sec-Fetch-Dest", "empty");
     request.AddHeader("Accept-Language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
     request.AddHeader("Cache-Control", "no-cache");
     request.AddHeader("Content-Type", "text/plain");
     var body = @"https://game-domain.blum.codes/api/v1/farming/start";
     request.AddParameter("text/plain", body, ParameterType.RequestBody);
     RestResponse response = client.Execute(request);
     Console.WriteLine(response.Content);
     return response.Content;
 }
 string ClaimFarmingBlum(string Token, string ProxyNe)
 {
     var options = new RestClientOptions("https://game-domain.blum.codes")
     {
         MaxTimeout = -1,
         UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36",
         Proxy = ConfigProxy(ProxyNe)
     };
     var client = new RestClient(options);
     var request = new RestRequest("/api/v1/farming/claim", Method.Post);
     request.AddHeader("Host", "game-domain.blum.codes");
     request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"124\", \"Google Chrome\";v=\"124\", \"Not-A.Brand\";v=\"99\"");
     request.AddHeader("Accept", "application/json, text/plain, */*");
     request.AddHeader("sec-ch-ua-mobile", "?0");
     request.AddHeader("Authorization", "Bearer " + Token);
     request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
     request.AddHeader("Origin", "https://telegram.blum.codes");
     request.AddHeader("Sec-Fetch-Site", "same-site");
     request.AddHeader("Sec-Fetch-Mode", "cors");
     request.AddHeader("Sec-Fetch-Dest", "empty");
     request.AddHeader("Accept-Language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
     request.AddHeader("Cache-Control", "no-cache");
     request.AddHeader("Content-Type", "text/plain");
     var body = @"https://game-domain.blum.codes/api/v1/farming/claim";
     request.AddParameter("text/plain", body, ParameterType.RequestBody);
     RestResponse response = client.Execute(request);
     Console.WriteLine(response.Content);
     return response.Content;
 }
 string StartTaskBlum(string Token, string idTask, string ProxyNe)
 {
     var options = new RestClientOptions("https://game-domain.blum.codes")
     {
         MaxTimeout = -1,
         UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36",
         Proxy = ConfigProxy(ProxyNe)
     };
     var client = new RestClient(options);
     var request = new RestRequest($"/api/v1/tasks/{idTask}/start", Method.Post);
     request.AddHeader("Host", "game-domain.blum.codes");
     request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"124\", \"Google Chrome\";v=\"124\", \"Not-A.Brand\";v=\"99\"");
     request.AddHeader("Accept", "application/json, text/plain, */*");
     request.AddHeader("sec-ch-ua-mobile", "?0");
     request.AddHeader("Authorization", "Bearer " + Token);
     request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
     request.AddHeader("Origin", "https://telegram.blum.codes");
     request.AddHeader("Sec-Fetch-Site", "same-site");
     request.AddHeader("Sec-Fetch-Mode", "cors");
     request.AddHeader("Sec-Fetch-Dest", "empty");
     request.AddHeader("Accept-Language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
     request.AddHeader("Cache-Control", "no-cache");
     request.AddHeader("Content-Type", "text/plain");
     var body = $@"https://game-domain.blum.codes/api/v1/tasks/{idTask}/start";
     request.AddParameter("text/plain", body, ParameterType.RequestBody);
     RestResponse response = client.Execute(request);
     Console.WriteLine(response.Content);
     return response.Content;
 }
 string ClaimTaskBlum(string Token, string idTask, string ProxyNe)
 {
     var options = new RestClientOptions("https://game-domain.blum.codes")
     {
         MaxTimeout = -1,
         UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36",
         Proxy = ConfigProxy(ProxyNe)
     };
     var client = new RestClient(options);
     var request = new RestRequest($"/api/v1/tasks/{idTask}/claim", Method.Post);
     request.AddHeader("Host", "game-domain.blum.codes");
     request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"124\", \"Google Chrome\";v=\"124\", \"Not-A.Brand\";v=\"99\"");
     request.AddHeader("Accept", "application/json, text/plain, */*");
     request.AddHeader("sec-ch-ua-mobile", "?0");
     request.AddHeader("Authorization", "Bearer " + Token);
     request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
     request.AddHeader("Origin", "https://telegram.blum.codes");
     request.AddHeader("Sec-Fetch-Site", "same-site");
     request.AddHeader("Sec-Fetch-Mode", "cors");
     request.AddHeader("Sec-Fetch-Dest", "empty");
     request.AddHeader("Accept-Language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
     request.AddHeader("Cache-Control", "no-cache");
     request.AddHeader("Content-Type", "text/plain");
     var body = $@"https://game-domain.blum.codes/api/v1/tasks/{idTask}/claim";
     request.AddParameter("text/plain", body, ParameterType.RequestBody);
     RestResponse response = client.Execute(request);
     Console.WriteLine(response.Content);
     return response.Content;
 }
 string GetinfoBlum(string Token, string ProxyNe)
 {
     try
     {
         Leaf.xNet.HttpRequest request = new Leaf.xNet.HttpRequest();
         request.IgnoreProtocolErrors = true;
         if (ProxyNe != "")
         {
             string proxyAddress = ProxyNe.Split(':')[0]; // Địa chỉ proxy
             int proxyPort = Convert.ToInt32(ProxyNe.Split(':')[1]); // Cổng proxy
             var httpProxy = HttpProxyClient.Parse($"{proxyAddress}:{proxyPort}");
             if (ProxyNe.Split(':').Length == 4)
             {
                 httpProxy.Username = ProxyNe.Split(':')[2];
                 httpProxy.Password = ProxyNe.Split(':')[3];
             }
             request.Proxy = httpProxy;
         }
         request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36 Edg/125.0.0.0";


         //var options = new RestClientOptions("https://game-domain.blum.codes")
         //{
         //    MaxTimeout = -1,
         //    UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36 Edg/125.0.0.0",
         //    Proxy = ConfigProxy(ProxyNe)
         //};
         //var client = new RestClient(options);
         //var request = new RestRequest("/api/v1/user/balance", Method.Get);
         request.AddHeader("Host", "game-domain.blum.codes");
         request.AddHeader("sec-ch-ua", "\"Microsoft Edge\";v=\"125\", \"Chromium\";v=\"125\", \"Not.A/Brand\";v=\"24\", \"Microsoft Edge WebView2\";v=\"125\"");
         request.AddHeader("Accept", "application/json, text/plain, */*");
         request.AddHeader("sec-ch-ua-mobile", "?0");
         request.AddHeader("Authorization", "Bearer " + Token);
         request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
         request.AddHeader("Origin", "https://telegram.blum.codes");
         request.AddHeader("Sec-Fetch-Site", "same-site");
         request.AddHeader("Sec-Fetch-Mode", "cors");
         request.AddHeader("Sec-Fetch-Dest", "empty");
         request.AddHeader("Accept-Language", "en-US,en;q=0.9");
         request.AddHeader("Cache-Control", "no-cache");
         //RestResponse response = client.Execute(request);
         //Console.WriteLine(response.Content);
         //return response.Content;

         string response = request.Get("https://game-domain.blum.codes/api/v1/user/balance").ToString();
         return response;
     }
     catch (Exception ex)
     {
         return "Lỗi không lấy được thông tin tài khoản: " + ex.Message;
     }

 }
 string CreateGameBlum(string Token, string ProxyNe)
 {
     Leaf.xNet.HttpRequest request = new Leaf.xNet.HttpRequest();
     request.IgnoreProtocolErrors = true;
     if (ProxyNe != "")
     {
         string proxyAddress = ProxyNe.Split(':')[0]; // Địa chỉ proxy
         int proxyPort = Convert.ToInt32(ProxyNe.Split(':')[1]); // Cổng proxy
         var httpProxy = HttpProxyClient.Parse($"{proxyAddress}:{proxyPort}");
         if (ProxyNe.Split(':').Length == 4)
         {
             httpProxy.Username = ProxyNe.Split(':')[2];
             httpProxy.Password = ProxyNe.Split(':')[3];
         }
         request.Proxy = httpProxy;
     }
     request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36 Edg/125.0.0.0";


     //var options = new RestClientOptions("https://game-domain.blum.codes")
     //{
     //    MaxTimeout = -1,
     //    UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36 Edg/125.0.0.0",
     //    Proxy = ConfigProxy(ProxyNe)
     //};
     //var client = new RestClient(options);
     //var request = new RestRequest("/api/v1/game/play", Method.Post);
     request.AddHeader("Host", "game-domain.blum.codes");
     request.AddHeader("sec-ch-ua", "\"Microsoft Edge\";v=\"125\", \"Chromium\";v=\"125\", \"Not.A/Brand\";v=\"24\", \"Microsoft Edge WebView2\";v=\"125\"");
     request.AddHeader("Accept", "application/json, text/plain, */*");
     request.AddHeader("sec-ch-ua-mobile", "?0");
     request.AddHeader("Authorization", "Bearer " + Token);
     request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
     request.AddHeader("Origin", "https://telegram.blum.codes");
     request.AddHeader("Sec-Fetch-Site", "same-site");
     request.AddHeader("Sec-Fetch-Mode", "cors");
     request.AddHeader("Sec-Fetch-Dest", "empty");
     request.AddHeader("Accept-Language", "en-US,en;q=0.9");
     request.AddHeader("Cache-Control", "no-cache");
     request.AddHeader("Content-Type", "text/plain");
     var body = @"https://game-domain.blum.codes/api/v1/game/play";
     //request.AddParameter("text/plain", body, ParameterType.RequestBody);
     //RestResponse response =  client.Execute(request);
     //Console.WriteLine(response.Content);
     //return response.Content;

     string response = request.Post("https://game-domain.blum.codes/api/v1/game/play", body, "text/plain").ToString();
     return response;


 }
 string PlaygameBlum(string Token, string GameID, int DiemGame, string Proxy)
 {
     Leaf.xNet.HttpRequest request = new Leaf.xNet.HttpRequest();
     request.IgnoreProtocolErrors = true;
     if (Proxy != "")
     {
         string proxyAddress = Proxy.Split(':')[0]; // Địa chỉ proxy
         int proxyPort = Convert.ToInt32(Proxy.Split(':')[1]); // Cổng proxy
         var httpProxy = HttpProxyClient.Parse($"{proxyAddress}:{proxyPort}");
         if (Proxy.Split(':').Length == 4)
         {
             httpProxy.Username = Proxy.Split(':')[2];
             httpProxy.Password = Proxy.Split(':')[3];
         }
         request.Proxy = httpProxy;
     }
     request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36 Edg/125.0.0.0";
     request.AddHeader("Host", "game-domain.blum.codes");
     request.AddHeader("sec-ch-ua", "\"Microsoft Edge\";v=\"125\", \"Chromium\";v=\"125\", \"Not.A/Brand\";v=\"24\", \"Microsoft Edge WebView2\";v=\"125\"");
     request.AddHeader("Accept", "application/json, text/plain, */*");
     request.AddHeader("Content-Type", "application/json");
     request.AddHeader("sec-ch-ua-mobile", "?0");
     request.AddHeader("Authorization", "Bearer " + Token);
     request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
     request.AddHeader("Origin", "https://telegram.blum.codes");
     request.AddHeader("Sec-Fetch-Site", "same-site");
     request.AddHeader("Sec-Fetch-Mode", "cors");
     request.AddHeader("Sec-Fetch-Dest", "empty");
     request.AddHeader("Accept-Language", "en-US,en;q=0.9");
     request.AddHeader("Cache-Control", "no-cache");
     var body_0 = new
     {
         gameId = GameID,
         points = DiemGame,
     };
     string body = JsonConvert.SerializeObject(body_0);
     //string id = "b898795c-a4de-4aed-a5b2-130a3e64484a";
     //string body = "{\"gameId\":\"}";


     //MessageBox.Show(body);
     string response = request.Post("https://game-domain.blum.codes/api/v1/game/claim", body, "text/plain").ToString();
     return response;
 }

 string GetTaskBlum(string Token, string ProxyNe)
 {
     var options = new RestClientOptions("https://game-domain.blum.codes")
     {
         MaxTimeout = -1,
         UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36",
         Proxy = ConfigProxy(ProxyNe)
     };
     var client = new RestClient(options);
     var request = new RestRequest("/api/v1/tasks", Method.Get);
     request.AddHeader("accept", "application/json, text/plain, */*");
     request.AddHeader("accept-language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
     request.AddHeader("authorization", "Bearer " + Token);
     request.AddHeader("origin", "https://telegram.blum.codes");
     request.AddHeader("priority", "u=1, i");
     request.AddHeader("sec-ch-ua", "\"Not/A)Brand\";v=\"8\", \"Chromium\";v=\"126\", \"Google Chrome\";v=\"126\"");
     request.AddHeader("sec-ch-ua-mobile", "?0");
     request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
     request.AddHeader("sec-fetch-dest", "empty");
     request.AddHeader("sec-fetch-mode", "cors");
     request.AddHeader("sec-fetch-site", "same-site");
     RestResponse response = client.Execute(request);
     Console.WriteLine(response.Content);
     return response.Content;
 }
 string GetRefCodeBlum(string Token, string ProxyNe)
 {
     var options = new RestClientOptions("https://gateway.blum.codes")
     {
         MaxTimeout = -1,
         UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36",
         Proxy = ConfigProxy(ProxyNe)
     };
     var client = new RestClient(options);
     var request = new RestRequest("/v1/friends/balance", Method.Get);
     request.AddHeader("accept", "application/json, text/plain, */*");
     request.AddHeader("accept-language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
     request.AddHeader("authorization", "Bearer " + Token);
     request.AddHeader("origin", "https://telegram.blum.codes");
     request.AddHeader("priority", "u=1, i");
     request.AddHeader("sec-ch-ua", "\"Not/A)Brand\";v=\"8\", \"Chromium\";v=\"126\", \"Google Chrome\";v=\"126\"");
     request.AddHeader("sec-ch-ua-mobile", "?0");
     request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
     request.AddHeader("sec-fetch-dest", "empty");
     request.AddHeader("sec-fetch-mode", "cors");
     request.AddHeader("sec-fetch-site", "same-site");
     RestResponse response = client.Execute(request);
     Console.WriteLine(response.Content);
     return response.Content;
 }
