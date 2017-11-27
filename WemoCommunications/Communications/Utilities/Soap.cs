﻿using System.Xml.Linq;

namespace Communications.Utilities
{
    public class Soap
    {
        public static string GenerateWemoSoapRequest(WemoGetCommands cmd)
        {
            XNamespace ns = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace basicEventNs = "urn:Belkin:service:basicevent:1";

            var xml = new XDocument
            {
                Declaration = new XDeclaration("1.0", "utf-8", "true"),
            };

            var envElem = new XElement(ns + "Envelope",
                new XAttribute(XNamespace.Xmlns + "s", ns),
                new XAttribute("encodingStyle", "http://schemas.xmlsoap.org/soap/encoding/"),
                new XElement(ns + "Body",
                    new XElement(basicEventNs + cmd.ToString(),
                        new XAttribute(XNamespace.Xmlns + "u", basicEventNs))));
            xml.Add(envElem);
            var value = xml.ToString();

            return value;
        }

        public enum WemoGetCommands
        {
            GetSignalStrength,
            GetFriendlyName,
            GetBinaryState,
            GetHomeId,
            GetHomeInfo,
            GetDeviceId,
            GetMacAddr,
            GetSerialNo,
            GetPluginUDN,
            GetSmartDevInfo,
            GetRuleOverrideStatus,
            GetDeviceIcon,
            GetIconURL,
            GetLogFileURL,
            GetJardenStatus,
            GetWatchdogFile,
            GetServerEnvironment,
            GetIconVersion,
            GetSimulatedRuleData,
        }
    }
}
