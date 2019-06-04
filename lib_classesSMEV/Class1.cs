using System;
using System.Xml.Serialization;
// Test commit 
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

