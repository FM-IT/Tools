using System.Xml.Serialization;
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.fm-it.dk/Dynamics/Mobile/2009/01/Tasklets/UpdatePick")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.fm-it.dk/Dynamics/Mobile/2009/01/Tasklets/UpdatePick", IsNullable=false)]
public partial class pick {
    
    private pickPickProperties pickPropertiesField;
    
    private pickPickHeaders pickHeadersField;
    
    /// <remarks/>
    public pickPickProperties pickProperties {
        get {
            return this.pickPropertiesField;
        }
        set {
            this.pickPropertiesField = value;
        }
    }
    
    /// <remarks/>
    public pickPickHeaders PickHeaders {
        get {
            return this.pickHeadersField;
        }
        set {
            this.pickHeadersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.fm-it.dk/Dynamics/Mobile/2009/01/Tasklets/UpdatePick")]
public partial class pickPickProperties {
    
    private decimal versionField;
    
    private string docPurposeField;
    
    private System.DateTime requestDateTimeField;
    
    /// <remarks/>
    public decimal version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    public string docPurpose {
        get {
            return this.docPurposeField;
        }
        set {
            this.docPurposeField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime requestDateTime {
        get {
            return this.requestDateTimeField;
        }
        set {
            this.requestDateTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.fm-it.dk/Dynamics/Mobile/2009/01/Tasklets/UpdatePick")]
public partial class pickPickHeaders {
    
    private pickPickHeadersPickHeaderProperties pickHeaderPropertiesField;
    
    private pickPickHeadersPickLine[] pickLinesField;
    
    /// <remarks/>
    public pickPickHeadersPickHeaderProperties PickHeaderProperties {
        get {
            return this.pickHeaderPropertiesField;
        }
        set {
            this.pickHeaderPropertiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("PickLine", IsNullable=false)]
    public pickPickHeadersPickLine[] PickLines {
        get {
            return this.pickLinesField;
        }
        set {
            this.pickLinesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.fm-it.dk/Dynamics/Mobile/2009/01/Tasklets/UpdatePick")]
public partial class pickPickHeadersPickHeaderProperties {
    
    private string activityTypeField;
    
    private string numberField;
    
    private string assignedUserIDField;
    
    private System.DateTime assignmentDateField;
    
    private System.DateTime assignmentTimeField;
    
    /// <remarks/>
    public string ActivityType {
        get {
            return this.activityTypeField;
        }
        set {
            this.activityTypeField = value;
        }
    }
    
    /// <remarks/>
    public string Number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
    
    /// <remarks/>
    public string AssignedUserID {
        get {
            return this.assignedUserIDField;
        }
        set {
            this.assignedUserIDField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime AssignmentDate {
        get {
            return this.assignmentDateField;
        }
        set {
            this.assignmentDateField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime AssignmentTime {
        get {
            return this.assignmentTimeField;
        }
        set {
            this.assignmentTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.fm-it.dk/Dynamics/Mobile/2009/01/Tasklets/UpdatePick")]
public partial class pickPickHeadersPickLine {
    
    private pickPickHeadersPickLinePickLineProperties pickLinePropertiesField;
    
    /// <remarks/>
    public pickPickHeadersPickLinePickLineProperties PickLineProperties {
        get {
            return this.pickLinePropertiesField;
        }
        set {
            this.pickLinePropertiesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.fm-it.dk/Dynamics/Mobile/2009/01/Tasklets/UpdatePick")]
public partial class pickPickHeadersPickLinePickLineProperties {
    
    private string activityTypeField;
    
    private decimal numberField;
    
    private string lineNumberField;
    
    private byte qtyToHandleField;
    
    private decimal dueDateField;
    
    /// <remarks/>
    public string ActivityType {
        get {
            return this.activityTypeField;
        }
        set {
            this.activityTypeField = value;
        }
    }
    
    /// <remarks/>
    public decimal Number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
    
    /// <remarks/>
    public string LineNumber {
        get {
            return this.lineNumberField;
        }
        set {
            this.lineNumberField = value;
        }
    }
    
    /// <remarks/>
    public byte QtyToHandle {
        get {
            return this.qtyToHandleField;
        }
        set {
            this.qtyToHandleField = value;
        }
    }
    
    /// <remarks/>
    public decimal DueDate {
        get {
            return this.dueDateField;
        }
        set {
            this.dueDateField = value;
        }
    }
}
