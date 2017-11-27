﻿using Communications;
using Communications.Utilities;
using Communications.Responses;
using System.Net;

namespace WemoNet
{
    public class Wemo
    {
        #region Public Properties
        public HttpWebRequest WebRequest { get; set; }
        #endregion

        public WemoResponse GetResponse(Soap.WemoGetCommands cmd, string ipAddress)
        {
            var wemo = new WemoPlug { WebRequest = this.WebRequest };
            var response = wemo.GetResponse(cmd, ipAddress);
            return response;
        }

        public T GetResponseObject<T>(Soap.WemoGetCommands cmd, string ipAddress)
        {
            var wemo = new WemoPlug { WebRequest = this.WebRequest };
            var response = wemo.GetResponse(cmd, ipAddress);

            var objResponse = wemo.GetResponseObject<T>(response);
            return objResponse;
        }
    }

}
