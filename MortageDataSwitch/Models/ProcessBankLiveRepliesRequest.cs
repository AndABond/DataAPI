using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("ProcessBankLiveReplies.Request", Namespace = "", IsNullable = false)]
    public partial class ProcessBankLiveRepliesRequest
    {

        private ProcessBankLiveRepliesRequestLiveReplies liveRepliesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public RequestServiceHeader ServiceHeader { get; set; }

        /// <remarks/>
        public ProcessBankLiveRepliesRequestLiveReplies LiveReplies
        {
            get
            {
                return this.liveRepliesField;
            }
            set
            {
                this.liveRepliesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProcessBankLiveRepliesRequestLiveReplies
    {

        private ProcessBankLiveRepliesRequestLiveRepliesLiveReply liveReplyField;

        /// <remarks/>
        public ProcessBankLiveRepliesRequestLiveRepliesLiveReply LiveReply
        {
            get
            {
                return this.liveReplyField;
            }
            set
            {
                this.liveReplyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProcessBankLiveRepliesRequestLiveRepliesLiveReply
    {

        private uint bankReferenceField;

        private uint comcorpReferenceField;

        private byte eventIdField;

        private string eventDateField;

        private string eventCommentField;

        private uint bondAccountNoField;

        private decimal offeredAmountField;

        private uint requestedAmountField;

        private byte registeredAmountField;

        private string attorneyContactField;

        private object attorneyContactNoField;

        /// <remarks/>
        public uint BankReference
        {
            get
            {
                return this.bankReferenceField;
            }
            set
            {
                this.bankReferenceField = value;
            }
        }

        /// <remarks/>
        public uint ComcorpReference
        {
            get
            {
                return this.comcorpReferenceField;
            }
            set
            {
                this.comcorpReferenceField = value;
            }
        }

        /// <remarks/>
        public byte EventId
        {
            get
            {
                return this.eventIdField;
            }
            set
            {
                this.eventIdField = value;
            }
        }

        /// <remarks/>
        public string EventDate
        {
            get
            {
                return this.eventDateField;
            }
            set
            {
                this.eventDateField = value;
            }
        }

        /// <remarks/>
        public string EventComment
        {
            get
            {
                return this.eventCommentField;
            }
            set
            {
                this.eventCommentField = value;
            }
        }

        /// <remarks/>
        public uint BondAccountNo
        {
            get
            {
                return this.bondAccountNoField;
            }
            set
            {
                this.bondAccountNoField = value;
            }
        }

        /// <remarks/>
        public decimal OfferedAmount
        {
            get
            {
                return this.offeredAmountField;
            }
            set
            {
                this.offeredAmountField = value;
            }
        }

        /// <remarks/>
        public uint RequestedAmount
        {
            get
            {
                return this.requestedAmountField;
            }
            set
            {
                this.requestedAmountField = value;
            }
        }

        /// <remarks/>
        public byte RegisteredAmount
        {
            get
            {
                return this.registeredAmountField;
            }
            set
            {
                this.registeredAmountField = value;
            }
        }

        /// <remarks/>
        public string AttorneyContact
        {
            get
            {
                return this.attorneyContactField;
            }
            set
            {
                this.attorneyContactField = value;
            }
        }

        /// <remarks/>
        public object AttorneyContactNo
        {
            get
            {
                return this.attorneyContactNoField;
            }
            set
            {
                this.attorneyContactNoField = value;
            }
        }
    }


}