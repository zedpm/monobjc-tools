﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :2.0.50727.3615
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace Monobjc.Tools.Doxygenator.Model.Doxygen {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("doxygenindex", Namespace="", IsNullable=false)]
    public partial class DoxygenIndexType {
        
        private CompoundType[] compoundField;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("compound", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CompoundType[] compound {
            get {
                return this.compoundField;
            }
            set {
                this.compoundField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CompoundType {
        
        private string nameField;
        
        private MemberType[] memberField;
        
        private string refidField;
        
        private CompoundKind kindField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MemberType[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string refid {
            get {
                return this.refidField;
            }
            set {
                this.refidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CompoundKind kind {
            get {
                return this.kindField;
            }
            set {
                this.kindField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MemberType {
        
        private string nameField;
        
        private string refidField;
        
        private MemberKind kindField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string refid {
            get {
                return this.refidField;
            }
            set {
                this.refidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MemberKind kind {
            get {
                return this.kindField;
            }
            set {
                this.kindField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    public enum MemberKind {
        
        /// <remarks/>
        define,
        
        /// <remarks/>
        property,
        
        /// <remarks/>
        @event,
        
        /// <remarks/>
        variable,
        
        /// <remarks/>
        typedef,
        
        /// <remarks/>
        @enum,
        
        /// <remarks/>
        enumvalue,
        
        /// <remarks/>
        function,
        
        /// <remarks/>
        signal,
        
        /// <remarks/>
        prototype,
        
        /// <remarks/>
        friend,
        
        /// <remarks/>
        dcop,
        
        /// <remarks/>
        slot,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    public enum CompoundKind {
        
        /// <remarks/>
        @class,
        
        /// <remarks/>
        @struct,
        
        /// <remarks/>
        union,
        
        /// <remarks/>
        @interface,
        
        /// <remarks/>
        protocol,
        
        /// <remarks/>
        category,
        
        /// <remarks/>
        exception,
        
        /// <remarks/>
        file,
        
        /// <remarks/>
        @namespace,
        
        /// <remarks/>
        group,
        
        /// <remarks/>
        page,
        
        /// <remarks/>
        example,
        
        /// <remarks/>
        dir,
    }
}
