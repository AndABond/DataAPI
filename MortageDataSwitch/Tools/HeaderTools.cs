using MortageDataSwitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MortageDataSwitch.Tools
{
    /// <summary>
    /// Get default headers for request
    /// </summary>
    public static class HeaderTools
    {
        /// <summary>
        /// Get default header and populate required fields
        /// </summary>
        /// <param name="applicationReference"></param>
        /// <param name="applicationType"></param>
        /// <param name="applicationAction"></param>
        /// <param name="applicationGroupId"></param>
        /// <returns></returns>
        public static RequestServiceHeader GetHeader(string applicationReference = "", string applicationType = "", string applicationAction = "", string applicationGroupId = "")
        {
            var header = new RequestServiceHeader()
            {
                ChannelCode = WebConfigurationManager.AppSettings["ChannelCode"],
                ChannelPassword = WebConfigurationManager.AppSettings["ChannelPassword"],
                ChannelUsername = WebConfigurationManager.AppSettings["ChannelUsername"],
                OriginatorBranchId = WebConfigurationManager.AppSettings["OriginatorBranchId"],
                OriginatorId = WebConfigurationManager.AppSettings["OriginatorId"],
                OriginatorReference = Utils.GenerateOriginatorReference(),
                ServiceKey = new ServiceHeaderServiceKey()
                {
                    RSAKeyValue = new ServiceKeyRSAKeyValue()
                    {
                        Modulus = WebConfigurationManager.AppSettings["Modulus"],
                        Exponent = WebConfigurationManager.AppSettings["Exponent"],
                    },
                },
                RequestDateTime = TimeUtils.GetRSATime().ToString(),
                ApplicationMac = "",
                ApplicationReference = applicationReference,
                ServiceVersion = "30",
                ApplicationApplicationType = applicationType,
                ApplicationAction = applicationAction,
                ApplicationGroupId = applicationGroupId
            };

            return header;
        }
    }
}