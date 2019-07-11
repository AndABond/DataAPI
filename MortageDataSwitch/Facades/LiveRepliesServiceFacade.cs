using MortageDataSwitch.Facades.Utils;
using MortageDataSwitch.Models;
using MortageDataSwitch.Services;
using MortageDataSwitch.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;

namespace MortageDataSwitch.Facades
{
    /// <summary>
    /// 
    /// </summary>
    public static class LiveRepliesServiceFacade
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="liveRepliesRequest"></param>
        /// <returns></returns>
        //public static GetLiveRepliesAppRefReply GetLiveRepliesByAppRef(GetLiveRepliesByAppRefRequest liveRepliesRequest)
        //{
        //    var request = new LiveRepliesService.LiveRepliesServiceSoapClient("Live.RepliesServiceSoap");

        //    var xml = XmlUtils.SerializeXml<GetLiveRepliesByAppRefRequest>(liveRepliesRequest);

        //    var response = request.GetLiveRepliesByAppRef(xml);

        //    var reply = XmlUtils.DeserializeXml<GetLiveRepliesAppRefReply>(response);

        //    if (reply.ServiceHeader.ServiceResult == 2)
        //    {
        //        EmailProvider.SendEmail("GetLiveRepliesByAppRefRequest", xml, string.Empty);
        //    }

        //    return reply;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationRequest"></param>
        /// <returns></returns>
        public static GetLiveRepliesByDateRangeReply GetLiveRepliesByDateRange(GetLiveRepliesByDateRangeRequest applicationRequest)
        {
            var xml = XmlUtils.SerializeXml<GetLiveRepliesByDateRangeRequest>(applicationRequest);
            
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(RsaUtils.ValidateRemoteCertificate);
            
            var request = new LiveRepliesService.LiveRepliesServiceSoapClient("Live.RepliesServiceSoap");

            xml = XmlUtils.FormatMacXml(xml);

            var response = request.GetLiveRepliesByDateRange(xml);

            var reply = XmlUtils.DeserializeXml<GetLiveRepliesByDateRangeReply>(response);

            if (reply.ServiceHeader.ServiceResult == 2)
            {
                EmailProvider.SendEmail("GetLiveRepliesByDateRange", xml, string.Empty);
            }

            return reply;
        }
    }
}