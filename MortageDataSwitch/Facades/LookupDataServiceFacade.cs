using MortageDataSwitch.Models;
using MortageDataSwitch.Services;
using MortageDataSwitch.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;
using System.Xml.Serialization;

namespace MortageDataSwitch.Facades
{
    /// <summary>
    /// 
    /// </summary>
    public static class LookupDataServiceFacade
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <returns></returns>
        public static GetTableValuesReply GetTableValues(LookupServiceRequest lookupRequest)
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);

            var request = new LookupDataService.LookupDataServiceSoapClient("Lookup.DataServiceSoap");

            var xml = XmlUtils.SerializeXml<LookupServiceRequest>(lookupRequest);

            xml = XmlUtils.FormatMacXml(xml);

            var response = request.GetTableValues(xml);

            var reply = XmlUtils.DeserializeXml<GetTableValuesReply>(response);

            if(reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("GetTableValues", xml, string.Empty);
            }

            return reply;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <returns></returns>
        public static GetTableValuesZippedReply GetTableValuesZipped(LookupServiceRequest lookupRequest)
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);

            var request = new LookupDataService.LookupDataServiceSoapClient("Lookup.DataServiceSoap");

            var xml = XmlUtils.SerializeXml<LookupServiceRequest>(lookupRequest);

            var response = request.GetTableValuesZipped(XmlUtils.FormatMacXml(xml));

            var reply = XmlUtils.DeserializeXml<GetTableValuesZippedReply>(response);

            if (reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("GetTableValuesZipped", xml, string.Empty);
            }

            return reply;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <returns></returns>
        public static GetTableVersionInfoReply GetTableVersionInfo(LookupServiceRequest lookupRequest)
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);

            var request = new LookupDataService.LookupDataServiceSoapClient("Lookup.DataServiceSoap");

            var xml = XmlUtils.SerializeXml<LookupServiceRequest>(lookupRequest);

            var response = request.GetTableVersionInfo(XmlUtils.FormatMacXml(xml));

            var reply = XmlUtils.DeserializeXml<GetTableVersionInfoReply>(response);

            if (reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("GetTableVersionInfo", xml, string.Empty);
            }

            return reply;
        }
    }
}