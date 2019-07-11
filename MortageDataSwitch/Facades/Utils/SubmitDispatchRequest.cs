using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace MortageDataSwitch.Facades.Utils
{
    public class DispatchRequest
    {
        private XmlDocument _requestXml;

        public DispatchRequest(string requestXml)
        {
            _requestXml = new XmlDocument();
            _requestXml.LoadXml(requestXml);
        }

        public string GetXml
        {
            get { return _requestXml.OuterXml; }
        }

        public string ChannelCode
        {
            get
            {
                return _requestXml.SelectSingleNode(".//Channel.Code").InnerText;
            }
            set
            {
                _requestXml.SelectSingleNode(".//Channel.Code").InnerText = value;
            }
        }

        public string ChannelUsername
        {
            get
            {
                return _requestXml.SelectSingleNode(".//Channel.Username").InnerText;
            }
            set
            {
                _requestXml.SelectSingleNode(".//Channel.Username").InnerText = value;
            }
        }

        public string ChannelPassword
        {
            get
            {
                return _requestXml.SelectSingleNode(".//Channel.Password").InnerText;
            }
            set
            {
                _requestXml.SelectSingleNode(".//Channel.Password").InnerText = value;
            }
        }

        public string PublicKey
        {
            get
            {
                return _requestXml.SelectSingleNode(".//Service.Key").InnerXml;
            }
        }

        public string MAC
        {
            set
            {
                _requestXml.SelectSingleNode(".//Application.Mac").InnerText = value;
            }
        }

        public void ResetTimeStamp()
        {
            DateTime now = DateTime.UtcNow;
            now = now.AddHours(2.0);
            

            _requestXml.SelectSingleNode(".//Request.DateTime").InnerText = now.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        public void ResetMAC()
        {
            try
            {
                _requestXml.SelectSingleNode(".//Application.Mac").InnerText = "";
            }
            catch { }
        }

        public void ResetAppRef()
        {
            try
            {
                _requestXml.SelectSingleNode(".//Application.Reference").InnerText = "";
            }
            catch { }
        }

        public string RootElement
        {
            get
            {
                return _requestXml.DocumentElement.Name;
            }
        }

        public long OriginatorReference
        {
            get
            {
                long originatorReference;
                XmlNode origString = _requestXml.SelectSingleNode(".//Originator.Reference");

                if (origString != null)
                {
                    if (long.TryParse(origString.InnerText, out originatorReference))
                        return originatorReference;
                }

                return -1;
            }
        }

        public long ApplicationReference
        {
            get
            {
                try
                {
                    return long.Parse(_requestXml.SelectSingleNode(".//Application.Reference").InnerText);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}