using Support;


 
var postRequest = new PostRequest("https://www.dns-shop.ru/");

postRequest.Data = "data={\"type\":\"retail-rocket-product\",\"containers\":[{\"id\":\"as-Xjz2G4\",\"data\":{\"product\":\"2310b40e-accd-11e8-9547-00155d03330d\",\"requestUrl\":\"/product/2310b40eaccd3330/processor-amd-athlon-200ge-oem/\",\"referrerUrl\":\"https://www.dns-shop.ru/catalog/17a899cd16404e77/processory/\"}}]}";
postRequest.Accept = "*/*";
postRequest.Useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36 OPR/106.0.0.0 (Edition Yx GX 03)";
postRequest.ContentType = "application/x-www-form-urlencoded";
postRequest.Headers.Add("X-CSRF-Token", "rc-AgoJ1JMN6p0x9NzZaALWYVw8LKKTXZT4rvryS1GXIp8Xy0iB-8y-TOTpxRilL39c-aj4fwYUwUHyTitegDA==");
postRequest.Referer = "https://www.dns-shop.ru/product/2310b40eaccd3330/processor-amd-athlon-200ge-oem/no-referrer";

postRequest.Host = "www.dns-shop.ru";

postRequest.Headers.Add("Origin","https://www.dns-shop.ru");

postRequest.Headers.Add("sec-ch-ua", "\"Not_A Brand\";v=\"8\", \"Chromium\";v=\"120\", \"Opera GX\";v=\"106\"");
postRequest.Headers.Add("sec-ch-ua", "?0");
postRequest.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
postRequest.Headers.Add("Sec-Fetch-Dest", "empty");

postRequest.Headers.Add("Sec-Fetch-Mode", "cors");
postRequest.Headers.Add("Sec-Fetch-Site", "same-origin");
postRequest.Headers.Add("", "");
postRequest.Headers.Add("", "");
postRequest.Headers.Add("", "");


postRequest.Run();