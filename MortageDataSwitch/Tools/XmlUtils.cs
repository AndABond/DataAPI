using MortageDataSwitch.Facades.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MortageDataSwitch.Tools
{
    /// <summary>
    /// Utils to help serialize xml to classes
    /// </summary>
    public static class XmlUtils
    {
        private static readonly log4net.ILog LOG = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Its a generic module to help deserialze xml to the respective class.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T DeserializeXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            var rdr = new StringReader(xml);
            var resultingMessage = (T)serializer.Deserialize(rdr);

            return (T)Convert.ChangeType(resultingMessage, typeof(T));
        }

        /// <summary>
        /// Generic module to help serialze object to xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string SerializeXml<T>(T data)
        {
            try
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                //var stringwriter = new System.IO.StringWriter();
                //var serializer = new XmlSerializer(typeof(T));
                //serializer.Serialize(stringwriter, data, ns);
                //string xml = stringwriter.ToString();
                //LOG.Debug("Serialized XML: " + xml);
                //return xml;

                var xml = string.Empty;

                using (var stringWriter = new StringWriter())
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { OmitXmlDeclaration = true }))
                    {
                        new XmlSerializer(typeof(T)).Serialize(xmlWriter, data, ns);

                        xml = stringWriter.ToString();
                    }
                }

                LOG.Debug("FINAL Serialized XML: " + xml);
                return xml;

            }
            catch(Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Apply mac rules on xml header
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static string FormatMacXml(string xml)
        {
            DispatchRequest xmlRequest = new DispatchRequest(xml);
            string publicKey = "";
            string mac = "";

            publicKey = xmlRequest.PublicKey;

            //Encrypt them. CH
            xmlRequest.ChannelCode = RsaUtils.Encrypt(publicKey, xmlRequest.ChannelCode);
            xmlRequest.ChannelUsername = RsaUtils.Encrypt(publicKey, xmlRequest.ChannelUsername);
            xmlRequest.ChannelPassword = RsaUtils.Encrypt(publicKey, xmlRequest.ChannelPassword);

            //Reset the XML before calculating MAC. CH
            xmlRequest.ResetTimeStamp();
            xmlRequest.ResetMAC();


            //Calculate the MAC. CH
            mac = RsaUtils.Hash(xmlRequest.GetXml);
            xmlRequest.MAC = RsaUtils.Encrypt(publicKey, mac);

            return xmlRequest.GetXml;
        }

    }
}