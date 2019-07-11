using MortageDataSwitch.Facades.Utils;
using MortageDataSwitch.Models;
using MortageDataSwitch.Services;
using MortageDataSwitch.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace MortageDataSwitch.Facades
{
    /// <summary>
    /// 
    /// </summary>
    public static class SubmitApplicationFacade
    {
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationRequest"></param>
        /// <returns></returns>
        public static SubmitServiceReply SubmitApplication(SubmitApplicationRequest applicationRequest)
        {
            string xml = "";
            if (applicationRequest.GetType() == typeof(SubmitAbsaApplicationRequest))
            {
                xml = XmlUtils.SerializeXml<SubmitAbsaApplicationRequest>((SubmitAbsaApplicationRequest)applicationRequest);
            }
            if (applicationRequest.GetType() == typeof(SubmitFnbApplicationRequest))
            {
                xml = XmlUtils.SerializeXml<SubmitFnbApplicationRequest>((SubmitFnbApplicationRequest)applicationRequest);
            }
            if (applicationRequest.GetType() == typeof(SubmitNedApplicationRequest))
            {
                xml = XmlUtils.SerializeXml<SubmitNedApplicationRequest>((SubmitNedApplicationRequest)applicationRequest);
            }
            if (applicationRequest.GetType() == typeof(SubmitSbsaApplicationRequest))
            {
                xml = XmlUtils.SerializeXml<SubmitSbsaApplicationRequest>((SubmitSbsaApplicationRequest)applicationRequest);
            }

            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);

            var submitService = new SubmitService.SubmitServiceSoapClient();

            xml = XmlUtils.FormatMacXml(xml);

            string response = submitService.SubmitApplication(xml);

            var reply = XmlUtils.DeserializeXml<SubmitServiceReply>(response);

            if (reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("SubmitApplication", xml, string.Empty);
            }

            reply.StatusMessage = TimeUtils.GetRSATime().ToString("yyyy-MM-ddTHH:mm:ss");

            return reply;
        }

       

        


        
    }
}