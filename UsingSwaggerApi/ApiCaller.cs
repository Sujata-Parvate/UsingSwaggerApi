using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.IO;


/// <summary>
/// Summary description for WCFCaller
/// </summary>
public class ApiCaller
{
        
        public string sendMessage(string url, string messageTxt)
        {
            
            messageTxt = messageTxt.Replace("\\", "");
            WebRequest tRequest;
            tRequest = WebRequest.Create(url);
            tRequest.Method = "post";
            tRequest.ContentType = "application/json";
            string postData = messageTxt;
            postData = postData.Replace("\\", "");
            Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;
            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse tResponse = tRequest.GetResponse();
            dataStream = tResponse.GetResponseStream();
            StreamReader tReader = new StreamReader(dataStream);
            String sResponseFromServer = tReader.ReadToEnd();  //Get response from GCM server  
            String txtresponse = sResponseFromServer;  //Assigning GCM response to Label text
            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return txtresponse;
        }

    public string sendMessageWithAuthToken(string url, string messageTxt,string token)
    {

        messageTxt = messageTxt.Replace("\\", "");
        WebRequest tRequest;
        tRequest = WebRequest.Create(url);
        tRequest.Method = "post";
        tRequest.Headers.Add("Authorization", token);
        tRequest.ContentType = "application/json";
        string postData = messageTxt;
        postData = postData.Replace("\\", "");
        Console.WriteLine(postData);
        Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
        tRequest.ContentLength = byteArray.Length;

        Stream dataStream = tRequest.GetRequestStream();
        dataStream.Write(byteArray, 0, byteArray.Length);
        dataStream.Close();
        WebResponse tResponse = tRequest.GetResponse();
        dataStream = tResponse.GetResponseStream();
        StreamReader tReader = new StreamReader(dataStream);
        String sResponseFromServer = tReader.ReadToEnd();  //Get response from GCM server  
        String txtresponse = sResponseFromServer;  //Assigning GCM response to Label text
        tReader.Close();
        dataStream.Close();
        tResponse.Close();
        return txtresponse;
    }

    public string getMessage(string url)
        {
            
            WebRequest tRequest;
            tRequest = WebRequest.Create(url);
            tRequest.Method = "get";
            WebResponse tResponse = tRequest.GetResponse();
            Stream dataStream = tResponse.GetResponseStream();
            StreamReader tReader = new StreamReader(dataStream);
            String sResponseFromServer = tReader.ReadToEnd();  //Get response from GCM server  
            String txtresponse = sResponseFromServer; //Assigning GCM response to Label text
            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return txtresponse;
        }
 }
