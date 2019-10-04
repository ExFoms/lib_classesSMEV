using System;
using System.Xml.Serialization;
using System.ServiceModel;
public class VS00643v002_MZRV01
/* Сведения для приема событий электронного заявления о выборе (замене) СМО на КУТФОМС  
 * VS00643v002_MZRV01
 * Версия 1.0.1
 */
{
    public string vs_name = "Сведения для приема событий электронного заявления о выборе (замене) СМО на КУТФОМС";
    public string vs_mnemo = "VS00643v002_MZRV01";
    public string vs_version = "1.0.1";
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egisz.rosminzdrav.ru/ExecutionMedicalInsurancePolicy/order/event/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("OrderStatusEventRequest", Namespace = "http://egisz.rosminzdrav.ru/ExecutionMedicalInsurancePolicy/order/event/1.0.1", IsNullable = false)]
    public partial class OrderStatusEventRequestType
    {

        private string orderIdField;

        private statusType statusCodeField;

        private string eventCommentField;

        /// <remarks/>
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }

        /// <remarks/>
        public statusType statusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        public string eventComment
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egisz.rosminzdrav.ru/ExecutionMedicalInsurancePolicy/order/event/1.0.1")]
    public enum statusType
    {

        /// <remarks/>
        Принято,

        /// <remarks/>
        Отказ,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egisz.rosminzdrav.ru/ExecutionMedicalInsurancePolicy/order/event/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("OrderStatusEventResponse", Namespace = "http://egisz.rosminzdrav.ru/ExecutionMedicalInsurancePolicy/order/event/1.0.1", IsNullable = false)]
    public partial class Void
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("IdentityDocument", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class AnyIdentityDocumentType
    {

        private object itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BirthCertificate", typeof(SovietPassportType))]
        [System.Xml.Serialization.XmlElementAttribute("DrivingLicenseRF", typeof(DrivingLicenseRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("Form9Certificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("InternationalPassportRF", typeof(InternationalPassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("MilitaryPassport", typeof(MilitaryPassportDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportLossCertificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ReleaseCertificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("SailorPassport", typeof(MilitaryPassportDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("SovietPassport", typeof(SovietPassportType))]
        [System.Xml.Serialization.XmlElementAttribute("TemporaryIdentityCardRF", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("SovietPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class SovietPassportType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("DrivingLicenseRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class DrivingLicenseRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("ForeignPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class NotRestrictedDocumentType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("ResidencePermitRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class InternationalPassportRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("MilitaryPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class MilitaryPassportDocumentType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("PassportRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class PassportRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        BirthCertificate,

        /// <remarks/>
        DrivingLicenseRF,

        /// <remarks/>
        ForeignPassport,

        /// <remarks/>
        Form9Certificate,

        /// <remarks/>
        InternationalPassportRF,

        /// <remarks/>
        MilitaryPassport,

        /// <remarks/>
        PassportLossCertificate,

        /// <remarks/>
        PassportRF,

        /// <remarks/>
        ReleaseCertificate,

        /// <remarks/>
        ResidencePermitRF,

        /// <remarks/>
        SailorPassport,

        /// <remarks/>
        SovietPassport,

        /// <remarks/>
        TemporaryIdentityCardRF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("PrimaryIdentityDocument", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class PrimaryIdentityDocumentType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("AttachmentRef", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class AttachmentRefType
    {

        private string attachmentIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attachmentId
        {
            get
            {
                return this.attachmentIdField;
            }
            set
            {
                this.attachmentIdField = value;
            }
        }
    }
}

public class VS01112v001_TABL00
/* Прием заявления о выборе СМО в ТФОМС  
 * VS01112v001_TABL00
 * Версия 1.0.0
 */
{
    public string vs_name = "Прием заявления о выборе СМО в ТФОМС";
    public string vs_mnemo = "VS01112v001_TABL00";
    public string vs_version = "1.0.0";

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("InputData", Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0", IsNullable = false)]
    public partial class InputDataType
    {

        private ExecutionMedicalInsurancePolicyRequestType executionMedicalInsurancePolicyRequestField;

        /// <remarks/>
        public ExecutionMedicalInsurancePolicyRequestType ExecutionMedicalInsurancePolicyRequest
        {
            get
            {
                return this.executionMedicalInsurancePolicyRequestField;
            }
            set
            {
                this.executionMedicalInsurancePolicyRequestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public partial class ExecutionMedicalInsurancePolicyRequestType
    {

        private string orderIdField;

        private string regionCodeField;

        private string code_smopField;

        private string issuingPointAddressField;

        private _AttachmentsBlockType attachmentsBlockField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }

        /// <remarks/>
        public string RegionCode
        {
            get
            {
                return this.regionCodeField;
            }
            set
            {
                this.regionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Code_smop
        {
            get
            {
                return this.code_smopField;
            }
            set
            {
                this.code_smopField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string IssuingPointAddress
        {
            get
            {
                return this.issuingPointAddressField;
            }
            set
            {
                this.issuingPointAddressField = value;
            }
        }

        /// <remarks/>
        public _AttachmentsBlockType AttachmentsBlock
        {
            get
            {
                return this.attachmentsBlockField;
            }
            set
            {
                this.attachmentsBlockField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public partial class _AttachmentsBlockType
    {

        private _AttachmentDescriptionType attachmentDescriptionField;

        /// <remarks/>
        public _AttachmentDescriptionType AttachmentDescription
        {
            get
            {
                return this.attachmentDescriptionField;
            }
            set
            {
                this.attachmentDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public partial class _AttachmentDescriptionType
    {

        private object itemField;

        private _StructuredAttachmentFormatType1 attachmentFormat1Field;

        private string attachmentSignatureFSLinkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentFSLink", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("IsMTOMAttachmentContent", typeof(bool))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public _StructuredAttachmentFormatType1 AttachmentFormat1
        {
            get
            {
                return this.attachmentFormat1Field;
            }
            set
            {
                this.attachmentFormat1Field = value;
            }
        }

        /// <remarks/>
        public string AttachmentSignatureFSLink
        {
            get
            {
                return this.attachmentSignatureFSLinkField;
            }
            set
            {
                this.attachmentSignatureFSLinkField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public partial class _StructuredAttachmentFormatType1
    {

        private bool isUnstructuredFormatField;

        private bool isZippedPacketField;

        private ApplicationFormDataType applicationFormDataField;

        /// <remarks/>
        public bool IsUnstructuredFormat
        {
            get
            {
                return this.isUnstructuredFormatField;
            }
            set
            {
                this.isUnstructuredFormatField = value;
            }
        }

        /// <remarks/>
        public bool IsZippedPacket
        {
            get
            {
                return this.isZippedPacketField;
            }
            set
            {
                this.isZippedPacketField = value;
            }
        }

        /// <remarks/>
        public ApplicationFormDataType ApplicationFormData
        {
            get
            {
                return this.applicationFormDataField;
            }
            set
            {
                this.applicationFormDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public partial class ApplicationFormDataType
    {

        private string insuranceRegionCodeField;

        private PolicyCarrierType policyCarrierTypeCodeField;

        private string familyNameField;

        private string firstNameField;

        private string patronymicField;

        private System.DateTime birthDateField;

        private string birthPlaceField;

        private string sNILSField;

        private GenderType genderField;

        private PassportRFType passportRFField;

        private string phoneNumberRFTypeField;

        private string nam_smokField;

        private AddressInfoType regResidentialAddressField;

        private System.DateTime regDateField;

        private bool isStayAddressTheSameField;

        private AddressInfoType stayAddressField;

        private System.DateTime applicationDateField;

        private string emailField;

        private CitizenshipType citizenshipField;

        private IdentityDocumentType identityDocumentField;

        /// <remarks/>
        public string InsuranceRegionCode
        {
            get
            {
                return this.insuranceRegionCodeField;
            }
            set
            {
                this.insuranceRegionCodeField = value;
            }
        }

        /// <remarks/>
        public PolicyCarrierType PolicyCarrierTypeCode
        {
            get
            {
                return this.policyCarrierTypeCodeField;
            }
            set
            {
                this.policyCarrierTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
        public string FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
        public string Patronymic
        {
            get
            {
                return this.patronymicField;
            }
            set
            {
                this.patronymicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", DataType = "date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
        public string BirthPlace
        {
            get
            {
                return this.birthPlaceField;
            }
            set
            {
                this.birthPlaceField = value;
            }
        }

        /// <remarks/>
        public string SNILS
        {
            get
            {
                return this.sNILSField;
            }
            set
            {
                this.sNILSField = value;
            }
        }

        /// <remarks/>
        public GenderType Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public PassportRFType PassportRF
        {
            get
            {
                return this.passportRFField;
            }
            set
            {
                this.passportRFField = value;
            }
        }

        /// <remarks/>
        public string PhoneNumberRFType
        {
            get
            {
                return this.phoneNumberRFTypeField;
            }
            set
            {
                this.phoneNumberRFTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Nam_smok
        {
            get
            {
                return this.nam_smokField;
            }
            set
            {
                this.nam_smokField = value;
            }
        }

        /// <remarks/>
        public AddressInfoType RegResidentialAddress
        {
            get
            {
                return this.regResidentialAddressField;
            }
            set
            {
                this.regResidentialAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime RegDate
        {
            get
            {
                return this.regDateField;
            }
            set
            {
                this.regDateField = value;
            }
        }

        /// <remarks/>
        public bool IsStayAddressTheSame
        {
            get
            {
                return this.isStayAddressTheSameField;
            }
            set
            {
                this.isStayAddressTheSameField = value;
            }
        }

        /// <remarks/>
        public AddressInfoType StayAddress
        {
            get
            {
                return this.stayAddressField;
            }
            set
            {
                this.stayAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ApplicationDate
        {
            get
            {
                return this.applicationDateField;
            }
            set
            {
                this.applicationDateField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public CitizenshipType Citizenship
        {
            get
            {
                return this.citizenshipField;
            }
            set
            {
                this.citizenshipField = value;
            }
        }

        /// <remarks/>
        public IdentityDocumentType IdentityDocument
        {
            get
            {
                return this.identityDocumentField;
            }
            set
            {
                this.identityDocumentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public enum PolicyCarrierType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public enum GenderType
    {

        /// <remarks/>
        Мужской,

        /// <remarks/>
        Женский,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public partial class PassportRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerCodeField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string IssuerCode
        {
            get
            {
                return this.issuerCodeField;
            }
            set
            {
                this.issuerCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public partial class AddressInfoType
    {

        private string fullAddressTextField;

        private string regionCodeField;

        private string regionNameField;

        private string areaField;

        private string cityField;

        private string intracityAreaField;

        private string localityField;

        private string streetField;

        private string addTerritoryField;

        private string addTerritoryStreetField;

        private string houseField;

        private string buildingField;

        private string houseStructureField;

        private string flatField;

        private string postalIndexField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FullAddressText
        {
            get
            {
                return this.fullAddressTextField;
            }
            set
            {
                this.fullAddressTextField = value;
            }
        }

        /// <remarks/>
        public string RegionCode
        {
            get
            {
                return this.regionCodeField;
            }
            set
            {
                this.regionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string RegionName
        {
            get
            {
                return this.regionNameField;
            }
            set
            {
                this.regionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string IntracityArea
        {
            get
            {
                return this.intracityAreaField;
            }
            set
            {
                this.intracityAreaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Locality
        {
            get
            {
                return this.localityField;
            }
            set
            {
                this.localityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string AddTerritory
        {
            get
            {
                return this.addTerritoryField;
            }
            set
            {
                this.addTerritoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string AddTerritoryStreet
        {
            get
            {
                return this.addTerritoryStreetField;
            }
            set
            {
                this.addTerritoryStreetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string House
        {
            get
            {
                return this.houseField;
            }
            set
            {
                this.houseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Building
        {
            get
            {
                return this.buildingField;
            }
            set
            {
                this.buildingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string HouseStructure
        {
            get
            {
                return this.houseStructureField;
            }
            set
            {
                this.houseStructureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Flat
        {
            get
            {
                return this.flatField;
            }
            set
            {
                this.flatField = value;
            }
        }

        /// <remarks/>
        public string PostalIndex
        {
            get
            {
                return this.postalIndexField;
            }
            set
            {
                this.postalIndexField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public enum CitizenshipType
    {

        /// <remarks/>
        Россия,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public enum IdentityDocumentType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Паспорт гражданина Российской Федерации")]
        ПаспортгражданинаРоссийскойФедерации,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("OutputData", Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0", IsNullable = false)]
    public partial class OutputDataType
    {

        private statusType statusCodeField;

        private string commentField;

        /// <remarks/>
        public statusType statusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ffoms.ru/ExecutionMedicalInsurancePolicy/1.0.0")]
    public enum statusType
    {

        /// <remarks/>
        Исполнено,

        /// <remarks/>
        Отказ,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("IdentityDocument", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class AnyIdentityDocumentType
    {

        private object itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BirthCertificate", typeof(SovietPassportType))]
        [System.Xml.Serialization.XmlElementAttribute("DrivingLicenseRF", typeof(DrivingLicenseRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("Form9Certificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("InternationalPassportRF", typeof(InternationalPassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("MilitaryPassport", typeof(MilitaryPassportDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportLossCertificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType1))]
        [System.Xml.Serialization.XmlElementAttribute("ReleaseCertificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("SailorPassport", typeof(MilitaryPassportDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("SovietPassport", typeof(SovietPassportType))]
        [System.Xml.Serialization.XmlElementAttribute("TemporaryIdentityCardRF", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("SovietPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class SovietPassportType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("DrivingLicenseRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class DrivingLicenseRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("ForeignPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class NotRestrictedDocumentType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("ResidencePermitRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class InternationalPassportRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("MilitaryPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class MilitaryPassportDocumentType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PassportRFType", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("PassportRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class PassportRFType1
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        BirthCertificate,

        /// <remarks/>
        DrivingLicenseRF,

        /// <remarks/>
        ForeignPassport,

        /// <remarks/>
        Form9Certificate,

        /// <remarks/>
        InternationalPassportRF,

        /// <remarks/>
        MilitaryPassport,

        /// <remarks/>
        PassportLossCertificate,

        /// <remarks/>
        PassportRF,

        /// <remarks/>
        ReleaseCertificate,

        /// <remarks/>
        ResidencePermitRF,

        /// <remarks/>
        SailorPassport,

        /// <remarks/>
        SovietPassport,

        /// <remarks/>
        TemporaryIdentityCardRF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("PrimaryIdentityDocument", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class PrimaryIdentityDocumentType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType1))]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
    [System.Xml.Serialization.XmlRootAttribute("AttachmentRef", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2", IsNullable = false)]
    public partial class AttachmentRefType
    {

        private string attachmentIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attachmentId
        {
            get
            {
                return this.attachmentIdField;
            }
            set
            {
                this.attachmentIdField = value;
            }
        }
    }
}

public class VS01113v001_TABL00
/* Сведения ТФОМС об оказанных медицинских услугах и их стоимости
 * VS01113v001_TABL00
 * Версия 1.0.0
 */
{
    public string vs_name = "Сведения ТФОМС об оказанных медицинских услугах и их стоимости";
    public string vs_mnemo = "VS01113v001_TABL00";
    public string vs_version = "1.0.0";
    /*
      <ns1:InputData xmlns:ns1="http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0" xmlns:q1="urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2">
                <ns1:InsuredRenderingListRequest>
                    <ns1:RegionCode>76000</ns1:RegionCode>
                    <q1:FamilyName>ЕМЕЛИН</q1:FamilyName>
                    <q1:FirstName>ИЛЬЯ</q1:FirstName>
                    <q1:Patronymic>НИКОЛАЕВИЧ</q1:Patronymic>
                    <ns1:BirthDate>1964-02-28</ns1:BirthDate>
                    <ns1:UnitedPolicyNumber>3210987654321098</ns1:UnitedPolicyNumber>
                    <ns1:DateFrom>2017-01-01</ns1:DateFrom>
                    <ns1:DateTo>2017-12-31</ns1:DateTo>
                </ns1:InsuredRenderingListRequest>
                </ns1:InputData>
    */

    [Serializable]
    [XmlRoot(ElementName = "InputData", Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
    public class InputData
    {
        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public InsuredRenderingListRequest InsuredRenderingListRequest { get; set; }
    }
    [Serializable]
    [XmlRoot(ElementName = "InsuredRenderingListRequest", Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
    public class InsuredRenderingListRequest
    {
        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public string RegionCode { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
        public string FamilyName { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
        public string FirstName { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.2")]
        public string Patronymic { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        //public DateTime BirthDate { get; set; }
        public String BirthDate { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public string UnitedPolicyNumber { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        //public DateTime? DateFrom { get; set; }
        public String DateFrom { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        //public DateTime? DateTo { get; set; }
        public String DateTo { get; set; }
    }


    /*
    <ns1:OutputData xmlns:ns1="http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0">
        - <ns1:InsuredRenderingList>
        - <ns1:InsuredRenderingInfo>
          <ns1:DateRenderingFrom>2017-06-15</ns1:DateRenderingFrom> 
          <ns1:DateRenderingTo>2017-06-15</ns1:DateRenderingTo> 
          <ns1:CareRegimen>первичная медико-санитарная помощь</ns1:CareRegimen> 
          <ns1:CareType>Амбулаторно (в условиях, не предусматривающих круглосуточного медицинского наблюдения и лечения), в том числе на дому при вызове медицинского работника</ns1:CareType> 
          <ns1:Name>Осмотр врача-терапевта</ns1:Name> 
          <ns1:MedServicesSum>600.00</ns1:MedServicesSum> 
          <ns1:ClinicName>ГБУЗ РА "МАЙКОПСКАЯ ГОРОДСКАЯ ПОЛИКЛИНИКА № 2"</ns1:ClinicName> 
          <ns1:RegionName>Республика Адыгея</ns1:RegionName> 
          </ns1:InsuredRenderingInfo>
        - <ns1:InsuredRenderingInfo>
          <ns1:DateRenderingFrom>2017-06-16</ns1:DateRenderingFrom> 
          <ns1:DateRenderingTo>2017-06-16</ns1:DateRenderingTo> 
          <ns1:CareRegimen>первичная медико-санитарная помощь</ns1:CareRegimen> 
          <ns1:CareType>Амбулаторно (в условиях, не предусматривающих круглосуточного медицинского наблюдения и лечения), в том числе на дому при вызове медицинского работника</ns1:CareType> 
          <ns1:Name>Осмотр врача-травматолога</ns1:Name> 
          <ns1:MedServicesSum>950.00</ns1:MedServicesSum> 
          <ns1:ClinicName>ГБУЗ РА "МАЙКОПСКАЯ ГОРОДСКАЯ ПОЛИКЛИНИКА № 2"</ns1:ClinicName> 
          <ns1:RegionName>Республика Адыгея</ns1:RegionName> 
          </ns1:InsuredRenderingInfo>
          </ns1:InsuredRenderingList>
          </ns1:OutputData>
    </MessagePrimaryContent>
    */
    [Serializable]
    [XmlRoot(ElementName = "OutputData", Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
    /*public class OutputData
    {
        public OutputData()
        {
            InsuredRenderingList = new List<InsuredRenderingInfo>();
        }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public List<InsuredRenderingInfo> InsuredRenderingList { get; set; }

    }*/
    public partial class OutputDataType
    {

        private InsuredRenderingInfo[] insuredRenderingListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InsuredRenderingInfo", IsNullable = false)]
        public InsuredRenderingInfo[] InsuredRenderingList
        {
            get
            {
                return this.insuredRenderingListField;
            }
            set
            {
                this.insuredRenderingListField = value;
            }
        }
    }
    [Serializable]
    [XmlRoot(ElementName = "InsuredRenderingInfo", Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
    public class InsuredRenderingInfo
    {
        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        //public DateTime DateRenderingFrom { get; set; }
        public string DateRenderingFrom { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        //public DateTime DateRenderingTo { get; set; }
        public string DateRenderingTo { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public string CareRegimen { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public string CareType { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public string Name { get; set; }

        ///TODO !!!!
        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public decimal MedServicesSum { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public string ClinicName { get; set; }

        [XmlElement(Namespace = "http://ffoms.ru/GetInsuredRenderedMedicalServices/1.0.0")]
        public string RegionName { get; set; }
    }
}

public class VS01285v001_TABL00
/* Сведения из ЕГР ЗАГС о государственной регистрации смерти 
 * VS01285v001_TABL00
 * Версия 4.0.0
 */
{
    public string vs_name = "Сведения из ЕГР ЗАГС о государственной регистрации смерти";
    public string vs_mnemo = "VS01285v001_TABL00";
    public string vs_version = "4.0.0";

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0", IsNullable = false)]
    public partial class FATALZPRequest
    {

        private FATALZPRequestСведРегСмерт[] сведРегСмертField;

        private string идСведField;

        private System.DateTime датаСведField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведРегСмерт")]
        public FATALZPRequestСведРегСмерт[] СведРегСмерт
        {
            get
            {
                return this.сведРегСмертField;
            }
            set
            {
                this.сведРегСмертField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдСвед
        {
            get
            {
                return this.идСведField;
            }
            set
            {
                this.идСведField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаСвед
        {
            get
            {
                return this.датаСведField;
            }
            set
            {
                this.датаСведField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмерт
    {

        private ОрганЗАГСТип органЗАГСField;

        private FATALZPRequestСведРегСмертСтатусЗаписи статусЗаписиField;

        private СведСвидетТип[] сведСвидетField;

        private FATALZPRequestСведРегСмертПрдСведРег прдСведРегField;

        private FATALZPRequestСведРегСмертСведИспрАГС[] сведИспрАГСField;

        private string номерЗаписField;

        private System.DateTime датаЗаписField;

        /// <remarks/>
        public ОрганЗАГСТип ОрганЗАГС
        {
            get
            {
                return this.органЗАГСField;
            }
            set
            {
                this.органЗАГСField = value;
            }
        }

        /// <remarks/>
        public FATALZPRequestСведРегСмертСтатусЗаписи СтатусЗаписи
        {
            get
            {
                return this.статусЗаписиField;
            }
            set
            {
                this.статусЗаписиField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведСвидет")]
        public СведСвидетТип[] СведСвидет
        {
            get
            {
                return this.сведСвидетField;
            }
            set
            {
                this.сведСвидетField = value;
            }
        }

        /// <remarks/>
        public FATALZPRequestСведРегСмертПрдСведРег ПрдСведРег
        {
            get
            {
                return this.прдСведРегField;
            }
            set
            {
                this.прдСведРегField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведИспрАГС")]
        public FATALZPRequestСведРегСмертСведИспрАГС[] СведИспрАГС
        {
            get
            {
                return this.сведИспрАГСField;
            }
            set
            {
                this.сведИспрАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерЗапис
        {
            get
            {
                return this.номерЗаписField;
            }
            set
            {
                this.номерЗаписField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаЗапис
        {
            get
            {
                return this.датаЗаписField;
            }
            set
            {
                this.датаЗаписField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class ОрганЗАГСТип
    {

        private string наимЗАГСField;

        private string кодЗАГСField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимЗАГС
        {
            get
            {
                return this.наимЗАГСField;
            }
            set
            {
                this.наимЗАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодЗАГС
        {
            get
            {
                return this.кодЗАГСField;
            }
            set
            {
                this.кодЗАГСField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class СведДокТип
    {

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        private string кодДокField;

        private string наимДокField;

        private string серНомДокField;

        private System.DateTime датаДокField;

        private bool датаДокFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("НаимОрг", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ФИОИП", typeof(ФИОПрТип))]
        [System.Xml.Serialization.XmlElementAttribute("ФИОФЛ", typeof(ФИОПрТип))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодДок
        {
            get
            {
                return this.кодДокField;
            }
            set
            {
                this.кодДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимДок
        {
            get
            {
                return this.наимДокField;
            }
            set
            {
                this.наимДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерНомДок
        {
            get
            {
                return this.серНомДокField;
            }
            set
            {
                this.серНомДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаДок
        {
            get
            {
                return this.датаДокField;
            }
            set
            {
                this.датаДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДатаДокSpecified
        {
            get
            {
                return this.датаДокFieldSpecified;
            }
            set
            {
                this.датаДокFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class ФИОПрТип
    {

        private object itemField;

        private object item1Field;

        private object item2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ПрФамилия", typeof(ФИОПрТипПрФамилия))]
        [System.Xml.Serialization.XmlElementAttribute("Фамилия", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Имя", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ПрИмя", typeof(ФИОПрТипПрИмя))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Отчество", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ПрОтчество", typeof(ФИОПрТипПрОтчество))]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public enum ФИОПрТипПрФамилия
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public enum ФИОПрТипПрИмя
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public enum ФИОПрТипПрОтчество
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        НаимОрг,

        /// <remarks/>
        ФИОИП,

        /// <remarks/>
        ФИОФЛ,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class УдЛичнФЛТип
    {

        private string кодВидДокField;

        private string наимДокField;

        private string серНомДокField;

        private System.DateTime датаДокField;

        private bool датаДокFieldSpecified;

        private string выдДокField;

        private string кодВыдДокField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодВидДок
        {
            get
            {
                return this.кодВидДокField;
            }
            set
            {
                this.кодВидДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимДок
        {
            get
            {
                return this.наимДокField;
            }
            set
            {
                this.наимДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерНомДок
        {
            get
            {
                return this.серНомДокField;
            }
            set
            {
                this.серНомДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаДок
        {
            get
            {
                return this.датаДокField;
            }
            set
            {
                this.датаДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДатаДокSpecified
        {
            get
            {
                return this.датаДокFieldSpecified;
            }
            set
            {
                this.датаДокFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВыдДок
        {
            get
            {
                return this.выдДокField;
            }
            set
            {
                this.выдДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодВыдДок
        {
            get
            {
                return this.кодВыдДокField;
            }
            set
            {
                this.кодВыдДокField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class НомерТип
    {

        private string типField;

        private string номерField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Номер
        {
            get
            {
                return this.номерField;
            }
            set
            {
                this.номерField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class ТипНаимТип
    {

        private string типField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class ВидНаимТип
    {

        private string видField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Вид
        {
            get
            {
                return this.видField;
            }
            set
            {
                this.видField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class ВидНаимКодТип
    {

        private string видКодField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВидКод
        {
            get
            {
                return this.видКодField;
            }
            set
            {
                this.видКодField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class АдрФИАСТип
    {

        private string регионField;

        private ВидНаимКодТип муниципРайонField;

        private ВидНаимКодТип городСелПоселенField;

        private ВидНаимТип населенПунктField;

        private ТипНаимТип элПланСтруктурField;

        private ТипНаимТип элУлДорСетиField;

        private string земелУчастокField;

        private НомерТип[] зданиеField;

        private НомерТип помещЗданияField;

        private НомерТип помещКвартирыField;

        private string идНомField;

        private string индексField;

        /// <remarks/>
        public string Регион
        {
            get
            {
                return this.регионField;
            }
            set
            {
                this.регионField = value;
            }
        }

        /// <remarks/>
        public ВидНаимКодТип МуниципРайон
        {
            get
            {
                return this.муниципРайонField;
            }
            set
            {
                this.муниципРайонField = value;
            }
        }

        /// <remarks/>
        public ВидНаимКодТип ГородСелПоселен
        {
            get
            {
                return this.городСелПоселенField;
            }
            set
            {
                this.городСелПоселенField = value;
            }
        }

        /// <remarks/>
        public ВидНаимТип НаселенПункт
        {
            get
            {
                return this.населенПунктField;
            }
            set
            {
                this.населенПунктField = value;
            }
        }

        /// <remarks/>
        public ТипНаимТип ЭлПланСтруктур
        {
            get
            {
                return this.элПланСтруктурField;
            }
            set
            {
                this.элПланСтруктурField = value;
            }
        }

        /// <remarks/>
        public ТипНаимТип ЭлУлДорСети
        {
            get
            {
                return this.элУлДорСетиField;
            }
            set
            {
                this.элУлДорСетиField = value;
            }
        }

        /// <remarks/>
        public string ЗемелУчасток
        {
            get
            {
                return this.земелУчастокField;
            }
            set
            {
                this.земелУчастокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Здание")]
        public НомерТип[] Здание
        {
            get
            {
                return this.зданиеField;
            }
            set
            {
                this.зданиеField = value;
            }
        }

        /// <remarks/>
        public НомерТип ПомещЗдания
        {
            get
            {
                return this.помещЗданияField;
            }
            set
            {
                this.помещЗданияField = value;
            }
        }

        /// <remarks/>
        public НомерТип ПомещКвартиры
        {
            get
            {
                return this.помещКвартирыField;
            }
            set
            {
                this.помещКвартирыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдНом
        {
            get
            {
                return this.идНомField;
            }
            set
            {
                this.идНомField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Индекс
        {
            get
            {
                return this.индексField;
            }
            set
            {
                this.индексField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class АдрКЛАДРТип
    {

        private string индексField;

        private string кодРегионField;

        private string наимРегионField;

        private string районField;

        private string городField;

        private string населПунктField;

        private string улицаField;

        private string домField;

        private string корпусField;

        private string квартField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Индекс
        {
            get
            {
                return this.индексField;
            }
            set
            {
                this.индексField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодРегион
        {
            get
            {
                return this.кодРегионField;
            }
            set
            {
                this.кодРегионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимРегион
        {
            get
            {
                return this.наимРегионField;
            }
            set
            {
                this.наимРегионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Район
        {
            get
            {
                return this.районField;
            }
            set
            {
                this.районField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Город
        {
            get
            {
                return this.городField;
            }
            set
            {
                this.городField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаселПункт
        {
            get
            {
                return this.населПунктField;
            }
            set
            {
                this.населПунктField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Улица
        {
            get
            {
                return this.улицаField;
            }
            set
            {
                this.улицаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Дом
        {
            get
            {
                return this.домField;
            }
            set
            {
                this.домField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Корпус
        {
            get
            {
                return this.корпусField;
            }
            set
            {
                this.корпусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Кварт
        {
            get
            {
                return this.квартField;
            }
            set
            {
                this.квартField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class МестоТип
    {

        private string местоТекстField;

        private string кодСтраныField;

        private string наимСтраныField;

        private string регионField;

        private string наимСубъектField;

        private string районField;

        private string городField;

        private string населПунктField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string МестоТекст
        {
            get
            {
                return this.местоТекстField;
            }
            set
            {
                this.местоТекстField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодСтраны
        {
            get
            {
                return this.кодСтраныField;
            }
            set
            {
                this.кодСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Регион
        {
            get
            {
                return this.регионField;
            }
            set
            {
                this.регионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСубъект
        {
            get
            {
                return this.наимСубъектField;
            }
            set
            {
                this.наимСубъектField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Район
        {
            get
            {
                return this.районField;
            }
            set
            {
                this.районField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Город
        {
            get
            {
                return this.городField;
            }
            set
            {
                this.городField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаселПункт
        {
            get
            {
                return this.населПунктField;
            }
            set
            {
                this.населПунктField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.0")]
    public partial class СведСвидетТип
    {

        private string серияСвидетField;

        private string номерСвидетField;

        private System.DateTime датаВыдСвидетField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерияСвидет
        {
            get
            {
                return this.серияСвидетField;
            }
            set
            {
                this.серияСвидетField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерСвидет
        {
            get
            {
                return this.номерСвидетField;
            }
            set
            {
                this.номерСвидетField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВыдСвидет
        {
            get
            {
                return this.датаВыдСвидетField;
            }
            set
            {
                this.датаВыдСвидетField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмертСтатусЗаписи
    {

        private System.DateTime датаНачСтатусField;

        private FATALZPRequestСведРегСмертСтатусЗаписиКодСтатус кодСтатусField;

        private string наимСтатусField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаНачСтатус
        {
            get
            {
                return this.датаНачСтатусField;
            }
            set
            {
                this.датаНачСтатусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FATALZPRequestСведРегСмертСтатусЗаписиКодСтатус КодСтатус
        {
            get
            {
                return this.кодСтатусField;
            }
            set
            {
                this.кодСтатусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтатус
        {
            get
            {
                return this.наимСтатусField;
            }
            set
            {
                this.наимСтатусField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public enum FATALZPRequestСведРегСмертСтатусЗаписиКодСтатус
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмертПрдСведРег
    {

        private FATALZPRequestСведРегСмертПрдСведРегСведУмер сведУмерField;

        private СведДокТип сведДокСмертField;

        /// <remarks/>
        public FATALZPRequestСведРегСмертПрдСведРегСведУмер СведУмер
        {
            get
            {
                return this.сведУмерField;
            }
            set
            {
                this.сведУмерField = value;
            }
        }

        /// <remarks/>
        public СведДокТип СведДокСмерт
        {
            get
            {
                return this.сведДокСмертField;
            }
            set
            {
                this.сведДокСмертField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмертПрдСведРегСведУмер
    {

        private FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмерт[] сведПричСмертField;

        private ФИОПрТип фИОУмерField;

        private object itemField;

        private ItemChoiceType itemElementNameField;

        private МестоТип местоРожденField;

        private object item1Field;

        private УдЛичнФЛТип удЛичнФЛField;

        private object item2Field;

        private Item2ChoiceType item2ElementNameField;

        private System.DateTime времяСмертField;

        private МестоТип местоСмертField;

        private FATALZPRequestСведРегСмертПрдСведРегСведУмерПол полField;

        private bool полFieldSpecified;

        private string оКСМField;

        private string наимСтраныField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведПричСмерт")]
        public FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмерт[] СведПричСмерт
        {
            get
            {
                return this.сведПричСмертField;
            }
            set
            {
                this.сведПричСмертField = value;
            }
        }

        /// <remarks/>
        public ФИОПрТип ФИОУмер
        {
            get
            {
                return this.фИОУмерField;
            }
            set
            {
                this.фИОУмерField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ГодРожд", typeof(string), DataType = "gYear")]
        [System.Xml.Serialization.XmlElementAttribute("ДатаРожд", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("МесГодРожд", typeof(string), DataType = "gYearMonth")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public МестоТип МестоРожден
        {
            get
            {
                return this.местоРожденField;
            }
            set
            {
                this.местоРожденField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("МЖПослИн", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерМЖПослИн))]
        [System.Xml.Serialization.XmlElementAttribute("МЖПослРФ", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерМЖПослРФ))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        public УдЛичнФЛТип УдЛичнФЛ
        {
            get
            {
                return this.удЛичнФЛField;
            }
            set
            {
                this.удЛичнФЛField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ГодСмерт", typeof(string), DataType = "gYear")]
        [System.Xml.Serialization.XmlElementAttribute("ДатаСмерт", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("МесГодСмерт", typeof(string), DataType = "gYearMonth")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item2ElementName")]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item2ChoiceType Item2ElementName
        {
            get
            {
                return this.item2ElementNameField;
            }
            set
            {
                this.item2ElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime ВремяСмерт
        {
            get
            {
                return this.времяСмертField;
            }
            set
            {
                this.времяСмертField = value;
            }
        }

        /// <remarks/>
        public МестоТип МестоСмерт
        {
            get
            {
                return this.местоСмертField;
            }
            set
            {
                this.местоСмертField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FATALZPRequestСведРегСмертПрдСведРегСведУмерПол Пол
        {
            get
            {
                return this.полField;
            }
            set
            {
                this.полField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ПолSpecified
        {
            get
            {
                return this.полFieldSpecified;
            }
            set
            {
                this.полFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКСМ
        {
            get
            {
                return this.оКСМField;
            }
            set
            {
                this.оКСМField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмерт
    {

        private FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмертСведПричСмерт[] сведПричСмертField;

        private FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмертЗаболевание заболеваниеField;

        private bool заболеваниеFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведПричСмерт")]
        public FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмертСведПричСмерт[] СведПричСмерт
        {
            get
            {
                return this.сведПричСмертField;
            }
            set
            {
                this.сведПричСмертField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмертЗаболевание Заболевание
        {
            get
            {
                return this.заболеваниеField;
            }
            set
            {
                this.заболеваниеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ЗаболеваниеSpecified
        {
            get
            {
                return this.заболеваниеFieldSpecified;
            }
            set
            {
                this.заболеваниеFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмертСведПричСмерт
    {

        private string кодПричСмертField;

        private string причСмертField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодПричСмерт
        {
            get
            {
                return this.кодПричСмертField;
            }
            set
            {
                this.кодПричСмертField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ПричСмерт
        {
            get
            {
                return this.причСмертField;
            }
            set
            {
                this.причСмертField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерСведПричСмертЗаболевание
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        ГодРожд,

        /// <remarks/>
        ДатаРожд,

        /// <remarks/>
        МесГодРожд,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмертПрдСведРегСведУмерМЖПослИн
    {

        private string оКСМField;

        private string наимСтраныField;

        private string адрТекстField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКСМ
        {
            get
            {
                return this.оКСМField;
            }
            set
            {
                this.оКСМField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string АдрТекст
        {
            get
            {
                return this.адрТекстField;
            }
            set
            {
                this.адрТекстField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмертПрдСведРегСведУмерМЖПослРФ
    {

        private object itemField;

        private string адрРФТекстField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("АдрКЛАДР", typeof(АдрКЛАДРТип))]
        [System.Xml.Serialization.XmlElementAttribute("АдрФИАС", typeof(АдрФИАСТип))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string АдрРФТекст
        {
            get
            {
                return this.адрРФТекстField;
            }
            set
            {
                this.адрРФТекстField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0", IncludeInSchema = false)]
    public enum Item2ChoiceType
    {

        /// <remarks/>
        ГодСмерт,

        /// <remarks/>
        ДатаСмерт,

        /// <remarks/>
        МесГодСмерт,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПол
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public partial class FATALZPRequestСведРегСмертСведИспрАГС
    {

        private СведДокТип сведДокИспрАГСField;

        private System.DateTime датаВнесИспрField;

        private string содержИспрField;

        /// <remarks/>
        public СведДокТип СведДокИспрАГС
        {
            get
            {
                return this.сведДокИспрАГСField;
            }
            set
            {
                this.сведДокИспрАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВнесИспр
        {
            get
            {
                return this.датаВнесИспрField;
            }
            set
            {
                this.датаВнесИспрField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СодержИспр
        {
            get
            {
                return this.содержИспрField;
            }
            set
            {
                this.содержИспрField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0", IsNullable = false)]
    public partial class FATALZPResponse
    {

        private string идСведField;

        private FATALZPResponseКодОбр кодОбрField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдСвед
        {
            get
            {
                return this.идСведField;
            }
            set
            {
                this.идСведField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FATALZPResponseКодОбр КодОбр
        {
            get
            {
                return this.кодОбрField;
            }
            set
            {
                this.кодОбрField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.0")]
    public enum FATALZPResponseКодОбр
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
}

public class VS01285v002_TABL00
/* Сведения из ЕГР ЗАГС о государственной регистрации смерти 
*  VS01285v002_TABL00
* Версия 4.0.1
*/
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1", IsNullable = false)]
    public partial class FATALZPRequest : object, System.ComponentModel.INotifyPropertyChanged
    {

        private FATALZPRequestСведРегСмерт[] сведРегСмертField;

        private string идСведField;

        private System.DateTime датаСведField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведРегСмерт")]
        public FATALZPRequestСведРегСмерт[] СведРегСмерт
        {
            get
            {
                return this.сведРегСмертField;
            }
            set
            {
                this.сведРегСмертField = value;
                this.RaisePropertyChanged("СведРегСмерт");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдСвед
        {
            get
            {
                return this.идСведField;
            }
            set
            {
                this.идСведField = value;
                this.RaisePropertyChanged("ИдСвед");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаСвед
        {
            get
            {
                return this.датаСведField;
            }
            set
            {
                this.датаСведField = value;
                this.RaisePropertyChanged("ДатаСвед");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public partial class FATALZPRequestСведРегСмерт : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ОрганЗАГСТип органЗАГСField;

        private FATALZPRequestСведРегСмертСтатусЗаписи статусЗаписиField;

        private СведСвидетТип сведСвидетField;

        private СведСвидетТип[] повтСвидетField;

        private FATALZPRequestСведРегСмертПрдСведРег прдСведРегField;

        private СведИзмАГСТип[] сведИспрАГСField;

        private СведИзмАГСТип сведВосстанАГСField;

        private СведИзмАГСТип сведАннулирАГСField;

        private string номерЗаписField;

        private System.DateTime датаЗаписField;

        private string номерВерсField;

        private System.DateTime датаВерсField;

        /// <remarks/>
        public ОрганЗАГСТип ОрганЗАГС
        {
            get
            {
                return this.органЗАГСField;
            }
            set
            {
                this.органЗАГСField = value;
                this.RaisePropertyChanged("ОрганЗАГС");
            }
        }

        /// <remarks/>
        public FATALZPRequestСведРегСмертСтатусЗаписи СтатусЗаписи
        {
            get
            {
                return this.статусЗаписиField;
            }
            set
            {
                this.статусЗаписиField = value;
                this.RaisePropertyChanged("СтатусЗаписи");
            }
        }

        /// <remarks/>
        public СведСвидетТип СведСвидет
        {
            get
            {
                return this.сведСвидетField;
            }
            set
            {
                this.сведСвидетField = value;
                this.RaisePropertyChanged("СведСвидет");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ПовтСвидет")]
        public СведСвидетТип[] ПовтСвидет
        {
            get
            {
                return this.повтСвидетField;
            }
            set
            {
                this.повтСвидетField = value;
                this.RaisePropertyChanged("ПовтСвидет");
            }
        }

        /// <remarks/>
        public FATALZPRequestСведРегСмертПрдСведРег ПрдСведРег
        {
            get
            {
                return this.прдСведРегField;
            }
            set
            {
                this.прдСведРегField = value;
                this.RaisePropertyChanged("ПрдСведРег");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведИспрАГС")]
        public СведИзмАГСТип[] СведИспрАГС
        {
            get
            {
                return this.сведИспрАГСField;
            }
            set
            {
                this.сведИспрАГСField = value;
                this.RaisePropertyChanged("СведИспрАГС");
            }
        }

        /// <remarks/>
        public СведИзмАГСТип СведВосстанАГС
        {
            get
            {
                return this.сведВосстанАГСField;
            }
            set
            {
                this.сведВосстанАГСField = value;
                this.RaisePropertyChanged("СведВосстанАГС");
            }
        }

        /// <remarks/>
        public СведИзмАГСТип СведАннулирАГС
        {
            get
            {
                return this.сведАннулирАГСField;
            }
            set
            {
                this.сведАннулирАГСField = value;
                this.RaisePropertyChanged("СведАннулирАГС");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерЗапис
        {
            get
            {
                return this.номерЗаписField;
            }
            set
            {
                this.номерЗаписField = value;
                this.RaisePropertyChanged("НомерЗапис");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаЗапис
        {
            get
            {
                return this.датаЗаписField;
            }
            set
            {
                this.датаЗаписField = value;
                this.RaisePropertyChanged("ДатаЗапис");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерВерс
        {
            get
            {
                return this.номерВерсField;
            }
            set
            {
                this.номерВерсField = value;
                this.RaisePropertyChanged("НомерВерс");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВерс
        {
            get
            {
                return this.датаВерсField;
            }
            set
            {
                this.датаВерсField = value;
                this.RaisePropertyChanged("ДатаВерс");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class ОрганЗАГСТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string наимЗАГСField;

        private string кодЗАГСField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимЗАГС
        {
            get
            {
                return this.наимЗАГСField;
            }
            set
            {
                this.наимЗАГСField = value;
                this.RaisePropertyChanged("НаимЗАГС");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодЗАГС
        {
            get
            {
                return this.кодЗАГСField;
            }
            set
            {
                this.кодЗАГСField = value;
                this.RaisePropertyChanged("КодЗАГС");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class СведДокТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        private ItemChoiceType itemElementNameField;

        private string кодДокField;

        private string наимДокField;

        private string серНомДокField;

        private System.DateTime датаДокField;

        private bool датаДокFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("НаимОрг", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ФИОИП", typeof(ФИОПрТип))]
        [System.Xml.Serialization.XmlElementAttribute("ФИОФЛ", typeof(ФИОПрТип))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
                this.RaisePropertyChanged("ItemElementName");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодДок
        {
            get
            {
                return this.кодДокField;
            }
            set
            {
                this.кодДокField = value;
                this.RaisePropertyChanged("КодДок");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимДок
        {
            get
            {
                return this.наимДокField;
            }
            set
            {
                this.наимДокField = value;
                this.RaisePropertyChanged("НаимДок");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерНомДок
        {
            get
            {
                return this.серНомДокField;
            }
            set
            {
                this.серНомДокField = value;
                this.RaisePropertyChanged("СерНомДок");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаДок
        {
            get
            {
                return this.датаДокField;
            }
            set
            {
                this.датаДокField = value;
                this.RaisePropertyChanged("ДатаДок");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДатаДокSpecified
        {
            get
            {
                return this.датаДокFieldSpecified;
            }
            set
            {
                this.датаДокFieldSpecified = value;
                this.RaisePropertyChanged("ДатаДокSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class ФИОПрТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        private object item1Field;

        private object item2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ПрФамилия", typeof(ФИОПрТипПрФамилия))]
        [System.Xml.Serialization.XmlElementAttribute("Фамилия", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Имя", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ПрИмя", typeof(ФИОПрТипПрИмя))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                this.RaisePropertyChanged("Item1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Отчество", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ПрОтчество", typeof(ФИОПрТипПрОтчество))]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
                this.RaisePropertyChanged("Item2");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public enum ФИОПрТипПрФамилия
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public enum ФИОПрТипПрИмя
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public enum ФИОПрТипПрОтчество
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        НаимОрг,

        /// <remarks/>
        ФИОИП,

        /// <remarks/>
        ФИОФЛ,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class ЗапАктТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ОрганЗАГСТип органЗАГСField;

        private string типАГСField;

        private string наимТипЗаписField;

        private string номерЗаписField;

        private System.DateTime датаЗаписField;

        /// <remarks/>
        public ОрганЗАГСТип ОрганЗАГС
        {
            get
            {
                return this.органЗАГСField;
            }
            set
            {
                this.органЗАГСField = value;
                this.RaisePropertyChanged("ОрганЗАГС");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ТипАГС
        {
            get
            {
                return this.типАГСField;
            }
            set
            {
                this.типАГСField = value;
                this.RaisePropertyChanged("ТипАГС");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимТипЗапис
        {
            get
            {
                return this.наимТипЗаписField;
            }
            set
            {
                this.наимТипЗаписField = value;
                this.RaisePropertyChanged("НаимТипЗапис");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерЗапис
        {
            get
            {
                return this.номерЗаписField;
            }
            set
            {
                this.номерЗаписField = value;
                this.RaisePropertyChanged("НомерЗапис");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаЗапис
        {
            get
            {
                return this.датаЗаписField;
            }
            set
            {
                this.датаЗаписField = value;
                this.RaisePropertyChanged("ДатаЗапис");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class СведДокОснТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ДокОсн", typeof(СведДокТип))]
        [System.Xml.Serialization.XmlElementAttribute("ЗапАктОсн", typeof(ЗапАктТип))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class СведИзмАГСТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        private string кодВидСведField;

        private string наимВидСведField;

        private System.DateTime датаВнесИспрField;

        private string содержИспрField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ПрСведДокИспрАГС", typeof(СведИзмАГСТипПрСведДокИспрАГС))]
        [System.Xml.Serialization.XmlElementAttribute("СведДокИспрАГС", typeof(СведДокОснТип))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодВидСвед
        {
            get
            {
                return this.кодВидСведField;
            }
            set
            {
                this.кодВидСведField = value;
                this.RaisePropertyChanged("КодВидСвед");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимВидСвед
        {
            get
            {
                return this.наимВидСведField;
            }
            set
            {
                this.наимВидСведField = value;
                this.RaisePropertyChanged("НаимВидСвед");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВнесИспр
        {
            get
            {
                return this.датаВнесИспрField;
            }
            set
            {
                this.датаВнесИспрField = value;
                this.RaisePropertyChanged("ДатаВнесИспр");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СодержИспр
        {
            get
            {
                return this.содержИспрField;
            }
            set
            {
                this.содержИспрField = value;
                this.RaisePropertyChanged("СодержИспр");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public enum СведИзмАГСТипПрСведДокИспрАГС
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class УдЛичнФЛТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string кодВидДокField;

        private string наимДокField;

        private string серНомДокField;

        private System.DateTime датаДокField;

        private bool датаДокFieldSpecified;

        private string выдДокField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодВидДок
        {
            get
            {
                return this.кодВидДокField;
            }
            set
            {
                this.кодВидДокField = value;
                this.RaisePropertyChanged("КодВидДок");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимДок
        {
            get
            {
                return this.наимДокField;
            }
            set
            {
                this.наимДокField = value;
                this.RaisePropertyChanged("НаимДок");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерНомДок
        {
            get
            {
                return this.серНомДокField;
            }
            set
            {
                this.серНомДокField = value;
                this.RaisePropertyChanged("СерНомДок");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаДок
        {
            get
            {
                return this.датаДокField;
            }
            set
            {
                this.датаДокField = value;
                this.RaisePropertyChanged("ДатаДок");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДатаДокSpecified
        {
            get
            {
                return this.датаДокFieldSpecified;
            }
            set
            {
                this.датаДокFieldSpecified = value;
                this.RaisePropertyChanged("ДатаДокSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВыдДок
        {
            get
            {
                return this.выдДокField;
            }
            set
            {
                this.выдДокField = value;
                this.RaisePropertyChanged("ВыдДок");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class НомерТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string типField;

        private string номерField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
                this.RaisePropertyChanged("Тип");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Номер
        {
            get
            {
                return this.номерField;
            }
            set
            {
                this.номерField = value;
                this.RaisePropertyChanged("Номер");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class ТипНаимТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string типField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
                this.RaisePropertyChanged("Тип");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
                this.RaisePropertyChanged("Наим");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class ВидНаимТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string видField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Вид
        {
            get
            {
                return this.видField;
            }
            set
            {
                this.видField = value;
                this.RaisePropertyChanged("Вид");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
                this.RaisePropertyChanged("Наим");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class ВидНаимКодТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string видКодField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВидКод
        {
            get
            {
                return this.видКодField;
            }
            set
            {
                this.видКодField = value;
                this.RaisePropertyChanged("ВидКод");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
                this.RaisePropertyChanged("Наим");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class АдрФИАСТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string регионField;

        private ВидНаимКодТип муниципРайонField;

        private ВидНаимКодТип городСелПоселенField;

        private ВидНаимТип населенПунктField;

        private ТипНаимТип элПланСтруктурField;

        private ТипНаимТип элУлДорСетиField;

        private string земелУчастокField;

        private НомерТип[] зданиеField;

        private НомерТип помещЗданияField;

        private НомерТип помещКвартирыField;

        private string идНомField;

        private string индексField;

        /// <remarks/>
        public string Регион
        {
            get
            {
                return this.регионField;
            }
            set
            {
                this.регионField = value;
                this.RaisePropertyChanged("Регион");
            }
        }

        /// <remarks/>
        public ВидНаимКодТип МуниципРайон
        {
            get
            {
                return this.муниципРайонField;
            }
            set
            {
                this.муниципРайонField = value;
                this.RaisePropertyChanged("МуниципРайон");
            }
        }

        /// <remarks/>
        public ВидНаимКодТип ГородСелПоселен
        {
            get
            {
                return this.городСелПоселенField;
            }
            set
            {
                this.городСелПоселенField = value;
                this.RaisePropertyChanged("ГородСелПоселен");
            }
        }

        /// <remarks/>
        public ВидНаимТип НаселенПункт
        {
            get
            {
                return this.населенПунктField;
            }
            set
            {
                this.населенПунктField = value;
                this.RaisePropertyChanged("НаселенПункт");
            }
        }

        /// <remarks/>
        public ТипНаимТип ЭлПланСтруктур
        {
            get
            {
                return this.элПланСтруктурField;
            }
            set
            {
                this.элПланСтруктурField = value;
                this.RaisePropertyChanged("ЭлПланСтруктур");
            }
        }

        /// <remarks/>
        public ТипНаимТип ЭлУлДорСети
        {
            get
            {
                return this.элУлДорСетиField;
            }
            set
            {
                this.элУлДорСетиField = value;
                this.RaisePropertyChanged("ЭлУлДорСети");
            }
        }

        /// <remarks/>
        public string ЗемелУчасток
        {
            get
            {
                return this.земелУчастокField;
            }
            set
            {
                this.земелУчастокField = value;
                this.RaisePropertyChanged("ЗемелУчасток");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Здание")]
        public НомерТип[] Здание
        {
            get
            {
                return this.зданиеField;
            }
            set
            {
                this.зданиеField = value;
                this.RaisePropertyChanged("Здание");
            }
        }

        /// <remarks/>
        public НомерТип ПомещЗдания
        {
            get
            {
                return this.помещЗданияField;
            }
            set
            {
                this.помещЗданияField = value;
                this.RaisePropertyChanged("ПомещЗдания");
            }
        }

        /// <remarks/>
        public НомерТип ПомещКвартиры
        {
            get
            {
                return this.помещКвартирыField;
            }
            set
            {
                this.помещКвартирыField = value;
                this.RaisePropertyChanged("ПомещКвартиры");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдНом
        {
            get
            {
                return this.идНомField;
            }
            set
            {
                this.идНомField = value;
                this.RaisePropertyChanged("ИдНом");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Индекс
        {
            get
            {
                return this.индексField;
            }
            set
            {
                this.индексField = value;
                this.RaisePropertyChanged("Индекс");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class АдрКЛАДРТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string индексField;

        private string кодРегионField;

        private string наимРегионField;

        private string районField;

        private string городField;

        private string населПунктField;

        private string улицаField;

        private string домField;

        private string корпусField;

        private string квартField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Индекс
        {
            get
            {
                return this.индексField;
            }
            set
            {
                this.индексField = value;
                this.RaisePropertyChanged("Индекс");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодРегион
        {
            get
            {
                return this.кодРегионField;
            }
            set
            {
                this.кодРегионField = value;
                this.RaisePropertyChanged("КодРегион");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимРегион
        {
            get
            {
                return this.наимРегионField;
            }
            set
            {
                this.наимРегионField = value;
                this.RaisePropertyChanged("НаимРегион");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Район
        {
            get
            {
                return this.районField;
            }
            set
            {
                this.районField = value;
                this.RaisePropertyChanged("Район");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Город
        {
            get
            {
                return this.городField;
            }
            set
            {
                this.городField = value;
                this.RaisePropertyChanged("Город");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаселПункт
        {
            get
            {
                return this.населПунктField;
            }
            set
            {
                this.населПунктField = value;
                this.RaisePropertyChanged("НаселПункт");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Улица
        {
            get
            {
                return this.улицаField;
            }
            set
            {
                this.улицаField = value;
                this.RaisePropertyChanged("Улица");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Дом
        {
            get
            {
                return this.домField;
            }
            set
            {
                this.домField = value;
                this.RaisePropertyChanged("Дом");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Корпус
        {
            get
            {
                return this.корпусField;
            }
            set
            {
                this.корпусField = value;
                this.RaisePropertyChanged("Корпус");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Кварт
        {
            get
            {
                return this.квартField;
            }
            set
            {
                this.квартField = value;
                this.RaisePropertyChanged("Кварт");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class МЖПослТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("МЖПослИн", typeof(МЖПослТипМЖПослИн))]
        [System.Xml.Serialization.XmlElementAttribute("МЖПослРФ", typeof(МЖПослТипМЖПослРФ))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class МЖПослТипМЖПослИн : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string оКСМField;

        private string наимСтраныField;

        private string адрТекстField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКСМ
        {
            get
            {
                return this.оКСМField;
            }
            set
            {
                this.оКСМField = value;
                this.RaisePropertyChanged("ОКСМ");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
                this.RaisePropertyChanged("НаимСтраны");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string АдрТекст
        {
            get
            {
                return this.адрТекстField;
            }
            set
            {
                this.адрТекстField = value;
                this.RaisePropertyChanged("АдрТекст");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class МЖПослТипМЖПослРФ : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        private string адрРФТекстField;

        private МЖПослТипМЖПослРФПрТипАдрРФ прТипАдрРФField;

        private string оКТМОField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("АдрКЛАДР", typeof(АдрКЛАДРТип))]
        [System.Xml.Serialization.XmlElementAttribute("АдрФИАС", typeof(АдрФИАСТип))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string АдрРФТекст
        {
            get
            {
                return this.адрРФТекстField;
            }
            set
            {
                this.адрРФТекстField = value;
                this.RaisePropertyChanged("АдрРФТекст");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public МЖПослТипМЖПослРФПрТипАдрРФ ПрТипАдрРФ
        {
            get
            {
                return this.прТипАдрРФField;
            }
            set
            {
                this.прТипАдрРФField = value;
                this.RaisePropertyChanged("ПрТипАдрРФ");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКТМО
        {
            get
            {
                return this.оКТМОField;
            }
            set
            {
                this.оКТМОField = value;
                this.RaisePropertyChanged("ОКТМО");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public enum МЖПослТипМЖПослРФПрТипАдрРФ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class МестоТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private МестоТипПризнМесто признМестоField;

        private string местоТекстField;

        private string кодСтраныField;

        private string наимСтраныField;

        private string регионField;

        private string наимСубъектField;

        private string районField;

        private string городField;

        private string населПунктField;

        private string оКТМОField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public МестоТипПризнМесто ПризнМесто
        {
            get
            {
                return this.признМестоField;
            }
            set
            {
                this.признМестоField = value;
                this.RaisePropertyChanged("ПризнМесто");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string МестоТекст
        {
            get
            {
                return this.местоТекстField;
            }
            set
            {
                this.местоТекстField = value;
                this.RaisePropertyChanged("МестоТекст");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодСтраны
        {
            get
            {
                return this.кодСтраныField;
            }
            set
            {
                this.кодСтраныField = value;
                this.RaisePropertyChanged("КодСтраны");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
                this.RaisePropertyChanged("НаимСтраны");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Регион
        {
            get
            {
                return this.регионField;
            }
            set
            {
                this.регионField = value;
                this.RaisePropertyChanged("Регион");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСубъект
        {
            get
            {
                return this.наимСубъектField;
            }
            set
            {
                this.наимСубъектField = value;
                this.RaisePropertyChanged("НаимСубъект");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Район
        {
            get
            {
                return this.районField;
            }
            set
            {
                this.районField = value;
                this.RaisePropertyChanged("Район");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Город
        {
            get
            {
                return this.городField;
            }
            set
            {
                this.городField = value;
                this.RaisePropertyChanged("Город");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаселПункт
        {
            get
            {
                return this.населПунктField;
            }
            set
            {
                this.населПунктField = value;
                this.RaisePropertyChanged("НаселПункт");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКТМО
        {
            get
            {
                return this.оКТМОField;
            }
            set
            {
                this.оКТМОField = value;
                this.RaisePropertyChanged("ОКТМО");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public enum МестоТипПризнМесто
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class ДатаДокТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        private object item1Field;

        private string годField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("День", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("ПрДень", typeof(ДатаДокТипПрДень))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Месяц", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("ПрМесяц", typeof(ДатаДокТипПрМесяц))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                this.RaisePropertyChanged("Item1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "gYear")]
        public string Год
        {
            get
            {
                return this.годField;
            }
            set
            {
                this.годField = value;
                this.RaisePropertyChanged("Год");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public enum ДатаДокТипПрДень
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public enum ДатаДокТипПрМесяц
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class ГражданствоТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string оКСМField;

        private string наимСтраныField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКСМ
        {
            get
            {
                return this.оКСМField;
            }
            set
            {
                this.оКСМField = value;
                this.RaisePropertyChanged("ОКСМ");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
                this.RaisePropertyChanged("НаимСтраны");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/types/4.0.1")]
    public partial class СведСвидетТип : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string серияСвидетField;

        private string номерСвидетField;

        private System.DateTime датаВыдСвидетField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерияСвидет
        {
            get
            {
                return this.серияСвидетField;
            }
            set
            {
                this.серияСвидетField = value;
                this.RaisePropertyChanged("СерияСвидет");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерСвидет
        {
            get
            {
                return this.номерСвидетField;
            }
            set
            {
                this.номерСвидетField = value;
                this.RaisePropertyChanged("НомерСвидет");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВыдСвидет
        {
            get
            {
                return this.датаВыдСвидетField;
            }
            set
            {
                this.датаВыдСвидетField = value;
                this.RaisePropertyChanged("ДатаВыдСвидет");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public partial class FATALZPRequestСведРегСмертСтатусЗаписи : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime датаНачСтатусField;

        private FATALZPRequestСведРегСмертСтатусЗаписиКодСтатус кодСтатусField;

        private string наимСтатусField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаНачСтатус
        {
            get
            {
                return this.датаНачСтатусField;
            }
            set
            {
                this.датаНачСтатусField = value;
                this.RaisePropertyChanged("ДатаНачСтатус");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FATALZPRequestСведРегСмертСтатусЗаписиКодСтатус КодСтатус
        {
            get
            {
                return this.кодСтатусField;
            }
            set
            {
                this.кодСтатусField = value;
                this.RaisePropertyChanged("КодСтатус");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтатус
        {
            get
            {
                return this.наимСтатусField;
            }
            set
            {
                this.наимСтатусField = value;
                this.RaisePropertyChanged("НаимСтатус");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертСтатусЗаписиКодСтатус
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public partial class FATALZPRequestСведРегСмертПрдСведРег : object, System.ComponentModel.INotifyPropertyChanged
    {

        private FATALZPRequestСведРегСмертПрдСведРегСведУмер сведУмерField;

        /// <remarks/>
        public FATALZPRequestСведРегСмертПрдСведРегСведУмер СведУмер
        {
            get
            {
                return this.сведУмерField;
            }
            set
            {
                this.сведУмерField = value;
                this.RaisePropertyChanged("СведУмер");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public partial class FATALZPRequestСведРегСмертПрдСведРегСведУмер : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        private ФИОПрТип фИОУмерField;

        private object item1Field;

        private object item2Field;

        private object item3Field;

        private object item4Field;

        private object item5Field;

        private object item6Field;

        private object item7Field;

        private FATALZPRequestСведРегСмертПрдСведРегСведУмерПрНеустанЛицо прНеустанЛицоField;

        private bool прНеустанЛицоFieldSpecified;

        private FATALZPRequestСведРегСмертПрдСведРегСведУмерПол полField;

        private bool полFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Гражданство", typeof(ГражданствоТип))]
        [System.Xml.Serialization.XmlElementAttribute("ПрГражданство", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерПрГражданство))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        public ФИОПрТип ФИОУмер
        {
            get
            {
                return this.фИОУмерField;
            }
            set
            {
                this.фИОУмерField = value;
                this.RaisePropertyChanged("ФИОУмер");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ДатаРождДок", typeof(ДатаДокТип))]
        [System.Xml.Serialization.XmlElementAttribute("ДатаРождКаленд", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("ПрДатаРожд", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерПрДатаРожд))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                this.RaisePropertyChanged("Item1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("МестоРожден", typeof(МестоТип))]
        [System.Xml.Serialization.XmlElementAttribute("ПрМестоРожден", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерПрМестоРожден))]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
                this.RaisePropertyChanged("Item2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("МЖПосл", typeof(МЖПослТип))]
        [System.Xml.Serialization.XmlElementAttribute("ПрМЖПосл", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерПрМЖПосл))]
        public object Item3
        {
            get
            {
                return this.item3Field;
            }
            set
            {
                this.item3Field = value;
                this.RaisePropertyChanged("Item3");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ПрУдЛичнФЛ", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерПрУдЛичнФЛ))]
        [System.Xml.Serialization.XmlElementAttribute("УдЛичнФЛ", typeof(УдЛичнФЛТип))]
        public object Item4
        {
            get
            {
                return this.item4Field;
            }
            set
            {
                this.item4Field = value;
                this.RaisePropertyChanged("Item4");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ДатаСмертДок", typeof(ДатаДокТип))]
        [System.Xml.Serialization.XmlElementAttribute("ДатаСмертКаленд", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("ПрДатаСмерт", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерПрДатаСмерт))]
        public object Item5
        {
            get
            {
                return this.item5Field;
            }
            set
            {
                this.item5Field = value;
                this.RaisePropertyChanged("Item5");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ВремяСмерт", typeof(System.DateTime), DataType = "time")]
        [System.Xml.Serialization.XmlElementAttribute("ПрВремяСмерт", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерПрВремяСмерт))]
        public object Item6
        {
            get
            {
                return this.item6Field;
            }
            set
            {
                this.item6Field = value;
                this.RaisePropertyChanged("Item6");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("МестоСмерт", typeof(МестоТип))]
        [System.Xml.Serialization.XmlElementAttribute("ПрМестоСмерт", typeof(FATALZPRequestСведРегСмертПрдСведРегСведУмерПрМестоСмерт))]
        public object Item7
        {
            get
            {
                return this.item7Field;
            }
            set
            {
                this.item7Field = value;
                this.RaisePropertyChanged("Item7");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FATALZPRequestСведРегСмертПрдСведРегСведУмерПрНеустанЛицо ПрНеустанЛицо
        {
            get
            {
                return this.прНеустанЛицоField;
            }
            set
            {
                this.прНеустанЛицоField = value;
                this.RaisePropertyChanged("ПрНеустанЛицо");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ПрНеустанЛицоSpecified
        {
            get
            {
                return this.прНеустанЛицоFieldSpecified;
            }
            set
            {
                this.прНеустанЛицоFieldSpecified = value;
                this.RaisePropertyChanged("ПрНеустанЛицоSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FATALZPRequestСведРегСмертПрдСведРегСведУмерПол Пол
        {
            get
            {
                return this.полField;
            }
            set
            {
                this.полField = value;
                this.RaisePropertyChanged("Пол");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ПолSpecified
        {
            get
            {
                return this.полFieldSpecified;
            }
            set
            {
                this.полFieldSpecified = value;
                this.RaisePropertyChanged("ПолSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрГражданство
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрДатаРожд
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрМестоРожден
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрМЖПосл
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрУдЛичнФЛ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрДатаСмерт
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрВремяСмерт
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрМестоСмерт
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПрНеустанЛицо
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPRequestСведРегСмертПрдСведРегСведУмерПол
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1", IsNullable = false)]
    public partial class FATALZPResponse : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string идСведField;

        private FATALZPResponseКодОбр кодОбрField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдСвед
        {
            get
            {
                return this.идСведField;
            }
            set
            {
                this.идСведField = value;
                this.RaisePropertyChanged("ИдСвед");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FATALZPResponseКодОбр КодОбр
        {
            get
            {
                return this.кодОбрField;
            }
            set
            {
                this.кодОбрField = value;
                this.RaisePropertyChanged("КодОбр");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-fatalzp/root/112-25/4.0.1")]
    public enum FATALZPResponseКодОбр
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

}
public class VS01287v001_TABL00
/* Сведения и ЕГР ЗАГС о государственной регистрации рождения 
 * VS01287v001_TABL00
 * Версия 4.0.0
 */
{
    public string vs_name = "Сведения и ЕГР ЗАГС о государственной регистрации рождения";
    public string vs_mnemo = "VS01287v001_TABL00";
    public string vs_version = "4.0.0";


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0", IsNullable = false)]
    public partial class ROGDZPRequest
    {

        private ROGDZPRequestСведРегРожд[] сведРегРождField;

        private string идСведField;

        private System.DateTime датаСведField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведРегРожд")]
        public ROGDZPRequestСведРегРожд[] СведРегРожд
        {
            get
            {
                return this.сведРегРождField;
            }
            set
            {
                this.сведРегРождField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдСвед
        {
            get
            {
                return this.идСведField;
            }
            set
            {
                this.идСведField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаСвед
        {
            get
            {
                return this.датаСведField;
            }
            set
            {
                this.датаСведField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    public partial class ROGDZPRequestСведРегРожд
    {

        private ОрганЗАГСТип органЗАГСField;

        private ROGDZPRequestСведРегРождСтатусЗаписи статусЗаписиField;

        private СведСвидетТип[] свидетРождField;

        private ROGDZPRequestСведРегРождПрдСведРег прдСведРегField;

        private СведИспрАГСТип[] сведИспрАГСField;

        private string номерЗаписField;

        private System.DateTime датаЗаписField;

        /// <remarks/>
        public ОрганЗАГСТип ОрганЗАГС
        {
            get
            {
                return this.органЗАГСField;
            }
            set
            {
                this.органЗАГСField = value;
            }
        }

        /// <remarks/>
        public ROGDZPRequestСведРегРождСтатусЗаписи СтатусЗаписи
        {
            get
            {
                return this.статусЗаписиField;
            }
            set
            {
                this.статусЗаписиField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СвидетРожд")]
        public СведСвидетТип[] СвидетРожд
        {
            get
            {
                return this.свидетРождField;
            }
            set
            {
                this.свидетРождField = value;
            }
        }

        /// <remarks/>
        public ROGDZPRequestСведРегРождПрдСведРег ПрдСведРег
        {
            get
            {
                return this.прдСведРегField;
            }
            set
            {
                this.прдСведРегField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведИспрАГС")]
        public СведИспрАГСТип[] СведИспрАГС
        {
            get
            {
                return this.сведИспрАГСField;
            }
            set
            {
                this.сведИспрАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерЗапис
        {
            get
            {
                return this.номерЗаписField;
            }
            set
            {
                this.номерЗаписField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаЗапис
        {
            get
            {
                return this.датаЗаписField;
            }
            set
            {
                this.датаЗаписField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class ОрганЗАГСТип
    {

        private string наимЗАГСField;

        private string кодЗАГСField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимЗАГС
        {
            get
            {
                return this.наимЗАГСField;
            }
            set
            {
                this.наимЗАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодЗАГС
        {
            get
            {
                return this.кодЗАГСField;
            }
            set
            {
                this.кодЗАГСField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class СведИспрАГСТип
    {

        private СведДокОснТип сведДокИспрАГСField;

        private System.DateTime датаВнесИспрField;

        private string содержИспрField;

        /// <remarks/>
        public СведДокОснТип СведДокИспрАГС
        {
            get
            {
                return this.сведДокИспрАГСField;
            }
            set
            {
                this.сведДокИспрАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВнесИспр
        {
            get
            {
                return this.датаВнесИспрField;
            }
            set
            {
                this.датаВнесИспрField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СодержИспр
        {
            get
            {
                return this.содержИспрField;
            }
            set
            {
                this.содержИспрField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class СведДокОснТип
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ДокОсн", typeof(СведДокТип))]
        [System.Xml.Serialization.XmlElementAttribute("ЗапАктОсн", typeof(ЗапАктТип))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class СведДокТип
    {

        private object itemField;

        private ItemChoiceType2 itemElementNameField;

        private string кодДокField;

        private string наимДокField;

        private string серНомДокField;

        private System.DateTime датаДокField;

        private bool датаДокFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("НаимОрг", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ФИОИП", typeof(ФИОПрТип))]
        [System.Xml.Serialization.XmlElementAttribute("ФИОФЛ", typeof(ФИОПрТип))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодДок
        {
            get
            {
                return this.кодДокField;
            }
            set
            {
                this.кодДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимДок
        {
            get
            {
                return this.наимДокField;
            }
            set
            {
                this.наимДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерНомДок
        {
            get
            {
                return this.серНомДокField;
            }
            set
            {
                this.серНомДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаДок
        {
            get
            {
                return this.датаДокField;
            }
            set
            {
                this.датаДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДатаДокSpecified
        {
            get
            {
                return this.датаДокFieldSpecified;
            }
            set
            {
                this.датаДокFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class ФИОПрТип
    {

        private object itemField;

        private object item1Field;

        private object item2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ПрФамилия", typeof(ФИОПрТипПрФамилия))]
        [System.Xml.Serialization.XmlElementAttribute("Фамилия", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Имя", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ПрИмя", typeof(ФИОПрТипПрИмя))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Отчество", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ПрОтчество", typeof(ФИОПрТипПрОтчество))]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public enum ФИОПрТипПрФамилия
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public enum ФИОПрТипПрИмя
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public enum ФИОПрТипПрОтчество
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

        /// <remarks/>
        НаимОрг,

        /// <remarks/>
        ФИОИП,

        /// <remarks/>
        ФИОФЛ,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class ЗапАктТип
    {

        private ОрганЗАГСТип органЗАГСField;

        private string типАГСField;

        private string наимТипЗаписField;

        private string номерЗаписField;

        private System.DateTime датаЗаписField;

        /// <remarks/>
        public ОрганЗАГСТип ОрганЗАГС
        {
            get
            {
                return this.органЗАГСField;
            }
            set
            {
                this.органЗАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ТипАГС
        {
            get
            {
                return this.типАГСField;
            }
            set
            {
                this.типАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимТипЗапис
        {
            get
            {
                return this.наимТипЗаписField;
            }
            set
            {
                this.наимТипЗаписField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерЗапис
        {
            get
            {
                return this.номерЗаписField;
            }
            set
            {
                this.номерЗаписField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаЗапис
        {
            get
            {
                return this.датаЗаписField;
            }
            set
            {
                this.датаЗаписField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class НомерТип
    {

        private string типField;

        private string номерField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Номер
        {
            get
            {
                return this.номерField;
            }
            set
            {
                this.номерField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class ТипНаимТип
    {

        private string типField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class ВидНаимТип
    {

        private string видField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Вид
        {
            get
            {
                return this.видField;
            }
            set
            {
                this.видField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class ВидНаимКодТип
    {

        private string видКодField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВидКод
        {
            get
            {
                return this.видКодField;
            }
            set
            {
                this.видКодField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class АдрФИАСТип
    {

        private string регионField;

        private ВидНаимКодТип муниципРайонField;

        private ВидНаимКодТип городСелПоселенField;

        private ВидНаимТип населенПунктField;

        private ТипНаимТип элПланСтруктурField;

        private ТипНаимТип элУлДорСетиField;

        private string земелУчастокField;

        private НомерТип[] зданиеField;

        private НомерТип помещЗданияField;

        private НомерТип помещКвартирыField;

        private string идНомField;

        private string индексField;

        /// <remarks/>
        public string Регион
        {
            get
            {
                return this.регионField;
            }
            set
            {
                this.регионField = value;
            }
        }

        /// <remarks/>
        public ВидНаимКодТип МуниципРайон
        {
            get
            {
                return this.муниципРайонField;
            }
            set
            {
                this.муниципРайонField = value;
            }
        }

        /// <remarks/>
        public ВидНаимКодТип ГородСелПоселен
        {
            get
            {
                return this.городСелПоселенField;
            }
            set
            {
                this.городСелПоселенField = value;
            }
        }

        /// <remarks/>
        public ВидНаимТип НаселенПункт
        {
            get
            {
                return this.населенПунктField;
            }
            set
            {
                this.населенПунктField = value;
            }
        }

        /// <remarks/>
        public ТипНаимТип ЭлПланСтруктур
        {
            get
            {
                return this.элПланСтруктурField;
            }
            set
            {
                this.элПланСтруктурField = value;
            }
        }

        /// <remarks/>
        public ТипНаимТип ЭлУлДорСети
        {
            get
            {
                return this.элУлДорСетиField;
            }
            set
            {
                this.элУлДорСетиField = value;
            }
        }

        /// <remarks/>
        public string ЗемелУчасток
        {
            get
            {
                return this.земелУчастокField;
            }
            set
            {
                this.земелУчастокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Здание")]
        public НомерТип[] Здание
        {
            get
            {
                return this.зданиеField;
            }
            set
            {
                this.зданиеField = value;
            }
        }

        /// <remarks/>
        public НомерТип ПомещЗдания
        {
            get
            {
                return this.помещЗданияField;
            }
            set
            {
                this.помещЗданияField = value;
            }
        }

        /// <remarks/>
        public НомерТип ПомещКвартиры
        {
            get
            {
                return this.помещКвартирыField;
            }
            set
            {
                this.помещКвартирыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдНом
        {
            get
            {
                return this.идНомField;
            }
            set
            {
                this.идНомField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Индекс
        {
            get
            {
                return this.индексField;
            }
            set
            {
                this.индексField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class АдрКЛАДРТип
    {

        private string индексField;

        private string кодРегионField;

        private string наимРегионField;

        private string районField;

        private string городField;

        private string населПунктField;

        private string улицаField;

        private string домField;

        private string корпусField;

        private string квартField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Индекс
        {
            get
            {
                return this.индексField;
            }
            set
            {
                this.индексField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодРегион
        {
            get
            {
                return this.кодРегионField;
            }
            set
            {
                this.кодРегионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимРегион
        {
            get
            {
                return this.наимРегионField;
            }
            set
            {
                this.наимРегионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Район
        {
            get
            {
                return this.районField;
            }
            set
            {
                this.районField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Город
        {
            get
            {
                return this.городField;
            }
            set
            {
                this.городField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаселПункт
        {
            get
            {
                return this.населПунктField;
            }
            set
            {
                this.населПунктField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Улица
        {
            get
            {
                return this.улицаField;
            }
            set
            {
                this.улицаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Дом
        {
            get
            {
                return this.домField;
            }
            set
            {
                this.домField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Корпус
        {
            get
            {
                return this.корпусField;
            }
            set
            {
                this.корпусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Кварт
        {
            get
            {
                return this.квартField;
            }
            set
            {
                this.квартField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class УдЛичнФЛТип
    {

        private string кодВидДокField;

        private string наимДокField;

        private string серНомДокField;

        private System.DateTime датаДокField;

        private bool датаДокFieldSpecified;

        private string выдДокField;

        private string кодВыдДокField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодВидДок
        {
            get
            {
                return this.кодВидДокField;
            }
            set
            {
                this.кодВидДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимДок
        {
            get
            {
                return this.наимДокField;
            }
            set
            {
                this.наимДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерНомДок
        {
            get
            {
                return this.серНомДокField;
            }
            set
            {
                this.серНомДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаДок
        {
            get
            {
                return this.датаДокField;
            }
            set
            {
                this.датаДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДатаДокSpecified
        {
            get
            {
                return this.датаДокFieldSpecified;
            }
            set
            {
                this.датаДокFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВыдДок
        {
            get
            {
                return this.выдДокField;
            }
            set
            {
                this.выдДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодВыдДок
        {
            get
            {
                return this.кодВыдДокField;
            }
            set
            {
                this.кодВыдДокField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class СведРодитТип
    {

        private ФИОПрТип фИОField;

        private МестоТип местоРожденField;

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        private УдЛичнФЛТип удЛичнФЛField;

        private object item1Field;

        private string оКСМField;

        private string наимСтраныField;

        /// <remarks/>
        public ФИОПрТип ФИО
        {
            get
            {
                return this.фИОField;
            }
            set
            {
                this.фИОField = value;
            }
        }

        /// <remarks/>
        public МестоТип МестоРожден
        {
            get
            {
                return this.местоРожденField;
            }
            set
            {
                this.местоРожденField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ГодРожд", typeof(string), DataType = "gYear")]
        [System.Xml.Serialization.XmlElementAttribute("ДатаРожд", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("МесГодРожд", typeof(string), DataType = "gYearMonth")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public УдЛичнФЛТип УдЛичнФЛ
        {
            get
            {
                return this.удЛичнФЛField;
            }
            set
            {
                this.удЛичнФЛField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("АдрМЖИн", typeof(СведРодитТипАдрМЖИн))]
        [System.Xml.Serialization.XmlElementAttribute("АдрМЖРФ", typeof(СведРодитТипАдрМЖРФ))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКСМ
        {
            get
            {
                return this.оКСМField;
            }
            set
            {
                this.оКСМField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class МестоТип
    {

        private string местоТекстField;

        private string кодСтраныField;

        private string наимСтраныField;

        private string регионField;

        private string наимСубъектField;

        private string районField;

        private string городField;

        private string населПунктField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string МестоТекст
        {
            get
            {
                return this.местоТекстField;
            }
            set
            {
                this.местоТекстField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодСтраны
        {
            get
            {
                return this.кодСтраныField;
            }
            set
            {
                this.кодСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Регион
        {
            get
            {
                return this.регионField;
            }
            set
            {
                this.регионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСубъект
        {
            get
            {
                return this.наимСубъектField;
            }
            set
            {
                this.наимСубъектField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Район
        {
            get
            {
                return this.районField;
            }
            set
            {
                this.районField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Город
        {
            get
            {
                return this.городField;
            }
            set
            {
                this.городField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаселПункт
        {
            get
            {
                return this.населПунктField;
            }
            set
            {
                this.населПунктField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        ГодРожд,

        /// <remarks/>
        ДатаРожд,

        /// <remarks/>
        МесГодРожд,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class СведРодитТипАдрМЖИн
    {

        private string оКСМField;

        private string наимСтраныField;

        private string адрТекстField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКСМ
        {
            get
            {
                return this.оКСМField;
            }
            set
            {
                this.оКСМField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string АдрТекст
        {
            get
            {
                return this.адрТекстField;
            }
            set
            {
                this.адрТекстField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class СведРодитТипАдрМЖРФ
    {

        private object itemField;

        private string адрРФТекстField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("АдрКЛАДР", typeof(АдрКЛАДРТип))]
        [System.Xml.Serialization.XmlElementAttribute("АдрФИАС", typeof(АдрФИАСТип))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string АдрРФТекст
        {
            get
            {
                return this.адрРФТекстField;
            }
            set
            {
                this.адрРФТекстField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/types/4.0.0")]
    public partial class СведСвидетТип
    {

        private string серияСвидетField;

        private string номерСвидетField;

        private System.DateTime датаВыдСвидетField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерияСвидет
        {
            get
            {
                return this.серияСвидетField;
            }
            set
            {
                this.серияСвидетField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерСвидет
        {
            get
            {
                return this.номерСвидетField;
            }
            set
            {
                this.номерСвидетField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВыдСвидет
        {
            get
            {
                return this.датаВыдСвидетField;
            }
            set
            {
                this.датаВыдСвидетField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    public partial class ROGDZPRequestСведРегРождСтатусЗаписи
    {

        private System.DateTime датаНачСтатусField;

        private ROGDZPRequestСведРегРождСтатусЗаписиКодСтатус кодСтатусField;

        private string наимСтатусField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаНачСтатус
        {
            get
            {
                return this.датаНачСтатусField;
            }
            set
            {
                this.датаНачСтатусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ROGDZPRequestСведРегРождСтатусЗаписиКодСтатус КодСтатус
        {
            get
            {
                return this.кодСтатусField;
            }
            set
            {
                this.кодСтатусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтатус
        {
            get
            {
                return this.наимСтатусField;
            }
            set
            {
                this.наимСтатусField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    public enum ROGDZPRequestСведРегРождСтатусЗаписиКодСтатус
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    public partial class ROGDZPRequestСведРегРождПрдСведРег
    {

        private ROGDZPRequestСведРегРождПрдСведРегСведРодившемся сведРодившемсяField;

        private СведРодитТип сведМатьField;

        private СведРодитТип сведОтецField;

        private СведДокТип сведДокРодField;

        private СведДокОснТип сведДокОснОтецField;

        private string колРодДетейField;

        /// <remarks/>
        public ROGDZPRequestСведРегРождПрдСведРегСведРодившемся СведРодившемся
        {
            get
            {
                return this.сведРодившемсяField;
            }
            set
            {
                this.сведРодившемсяField = value;
            }
        }

        /// <remarks/>
        public СведРодитТип СведМать
        {
            get
            {
                return this.сведМатьField;
            }
            set
            {
                this.сведМатьField = value;
            }
        }

        /// <remarks/>
        public СведРодитТип СведОтец
        {
            get
            {
                return this.сведОтецField;
            }
            set
            {
                this.сведОтецField = value;
            }
        }

        /// <remarks/>
        public СведДокТип СведДокРод
        {
            get
            {
                return this.сведДокРодField;
            }
            set
            {
                this.сведДокРодField = value;
            }
        }

        /// <remarks/>
        public СведДокОснТип СведДокОснОтец
        {
            get
            {
                return this.сведДокОснОтецField;
            }
            set
            {
                this.сведДокОснОтецField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string КолРодДетей
        {
            get
            {
                return this.колРодДетейField;
            }
            set
            {
                this.колРодДетейField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    public partial class ROGDZPRequestСведРегРождПрдСведРегСведРодившемся
    {

        private ФИОПрТип фИОРождField;

        private object itemField;

        private ItemChoiceType itemElementNameField;

        private МестоТип местоРожденField;

        private ROGDZPRequestСведРегРождПрдСведРегСведРодившемсяЖивМертв живМертвField;

        private ROGDZPRequestСведРегРождПрдСведРегСведРодившемсяПол полField;

        /// <remarks/>
        public ФИОПрТип ФИОРожд
        {
            get
            {
                return this.фИОРождField;
            }
            set
            {
                this.фИОРождField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ГодРожд", typeof(string), DataType = "gYear")]
        [System.Xml.Serialization.XmlElementAttribute("ДатаРожд", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("МесГодРожд", typeof(string), DataType = "gYearMonth")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public МестоТип МестоРожден
        {
            get
            {
                return this.местоРожденField;
            }
            set
            {
                this.местоРожденField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ROGDZPRequestСведРегРождПрдСведРегСведРодившемсяЖивМертв ЖивМертв
        {
            get
            {
                return this.живМертвField;
            }
            set
            {
                this.живМертвField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ROGDZPRequestСведРегРождПрдСведРегСведРодившемсяПол Пол
        {
            get
            {
                return this.полField;
            }
            set
            {
                this.полField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        ГодРожд,

        /// <remarks/>
        ДатаРожд,

        /// <remarks/>
        МесГодРожд,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    public enum ROGDZPRequestСведРегРождПрдСведРегСведРодившемсяЖивМертв
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    public enum ROGDZPRequestСведРегРождПрдСведРегСведРодившемсяПол
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0", IsNullable = false)]
    public partial class ROGDZPResponse
    {

        private string идСведField;

        private ROGDZPResponseКодОбр кодОбрField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдСвед
        {
            get
            {
                return this.идСведField;
            }
            set
            {
                this.идСведField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ROGDZPResponseКодОбр КодОбр
        {
            get
            {
                return this.кодОбрField;
            }
            set
            {
                this.кодОбрField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-rogdzp/root/112-23/4.0.0")]
    public enum ROGDZPResponseКодОбр
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
}

public class VS01284v001_TABL00
/* Сведения из ЕГР ЗАГС о государственной регистрации перемены имени 
 * VS01284v001_TABL00
 * Версия 4.0.0
 */
{
    public string vs_name = "Сведения из ЕГР ЗАГС о государственной регистрации перемены имени";
    public string vs_mnemo = "VS01284v001_TABL00";
    public string vs_version = "4.0.0";

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0", IsNullable = false)]
    public partial class PERNAMEZPRequest
    {

        private PERNAMEZPRequestСведРегПерИмя[] сведРегПерИмяField;

        private string идСведField;

        private System.DateTime датаСведField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведРегПерИмя")]
        public PERNAMEZPRequestСведРегПерИмя[] СведРегПерИмя
        {
            get
            {
                return this.сведРегПерИмяField;
            }
            set
            {
                this.сведРегПерИмяField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдСвед
        {
            get
            {
                return this.идСведField;
            }
            set
            {
                this.идСведField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаСвед
        {
            get
            {
                return this.датаСведField;
            }
            set
            {
                this.датаСведField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    public partial class PERNAMEZPRequestСведРегПерИмя
    {

        private ОрганЗАГСТип органЗАГСField;

        private PERNAMEZPRequestСведРегПерИмяСтатусЗаписи статусЗаписиField;

        private СведСвидетТип[] сведСвидетField;

        private PERNAMEZPRequestСведРегПерИмяПрдСведРег прдСведРегField;

        private СведИспрАГСТип[] сведИспрАГСField;

        private string номерЗаписField;

        private System.DateTime датаЗаписField;

        /// <remarks/>
        public ОрганЗАГСТип ОрганЗАГС
        {
            get
            {
                return this.органЗАГСField;
            }
            set
            {
                this.органЗАГСField = value;
            }
        }

        /// <remarks/>
        public PERNAMEZPRequestСведРегПерИмяСтатусЗаписи СтатусЗаписи
        {
            get
            {
                return this.статусЗаписиField;
            }
            set
            {
                this.статусЗаписиField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведСвидет")]
        public СведСвидетТип[] СведСвидет
        {
            get
            {
                return this.сведСвидетField;
            }
            set
            {
                this.сведСвидетField = value;
            }
        }

        /// <remarks/>
        public PERNAMEZPRequestСведРегПерИмяПрдСведРег ПрдСведРег
        {
            get
            {
                return this.прдСведРегField;
            }
            set
            {
                this.прдСведРегField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("СведИспрАГС")]
        public СведИспрАГСТип[] СведИспрАГС
        {
            get
            {
                return this.сведИспрАГСField;
            }
            set
            {
                this.сведИспрАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерЗапис
        {
            get
            {
                return this.номерЗаписField;
            }
            set
            {
                this.номерЗаписField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаЗапис
        {
            get
            {
                return this.датаЗаписField;
            }
            set
            {
                this.датаЗаписField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class ОрганЗАГСТип
    {

        private string наимЗАГСField;

        private string кодЗАГСField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимЗАГС
        {
            get
            {
                return this.наимЗАГСField;
            }
            set
            {
                this.наимЗАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодЗАГС
        {
            get
            {
                return this.кодЗАГСField;
            }
            set
            {
                this.кодЗАГСField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class СведДокТип
    {

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        private string кодДокField;

        private string наимДокField;

        private string серНомДокField;

        private System.DateTime датаДокField;

        private bool датаДокFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("НаимОрг", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ФИОИП", typeof(ФИОПрТип))]
        [System.Xml.Serialization.XmlElementAttribute("ФИОФЛ", typeof(ФИОПрТип))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодДок
        {
            get
            {
                return this.кодДокField;
            }
            set
            {
                this.кодДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимДок
        {
            get
            {
                return this.наимДокField;
            }
            set
            {
                this.наимДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерНомДок
        {
            get
            {
                return this.серНомДокField;
            }
            set
            {
                this.серНомДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаДок
        {
            get
            {
                return this.датаДокField;
            }
            set
            {
                this.датаДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДатаДокSpecified
        {
            get
            {
                return this.датаДокFieldSpecified;
            }
            set
            {
                this.датаДокFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class ФИОПрТип
    {

        private object itemField;

        private object item1Field;

        private object item2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ПрФамилия", typeof(ФИОПрТипПрФамилия))]
        [System.Xml.Serialization.XmlElementAttribute("Фамилия", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Имя", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ПрИмя", typeof(ФИОПрТипПрИмя))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Отчество", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ПрОтчество", typeof(ФИОПрТипПрОтчество))]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public enum ФИОПрТипПрФамилия
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public enum ФИОПрТипПрИмя
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public enum ФИОПрТипПрОтчество
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        НаимОрг,

        /// <remarks/>
        ФИОИП,

        /// <remarks/>
        ФИОФЛ,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class СведДокОснТип
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ДокОсн", typeof(СведДокТип))]
        [System.Xml.Serialization.XmlElementAttribute("ЗапАктОсн", typeof(ЗапАктТип))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class ЗапАктТип
    {

        private ОрганЗАГСТип органЗАГСField;

        private string типАГСField;

        private string наимТипЗаписField;

        private string номерЗаписField;

        private System.DateTime датаЗаписField;

        /// <remarks/>
        public ОрганЗАГСТип ОрганЗАГС
        {
            get
            {
                return this.органЗАГСField;
            }
            set
            {
                this.органЗАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ТипАГС
        {
            get
            {
                return this.типАГСField;
            }
            set
            {
                this.типАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимТипЗапис
        {
            get
            {
                return this.наимТипЗаписField;
            }
            set
            {
                this.наимТипЗаписField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерЗапис
        {
            get
            {
                return this.номерЗаписField;
            }
            set
            {
                this.номерЗаписField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаЗапис
        {
            get
            {
                return this.датаЗаписField;
            }
            set
            {
                this.датаЗаписField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class СведИспрАГСТип
    {

        private СведДокОснТип сведДокИспрАГСField;

        private System.DateTime датаВнесИспрField;

        private string содержИспрField;

        /// <remarks/>
        public СведДокОснТип СведДокИспрАГС
        {
            get
            {
                return this.сведДокИспрАГСField;
            }
            set
            {
                this.сведДокИспрАГСField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВнесИспр
        {
            get
            {
                return this.датаВнесИспрField;
            }
            set
            {
                this.датаВнесИспрField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СодержИспр
        {
            get
            {
                return this.содержИспрField;
            }
            set
            {
                this.содержИспрField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class УдЛичнФЛТип
    {

        private string кодВидДокField;

        private string наимДокField;

        private string серНомДокField;

        private System.DateTime датаДокField;

        private bool датаДокFieldSpecified;

        private string выдДокField;

        private string кодВыдДокField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодВидДок
        {
            get
            {
                return this.кодВидДокField;
            }
            set
            {
                this.кодВидДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимДок
        {
            get
            {
                return this.наимДокField;
            }
            set
            {
                this.наимДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерНомДок
        {
            get
            {
                return this.серНомДокField;
            }
            set
            {
                this.серНомДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаДок
        {
            get
            {
                return this.датаДокField;
            }
            set
            {
                this.датаДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДатаДокSpecified
        {
            get
            {
                return this.датаДокFieldSpecified;
            }
            set
            {
                this.датаДокFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВыдДок
        {
            get
            {
                return this.выдДокField;
            }
            set
            {
                this.выдДокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодВыдДок
        {
            get
            {
                return this.кодВыдДокField;
            }
            set
            {
                this.кодВыдДокField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class НомерТип
    {

        private string типField;

        private string номерField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Номер
        {
            get
            {
                return this.номерField;
            }
            set
            {
                this.номерField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class ТипНаимТип
    {

        private string типField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Тип
        {
            get
            {
                return this.типField;
            }
            set
            {
                this.типField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class ВидНаимТип
    {

        private string видField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Вид
        {
            get
            {
                return this.видField;
            }
            set
            {
                this.видField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class ВидНаимКодТип
    {

        private string видКодField;

        private string наимField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ВидКод
        {
            get
            {
                return this.видКодField;
            }
            set
            {
                this.видКодField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Наим
        {
            get
            {
                return this.наимField;
            }
            set
            {
                this.наимField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class АдрФИАСТип
    {

        private string регионField;

        private ВидНаимКодТип муниципРайонField;

        private ВидНаимКодТип городСелПоселенField;

        private ВидНаимТип населенПунктField;

        private ТипНаимТип элПланСтруктурField;

        private ТипНаимТип элУлДорСетиField;

        private string земелУчастокField;

        private НомерТип[] зданиеField;

        private НомерТип помещЗданияField;

        private НомерТип помещКвартирыField;

        private string идНомField;

        private string индексField;

        /// <remarks/>
        public string Регион
        {
            get
            {
                return this.регионField;
            }
            set
            {
                this.регионField = value;
            }
        }

        /// <remarks/>
        public ВидНаимКодТип МуниципРайон
        {
            get
            {
                return this.муниципРайонField;
            }
            set
            {
                this.муниципРайонField = value;
            }
        }

        /// <remarks/>
        public ВидНаимКодТип ГородСелПоселен
        {
            get
            {
                return this.городСелПоселенField;
            }
            set
            {
                this.городСелПоселенField = value;
            }
        }

        /// <remarks/>
        public ВидНаимТип НаселенПункт
        {
            get
            {
                return this.населенПунктField;
            }
            set
            {
                this.населенПунктField = value;
            }
        }

        /// <remarks/>
        public ТипНаимТип ЭлПланСтруктур
        {
            get
            {
                return this.элПланСтруктурField;
            }
            set
            {
                this.элПланСтруктурField = value;
            }
        }

        /// <remarks/>
        public ТипНаимТип ЭлУлДорСети
        {
            get
            {
                return this.элУлДорСетиField;
            }
            set
            {
                this.элУлДорСетиField = value;
            }
        }

        /// <remarks/>
        public string ЗемелУчасток
        {
            get
            {
                return this.земелУчастокField;
            }
            set
            {
                this.земелУчастокField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Здание")]
        public НомерТип[] Здание
        {
            get
            {
                return this.зданиеField;
            }
            set
            {
                this.зданиеField = value;
            }
        }

        /// <remarks/>
        public НомерТип ПомещЗдания
        {
            get
            {
                return this.помещЗданияField;
            }
            set
            {
                this.помещЗданияField = value;
            }
        }

        /// <remarks/>
        public НомерТип ПомещКвартиры
        {
            get
            {
                return this.помещКвартирыField;
            }
            set
            {
                this.помещКвартирыField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдНом
        {
            get
            {
                return this.идНомField;
            }
            set
            {
                this.идНомField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Индекс
        {
            get
            {
                return this.индексField;
            }
            set
            {
                this.индексField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class АдрКЛАДРТип
    {

        private string индексField;

        private string кодРегионField;

        private string наимРегионField;

        private string районField;

        private string городField;

        private string населПунктField;

        private string улицаField;

        private string домField;

        private string корпусField;

        private string квартField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Индекс
        {
            get
            {
                return this.индексField;
            }
            set
            {
                this.индексField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодРегион
        {
            get
            {
                return this.кодРегионField;
            }
            set
            {
                this.кодРегионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимРегион
        {
            get
            {
                return this.наимРегионField;
            }
            set
            {
                this.наимРегионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Район
        {
            get
            {
                return this.районField;
            }
            set
            {
                this.районField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Город
        {
            get
            {
                return this.городField;
            }
            set
            {
                this.городField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаселПункт
        {
            get
            {
                return this.населПунктField;
            }
            set
            {
                this.населПунктField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Улица
        {
            get
            {
                return this.улицаField;
            }
            set
            {
                this.улицаField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Дом
        {
            get
            {
                return this.домField;
            }
            set
            {
                this.домField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Корпус
        {
            get
            {
                return this.корпусField;
            }
            set
            {
                this.корпусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Кварт
        {
            get
            {
                return this.квартField;
            }
            set
            {
                this.квартField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class МестоТип
    {

        private string местоТекстField;

        private string кодСтраныField;

        private string наимСтраныField;

        private string регионField;

        private string наимСубъектField;

        private string районField;

        private string городField;

        private string населПунктField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string МестоТекст
        {
            get
            {
                return this.местоТекстField;
            }
            set
            {
                this.местоТекстField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string КодСтраны
        {
            get
            {
                return this.кодСтраныField;
            }
            set
            {
                this.кодСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Регион
        {
            get
            {
                return this.регионField;
            }
            set
            {
                this.регионField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСубъект
        {
            get
            {
                return this.наимСубъектField;
            }
            set
            {
                this.наимСубъектField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Район
        {
            get
            {
                return this.районField;
            }
            set
            {
                this.районField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Город
        {
            get
            {
                return this.городField;
            }
            set
            {
                this.городField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаселПункт
        {
            get
            {
                return this.населПунктField;
            }
            set
            {
                this.населПунктField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/types/4.0.0")]
    public partial class СведСвидетТип
    {

        private string серияСвидетField;

        private string номерСвидетField;

        private System.DateTime датаВыдСвидетField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string СерияСвидет
        {
            get
            {
                return this.серияСвидетField;
            }
            set
            {
                this.серияСвидетField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НомерСвидет
        {
            get
            {
                return this.номерСвидетField;
            }
            set
            {
                this.номерСвидетField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаВыдСвидет
        {
            get
            {
                return this.датаВыдСвидетField;
            }
            set
            {
                this.датаВыдСвидетField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    public partial class PERNAMEZPRequestСведРегПерИмяСтатусЗаписи
    {

        private System.DateTime датаНачСтатусField;

        private PERNAMEZPRequestСведРегПерИмяСтатусЗаписиКодСтатус кодСтатусField;

        private string наимСтатусField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ДатаНачСтатус
        {
            get
            {
                return this.датаНачСтатусField;
            }
            set
            {
                this.датаНачСтатусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PERNAMEZPRequestСведРегПерИмяСтатусЗаписиКодСтатус КодСтатус
        {
            get
            {
                return this.кодСтатусField;
            }
            set
            {
                this.кодСтатусField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтатус
        {
            get
            {
                return this.наимСтатусField;
            }
            set
            {
                this.наимСтатусField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    public enum PERNAMEZPRequestСведРегПерИмяСтатусЗаписиКодСтатус
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    public partial class PERNAMEZPRequestСведРегПерИмяПрдСведРег
    {

        private ФИОПрТип фИОДоField;

        private ФИОПрТип фИОПослеField;

        private object itemField;

        private ItemChoiceType itemElementNameField;

        private МестоТип местоРожденField;

        private object item1Field;

        private УдЛичнФЛТип удЛичнФЛField;

        private ЗапАктТип сведРегРождField;

        private string оКСМField;

        private string наимСтраныField;

        /// <remarks/>
        public ФИОПрТип ФИОДо
        {
            get
            {
                return this.фИОДоField;
            }
            set
            {
                this.фИОДоField = value;
            }
        }

        /// <remarks/>
        public ФИОПрТип ФИОПосле
        {
            get
            {
                return this.фИОПослеField;
            }
            set
            {
                this.фИОПослеField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ГодРожд", typeof(string), DataType = "gYear")]
        [System.Xml.Serialization.XmlElementAttribute("ДатаРожд", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("МесГодРожд", typeof(string), DataType = "gYearMonth")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public МестоТип МестоРожден
        {
            get
            {
                return this.местоРожденField;
            }
            set
            {
                this.местоРожденField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("АдрМЖИн", typeof(PERNAMEZPRequestСведРегПерИмяПрдСведРегАдрМЖИн))]
        [System.Xml.Serialization.XmlElementAttribute("АдрМЖРФ", typeof(PERNAMEZPRequestСведРегПерИмяПрдСведРегАдрМЖРФ))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        public УдЛичнФЛТип УдЛичнФЛ
        {
            get
            {
                return this.удЛичнФЛField;
            }
            set
            {
                this.удЛичнФЛField = value;
            }
        }

        /// <remarks/>
        public ЗапАктТип СведРегРожд
        {
            get
            {
                return this.сведРегРождField;
            }
            set
            {
                this.сведРегРождField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКСМ
        {
            get
            {
                return this.оКСМField;
            }
            set
            {
                this.оКСМField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        ГодРожд,

        /// <remarks/>
        ДатаРожд,

        /// <remarks/>
        МесГодРожд,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    public partial class PERNAMEZPRequestСведРегПерИмяПрдСведРегАдрМЖИн
    {

        private string оКСМField;

        private string наимСтраныField;

        private string адрТекстField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ОКСМ
        {
            get
            {
                return this.оКСМField;
            }
            set
            {
                this.оКСМField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string НаимСтраны
        {
            get
            {
                return this.наимСтраныField;
            }
            set
            {
                this.наимСтраныField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string АдрТекст
        {
            get
            {
                return this.адрТекстField;
            }
            set
            {
                this.адрТекстField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    public partial class PERNAMEZPRequestСведРегПерИмяПрдСведРегАдрМЖРФ
    {

        private object itemField;

        private string адрРФТекстField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("АдрКЛАДР", typeof(АдрКЛАДРТип))]
        [System.Xml.Serialization.XmlElementAttribute("АдрФИАС", typeof(АдрФИАСТип))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string АдрРФТекст
        {
            get
            {
                return this.адрРФТекстField;
            }
            set
            {
                this.адрРФТекстField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0", IsNullable = false)]
    public partial class PERNAMEZPResponse
    {

        private string идСведField;

        private PERNAMEZPResponseКодОбр кодОбрField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ИдСвед
        {
            get
            {
                return this.идСведField;
            }
            set
            {
                this.идСведField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PERNAMEZPResponseКодОбр КодОбр
        {
            get
            {
                return this.кодОбрField;
            }
            set
            {
                this.кодОбрField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-zags-pernamezp/root/112-24/4.0.0")]
    public enum PERNAMEZPResponseКодОбр
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
}

public class VS00648v001_PFR001
/* Сведение «Предоставление страхового номера индивидуального лицевого счёта (СНИЛС) застрахованного лица 
 * с учётом дополнительных сведений о месте рождения, документе, удостоверяющем личность» ID вида сведений в ФРГУ
 * VS00648v001_PFR001
 * Версия 1.0.1
 */
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://kvs.pfr.com/snils-by-additionalData/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://kvs.pfr.com/snils-by-additionalData/1.0.1", IsNullable = false)]
    public partial class SnilsByAdditionalDataRequest
    {

        private string familyNameField;

        private string firstNameField;

        private string patronymicField;

        private System.DateTime birthDateField;

        private GenderType genderField;

        private BirthPlaceType birthPlaceField;

        private object itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string Patronymic
        {
            get
            {
                return this.patronymicField;
            }
            set
            {
                this.patronymicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        public GenderType Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public BirthPlaceType BirthPlace
        {
            get
            {
                return this.birthPlaceField;
            }
            set
            {
                this.birthPlaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PfrIdentificationDocument", typeof(IdentificationDocumentType), Namespace = "http://common.kvs.pfr.com/1.0.0")]
        [System.Xml.Serialization.XmlElementAttribute("BirthCertificate", typeof(SovietPassportType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("DrivingLicenseRF", typeof(DrivingLicenseRFType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Form9Certificate", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("InternationalPassportRF", typeof(InternationalPassportRFType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("MilitaryPassport", typeof(MilitaryPassportDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("PassportLossCertificate", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ReleaseCertificate", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("SailorPassport", typeof(MilitaryPassportDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("SovietPassport", typeof(SovietPassportType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("TemporaryIdentityCardRF", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://common.kvs.pfr.com/1.0.0")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    public enum GenderType
    {

        /// <remarks/>
        Male,

        /// <remarks/>
        Female,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://common.kvs.pfr.com/1.0.0")]
    public partial class BirthPlaceType
    {

        private string placeTypeField;

        private string settlementField;

        private string districtField;

        private string regionField;

        private string countryField;

        /// <remarks/>
        public string PlaceType
        {
            get
            {
                return this.placeTypeField;
            }
            set
            {
                this.placeTypeField = value;
            }
        }

        /// <remarks/>
        public string Settlement
        {
            get
            {
                return this.settlementField;
            }
            set
            {
                this.settlementField = value;
            }
        }

        /// <remarks/>
        public string District
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }

        /// <remarks/>
        public string Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://common.kvs.pfr.com/1.0.0")]
    public partial class IdentificationDocumentType
    {

        private string typeField;

        private NotRestrictedDocumentType documentField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public NotRestrictedDocumentType Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ForeignPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class NotRestrictedDocumentType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("DrivingLicenseRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class DrivingLicenseRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("SovietPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class SovietPassportType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("MilitaryPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class MilitaryPassportDocumentType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ResidencePermitRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class InternationalPassportRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("PassportRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class PassportRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://common.kvs.pfr.com/1.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        PfrIdentificationDocument,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:BirthCertificate")]
        BirthCertificate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:DrivingLicenseRF")]
        DrivingLicenseRF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:ForeignPassport")]
        ForeignPassport,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:Form9Certificate")]
        Form9Certificate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:InternationalPassportRF" +
            "")]
        InternationalPassportRF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:MilitaryPassport")]
        MilitaryPassport,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:PassportLossCertificate" +
            "")]
        PassportLossCertificate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:PassportRF")]
        PassportRF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:ReleaseCertificate")]
        ReleaseCertificate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:ResidencePermitRF")]
        ResidencePermitRF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:SailorPassport")]
        SailorPassport,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:SovietPassport")]
        SovietPassport,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:TemporaryIdentityCardRF" +
            "")]
        TemporaryIdentityCardRF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://kvs.pfr.com/snils-by-additionalData/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://kvs.pfr.com/snils-by-additionalData/1.0.1", IsNullable = false)]
    public partial class SnilsByAdditionalDataResponse
    {

        private string familyNameField;

        private string firstNameField;

        private string patronymicField;

        private string snilsField;

        private System.DateTime birthDateField;

        private GenderType genderField;

        private BirthPlaceType birthPlaceField;

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string Patronymic
        {
            get
            {
                return this.patronymicField;
            }
            set
            {
                this.patronymicField = value;
            }
        }

        /// <remarks/>
        public string Snils
        {
            get
            {
                return this.snilsField;
            }
            set
            {
                this.snilsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        public GenderType Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public BirthPlaceType BirthPlace
        {
            get
            {
                return this.birthPlaceField;
            }
            set
            {
                this.birthPlaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PfrIdentificationDocument", typeof(IdentificationDocumentType), Namespace = "http://common.kvs.pfr.com/1.0.0")]
        [System.Xml.Serialization.XmlElementAttribute("BirthCertificate", typeof(SovietPassportType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("DrivingLicenseRF", typeof(DrivingLicenseRFType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Form9Certificate", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("InternationalPassportRF", typeof(InternationalPassportRFType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("MilitaryPassport", typeof(MilitaryPassportDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("PassportLossCertificate", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ReleaseCertificate", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("SailorPassport", typeof(MilitaryPassportDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("SovietPassport", typeof(SovietPassportType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("TemporaryIdentityCardRF", typeof(NotRestrictedDocumentType), Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://common.kvs.pfr.com/1.0.0")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://common.kvs.pfr.com/1.0.0", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        PfrIdentificationDocument,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:BirthCertificate")]
        BirthCertificate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:DrivingLicenseRF")]
        DrivingLicenseRF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:ForeignPassport")]
        ForeignPassport,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:Form9Certificate")]
        Form9Certificate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:InternationalPassportRF" +
            "")]
        InternationalPassportRF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:MilitaryPassport")]
        MilitaryPassport,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:PassportLossCertificate" +
            "")]
        PassportLossCertificate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:PassportRF")]
        PassportRF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:ReleaseCertificate")]
        ReleaseCertificate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:ResidencePermitRF")]
        ResidencePermitRF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:SailorPassport")]
        SailorPassport,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:SovietPassport")]
        SovietPassport,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1:TemporaryIdentityCardRF" +
            "")]
        TemporaryIdentityCardRF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("AttachmentRef", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class AttachmentRefType
    {

        private string attachmentIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attachmentId
        {
            get
            {
                return this.attachmentIdField;
            }
            set
            {
                this.attachmentIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("PrimaryIdentityDocument", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class PrimaryIdentityDocumentType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("IdentityDocument", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class AnyIdentityDocumentType
    {

        private object itemField;

        private ItemChoiceType2 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BirthCertificate", typeof(SovietPassportType))]
        [System.Xml.Serialization.XmlElementAttribute("DrivingLicenseRF", typeof(DrivingLicenseRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("Form9Certificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("InternationalPassportRF", typeof(InternationalPassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("MilitaryPassport", typeof(MilitaryPassportDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportLossCertificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ReleaseCertificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("SailorPassport", typeof(MilitaryPassportDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("SovietPassport", typeof(SovietPassportType))]
        [System.Xml.Serialization.XmlElementAttribute("TemporaryIdentityCardRF", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

        /// <remarks/>
        BirthCertificate,

        /// <remarks/>
        DrivingLicenseRF,

        /// <remarks/>
        ForeignPassport,

        /// <remarks/>
        Form9Certificate,

        /// <remarks/>
        InternationalPassportRF,

        /// <remarks/>
        MilitaryPassport,

        /// <remarks/>
        PassportLossCertificate,

        /// <remarks/>
        PassportRF,

        /// <remarks/>
        ReleaseCertificate,

        /// <remarks/>
        ResidencePermitRF,

        /// <remarks/>
        SailorPassport,

        /// <remarks/>
        SovietPassport,

        /// <remarks/>
        TemporaryIdentityCardRF,
    }
}

/// <summary>
/// Выписка сведений об инвалиде
/// https://smev3.gosuslugi.ru/portal/inquirytype_one.jsp?id=41140&zone=fed&page=1&dTest=false
/// Версия 1.0.3
/// Тип запроса - Запрос
/// Namespace URI - http://kvs.fri.com/extraction-invalid-data/1.0.3
/// Версия МР - 3.0
/// </summary>
public class VS00291v004_PFRF01
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://kvs.fri.com/extraction-invalid-data/1.0.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/1.0.3", IsNullable = false)]
    public partial class ExtractionInvalidDataRequest
    {

        private string sNILSField;

        private ExtractionInvalidDataRequestTypeOfExtraction typeOfExtractionField;

        private ExtractionPeriodType extractionPeriodField;

        /// <remarks/>
        public string SNILS
        {
            get
            {
                return this.sNILSField;
            }
            set
            {
                this.sNILSField = value;
            }
        }

        /// <remarks/>
        public ExtractionInvalidDataRequestTypeOfExtraction TypeOfExtraction
        {
            get
            {
                return this.typeOfExtractionField;
            }
            set
            {
                this.typeOfExtractionField = value;
            }
        }

        /// <remarks/>
        public ExtractionPeriodType ExtractionPeriod
        {
            get
            {
                return this.extractionPeriodField;
            }
            set
            {
                this.extractionPeriodField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://kvs.fri.com/extraction-invalid-data/1.0.3")]
    public enum ExtractionInvalidDataRequestTypeOfExtraction
    {

        /// <remarks/>
        Stable,

        /// <remarks/>
        Flexible,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/1.0.3")]
    public partial class ExtractionPeriodType
    {

        private System.DateTime documentsValidOnDateField;

        private bool documentsValidOnDateFieldSpecified;

        private PeriodType documentsOnPeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DocumentsValidOnDate
        {
            get
            {
                return this.documentsValidOnDateField;
            }
            set
            {
                this.documentsValidOnDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocumentsValidOnDateSpecified
        {
            get
            {
                return this.documentsValidOnDateFieldSpecified;
            }
            set
            {
                this.documentsValidOnDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PeriodType DocumentsOnPeriod
        {
            get
            {
                return this.documentsOnPeriodField;
            }
            set
            {
                this.documentsOnPeriodField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/1.0.3")]
    public partial class PeriodType
    {

        private System.DateTime dateFromField;

        private System.DateTime dateToField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/attachments/1.0.0")]
    public partial class _StructuredAttachmentFormatType1
    {

        private bool isUnstructuredFormatField;

        private bool isZippedPacketField;

        private string documentTypeField;

        private string familyNameField;

        private string firstNameField;

        private string patronymicField;

        private string snilsField;

        /// <remarks/>
        public bool IsUnstructuredFormat
        {
            get
            {
                return this.isUnstructuredFormatField;
            }
            set
            {
                this.isUnstructuredFormatField = value;
            }
        }

        /// <remarks/>
        public bool IsZippedPacket
        {
            get
            {
                return this.isZippedPacketField;
            }
            set
            {
                this.isZippedPacketField = value;
            }
        }

        /// <remarks/>
        public string DocumentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
        public string Patronymic
        {
            get
            {
                return this.patronymicField;
            }
            set
            {
                this.patronymicField = value;
            }
        }

        /// <remarks/>
        public string Snils
        {
            get
            {
                return this.snilsField;
            }
            set
            {
                this.snilsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/attachments/1.0.0")]
    public partial class _AttachmentDescriptionType
    {

        private object itemField;

        private _StructuredAttachmentFormatType1 attachmentFormat1Field;

        private string attachmentSignatureFSLinkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentFSLink", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("IsMTOMAttachmentContent", typeof(bool))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public _StructuredAttachmentFormatType1 AttachmentFormat1
        {
            get
            {
                return this.attachmentFormat1Field;
            }
            set
            {
                this.attachmentFormat1Field = value;
            }
        }

        /// <remarks/>
        public string AttachmentSignatureFSLink
        {
            get
            {
                return this.attachmentSignatureFSLinkField;
            }
            set
            {
                this.attachmentSignatureFSLinkField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://kvs.fri.com/extraction-invalid-data/1.0.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/1.0.3", IsNullable = false)]
    public partial class ExtractionInvalidDataResponse
    {

        private _AttachmentDescriptionType attachmentsBlockField;

        /// <remarks/>
        public _AttachmentDescriptionType AttachmentsBlock
        {
            get
            {
                return this.attachmentsBlockField;
            }
            set
            {
                this.attachmentsBlockField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("AttachmentRef", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class AttachmentRefType
    {

        private string attachmentIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attachmentId
        {
            get
            {
                return this.attachmentIdField;
            }
            set
            {
                this.attachmentIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("PrimaryIdentityDocument", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class PrimaryIdentityDocumentType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ForeignPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class NotRestrictedDocumentType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("PassportRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class PassportRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ResidencePermitRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class InternationalPassportRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("IdentityDocument", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class AnyIdentityDocumentType
    {

        private object itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BirthCertificate", typeof(SovietPassportType))]
        [System.Xml.Serialization.XmlElementAttribute("DrivingLicenseRF", typeof(DrivingLicenseRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ForeignPassport", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("Form9Certificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("InternationalPassportRF", typeof(InternationalPassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("MilitaryPassport", typeof(MilitaryPassportDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportLossCertificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("PassportRF", typeof(PassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("ReleaseCertificate", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("ResidencePermitRF", typeof(InternationalPassportRFType))]
        [System.Xml.Serialization.XmlElementAttribute("SailorPassport", typeof(MilitaryPassportDocumentType))]
        [System.Xml.Serialization.XmlElementAttribute("SovietPassport", typeof(SovietPassportType))]
        [System.Xml.Serialization.XmlElementAttribute("TemporaryIdentityCardRF", typeof(NotRestrictedDocumentType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("SovietPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class SovietPassportType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("DrivingLicenseRF", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class DrivingLicenseRFType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("MilitaryPassport", Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IsNullable = false)]
    public partial class MilitaryPassportDocumentType
    {

        private string seriesField;

        private string numberField;

        private System.DateTime issueDateField;

        private string issuerField;

        /// <remarks/>
        public string Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/supplementary/commons/1.0.1", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        BirthCertificate,

        /// <remarks/>
        DrivingLicenseRF,

        /// <remarks/>
        ForeignPassport,

        /// <remarks/>
        Form9Certificate,

        /// <remarks/>
        InternationalPassportRF,

        /// <remarks/>
        MilitaryPassport,

        /// <remarks/>
        PassportLossCertificate,

        /// <remarks/>
        PassportRF,

        /// <remarks/>
        ReleaseCertificate,

        /// <remarks/>
        ResidencePermitRF,

        /// <remarks/>
        SailorPassport,

        /// <remarks/>
        SovietPassport,

        /// <remarks/>
        TemporaryIdentityCardRF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://kvs.fri.com/extraction-invalid-data/attachments/1.0.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/attachments/1.0.0", IsNullable = false)]
    public partial class RegistryExampleRequest
    {

        private _RegistryBlockType registryBlockField;

        private _AttachmentsBlockType attachmentsBlockField;

        /// <remarks/>
        public _RegistryBlockType RegistryBlock
        {
            get
            {
                return this.registryBlockField;
            }
            set
            {
                this.registryBlockField = value;
            }
        }

        /// <remarks/>
        public _AttachmentsBlockType AttachmentsBlock
        {
            get
            {
                return this.attachmentsBlockField;
            }
            set
            {
                this.attachmentsBlockField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/attachments/1.0.0")]
    public partial class _RegistryBlockType
    {

        private _RegistryRecordType registryRecordField;

        /// <remarks/>
        public _RegistryRecordType RegistryRecord
        {
            get
            {
                return this.registryRecordField;
            }
            set
            {
                this.registryRecordField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/attachments/1.0.0")]
    public partial class _RegistryRecordType
    {

        private string registryRecordIDField;

        private _AttachmentsBlockType attachmentsBlockField;

        private string documentNumberField;

        private System.DateTime documentDateField;

        private string documentOriginatorField;

        private int documentAttachmentsAmountField;

        /// <remarks/>
        public string RegistryRecordID
        {
            get
            {
                return this.registryRecordIDField;
            }
            set
            {
                this.registryRecordIDField = value;
            }
        }

        /// <remarks/>
        public _AttachmentsBlockType AttachmentsBlock
        {
            get
            {
                return this.attachmentsBlockField;
            }
            set
            {
                this.attachmentsBlockField = value;
            }
        }

        /// <remarks/>
        public string DocumentNumber
        {
            get
            {
                return this.documentNumberField;
            }
            set
            {
                this.documentNumberField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DocumentDate
        {
            get
            {
                return this.documentDateField;
            }
            set
            {
                this.documentDateField = value;
            }
        }

        /// <remarks/>
        public string DocumentOriginator
        {
            get
            {
                return this.documentOriginatorField;
            }
            set
            {
                this.documentOriginatorField = value;
            }
        }

        /// <remarks/>
        public int DocumentAttachmentsAmount
        {
            get
            {
                return this.documentAttachmentsAmountField;
            }
            set
            {
                this.documentAttachmentsAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://kvs.fri.com/extraction-invalid-data/attachments/1.0.0")]
    public partial class _AttachmentsBlockType
    {

        private _AttachmentDescriptionType attachmentDescriptionField;

        /// <remarks/>
        public _AttachmentDescriptionType AttachmentDescription
        {
            get
            {
                return this.attachmentDescriptionField;
            }
            set
            {
                this.attachmentDescriptionField = value;
            }
        }
    }
}



//Формируется из импортированного wsdl
//Обязательно указать  для AdapterMessage 
//[XmlRootAttribute("OrderStatusEventRequest", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsNullable = false, ElementName = "AdapterMessage")]
public class adapterSmev1_2
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class SystemFault : Fault
    {
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(ValidationFault))]
    [XmlIncludeAttribute(typeof(SystemFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class Fault : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private string descriptionField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Status : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private string descriptionField;

        private StatusParameter[] parameterField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("parameter", IsNullable = true, Order = 2)]
        public StatusParameter[] parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusParameter : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Reject : object, System.ComponentModel.INotifyPropertyChanged
    {

        private RejectCode codeField;

        private string descriptionField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public RejectCode code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum RejectCode
    {

        /// <remarks/>
        ACCESS_DENIED,

        /// <remarks/>
        NO_DATA,

        /// <remarks/>
        UNKNOWN_REQUEST_DESCRIPTION,

        /// <remarks/>
        FAILURE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseContentType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Content contentField;

        private Reject[] rejectsField;

        private Status statusField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public Content content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("rejects", IsNullable = true, Order = 1)]
        public Reject[] rejects
        {
            get
            {
                return this.rejectsField;
            }
            set
            {
                this.rejectsField = value;
                this.RaisePropertyChanged("rejects");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public Status status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Content : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement messagePrimaryContentField;

        private System.Xml.XmlElement personalSignatureField;

        private AttachmentHeaderType[] attachmentHeaderListField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public System.Xml.XmlElement MessagePrimaryContent
        {
            get
            {
                return this.messagePrimaryContentField;
            }
            set
            {
                this.messagePrimaryContentField = value;
                this.RaisePropertyChanged("MessagePrimaryContent");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public System.Xml.XmlElement PersonalSignature
        {
            get
            {
                return this.personalSignatureField;
            }
            set
            {
                this.personalSignatureField = value;
                this.RaisePropertyChanged("PersonalSignature");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("AttachmentHeader", IsNullable = false)]
        public AttachmentHeaderType[] AttachmentHeaderList
        {
            get
            {
                return this.attachmentHeaderListField;
            }
            set
            {
                this.attachmentHeaderListField = value;
                this.RaisePropertyChanged("AttachmentHeaderList");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class AttachmentHeaderType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string idField;

        private string filePathField;

        private byte[] signaturePKCS7Field;

        private TransferMethodType transferMethodField;

        private bool transferMethodFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string filePath
        {
            get
            {
                return this.filePathField;
            }
            set
            {
                this.filePathField = value;
                this.RaisePropertyChanged("filePath");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary", Order = 2)]
        public byte[] SignaturePKCS7
        {
            get
            {
                return this.signaturePKCS7Field;
            }
            set
            {
                this.signaturePKCS7Field = value;
                this.RaisePropertyChanged("SignaturePKCS7");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public TransferMethodType TransferMethod
        {
            get
            {
                return this.transferMethodField;
            }
            set
            {
                this.transferMethodField = value;
                this.RaisePropertyChanged("TransferMethod");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TransferMethodSpecified
        {
            get
            {
                return this.transferMethodFieldSpecified;
            }
            set
            {
                this.transferMethodFieldSpecified = value;
                this.RaisePropertyChanged("TransferMethodSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum TransferMethodType
    {

        /// <remarks/>
        MTOM,

        /// <remarks/>
        REFERENCE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestContentType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Content contentField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public Content content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RegistryRecordRoutingType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int recordIdField;

        private bool useGeneralRoutingField;

        private string[] dynamicRoutingField;

        private string[] identifierRoutingField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public int RecordId
        {
            get
            {
                return this.recordIdField;
            }
            set
            {
                this.recordIdField = value;
                this.RaisePropertyChanged("RecordId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public bool UseGeneralRouting
        {
            get
            {
                return this.useGeneralRoutingField;
            }
            set
            {
                this.useGeneralRoutingField = value;
                this.RaisePropertyChanged("UseGeneralRouting");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("DynamicValue", IsNullable = false)]
        public string[] DynamicRouting
        {
            get
            {
                return this.dynamicRoutingField;
            }
            set
            {
                this.dynamicRoutingField = value;
                this.RaisePropertyChanged("DynamicRouting");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 3)]
        [XmlArrayItemAttribute("IdentifierValue", IsNullable = false)]
        public string[] IdentifierRouting
        {
            get
            {
                return this.identifierRoutingField;
            }
            set
            {
                this.identifierRoutingField = value;
                this.RaisePropertyChanged("IdentifierRouting");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RoutingInformationType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] dynamicRoutingField;

        private string[] identifierRoutingField;

        private RegistryRecordRoutingType[] registryRoutingField;

        /// <remarks/>
        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("DynamicValue", IsNullable = false)]
        public string[] DynamicRouting
        {
            get
            {
                return this.dynamicRoutingField;
            }
            set
            {
                this.dynamicRoutingField = value;
                this.RaisePropertyChanged("DynamicRouting");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 1)]
        [XmlArrayItemAttribute("IdentifierValue", IsNullable = false)]
        public string[] IdentifierRouting
        {
            get
            {
                return this.identifierRoutingField;
            }
            set
            {
                this.identifierRoutingField = value;
                this.RaisePropertyChanged("IdentifierRouting");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("RegistryRecordRouting", IsNullable = false)]
        public RegistryRecordRoutingType[] RegistryRouting
        {
            get
            {
                return this.registryRoutingField;
            }
            set
            {
                this.registryRoutingField = value;
                this.RaisePropertyChanged("RegistryRouting");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class BusinessProcessMetadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement[] anyField;

        /// <remarks/>
        [XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class CreateGroupIdentity : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string fRGUServiceCodeField;

        private string fRGUServiceDescriptionField;

        private string fRGUServiceRecipientDescriptionField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string FRGUServiceCode
        {
            get
            {
                return this.fRGUServiceCodeField;
            }
            set
            {
                this.fRGUServiceCodeField = value;
                this.RaisePropertyChanged("FRGUServiceCode");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string FRGUServiceDescription
        {
            get
            {
                return this.fRGUServiceDescriptionField;
            }
            set
            {
                this.fRGUServiceDescriptionField = value;
                this.RaisePropertyChanged("FRGUServiceDescription");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string FRGUServiceRecipientDescription
        {
            get
            {
                return this.fRGUServiceRecipientDescriptionField;
            }
            set
            {
                this.fRGUServiceRecipientDescriptionField = value;
                this.RaisePropertyChanged("FRGUServiceRecipientDescription");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class LinkedGroupIdentity : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string refClientIdField;

        private string refGroupIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string refClientId
        {
            get
            {
                return this.refClientIdField;
            }
            set
            {
                this.refClientIdField = value;
                this.RaisePropertyChanged("refClientId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string refGroupId
        {
            get
            {
                return this.refGroupIdField;
            }
            set
            {
                this.refGroupIdField = value;
                this.RaisePropertyChanged("refGroupId");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(StatusMetadataType))]
    [XmlIncludeAttribute(typeof(ResponseMetadataType))]
    [XmlIncludeAttribute(typeof(RequestMetadataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Metadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string clientIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
                this.RaisePropertyChanged("clientId");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusMetadataType : Metadata
    {

        private string originalClientIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string originalClientId
        {
            get
            {
                return this.originalClientIdField;
            }
            set
            {
                this.originalClientIdField = value;
                this.RaisePropertyChanged("originalClientId");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseMetadataType : Metadata
    {

        private string replyToClientIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string replyToClientId
        {
            get
            {
                return this.replyToClientIdField;
            }
            set
            {
                this.replyToClientIdField = value;
                this.RaisePropertyChanged("replyToClientId");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestMetadataType : Metadata
    {

        private LinkedGroupIdentity linkedGroupIdentityField;

        private CreateGroupIdentity createGroupIdentityField;

        private string nodeIdField;

        private System.DateTime eolField;

        private bool eolFieldSpecified;

        private bool testMessageField;

        private bool testMessageFieldSpecified;

        private string transactionCodeField;

        private BusinessProcessMetadata businessProcessMetadataField;

        private RoutingInformationType routingInformationField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public LinkedGroupIdentity linkedGroupIdentity
        {
            get
            {
                return this.linkedGroupIdentityField;
            }
            set
            {
                this.linkedGroupIdentityField = value;
                this.RaisePropertyChanged("linkedGroupIdentity");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public CreateGroupIdentity createGroupIdentity
        {
            get
            {
                return this.createGroupIdentityField;
            }
            set
            {
                this.createGroupIdentityField = value;
                this.RaisePropertyChanged("createGroupIdentity");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string nodeId
        {
            get
            {
                return this.nodeIdField;
            }
            set
            {
                this.nodeIdField = value;
                this.RaisePropertyChanged("nodeId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public System.DateTime eol
        {
            get
            {
                return this.eolField;
            }
            set
            {
                this.eolField = value;
                this.RaisePropertyChanged("eol");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool eolSpecified
        {
            get
            {
                return this.eolFieldSpecified;
            }
            set
            {
                this.eolFieldSpecified = value;
                this.RaisePropertyChanged("eolSpecified");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 4)]
        public bool testMessage
        {
            get
            {
                return this.testMessageField;
            }
            set
            {
                this.testMessageField = value;
                this.RaisePropertyChanged("testMessage");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool testMessageSpecified
        {
            get
            {
                return this.testMessageFieldSpecified;
            }
            set
            {
                this.testMessageFieldSpecified = value;
                this.RaisePropertyChanged("testMessageSpecified");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 5)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
                this.RaisePropertyChanged("TransactionCode");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 6)]
        public BusinessProcessMetadata BusinessProcessMetadata
        {
            get
            {
                return this.businessProcessMetadataField;
            }
            set
            {
                this.businessProcessMetadataField = value;
                this.RaisePropertyChanged("BusinessProcessMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 7)]
        public RoutingInformationType RoutingInformation
        {
            get
            {
                return this.routingInformationField;
            }
            set
            {
                this.routingInformationField = value;
                this.RaisePropertyChanged("RoutingInformation");
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(StatusMessage))]
    [XmlIncludeAttribute(typeof(ErrorMessage))]
    [XmlIncludeAttribute(typeof(ResponseMessageType))]
    [XmlIncludeAttribute(typeof(RequestMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Message : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string messageTypeField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string messageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
                this.RaisePropertyChanged("messageType");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(ErrorMessage))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusMessage : Message
    {

        private StatusMetadataType statusMetadataField;

        private StatusMessageCategory statusField;

        private string detailsField;

        private System.DateTime timestampField;

        private bool timestampFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public StatusMetadataType statusMetadata
        {
            get
            {
                return this.statusMetadataField;
            }
            set
            {
                this.statusMetadataField = value;
                this.RaisePropertyChanged("statusMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public StatusMessageCategory status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string details
        {
            get
            {
                return this.detailsField;
            }
            set
            {
                this.detailsField = value;
                this.RaisePropertyChanged("details");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public System.DateTime timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool timestampSpecified
        {
            get
            {
                return this.timestampFieldSpecified;
            }
            set
            {
                this.timestampFieldSpecified = value;
                this.RaisePropertyChanged("timestampSpecified");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum StatusMessageCategory
    {

        /// <remarks/>
        OTHER,

        /// <remarks/>
        ERROR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ErrorMessage : StatusMessage
    {

        private ErrorType typeField;

        private Fault faultField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public ErrorType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public Fault fault
        {
            get
            {
                return this.faultField;
            }
            set
            {
                this.faultField = value;
                this.RaisePropertyChanged("fault");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum ErrorType
    {

        /// <remarks/>
        SERVER,

        /// <remarks/>
        CLIENT,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseMessageType : Message
    {

        private ResponseMetadataType responseMetadataField;

        private ResponseContentType responseContentField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public ResponseMetadataType ResponseMetadata
        {
            get
            {
                return this.responseMetadataField;
            }
            set
            {
                this.responseMetadataField = value;
                this.RaisePropertyChanged("ResponseMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public ResponseContentType ResponseContent
        {
            get
            {
                return this.responseContentField;
            }
            set
            {
                this.responseContentField = value;
                this.RaisePropertyChanged("ResponseContent");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestMessageType : Message
    {

        private RequestMetadataType requestMetadataField;

        private RequestContentType requestContentField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public RequestMetadataType RequestMetadata
        {
            get
            {
                return this.requestMetadataField;
            }
            set
            {
                this.requestMetadataField = value;
                this.RaisePropertyChanged("RequestMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public RequestContentType RequestContent
        {
            get
            {
                return this.requestContentField;
            }
            set
            {
                this.requestContentField = value;
                this.RaisePropertyChanged("RequestContent");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class SmevMetadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string messageIdField;

        private string referenceMessageIDField;

        private string transactionCodeField;

        private string originalMessageIDField;

        private string senderField;

        private string recipientField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string MessageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
                this.RaisePropertyChanged("MessageId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string ReferenceMessageID
        {
            get
            {
                return this.referenceMessageIDField;
            }
            set
            {
                this.referenceMessageIDField = value;
                this.RaisePropertyChanged("ReferenceMessageID");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
                this.RaisePropertyChanged("TransactionCode");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public string OriginalMessageID
        {
            get
            {
                return this.originalMessageIDField;
            }
            set
            {
                this.originalMessageIDField = value;
                this.RaisePropertyChanged("OriginalMessageID");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 4)]
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
                this.RaisePropertyChanged("Sender");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 5)]
        public string Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
                this.RaisePropertyChanged("Recipient");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class QueryTypeCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private TypeCriteria messageTypeCriteriaField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public TypeCriteria messageTypeCriteria
        {
            get
            {
                return this.messageTypeCriteriaField;
            }
            set
            {
                this.messageTypeCriteriaField = value;
                this.RaisePropertyChanged("messageTypeCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum TypeCriteria
    {

        /// <remarks/>
        RESPONSE,

        /// <remarks/>
        REQUEST,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class ValidationFault : Fault
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContractAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter", ConfigurationName = "SMEVServiceAdapterPortType")]
    public interface SMEVServiceAdapterPortType
    {

        [OperationContractAttribute(Action = "urn:Get", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":GetResponse")]
        [FaultContractAttribute(typeof(SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Get:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [FaultContractAttribute(typeof(ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Get:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(Metadata))]
        GetResponse Get(GetRequest request);

        // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
        [OperationContractAttribute(Action = "urn:Get", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":GetResponse")]
        System.Threading.Tasks.Task<GetResponse> GetAsync(GetRequest request);

        // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/service-adapter/types) сообщения FindRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/service-adapter).
        [OperationContractAttribute(Action = "urn:Find", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":FindResponse")]
        [FaultContractAttribute(typeof(SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Find:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [FaultContractAttribute(typeof(ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Find:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(Metadata))]
        FindResponse Find(FindRequest request);

        [OperationContractAttribute(Action = "urn:Find", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":FindResponse")]
        System.Threading.Tasks.Task<FindResponse> FindAsync(FindRequest request);

        [OperationContractAttribute(Action = "urn:Send", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":SendResponse")]
        [FaultContractAttribute(typeof(SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Send:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [FaultContractAttribute(typeof(ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Send:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(Metadata))]
        SendResponse Send(SendRequest request);

        // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
        [OperationContractAttribute(Action = "urn:Send", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":SendResponse")]
        System.Threading.Tasks.Task<SendResponse> SendAsync(SendRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName = "MessageQuery", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class GetRequest
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public string nodeId;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 2)]
        public QueryTypeCriteria specificQuery;

        public GetRequest()
        {
        }

        public GetRequest(string itSystem, string nodeId, QueryTypeCriteria specificQuery)
        {
            this.itSystem = itSystem;
            this.nodeId = nodeId;
            this.specificQuery = specificQuery;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName = "QueryResult", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class GetResponse
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public SmevMetadata smevMetadata;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public Message Message;

        public GetResponse()
        {
        }

        public GetResponse(SmevMetadata smevMetadata, Message Message)
        {
            this.smevMetadata = smevMetadata;
            this.Message = Message;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class FindTypeCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private MessageIntervalCriteria messagePeriodCriteriaField;

        private MessageClientIdCriteria messageClientIdCriteriaField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public MessageIntervalCriteria messagePeriodCriteria
        {
            get
            {
                return this.messagePeriodCriteriaField;
            }
            set
            {
                this.messagePeriodCriteriaField = value;
                this.RaisePropertyChanged("messagePeriodCriteria");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public MessageClientIdCriteria messageClientIdCriteria
        {
            get
            {
                return this.messageClientIdCriteriaField;
            }
            set
            {
                this.messageClientIdCriteriaField = value;
                this.RaisePropertyChanged("messageClientIdCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class MessageIntervalCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime fromField;

        private System.DateTime toField;

        private bool toFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public System.DateTime from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
                this.RaisePropertyChanged("from");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public System.DateTime to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
                this.RaisePropertyChanged("to");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool toSpecified
        {
            get
            {
                return this.toFieldSpecified;
            }
            set
            {
                this.toFieldSpecified = value;
                this.RaisePropertyChanged("toSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class MessageClientIdCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string clientIdField;

        private ClientIdCriteria clientIdCriteriaField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
                this.RaisePropertyChanged("clientId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public ClientIdCriteria clientIdCriteria
        {
            get
            {
                return this.clientIdCriteriaField;
            }
            set
            {
                this.clientIdCriteriaField = value;
                this.RaisePropertyChanged("clientIdCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum ClientIdCriteria
    {

        /// <remarks/>
        GET_REQUEST_BY_REQUEST_CLIENTID,

        /// <remarks/>
        GET_RESPONSE_BY_REQUEST_CLIENTID,

        /// <remarks/>
        GET_RESPONSE_BY_RESPONSE_CLIENTID,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    [XmlRootAttribute("OrderStatusEventRequest", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsNullable = false, ElementName = "AdapterMessage")]

    public partial class AdapterMessage : object, System.ComponentModel.INotifyPropertyChanged
    {

        private SmevMetadata smevMetadataField;

        private Message messageField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public SmevMetadata smevMetadata
        {
            get
            {
                return this.smevMetadataField;
            }
            set
            {
                this.smevMetadataField = value;
                this.RaisePropertyChanged("smevMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public Message Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "FindMessageQuery", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class FindRequest
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public FindTypeCriteria specificQuery;

        public FindRequest()
        {
        }

        public FindRequest(string itSystem, FindTypeCriteria specificQuery)
        {
            this.itSystem = itSystem;
            this.specificQuery = specificQuery;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "QueryResultList", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class FindResponse
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        [XmlElementAttribute("QueryResult")]
        public AdapterMessage[] QueryResult;

        public FindResponse()
        {
        }

        public FindResponse(AdapterMessage[] QueryResult)
        {
            this.QueryResult = QueryResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContract(WrapperName = "ClientMessage", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class SendRequest
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public RequestMessageType RequestMessage;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 2)]
        public ResponseMessageType ResponseMessage;

        public SendRequest()
        {
        }

        public SendRequest(string itSystem, RequestMessageType RequestMessage, ResponseMessageType ResponseMessage)
        {
            this.itSystem = itSystem;
            this.RequestMessage = RequestMessage;
            this.ResponseMessage = ResponseMessage;
        }

    }

    //Добавлено для формирования сообщения
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContract(WrapperName = "ClientMessage", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class ClientMessage
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public RequestMessageType RequestMessage;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 2)]
        public ResponseMessageType ResponseMessage;

        public ClientMessage()
        { }

        public ClientMessage(string itSystem, RequestMessageType RequestMessage, ResponseMessageType ResponseMessage)
        {
            this.itSystem = itSystem;
            this.RequestMessage = RequestMessage;
            this.ResponseMessage = ResponseMessage;
        }
    }




    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName = "MessageResult", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class SendResponse
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public string MessageId;

        public SendResponse()
        {
        }

        public SendResponse(string itSystem, string MessageId)
        {
            this.itSystem = itSystem;
            this.MessageId = MessageId;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SMEVServiceAdapterPortTypeChannel : SMEVServiceAdapterPortType, IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMEVServiceAdapterPortTypeClient : ClientBase<SMEVServiceAdapterPortType>, SMEVServiceAdapterPortType
    {

        public SMEVServiceAdapterPortTypeClient()
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public SMEVServiceAdapterPortTypeClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetResponse SMEVServiceAdapterPortType.Get(GetRequest request)
        {
            return base.Channel.Get(request);
        }

        public SmevMetadata Get(string itSystem, string nodeId, QueryTypeCriteria specificQuery, out Message Message)
        {
            GetRequest inValue = new GetRequest();
            inValue.itSystem = itSystem;
            inValue.nodeId = nodeId;
            inValue.specificQuery = specificQuery;
            GetResponse retVal = ((SMEVServiceAdapterPortType)(this)).Get(inValue);
            Message = retVal.Message;
            return retVal.smevMetadata;
        }

        public System.Threading.Tasks.Task<GetResponse> GetAsync(GetRequest request)
        {
            return base.Channel.GetAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FindResponse SMEVServiceAdapterPortType.Find(FindRequest request)
        {
            return base.Channel.Find(request);
        }

        public AdapterMessage[] Find(string itSystem, FindTypeCriteria specificQuery)
        {
            FindRequest inValue = new FindRequest();
            inValue.itSystem = itSystem;
            inValue.specificQuery = specificQuery;
            FindResponse retVal = ((SMEVServiceAdapterPortType)(this)).Find(inValue);
            return retVal.QueryResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FindResponse> SMEVServiceAdapterPortType.FindAsync(FindRequest request)
        {
            return base.Channel.FindAsync(request);
        }

        public System.Threading.Tasks.Task<FindResponse> FindAsync(string itSystem, FindTypeCriteria specificQuery)
        {
            FindRequest inValue = new FindRequest();
            inValue.itSystem = itSystem;
            inValue.specificQuery = specificQuery;
            return ((SMEVServiceAdapterPortType)(this)).FindAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SendResponse SMEVServiceAdapterPortType.Send(SendRequest request)
        {
            return base.Channel.Send(request);
        }

        public string Send(ref string itSystem, RequestMessageType RequestMessage, ResponseMessageType ResponseMessage)
        {
            SendRequest inValue = new SendRequest();
            inValue.itSystem = itSystem;
            inValue.RequestMessage = RequestMessage;
            inValue.ResponseMessage = ResponseMessage;
            SendResponse retVal = ((SMEVServiceAdapterPortType)(this)).Send(inValue);
            itSystem = retVal.itSystem;
            return retVal.MessageId;
        }

        public System.Threading.Tasks.Task<SendResponse> SendAsync(SendRequest request)
        {
            return base.Channel.SendAsync(request);
        }
    }
}


//Формируется из импортированного wsdl
//Обязательно указать  для AdapterMessage 
//[XmlRootAttribute("OrderStatusEventRequest", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsNullable = false, ElementName = "AdapterMessage")]
public class adapterSmev1_3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class SystemFault : Fault
    {
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(ValidationFault))]
    [XmlIncludeAttribute(typeof(SystemFault))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class Fault : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private string descriptionField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Status : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private string descriptionField;

        private StatusParameter[] parameterField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("parameter", IsNullable = true, Order = 2)]
        public StatusParameter[] parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusParameter : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Reject : object, System.ComponentModel.INotifyPropertyChanged
    {

        private RejectCode codeField;

        private string descriptionField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public RejectCode code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum RejectCode
    {

        /// <remarks/>
        ACCESS_DENIED,

        /// <remarks/>
        NO_DATA,

        /// <remarks/>
        UNKNOWN_REQUEST_DESCRIPTION,

        /// <remarks/>
        FAILURE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseContentType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Content contentField;

        private Reject[] rejectsField;

        private Status statusField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public Content content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("rejects", IsNullable = true, Order = 1)]
        public Reject[] rejects
        {
            get
            {
                return this.rejectsField;
            }
            set
            {
                this.rejectsField = value;
                this.RaisePropertyChanged("rejects");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public Status status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Content : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement messagePrimaryContentField;

        private System.Xml.XmlElement personalSignatureField;

        private AttachmentHeaderType[] attachmentHeaderListField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public System.Xml.XmlElement MessagePrimaryContent
        {
            get
            {
                return this.messagePrimaryContentField;
            }
            set
            {
                this.messagePrimaryContentField = value;
                this.RaisePropertyChanged("MessagePrimaryContent");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public System.Xml.XmlElement PersonalSignature
        {
            get
            {
                return this.personalSignatureField;
            }
            set
            {
                this.personalSignatureField = value;
                this.RaisePropertyChanged("PersonalSignature");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("AttachmentHeader", IsNullable = false)]
        public AttachmentHeaderType[] AttachmentHeaderList
        {
            get
            {
                return this.attachmentHeaderListField;
            }
            set
            {
                this.attachmentHeaderListField = value;
                this.RaisePropertyChanged("AttachmentHeaderList");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class AttachmentHeaderType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string idField;

        private string filePathField;

        private byte[] signaturePKCS7Field;

        private TransferMethodType transferMethodField;

        private bool transferMethodFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string filePath
        {
            get
            {
                return this.filePathField;
            }
            set
            {
                this.filePathField = value;
                this.RaisePropertyChanged("filePath");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary", Order = 2)]
        public byte[] SignaturePKCS7
        {
            get
            {
                return this.signaturePKCS7Field;
            }
            set
            {
                this.signaturePKCS7Field = value;
                this.RaisePropertyChanged("SignaturePKCS7");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public TransferMethodType TransferMethod
        {
            get
            {
                return this.transferMethodField;
            }
            set
            {
                this.transferMethodField = value;
                this.RaisePropertyChanged("TransferMethod");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TransferMethodSpecified
        {
            get
            {
                return this.transferMethodFieldSpecified;
            }
            set
            {
                this.transferMethodFieldSpecified = value;
                this.RaisePropertyChanged("TransferMethodSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum TransferMethodType
    {

        /// <remarks/>
        MTOM,

        /// <remarks/>
        REFERENCE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestContentType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Content contentField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public Content content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RegistryRecordRoutingType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int recordIdField;

        private bool useGeneralRoutingField;

        private string[] dynamicRoutingField;

        private string[] identifierRoutingField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public int RecordId
        {
            get
            {
                return this.recordIdField;
            }
            set
            {
                this.recordIdField = value;
                this.RaisePropertyChanged("RecordId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public bool UseGeneralRouting
        {
            get
            {
                return this.useGeneralRoutingField;
            }
            set
            {
                this.useGeneralRoutingField = value;
                this.RaisePropertyChanged("UseGeneralRouting");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("DynamicValue", IsNullable = false)]
        public string[] DynamicRouting
        {
            get
            {
                return this.dynamicRoutingField;
            }
            set
            {
                this.dynamicRoutingField = value;
                this.RaisePropertyChanged("DynamicRouting");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 3)]
        [XmlArrayItemAttribute("IdentifierValue", IsNullable = false)]
        public string[] IdentifierRouting
        {
            get
            {
                return this.identifierRoutingField;
            }
            set
            {
                this.identifierRoutingField = value;
                this.RaisePropertyChanged("IdentifierRouting");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RoutingInformationType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] dynamicRoutingField;

        private string[] identifierRoutingField;

        private RegistryRecordRoutingType[] registryRoutingField;

        /// <remarks/>
        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("DynamicValue", IsNullable = false)]
        public string[] DynamicRouting
        {
            get
            {
                return this.dynamicRoutingField;
            }
            set
            {
                this.dynamicRoutingField = value;
                this.RaisePropertyChanged("DynamicRouting");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 1)]
        [XmlArrayItemAttribute("IdentifierValue", IsNullable = false)]
        public string[] IdentifierRouting
        {
            get
            {
                return this.identifierRoutingField;
            }
            set
            {
                this.identifierRoutingField = value;
                this.RaisePropertyChanged("IdentifierRouting");
            }
        }

        /// <remarks/>
        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("RegistryRecordRouting", IsNullable = false)]
        public RegistryRecordRoutingType[] RegistryRouting
        {
            get
            {
                return this.registryRoutingField;
            }
            set
            {
                this.registryRoutingField = value;
                this.RaisePropertyChanged("RegistryRouting");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class BusinessProcessMetadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement[] anyField;

        /// <remarks/>
        [XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class CreateGroupIdentity : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string fRGUServiceCodeField;

        private string fRGUServiceDescriptionField;

        private string fRGUServiceRecipientDescriptionField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string FRGUServiceCode
        {
            get
            {
                return this.fRGUServiceCodeField;
            }
            set
            {
                this.fRGUServiceCodeField = value;
                this.RaisePropertyChanged("FRGUServiceCode");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string FRGUServiceDescription
        {
            get
            {
                return this.fRGUServiceDescriptionField;
            }
            set
            {
                this.fRGUServiceDescriptionField = value;
                this.RaisePropertyChanged("FRGUServiceDescription");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string FRGUServiceRecipientDescription
        {
            get
            {
                return this.fRGUServiceRecipientDescriptionField;
            }
            set
            {
                this.fRGUServiceRecipientDescriptionField = value;
                this.RaisePropertyChanged("FRGUServiceRecipientDescription");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class LinkedGroupIdentity : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string refClientIdField;

        private string refGroupIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string refClientId
        {
            get
            {
                return this.refClientIdField;
            }
            set
            {
                this.refClientIdField = value;
                this.RaisePropertyChanged("refClientId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string refGroupId
        {
            get
            {
                return this.refGroupIdField;
            }
            set
            {
                this.refGroupIdField = value;
                this.RaisePropertyChanged("refGroupId");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(ResponseMetadataType))]
    [XmlIncludeAttribute(typeof(StatusMetadataType))]
    [XmlIncludeAttribute(typeof(RequestMetadataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Metadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string clientIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
                this.RaisePropertyChanged("clientId");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseMetadataType : Metadata
    {

        private string replyToClientIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string replyToClientId
        {
            get
            {
                return this.replyToClientIdField;
            }
            set
            {
                this.replyToClientIdField = value;
                this.RaisePropertyChanged("replyToClientId");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusMetadataType : Metadata
    {

        private string originalClientIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string originalClientId
        {
            get
            {
                return this.originalClientIdField;
            }
            set
            {
                this.originalClientIdField = value;
                this.RaisePropertyChanged("originalClientId");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestMetadataType : Metadata
    {

        private LinkedGroupIdentity linkedGroupIdentityField;

        private CreateGroupIdentity createGroupIdentityField;

        private string nodeIdField;

        private System.DateTime eolField;

        private bool eolFieldSpecified;

        private bool testMessageField;

        private bool testMessageFieldSpecified;

        private string transactionCodeField;

        private BusinessProcessMetadata businessProcessMetadataField;

        private RoutingInformationType routingInformationField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public LinkedGroupIdentity linkedGroupIdentity
        {
            get
            {
                return this.linkedGroupIdentityField;
            }
            set
            {
                this.linkedGroupIdentityField = value;
                this.RaisePropertyChanged("linkedGroupIdentity");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public CreateGroupIdentity createGroupIdentity
        {
            get
            {
                return this.createGroupIdentityField;
            }
            set
            {
                this.createGroupIdentityField = value;
                this.RaisePropertyChanged("createGroupIdentity");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string nodeId
        {
            get
            {
                return this.nodeIdField;
            }
            set
            {
                this.nodeIdField = value;
                this.RaisePropertyChanged("nodeId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public System.DateTime eol
        {
            get
            {
                return this.eolField;
            }
            set
            {
                this.eolField = value;
                this.RaisePropertyChanged("eol");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool eolSpecified
        {
            get
            {
                return this.eolFieldSpecified;
            }
            set
            {
                this.eolFieldSpecified = value;
                this.RaisePropertyChanged("eolSpecified");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 4)]
        public bool testMessage
        {
            get
            {
                return this.testMessageField;
            }
            set
            {
                this.testMessageField = value;
                this.RaisePropertyChanged("testMessage");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool testMessageSpecified
        {
            get
            {
                return this.testMessageFieldSpecified;
            }
            set
            {
                this.testMessageFieldSpecified = value;
                this.RaisePropertyChanged("testMessageSpecified");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 5)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
                this.RaisePropertyChanged("TransactionCode");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 6)]
        public BusinessProcessMetadata BusinessProcessMetadata
        {
            get
            {
                return this.businessProcessMetadataField;
            }
            set
            {
                this.businessProcessMetadataField = value;
                this.RaisePropertyChanged("BusinessProcessMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 7)]
        public RoutingInformationType RoutingInformation
        {
            get
            {
                return this.routingInformationField;
            }
            set
            {
                this.routingInformationField = value;
                this.RaisePropertyChanged("RoutingInformation");
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(ResponseMessageType))]
    [XmlIncludeAttribute(typeof(StatusMessage))]
    [XmlIncludeAttribute(typeof(ErrorMessage))]
    [XmlIncludeAttribute(typeof(RequestMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class Message : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string messageTypeField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string messageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
                this.RaisePropertyChanged("messageType");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ResponseMessageType : Message
    {

        private ResponseMetadataType responseMetadataField;

        private ResponseContentType responseContentField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public ResponseMetadataType ResponseMetadata
        {
            get
            {
                return this.responseMetadataField;
            }
            set
            {
                this.responseMetadataField = value;
                this.RaisePropertyChanged("ResponseMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public ResponseContentType ResponseContent
        {
            get
            {
                return this.responseContentField;
            }
            set
            {
                this.responseContentField = value;
                this.RaisePropertyChanged("ResponseContent");
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(ErrorMessage))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class StatusMessage : Message
    {

        private StatusMetadataType statusMetadataField;

        private StatusMessageCategory statusField;

        private string detailsField;

        private System.DateTime timestampField;

        private bool timestampFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public StatusMetadataType statusMetadata
        {
            get
            {
                return this.statusMetadataField;
            }
            set
            {
                this.statusMetadataField = value;
                this.RaisePropertyChanged("statusMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public StatusMessageCategory status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string details
        {
            get
            {
                return this.detailsField;
            }
            set
            {
                this.detailsField = value;
                this.RaisePropertyChanged("details");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public System.DateTime timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool timestampSpecified
        {
            get
            {
                return this.timestampFieldSpecified;
            }
            set
            {
                this.timestampFieldSpecified = value;
                this.RaisePropertyChanged("timestampSpecified");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum StatusMessageCategory
    {

        /// <remarks/>
        OTHER,

        /// <remarks/>
        ERROR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class ErrorMessage : StatusMessage
    {

        private ErrorType typeField;

        private Fault faultField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public ErrorType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public Fault fault
        {
            get
            {
                return this.faultField;
            }
            set
            {
                this.faultField = value;
                this.RaisePropertyChanged("fault");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum ErrorType
    {

        /// <remarks/>
        SERVER,

        /// <remarks/>
        CLIENT,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class RequestMessageType : Message
    {

        private RequestMetadataType requestMetadataField;

        private RequestContentType requestContentField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public RequestMetadataType RequestMetadata
        {
            get
            {
                return this.requestMetadataField;
            }
            set
            {
                this.requestMetadataField = value;
                this.RaisePropertyChanged("RequestMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public RequestContentType RequestContent
        {
            get
            {
                return this.requestContentField;
            }
            set
            {
                this.requestContentField = value;
                this.RaisePropertyChanged("RequestContent");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class SmevMetadata : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string messageIdField;

        private string referenceMessageIDField;

        private string transactionCodeField;

        private string originalMessageIDField;

        private string senderField;

        private string recipientField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string MessageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
                this.RaisePropertyChanged("MessageId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string ReferenceMessageID
        {
            get
            {
                return this.referenceMessageIDField;
            }
            set
            {
                this.referenceMessageIDField = value;
                this.RaisePropertyChanged("ReferenceMessageID");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
                this.RaisePropertyChanged("TransactionCode");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public string OriginalMessageID
        {
            get
            {
                return this.originalMessageIDField;
            }
            set
            {
                this.originalMessageIDField = value;
                this.RaisePropertyChanged("OriginalMessageID");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 4)]
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
                this.RaisePropertyChanged("Sender");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 5)]
        public string Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
                this.RaisePropertyChanged("Recipient");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class QueryTypeCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private TypeCriteria messageTypeCriteriaField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public TypeCriteria messageTypeCriteria
        {
            get
            {
                return this.messageTypeCriteriaField;
            }
            set
            {
                this.messageTypeCriteriaField = value;
                this.RaisePropertyChanged("messageTypeCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum TypeCriteria
    {

        /// <remarks/>
        RESPONSE,

        /// <remarks/>
        REQUEST,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
    public partial class ValidationFault : Fault
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContractAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter", ConfigurationName = "adapterSmev1_3.SMEVServiceAdapterPortType")]
    public interface SMEVServiceAdapterPortType
    {

        [OperationContractAttribute(Action = "urn:Get", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":GetResponse")]
        [FaultContractAttribute(typeof(adapterSmev1_3.SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Get:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [FaultContractAttribute(typeof(adapterSmev1_3.ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Get:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(Metadata))]
        adapterSmev1_3.GetResponse Get(adapterSmev1_3.GetRequest request);

        // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
        [OperationContractAttribute(Action = "urn:Get", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":GetResponse")]
        System.Threading.Tasks.Task<adapterSmev1_3.GetResponse> GetAsync(adapterSmev1_3.GetRequest request);

        // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/service-adapter/types) сообщения FindRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/service-adapter).
        [OperationContractAttribute(Action = "urn:Find", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":FindResponse")]
        [FaultContractAttribute(typeof(adapterSmev1_3.SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Find:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [FaultContractAttribute(typeof(adapterSmev1_3.ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Find:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(Metadata))]
        adapterSmev1_3.FindResponse Find(adapterSmev1_3.FindRequest request);

        [OperationContractAttribute(Action = "urn:Find", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":FindResponse")]
        System.Threading.Tasks.Task<adapterSmev1_3.FindResponse> FindAsync(adapterSmev1_3.FindRequest request);

        [OperationContractAttribute(Action = "urn:Send", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":SendResponse")]
        [FaultContractAttribute(typeof(adapterSmev1_3.SystemFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Send:Fault:SystemFault", Name = "SystemFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [FaultContractAttribute(typeof(adapterSmev1_3.ValidationFault), Action = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":Send:Fault:ValidationFault", Name = "ValidationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types/faults")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(Metadata))]
        adapterSmev1_3.SendResponse Send(adapterSmev1_3.SendRequest request);

        // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
        [OperationContractAttribute(Action = "urn:Send", ReplyAction = "urn://x-artefacts-smev-gov-ru/services/service-adapter:SMEVServiceAdapterPortType" +
            ":SendResponse")]
        System.Threading.Tasks.Task<adapterSmev1_3.SendResponse> SendAsync(adapterSmev1_3.SendRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName = "MessageQuery", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class GetRequest
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public string nodeId;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 2)]
        public adapterSmev1_3.QueryTypeCriteria specificQuery;

        public GetRequest()
        {
        }

        public GetRequest(string itSystem, string nodeId, adapterSmev1_3.QueryTypeCriteria specificQuery)
        {
            this.itSystem = itSystem;
            this.nodeId = nodeId;
            this.specificQuery = specificQuery;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName = "QueryResult", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class GetResponse
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public adapterSmev1_3.SmevMetadata smevMetadata;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public adapterSmev1_3.Message Message;

        public GetResponse()
        {
        }

        public GetResponse(adapterSmev1_3.SmevMetadata smevMetadata, adapterSmev1_3.Message Message)
        {
            this.smevMetadata = smevMetadata;
            this.Message = Message;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class FindTypeCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private MessageIntervalCriteria messagePeriodCriteriaField;

        private MessageClientIdCriteria messageClientIdCriteriaField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public MessageIntervalCriteria messagePeriodCriteria
        {
            get
            {
                return this.messagePeriodCriteriaField;
            }
            set
            {
                this.messagePeriodCriteriaField = value;
                this.RaisePropertyChanged("messagePeriodCriteria");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public MessageClientIdCriteria messageClientIdCriteria
        {
            get
            {
                return this.messageClientIdCriteriaField;
            }
            set
            {
                this.messageClientIdCriteriaField = value;
                this.RaisePropertyChanged("messageClientIdCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class MessageIntervalCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime fromField;

        private System.DateTime toField;

        private bool toFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public System.DateTime from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
                this.RaisePropertyChanged("from");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public System.DateTime to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
                this.RaisePropertyChanged("to");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool toSpecified
        {
            get
            {
                return this.toFieldSpecified;
            }
            set
            {
                this.toFieldSpecified = value;
                this.RaisePropertyChanged("toSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public partial class MessageClientIdCriteria : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string clientIdField;

        private ClientIdCriteria clientIdCriteriaField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string clientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                this.clientIdField = value;
                this.RaisePropertyChanged("clientId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public ClientIdCriteria clientIdCriteria
        {
            get
            {
                return this.clientIdCriteriaField;
            }
            set
            {
                this.clientIdCriteriaField = value;
                this.RaisePropertyChanged("clientIdCriteria");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    public enum ClientIdCriteria
    {

        /// <remarks/>
        GET_REQUEST_BY_REQUEST_CLIENTID,

        /// <remarks/>
        GET_RESPONSE_BY_REQUEST_CLIENTID,

        /// <remarks/>
        GET_RESPONSE_BY_RESPONSE_CLIENTID,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types")]
    [XmlRootAttribute("OrderStatusEventRequest", Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsNullable = false, ElementName = "AdapterMessage")]
    public partial class AdapterMessage : object, System.ComponentModel.INotifyPropertyChanged
    {

        private SmevMetadata smevMetadataField;

        private Message messageField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public SmevMetadata smevMetadata
        {
            get
            {
                return this.smevMetadataField;
            }
            set
            {
                this.smevMetadataField = value;
                this.RaisePropertyChanged("smevMetadata");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public Message Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "FindMessageQuery", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class FindRequest
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public adapterSmev1_3.FindTypeCriteria specificQuery;

        public FindRequest()
        {
        }

        public FindRequest(string itSystem, adapterSmev1_3.FindTypeCriteria specificQuery)
        {
            this.itSystem = itSystem;
            this.specificQuery = specificQuery;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(WrapperName = "QueryResultList", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class FindResponse
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        [XmlElementAttribute("QueryResult")]
        public adapterSmev1_3.AdapterMessage[] QueryResult;

        public FindResponse()
        {
        }

        public FindResponse(adapterSmev1_3.AdapterMessage[] QueryResult)
        {
            this.QueryResult = QueryResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName = "ClientMessage", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class SendRequest
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public adapterSmev1_3.RequestMessageType RequestMessage;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 2)]
        public adapterSmev1_3.ResponseMessageType ResponseMessage;

        public SendRequest()
        {
        }

        public SendRequest(string itSystem, adapterSmev1_3.RequestMessageType RequestMessage, adapterSmev1_3.ResponseMessageType ResponseMessage)
        {
            this.itSystem = itSystem;
            this.RequestMessage = RequestMessage;
            this.ResponseMessage = ResponseMessage;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [MessageContractAttribute(WrapperName = "MessageResult", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", IsWrapped = true)]
    public partial class SendResponse
    {

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 0)]
        public string itSystem;

        [MessageBodyMemberAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/service-adapter/types", Order = 1)]
        public string MessageId;

        public SendResponse()
        {
        }

        public SendResponse(string itSystem, string MessageId)
        {
            this.itSystem = itSystem;
            this.MessageId = MessageId;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SMEVServiceAdapterPortTypeChannel : adapterSmev1_3.SMEVServiceAdapterPortType, IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMEVServiceAdapterPortTypeClient : ClientBase<adapterSmev1_3.SMEVServiceAdapterPortType>, adapterSmev1_3.SMEVServiceAdapterPortType
    {

        public SMEVServiceAdapterPortTypeClient()
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public SMEVServiceAdapterPortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public SMEVServiceAdapterPortTypeClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        adapterSmev1_3.GetResponse adapterSmev1_3.SMEVServiceAdapterPortType.Get(adapterSmev1_3.GetRequest request)
        {
            return base.Channel.Get(request);
        }

        public adapterSmev1_3.SmevMetadata Get(string itSystem, string nodeId, adapterSmev1_3.QueryTypeCriteria specificQuery, out adapterSmev1_3.Message Message)
        {
            adapterSmev1_3.GetRequest inValue = new adapterSmev1_3.GetRequest();
            inValue.itSystem = itSystem;
            inValue.nodeId = nodeId;
            inValue.specificQuery = specificQuery;
            adapterSmev1_3.GetResponse retVal = ((adapterSmev1_3.SMEVServiceAdapterPortType)(this)).Get(inValue);
            Message = retVal.Message;
            return retVal.smevMetadata;
        }

        public System.Threading.Tasks.Task<adapterSmev1_3.GetResponse> GetAsync(adapterSmev1_3.GetRequest request)
        {
            return base.Channel.GetAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        adapterSmev1_3.FindResponse adapterSmev1_3.SMEVServiceAdapterPortType.Find(adapterSmev1_3.FindRequest request)
        {
            return base.Channel.Find(request);
        }

        public adapterSmev1_3.AdapterMessage[] Find(string itSystem, adapterSmev1_3.FindTypeCriteria specificQuery)
        {
            adapterSmev1_3.FindRequest inValue = new adapterSmev1_3.FindRequest();
            inValue.itSystem = itSystem;
            inValue.specificQuery = specificQuery;
            adapterSmev1_3.FindResponse retVal = ((adapterSmev1_3.SMEVServiceAdapterPortType)(this)).Find(inValue);
            return retVal.QueryResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<adapterSmev1_3.FindResponse> adapterSmev1_3.SMEVServiceAdapterPortType.FindAsync(adapterSmev1_3.FindRequest request)
        {
            return base.Channel.FindAsync(request);
        }

        public System.Threading.Tasks.Task<adapterSmev1_3.FindResponse> FindAsync(string itSystem, adapterSmev1_3.FindTypeCriteria specificQuery)
        {
            adapterSmev1_3.FindRequest inValue = new adapterSmev1_3.FindRequest();
            inValue.itSystem = itSystem;
            inValue.specificQuery = specificQuery;
            return ((adapterSmev1_3.SMEVServiceAdapterPortType)(this)).FindAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        adapterSmev1_3.SendResponse adapterSmev1_3.SMEVServiceAdapterPortType.Send(adapterSmev1_3.SendRequest request)
        {
            return base.Channel.Send(request);
        }

        public string Send(ref string itSystem, adapterSmev1_3.RequestMessageType RequestMessage, adapterSmev1_3.ResponseMessageType ResponseMessage)
        {
            adapterSmev1_3.SendRequest inValue = new adapterSmev1_3.SendRequest();
            inValue.itSystem = itSystem;
            inValue.RequestMessage = RequestMessage;
            inValue.ResponseMessage = ResponseMessage;
            adapterSmev1_3.SendResponse retVal = ((adapterSmev1_3.SMEVServiceAdapterPortType)(this)).Send(inValue);
            itSystem = retVal.itSystem;
            return retVal.MessageId;
        }

        public System.Threading.Tasks.Task<adapterSmev1_3.SendResponse> SendAsync(adapterSmev1_3.SendRequest request)
        {
            return base.Channel.SendAsync(request);
        }
    }
}

public class adapterSmev1_3_smev_message_exchange_directive
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3", IsNullable = false)]
    public partial class Registry : object, System.ComponentModel.INotifyPropertyChanged
    {

        private RegistryRecord[] registryRecordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegistryRecord")]
        public RegistryRecord[] RegistryRecord
        {
            get
            {
                return this.registryRecordField;
            }
            set
            {
                this.registryRecordField = value;
                this.RaisePropertyChanged("RegistryRecord");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3", IsNullable = false)]
    public partial class RegistryRecord : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int recordIdField;

        private Record recordField;

        private System.Xml.XmlElement recordSignatureField;

        /// <remarks/>
        public int RecordId
        {
            get
            {
                return this.recordIdField;
            }
            set
            {
                this.recordIdField = value;
                this.RaisePropertyChanged("RecordId");
            }
        }

        /// <remarks/>
        public Record Record
        {
            get
            {
                return this.recordField;
            }
            set
            {
                this.recordField = value;
                this.RaisePropertyChanged("Record");
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement RecordSignature
        {
            get
            {
                return this.recordSignatureField;
            }
            set
            {
                this.recordSignatureField = value;
                this.RaisePropertyChanged("RecordSignature");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3", IsNullable = false)]
    public partial class Record : object, System.ComponentModel.INotifyPropertyChanged
    {

        private RecordContent recordContentField;

        private AttachmentHeaderType[] attachmentHeaderListField;

        private RefAttachmentHeaderType[] refAttachmentHeaderListField;

        private System.Xml.XmlElement[] personalSignatureField;

        private string idField;

        /// <remarks/>
        public RecordContent RecordContent
        {
            get
            {
                return this.recordContentField;
            }
            set
            {
                this.recordContentField = value;
                this.RaisePropertyChanged("RecordContent");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
        [System.Xml.Serialization.XmlArrayItemAttribute("AttachmentHeader", IsNullable = false)]
        public AttachmentHeaderType[] AttachmentHeaderList
        {
            get
            {
                return this.attachmentHeaderListField;
            }
            set
            {
                this.attachmentHeaderListField = value;
                this.RaisePropertyChanged("AttachmentHeaderList");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
        [System.Xml.Serialization.XmlArrayItemAttribute("RefAttachmentHeader", IsNullable = false)]
        public RefAttachmentHeaderType[] RefAttachmentHeaderList
        {
            get
            {
                return this.refAttachmentHeaderListField;
            }
            set
            {
                this.refAttachmentHeaderListField = value;
                this.RaisePropertyChanged("RefAttachmentHeaderList");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonalSignature")]
        public System.Xml.XmlElement[] PersonalSignature
        {
            get
            {
                return this.personalSignatureField;
            }
            set
            {
                this.personalSignatureField = value;
                this.RaisePropertyChanged("PersonalSignature");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3", IsNullable = false)]
    public partial class RecordContent : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement anyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public partial class RefAttachmentHeaderType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string uuidField;

        private string fileNameField;

        private string namespaceUriField;

        private string hashField;

        private string mimeTypeField;

        private byte[] signaturePKCS7Field;

        private FileType[] archiveField;

        /// <remarks/>
        public string uuid
        {
            get
            {
                return this.uuidField;
            }
            set
            {
                this.uuidField = value;
                this.RaisePropertyChanged("uuid");
            }
        }

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
                this.RaisePropertyChanged("FileName");
            }
        }

        /// <remarks/>
        public string NamespaceUri
        {
            get
            {
                return this.namespaceUriField;
            }
            set
            {
                this.namespaceUriField = value;
                this.RaisePropertyChanged("NamespaceUri");
            }
        }

        /// <remarks/>
        public string Hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
                this.RaisePropertyChanged("Hash");
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
                this.RaisePropertyChanged("MimeType");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] SignaturePKCS7
        {
            get
            {
                return this.signaturePKCS7Field;
            }
            set
            {
                this.signaturePKCS7Field = value;
                this.RaisePropertyChanged("SignaturePKCS7");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("File", IsNullable = false)]
        public FileType[] Archive
        {
            get
            {
                return this.archiveField;
            }
            set
            {
                this.archiveField = value;
                this.RaisePropertyChanged("Archive");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public partial class FileType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nameField;

        private string namespaceUriField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        /// <remarks/>
        public string NamespaceUri
        {
            get
            {
                return this.namespaceUriField;
            }
            set
            {
                this.namespaceUriField = value;
                this.RaisePropertyChanged("NamespaceUri");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public partial class AttachmentHeaderType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string contentIdField;

        private string namespaceUriField;

        private string mimeTypeField;

        private byte[] signaturePKCS7Field;

        private FileType[] archiveField;

        /// <remarks/>
        public string contentId
        {
            get
            {
                return this.contentIdField;
            }
            set
            {
                this.contentIdField = value;
                this.RaisePropertyChanged("contentId");
            }
        }

        /// <remarks/>
        public string NamespaceUri
        {
            get
            {
                return this.namespaceUriField;
            }
            set
            {
                this.namespaceUriField = value;
                this.RaisePropertyChanged("NamespaceUri");
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
                this.RaisePropertyChanged("MimeType");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] SignaturePKCS7
        {
            get
            {
                return this.signaturePKCS7Field;
            }
            set
            {
                this.signaturePKCS7Field = value;
                this.RaisePropertyChanged("SignaturePKCS7");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("File", IsNullable = false)]
        public FileType[] Archive
        {
            get
            {
                return this.archiveField;
            }
            set
            {
                this.archiveField = value;
                this.RaisePropertyChanged("Archive");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public partial class AttachmentHeaderList : object, System.ComponentModel.INotifyPropertyChanged
    {

        private AttachmentHeaderType[] attachmentHeaderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentHeader")]
        public AttachmentHeaderType[] AttachmentHeader
        {
            get
            {
                return this.attachmentHeaderField;
            }
            set
            {
                this.attachmentHeaderField = value;
                this.RaisePropertyChanged("AttachmentHeader");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public partial class AttachmentContentList : object, System.ComponentModel.INotifyPropertyChanged
    {

        private AttachmentContentType[] attachmentContentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentContent")]
        public AttachmentContentType[] AttachmentContent
        {
            get
            {
                return this.attachmentContentField;
            }
            set
            {
                this.attachmentContentField = value;
                this.RaisePropertyChanged("AttachmentContent");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public partial class AttachmentContentType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string idField;

        private byte[] contentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("Content");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public partial class FSAttachmentsList : object, System.ComponentModel.INotifyPropertyChanged
    {

        private FSAuthInfo[] fSAttachmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FSAttachment")]
        public FSAuthInfo[] FSAttachment
        {
            get
            {
                return this.fSAttachmentField;
            }
            set
            {
                this.fSAttachmentField = value;
                this.RaisePropertyChanged("FSAttachment");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public partial class FSAuthInfo : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string uuidField;

        private string userNameField;

        private string passwordField;

        private string fileNameField;

        /// <remarks/>
        public string uuid
        {
            get
            {
                return this.uuidField;
            }
            set
            {
                this.uuidField = value;
                this.RaisePropertyChanged("uuid");
            }
        }

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
                this.RaisePropertyChanged("FileName");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public partial class RefAttachmentHeaderList : object, System.ComponentModel.INotifyPropertyChanged
    {

        private RefAttachmentHeaderType[] refAttachmentHeaderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RefAttachmentHeader")]
        public RefAttachmentHeaderType[] RefAttachmentHeader
        {
            get
            {
                return this.refAttachmentHeaderField;
            }
            set
            {
                this.refAttachmentHeaderField = value;
                this.RaisePropertyChanged("RefAttachmentHeader");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public partial class MessageReference : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public partial class AckTargetMessage : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string idField;

        private bool acceptedField;

        private bool acceptedFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool accepted
        {
            get
            {
                return this.acceptedField;
            }
            set
            {
                this.acceptedField = value;
                this.RaisePropertyChanged("accepted");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool acceptedSpecified
        {
            get
            {
                return this.acceptedFieldSpecified;
            }
            set
            {
                this.acceptedFieldSpecified = value;
                this.RaisePropertyChanged("acceptedSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public partial class MessageTypeSelector : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string namespaceURIField;

        private string rootElementLocalNameField;

        private System.DateTime timestampField;

        private string nodeIDField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string NamespaceURI
        {
            get
            {
                return this.namespaceURIField;
            }
            set
            {
                this.namespaceURIField = value;
                this.RaisePropertyChanged("NamespaceURI");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "NCName")]
        public string RootElementLocalName
        {
            get
            {
                return this.rootElementLocalNameField;
            }
            set
            {
                this.rootElementLocalNameField = value;
                this.RaisePropertyChanged("RootElementLocalName");
            }
        }

        /// <remarks/>
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
                this.RaisePropertyChanged("Timestamp");
            }
        }

        /// <remarks/>
        public string NodeID
        {
            get
            {
                return this.nodeIDField;
            }
            set
            {
                this.nodeIDField = value;
                this.RaisePropertyChanged("NodeID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public partial class Timestamp : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string idField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

