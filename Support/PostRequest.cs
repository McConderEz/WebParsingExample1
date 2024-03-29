﻿using System.Net;
using System.Text;

namespace Support
{
    public class PostRequest
    {
        HttpWebRequest _request;
        string _address;
        public Dictionary<string,string> Headers { get; set; }
        public string Response { get; set; }
        public string Accept { get; set; }
        public string Host { get; set; }
        public string ContentType { get; set; }
        public string Referer { get; set; }
        public string Useragent { get; set; }
        public string Data { get; set; }
        public WebProxy Proxy { get; set; }

        public PostRequest(string address)
        {
            _address = address;
            Headers = new Dictionary<string,string>();
        }

        public void Run()
        {
            _request = (HttpWebRequest)WebRequest.Create(_address);
            _request.Method = "POST";

            try
            {
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var stream = response.GetResponseStream();

                if (stream != null)
                {
                    Response = new StreamReader(stream).ReadToEnd();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Run(CookieContainer cookieContainer)
        {
            _request = (HttpWebRequest)WebRequest.Create(_address);
            _request.Method = "POST";
            _request.CookieContainer = cookieContainer;
            _request.Proxy = Proxy;
            _request.Accept = Accept;
            _request.Host = Host;
            _request.ContentType = ContentType;
            _request.Referer = Referer;
            _request.UserAgent = Useragent;

            byte[] sendData = Encoding.UTF8.GetBytes(Data); 
            _request.ContentLength = sendData.Length;
            Stream sendStream = _request.GetRequestStream();
            sendStream.Write(sendData, 0, sendData.Length);
            sendStream.Close();

            foreach(var item in Headers)
            {
                _request.Headers.Add(item.Key, item.Value); 
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var stream = response.GetResponseStream();

                if (stream != null)
                {
                    Response = new StreamReader(stream).ReadToEnd();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
