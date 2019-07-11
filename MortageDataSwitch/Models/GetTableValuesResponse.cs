
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute("GetTableValues.Reply", Namespace = "", IsNullable = false)]
public class GetTableValuesReply
{

    private GetTableValuesReplyServiceHeader serviceHeaderField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
    public GetTableValuesReplyServiceHeader ServiceHeader
    {
        get
        {
            return this.serviceHeaderField;
        }
        set
        {
            this.serviceHeaderField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public class GetTableValuesReplyServiceHeader
{

    private System.DateTime replyDateTimeField;

    private int serviceResultField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Reply.DateTime")]
    public System.DateTime ReplyDateTime
    {
        get
        {
            return this.replyDateTimeField;
        }
        set
        {
            this.replyDateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Service.Result")]
    public int ServiceResult
    {
        get
        {
            return this.serviceResultField;
        }
        set
        {
            this.serviceResultField = value;
        }
    }
}

