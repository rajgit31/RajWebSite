﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace urn.items {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Linq;
    using Xml.Schema.Linq;
    
    
    /// <summary>
    /// <para>
    /// Regular expression: (item*)
    /// </para>
    /// </summary>
    public partial class ItemsForm : XTypedElement, IXMetaData {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedList<ItemForm> itemField;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator ItemsForm(XElement xe) { return XTypedServices.ToXTypedElement<ItemsForm>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static ItemsForm() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("item", "")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (item*)
        /// </para>
        /// </summary>
        public ItemsForm() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (item*)
        /// </para>
        /// </summary>
        public IList<ItemForm> item {
            get {
                if ((this.itemField == null)) {
                    this.itemField = new XTypedList<ItemForm>(this, LinqToXsdTypeManager.Instance, XName.Get("item", ""));
                }
                return this.itemField;
            }
            set {
                if ((value == null)) {
                    this.itemField = null;
                }
                else {
                    if ((this.itemField == null)) {
                        this.itemField = XTypedList<ItemForm>.Initialize(this, LinqToXsdTypeManager.Instance, value, XName.Get("item", ""));
                    }
                    else {
                        XTypedServices.SetList<ItemForm>(this.itemField, value);
                    }
                }
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("ItemsForm", "urn:items");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<ItemsForm>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("item", ""), typeof(ItemForm));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
    }
    
    /// <summary>
    /// <para>
    /// Regular expression: (title, description, url, date, type)
    /// </para>
    /// </summary>
    public partial class ItemForm : XTypedElement, IXMetaData {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static Dictionary<XName, System.Type> localElementDictionary = new Dictionary<XName, System.Type>();
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ContentModelEntity contentModel;
        
         public static explicit operator ItemForm(XElement xe) { return XTypedServices.ToXTypedElement<ItemForm>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        static ItemForm() {
            BuildElementDictionary();
            contentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("title", "")), new NamedContentModelEntity(XName.Get("description", "")), new NamedContentModelEntity(XName.Get("url", "")), new NamedContentModelEntity(XName.Get("date", "")), new NamedContentModelEntity(XName.Get("type", "")));
        }
        
        /// <summary>
        /// <para>
        /// Regular expression: (title, description, url, date, type)
        /// </para>
        /// </summary>
        public ItemForm() {
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (title, description, url, date, type)
        /// </para>
        /// </summary>
        public string title {
            get {
                XElement x = this.GetElement(XName.Get("title", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetElement(XName.Get("title", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (title, description, url, date, type)
        /// </para>
        /// </summary>
        public string description {
            get {
                XElement x = this.GetElement(XName.Get("description", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetElement(XName.Get("description", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (title, description, url, date, type)
        /// </para>
        /// </summary>
        public string url {
            get {
                XElement x = this.GetElement(XName.Get("url", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetElement(XName.Get("url", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (title, description, url, date, type)
        /// </para>
        /// </summary>
        public System.DateTime date {
            get {
                XElement x = this.GetElement(XName.Get("date", ""));
                return XTypedServices.ParseValue<System.DateTime>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Date).Datatype);
            }
            set {
                this.SetElement(XName.Get("date", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Date).Datatype);
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: required
        /// </para>
        /// <para>
        /// Regular expression: (title, description, url, date, type)
        /// </para>
        /// </summary>
        public string type {
            get {
                XElement x = this.GetElement(XName.Get("type", ""));
                return XTypedServices.ParseValue<string>(x, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
            set {
                this.SetElement(XName.Get("type", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                return localElementDictionary;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("ItemForm", "urn:items");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Fragment;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public override XTypedElement Clone() {
            return XTypedServices.CloneXTypedElement<ItemForm>(this);
        }
        
        private static void BuildElementDictionary() {
            localElementDictionary.Add(XName.Get("title", ""), typeof(string));
            localElementDictionary.Add(XName.Get("description", ""), typeof(string));
            localElementDictionary.Add(XName.Get("url", ""), typeof(string));
            localElementDictionary.Add(XName.Get("date", ""), typeof(System.DateTime));
            localElementDictionary.Add(XName.Get("type", ""), typeof(string));
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return contentModel;
        }
    }
    
    public partial class items : XTypedElement, IXMetaData {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ItemsForm ContentField;
        
         public static explicit operator items(XElement xe) { return XTypedServices.ToXTypedElement<items, ItemsForm>(xe,LinqToXsdTypeManager.Instance as ILinqToXsdTypeManager); }
        
        public items() {
            SetInnerType(new ItemsForm());
        }
        
        public items(ItemsForm content) {
            SetInnerType(content);
        }
        
        public override XElement Untyped {
            get {
                return base.Untyped;
            }
            set {
                base.Untyped = value;
                this.ContentField.Untyped = value;
            }
        }
        
        public ItemsForm Content {
            get {
                return ContentField;
            }
        }
        
        /// <summary>
        /// <para>
        /// Occurrence: optional, repeating
        /// </para>
        /// <para>
        /// Regular expression: (item*)
        /// </para>
        /// </summary>
        public IList<ItemForm> item {
            get {
                return this.ContentField.item;
            }
            set {
                this.ContentField.item = value;
            }
        }
        
        Dictionary<XName, System.Type> IXMetaData.LocalElementsDictionary {
            get {
                IXMetaData schemaMetaData = ((IXMetaData)(this.Content));
                return schemaMetaData.LocalElementsDictionary;
            }
        }
        
        XTypedElement IXMetaData.Content {
            get {
                return this.Content;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        XName IXMetaData.SchemaName {
            get {
                return XName.Get("items", "urn:items");
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        SchemaOrigin IXMetaData.TypeOrigin {
            get {
                return SchemaOrigin.Element;
            }
        }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILinqToXsdTypeManager IXMetaData.TypeManager {
            get {
                return LinqToXsdTypeManager.Instance;
            }
        }
        
        public void Save(string xmlFile) {
            XTypedServices.Save(xmlFile, Untyped);
        }
        
        public void Save(System.IO.TextWriter tw) {
            XTypedServices.Save(tw, Untyped);
        }
        
        public void Save(System.Xml.XmlWriter xmlWriter) {
            XTypedServices.Save(xmlWriter, Untyped);
        }
        
        public static items Load(string xmlFile) {
            return XTypedServices.Load<items, ItemsForm>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static items Load(System.IO.TextReader xmlFile) {
            return XTypedServices.Load<items, ItemsForm>(xmlFile, LinqToXsdTypeManager.Instance);
        }
        
        public static items Parse(string xml) {
            return XTypedServices.Parse<items, ItemsForm>(xml, LinqToXsdTypeManager.Instance);
        }
        
        public override XTypedElement Clone() {
            return new items(((ItemsForm)(this.Content.Clone())));
        }
        
        private void SetInnerType(ItemsForm ContentField) {
            this.ContentField = ((ItemsForm)(XTypedServices.GetCloneIfRooted(ContentField)));
            XTypedServices.SetName(this, this.ContentField);
        }
        
        ContentModelEntity IXMetaData.GetContentModel() {
            return ContentModelEntity.Default;
        }
    }
    
    public class LinqToXsdTypeManager : ILinqToXsdTypeManager {
        
        static Dictionary<XName, System.Type> typeDictionary = new Dictionary<XName, System.Type>();
        
        static Dictionary<XName, System.Type> elementDictionary = new Dictionary<XName, System.Type>();
        
        static Dictionary<System.Type, System.Type> wrapperDictionary = new Dictionary<System.Type, System.Type>();
        
        private static XmlSchemaSet schemaSet;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        static LinqToXsdTypeManager typeManagerSingleton = new LinqToXsdTypeManager();
        
        static LinqToXsdTypeManager() {
            BuildTypeDictionary();
            BuildElementDictionary();
            BuildWrapperDictionary();
        }
        
        XmlSchemaSet ILinqToXsdTypeManager.Schemas {
            get {
                if ((schemaSet == null)) {
                    XmlSchemaSet tempSet = new XmlSchemaSet();
                    System.Threading.Interlocked.CompareExchange(ref schemaSet, tempSet, null);
                }
                return schemaSet;
            }
            set {
                schemaSet = value;
            }
        }
        
        Dictionary<XName, System.Type> ILinqToXsdTypeManager.GlobalTypeDictionary {
            get {
                return typeDictionary;
            }
        }
        
        Dictionary<XName, System.Type> ILinqToXsdTypeManager.GlobalElementDictionary {
            get {
                return elementDictionary;
            }
        }
        
        Dictionary<System.Type, System.Type> ILinqToXsdTypeManager.RootContentTypeMapping {
            get {
                return wrapperDictionary;
            }
        }
        
        public static LinqToXsdTypeManager Instance {
            get {
                return typeManagerSingleton;
            }
        }
        
        private static void BuildTypeDictionary() {
            typeDictionary.Add(XName.Get("ItemsForm", "urn:items"), typeof(global::urn.items.ItemsForm));
            typeDictionary.Add(XName.Get("ItemForm", "urn:items"), typeof(global::urn.items.ItemForm));
        }
        
        private static void BuildElementDictionary() {
            elementDictionary.Add(XName.Get("items", "urn:items"), typeof(global::urn.items.items));
        }
        
        private static void BuildWrapperDictionary() {
            wrapperDictionary.Add(typeof(urn.items.items), typeof(global::urn.items.ItemsForm));
        }
        
        protected internal static void AddSchemas(XmlSchemaSet schemas) {
            schemas.Add(schemaSet);
        }
        
        public static System.Type GetRootType() {
            return elementDictionary[XName.Get("items", "urn:items")];
        }
    }
    
    public partial class XRootNamespace {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XDocument doc;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedElement rootObject;
        

    public items items {  get {return rootObject as items; } }
        
        private XRootNamespace() {
        }
        
        public XRootNamespace(items root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XDocument XDocument {
            get {
                return doc;
            }
        }
        
        public static XRootNamespace Load(string xmlFile) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlFile);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(string xmlFile, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlFile, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(TextReader textReader) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(textReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(TextReader textReader, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(textReader, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Load(XmlReader xmlReader) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Load(xmlReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Parse(string text) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Parse(text);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRootNamespace Parse(string text, LoadOptions options) {
            XRootNamespace root = new XRootNamespace();
            root.doc = XDocument.Parse(text, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public virtual void Save(string fileName) {
            doc.Save(fileName);
        }
        
        public virtual void Save(TextWriter textWriter) {
            doc.Save(textWriter);
        }
        
        public virtual void Save(XmlWriter writer) {
            doc.Save(writer);
        }
        
        public virtual void Save(TextWriter textWriter, SaveOptions options) {
            doc.Save(textWriter, options);
        }
        
        public virtual void Save(string fileName, SaveOptions options) {
            doc.Save(fileName, options);
        }
    }
    
    public partial class XRoot {
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XDocument doc;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XTypedElement rootObject;
        

    public global::urn.items.items items {  get {return rootObject as global::urn.items.items; } }
        
        private XRoot() {
        }
        
        public XRoot(global::urn.items.items root) {
            this.doc = new XDocument(root.Untyped);
            this.rootObject = root;
        }
        
        public XDocument XDocument {
            get {
                return doc;
            }
        }
        
        public static XRoot Load(string xmlFile) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(xmlFile);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Load(string xmlFile, LoadOptions options) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(xmlFile, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Load(TextReader textReader) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(textReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Load(TextReader textReader, LoadOptions options) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(textReader, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Load(XmlReader xmlReader) {
            XRoot root = new XRoot();
            root.doc = XDocument.Load(xmlReader);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Parse(string text) {
            XRoot root = new XRoot();
            root.doc = XDocument.Parse(text);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public static XRoot Parse(string text, LoadOptions options) {
            XRoot root = new XRoot();
            root.doc = XDocument.Parse(text, options);
            XTypedElement typedRoot = XTypedServices.ToXTypedElement(root.doc.Root, LinqToXsdTypeManager.Instance);
            if ((typedRoot == null)) {
                throw new LinqToXsdException("Invalid root element in xml document.");
            }
            root.rootObject = typedRoot;
            return root;
        }
        
        public virtual void Save(string fileName) {
            doc.Save(fileName);
        }
        
        public virtual void Save(TextWriter textWriter) {
            doc.Save(textWriter);
        }
        
        public virtual void Save(XmlWriter writer) {
            doc.Save(writer);
        }
        
        public virtual void Save(TextWriter textWriter, SaveOptions options) {
            doc.Save(textWriter, options);
        }
        
        public virtual void Save(string fileName, SaveOptions options) {
            doc.Save(fileName, options);
        }
    }
}
