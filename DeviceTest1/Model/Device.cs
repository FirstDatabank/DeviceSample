using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DeviceSample.Model
{
    /// <summary>
    /// Contains elements that describe a device
    /// </summary>
    [DataContract]
    public partial class Device :  IEquatable<Device>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// Initializes a new instance of the <see cref="Device" />class.
        /// </summary>
        /// <param name="DeviceName">Returns the name of the device identified from the device package, documentation or FDA filings.</param>
        /// <param name="EnhancedDeviceName">Returns a more descriptive name for a device composed of the labeler name, device name, and relevant size.</param>
        /// <param name="LabelerID">Returns the Id of the associated labeler.</param>
        /// <param name="LabelerName">Returns manufacturer or distributor name of the product.</param>
        /// <param name="UDI">Returns an identifier issued by GS1, HIBCC, or ICCBBA to uniquely identify the product.</param>
        /// <param name="GTIN14">Returns Global Trade Identification Number assigned by GS1.</param>
        /// <param name="HIBC">Returns Healthcase Industry Bar Code assigned by HIBCC.</param>
        /// <param name="ISBT128">Returns the International Society of Blood Transfusion.128 code assigned by ICCBBA.</param>
        /// <param name="UPC">Returns the Universal Product Code assigned by GS1.</param>
        /// <param name="GUDIDDescription">Contains additional relevant information about the device that is not already captured as a distinct GUDID data attribute.</param>
        /// <param name="DeviceTerms">DeviceTerms.</param>
        /// <param name="HCPCSCodes">Returns Healthcare Common Procedure Coding System code(s) and/or Current Procedural Terminology code(s) assigned to the product\r\n            for medical billing purposes.</param>
        /// <param name="BasePackageType">Returns the packaging unit used for the base package.</param>
        /// <param name="BasePackageCount">Returns the number if individual products/items in the base package.</param>
        /// <param name="UnitOfUseDINumber">An identifier assigned to an individual medical device when a UDI is not labeled on the individual device at the level of its unit of use. Its purpose is to associate the use of a device to/on a patient.</param>
        /// <param name="FDBVersionNumber">Returns an identifier assigned by the labeler to identify the specific design of the product.</param>
        /// <param name="VersionModelNumber">Returns an identifier assigned by the labeler to identify the specific design of the product.</param>
        /// <param name="CatalogNumber">Returns an identifier assigned by the labeler for use in product catalog and/or labeling to reference the product.</param>
        /// <param name="MRISafetyStatus">Identifies whether the product is safe, unsafe, or conditionally safe for a patient to have in an MR environment.</param>
        /// <param name="LatexIndicator">Indicates whether or not the product and/or packaging contains natural rubber latex.</param>
        /// <param name="IsFDAImplantDevice">Indicates whether or not the device or tissue is placed inside or on the surface of the body.</param>
        /// <param name="HasLotNumber">Indicates whether device has lot or batch number.</param>
        /// <param name="HasSerialNumber">Indicates whether device has a serial number.</param>
        /// <param name="HasExpirationDate">Indicates whether device has an expiration date.</param>
        /// <param name="HasManufacturingDate">Indicates whether device has a manufacturing date.</param>
        /// <param name="IsSingleUse">Indicates that the device is intended for one use or on a single patient during a single procedure..</param>
        /// <param name="RequiresPrescriptionIndicator">Indicates that the device requires a prescription to use..</param>
        /// <param name="DIRecordPublishDate">Indicates the date the DI Record is published and available via Public Search.</param>
        /// <param name="IsDifferentFromPrimaryDI">Indicates that the DM DI Number is different than the Primary DI Number.</param>
        /// <param name="DirectMarkingDI">Returns an indentifier that is marked directly on the medical device and is different than the Primary DI Number.</param>
        /// <param name="ConsumerInfo">Returns the Customer Contact information to be used by patients and consumers for device-related questions.</param>
        /// <param name="HasHCT">Indicates whether or not the product contains human cells or tissue.</param>
        /// <param name="IsKit">Indicates that the device is a convenience, combination, in vitro diagnostic (IVD), or medical procedure kit.</param>
        /// <param name="IsCombinationProduct">Indicates if the product combines drugs, devices, and/or biological products.</param>
        /// <param name="FDAProductInfo">Returns the Product Information.</param>
        /// <param name="HasDonationIdentificationNumberOnLabel">Returns the donation identification number.</param>
        /// <param name="IsOTC">Indicates that the device does not require a prescription to use.</param>
        /// <param name="SizeInfo">Returns clinical dimensions of the product.</param>
        /// <param name="StorageInfo">Returns storage and handling requirements for the device.</param>
        /// <param name="IsDevicePackagedAsSterile">Indicates whether the device is marketed as sterilized or not.</param>
        /// <param name="RequiresSterilizationPriorToUseIndicator">Indicates whether the device requires sterilization prior to use.</param>
        /// <param name="SterilizationMethod">Indicates the method(s) of sterilization that can be used for this device.</param>
        /// <param name="DeviceCategory">Returns FDA Device Class category.</param>

        public Device(string DeviceName = null, string EnhancedDeviceName = null, string LabelerID = null, string LabelerName = null, string UDI = null, string GTIN14 = null, string HIBC = null, string ISBT128 = null, string UPC = null, string GUDIDDescription = null, List<DeviceTerm> DeviceTerms = null, List<string> HCPCSCodes = null, string BasePackageType = null, string BasePackageCount = null, string UnitOfUseDINumber = null, string FDBVersionNumber = null, string VersionModelNumber = null, List<string> CatalogNumber = null, string MRISafetyStatus = null, bool? LatexIndicator = null, bool? IsFDAImplantDevice = null, bool? HasLotNumber = null, bool? HasSerialNumber = null, bool? HasExpirationDate = null, bool? HasManufacturingDate = null, bool? IsSingleUse = null, bool? RequiresPrescriptionIndicator = null, DateTime? DIRecordPublishDate = null, bool? IsDifferentFromPrimaryDI = null, string DirectMarkingDI = null, List<ConsumerInfo> ConsumerInfo = null, bool? HasHCT = null, bool? IsKit = null, bool? IsCombinationProduct = null, List<FDAProductInfo> FDAProductInfo = null, bool? HasDonationIdentificationNumberOnLabel = null, bool? IsOTC = null, List<SizeInfo> SizeInfo = null, List<StorageInfo> StorageInfo = null, bool? IsDevicePackagedAsSterile = null, bool? RequiresSterilizationPriorToUseIndicator = null, List<string> SterilizationMethod = null, List<string> DeviceCategory = null)
        {
            this.DeviceName = DeviceName;
            this.EnhancedDeviceName = EnhancedDeviceName;
            this.LabelerID = LabelerID;
            this.LabelerName = LabelerName;
            this.UDI = UDI;
            this.GTIN14 = GTIN14;
            this.HIBC = HIBC;
            this.ISBT128 = ISBT128;
            this.UPC = UPC;
            this.GUDIDDescription = GUDIDDescription;
            this.DeviceTerms = DeviceTerms;
            this.HCPCSCodes = HCPCSCodes;
            this.BasePackageType = BasePackageType;
            this.BasePackageCount = BasePackageCount;
            this.UnitOfUseDINumber = UnitOfUseDINumber;
            this.FDBVersionNumber = FDBVersionNumber;
            this.VersionModelNumber = VersionModelNumber;
            this.CatalogNumber = CatalogNumber;
            this.MRISafetyStatus = MRISafetyStatus;
            this.LatexIndicator = LatexIndicator;
            this.IsFDAImplantDevice = IsFDAImplantDevice;
            this.HasLotNumber = HasLotNumber;
            this.HasSerialNumber = HasSerialNumber;
            this.HasExpirationDate = HasExpirationDate;
            this.HasManufacturingDate = HasManufacturingDate;
            this.IsSingleUse = IsSingleUse;
            this.RequiresPrescriptionIndicator = RequiresPrescriptionIndicator;
            this.DIRecordPublishDate = DIRecordPublishDate;
            this.IsDifferentFromPrimaryDI = IsDifferentFromPrimaryDI;
            this.DirectMarkingDI = DirectMarkingDI;
            this.ConsumerInfo = ConsumerInfo;
            this.HasHCT = HasHCT;
            this.IsKit = IsKit;
            this.IsCombinationProduct = IsCombinationProduct;
            this.FDAProductInfo = FDAProductInfo;
            this.HasDonationIdentificationNumberOnLabel = HasDonationIdentificationNumberOnLabel;
            this.IsOTC = IsOTC;
            this.SizeInfo = SizeInfo;
            this.StorageInfo = StorageInfo;
            this.IsDevicePackagedAsSterile = IsDevicePackagedAsSterile;
            this.RequiresSterilizationPriorToUseIndicator = RequiresSterilizationPriorToUseIndicator;
            this.SterilizationMethod = SterilizationMethod;
            this.DeviceCategory = DeviceCategory;
            
        }
        
    
        /// <summary>
        /// Returns the name of the device identified from the device package, documentation or FDA filings
        /// </summary>
        /// <value>Returns the name of the device identified from the device package, documentation or FDA filings</value>
        [DataMember(Name="DeviceName", EmitDefaultValue=false)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Returns a more descriptive name for a device composed of the labeler name, device name, and relevant size
        /// </summary>
        /// <value>Returns a more descriptive name for a device composed of the labeler name, device name, and relevant size</value>
        [DataMember(Name="EnhancedDeviceName", EmitDefaultValue=false)]
        public string EnhancedDeviceName { get; set; }
    
        /// <summary>
        /// Returns the Id of the associated labeler
        /// </summary>
        /// <value>Returns the Id of the associated labeler</value>
        [DataMember(Name="LabelerID", EmitDefaultValue=false)]
        public string LabelerID { get; set; }
    
        /// <summary>
        /// Returns manufacturer or distributor name of the product
        /// </summary>
        /// <value>Returns manufacturer or distributor name of the product</value>
        [DataMember(Name="LabelerName", EmitDefaultValue=false)]
        public string LabelerName { get; set; }
    
        /// <summary>
        /// Returns an identifier issued by GS1, HIBCC, or ICCBBA to uniquely identify the product
        /// </summary>
        /// <value>Returns an identifier issued by GS1, HIBCC, or ICCBBA to uniquely identify the product</value>
        [DataMember(Name="UDI", EmitDefaultValue=false)]
        public string UDI { get; set; }
    
        /// <summary>
        /// Returns Global Trade Identification Number assigned by GS1
        /// </summary>
        /// <value>Returns Global Trade Identification Number assigned by GS1</value>
        [DataMember(Name="GTIN_14", EmitDefaultValue=false)]
        public string GTIN14 { get; set; }
    
        /// <summary>
        /// Returns Healthcase Industry Bar Code assigned by HIBCC
        /// </summary>
        /// <value>Returns Healthcase Industry Bar Code assigned by HIBCC</value>
        [DataMember(Name="HIBC", EmitDefaultValue=false)]
        public string HIBC { get; set; }
    
        /// <summary>
        /// Returns the International Society of Blood Transfusion.128 code assigned by ICCBBA
        /// </summary>
        /// <value>Returns the International Society of Blood Transfusion.128 code assigned by ICCBBA</value>
        [DataMember(Name="ISBT_128", EmitDefaultValue=false)]
        public string ISBT128 { get; set; }
    
        /// <summary>
        /// Returns the Universal Product Code assigned by GS1
        /// </summary>
        /// <value>Returns the Universal Product Code assigned by GS1</value>
        [DataMember(Name="UPC", EmitDefaultValue=false)]
        public string UPC { get; set; }
    
        /// <summary>
        /// Contains additional relevant information about the device that is not already captured as a distinct GUDID data attribute
        /// </summary>
        /// <value>Contains additional relevant information about the device that is not already captured as a distinct GUDID data attribute</value>
        [DataMember(Name="GUDIDDescription", EmitDefaultValue=false)]
        public string GUDIDDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets DeviceTerms
        /// </summary>
        [DataMember(Name="DeviceTerms", EmitDefaultValue=false)]
        public List<DeviceTerm> DeviceTerms { get; set; }
    
        /// <summary>
        /// Returns Healthcare Common Procedure Coding System code(s) and/or Current Procedural Terminology code(s) assigned to the product\r\n            for medical billing purposes
        /// </summary>
        /// <value>Returns Healthcare Common Procedure Coding System code(s) and/or Current Procedural Terminology code(s) assigned to the product\r\n            for medical billing purposes</value>
        [DataMember(Name="HCPCSCodes", EmitDefaultValue=false)]
        public List<string> HCPCSCodes { get; set; }
    
        /// <summary>
        /// Returns the packaging unit used for the base package
        /// </summary>
        /// <value>Returns the packaging unit used for the base package</value>
        [DataMember(Name="BasePackageType", EmitDefaultValue=false)]
        public string BasePackageType { get; set; }
    
        /// <summary>
        /// Returns the number if individual products/items in the base package
        /// </summary>
        /// <value>Returns the number if individual products/items in the base package</value>
        [DataMember(Name="BasePackageCount", EmitDefaultValue=false)]
        public string BasePackageCount { get; set; }
    
        /// <summary>
        /// An identifier assigned to an individual medical device when a UDI is not labeled on the individual device at the level of its unit of use. Its purpose is to associate the use of a device to/on a patient
        /// </summary>
        /// <value>An identifier assigned to an individual medical device when a UDI is not labeled on the individual device at the level of its unit of use. Its purpose is to associate the use of a device to/on a patient</value>
        [DataMember(Name="UnitOfUseDINumber", EmitDefaultValue=false)]
        public string UnitOfUseDINumber { get; set; }
    
        /// <summary>
        /// Returns an identifier assigned by the labeler to identify the specific design of the product
        /// </summary>
        /// <value>Returns an identifier assigned by the labeler to identify the specific design of the product</value>
        [DataMember(Name="FDBVersionNumber", EmitDefaultValue=false)]
        public string FDBVersionNumber { get; set; }
    
        /// <summary>
        /// Returns an identifier assigned by the labeler to identify the specific design of the product
        /// </summary>
        /// <value>Returns an identifier assigned by the labeler to identify the specific design of the product</value>
        [DataMember(Name="VersionModelNumber", EmitDefaultValue=false)]
        public string VersionModelNumber { get; set; }
    
        /// <summary>
        /// Returns an identifier assigned by the labeler for use in product catalog and/or labeling to reference the product
        /// </summary>
        /// <value>Returns an identifier assigned by the labeler for use in product catalog and/or labeling to reference the product</value>
        [DataMember(Name="CatalogNumber", EmitDefaultValue=false)]
        public List<string> CatalogNumber { get; set; }
    
        /// <summary>
        /// Identifies whether the product is safe, unsafe, or conditionally safe for a patient to have in an MR environment
        /// </summary>
        /// <value>Identifies whether the product is safe, unsafe, or conditionally safe for a patient to have in an MR environment</value>
        [DataMember(Name="MRISafetyStatus", EmitDefaultValue=false)]
        public string MRISafetyStatus { get; set; }
    
        /// <summary>
        /// Indicates whether or not the product and/or packaging contains natural rubber latex
        /// </summary>
        /// <value>Indicates whether or not the product and/or packaging contains natural rubber latex</value>
        [DataMember(Name="LatexIndicator", EmitDefaultValue=false)]
        public bool? LatexIndicator { get; set; }
    
        /// <summary>
        /// Indicates whether or not the device or tissue is placed inside or on the surface of the body
        /// </summary>
        /// <value>Indicates whether or not the device or tissue is placed inside or on the surface of the body</value>
        [DataMember(Name="IsFDAImplantDevice", EmitDefaultValue=false)]
        public bool? IsFDAImplantDevice { get; set; }
    
        /// <summary>
        /// Indicates whether device has lot or batch number
        /// </summary>
        /// <value>Indicates whether device has lot or batch number</value>
        [DataMember(Name="HasLotNumber", EmitDefaultValue=false)]
        public bool? HasLotNumber { get; set; }
    
        /// <summary>
        /// Indicates whether device has a serial number
        /// </summary>
        /// <value>Indicates whether device has a serial number</value>
        [DataMember(Name="HasSerialNumber", EmitDefaultValue=false)]
        public bool? HasSerialNumber { get; set; }
    
        /// <summary>
        /// Indicates whether device has an expiration date
        /// </summary>
        /// <value>Indicates whether device has an expiration date</value>
        [DataMember(Name="HasExpirationDate", EmitDefaultValue=false)]
        public bool? HasExpirationDate { get; set; }
    
        /// <summary>
        /// Indicates whether device has a manufacturing date
        /// </summary>
        /// <value>Indicates whether device has a manufacturing date</value>
        [DataMember(Name="HasManufacturingDate", EmitDefaultValue=false)]
        public bool? HasManufacturingDate { get; set; }
    
        /// <summary>
        /// Indicates that the device is intended for one use or on a single patient during a single procedure.
        /// </summary>
        /// <value>Indicates that the device is intended for one use or on a single patient during a single procedure.</value>
        [DataMember(Name="IsSingleUse", EmitDefaultValue=false)]
        public bool? IsSingleUse { get; set; }
    
        /// <summary>
        /// Indicates that the device requires a prescription to use.
        /// </summary>
        /// <value>Indicates that the device requires a prescription to use.</value>
        [DataMember(Name="RequiresPrescriptionIndicator", EmitDefaultValue=false)]
        public bool? RequiresPrescriptionIndicator { get; set; }
    
        /// <summary>
        /// Indicates the date the DI Record is published and available via Public Search
        /// </summary>
        /// <value>Indicates the date the DI Record is published and available via Public Search</value>
        [DataMember(Name="DIRecordPublishDate", EmitDefaultValue=false)]
        public DateTime? DIRecordPublishDate { get; set; }
    
        /// <summary>
        /// Indicates that the DM DI Number is different than the Primary DI Number
        /// </summary>
        /// <value>Indicates that the DM DI Number is different than the Primary DI Number</value>
        [DataMember(Name="IsDifferentFromPrimaryDI", EmitDefaultValue=false)]
        public bool? IsDifferentFromPrimaryDI { get; set; }
    
        /// <summary>
        /// Returns an indentifier that is marked directly on the medical device and is different than the Primary DI Number
        /// </summary>
        /// <value>Returns an indentifier that is marked directly on the medical device and is different than the Primary DI Number</value>
        [DataMember(Name="DirectMarkingDI", EmitDefaultValue=false)]
        public string DirectMarkingDI { get; set; }
    
        /// <summary>
        /// Returns the Customer Contact information to be used by patients and consumers for device-related questions
        /// </summary>
        /// <value>Returns the Customer Contact information to be used by patients and consumers for device-related questions</value>
        [DataMember(Name="ConsumerInfo", EmitDefaultValue=false)]
        public List<ConsumerInfo> ConsumerInfo { get; set; }
    
        /// <summary>
        /// Indicates whether or not the product contains human cells or tissue
        /// </summary>
        /// <value>Indicates whether or not the product contains human cells or tissue</value>
        [DataMember(Name="HasHCT", EmitDefaultValue=false)]
        public bool? HasHCT { get; set; }
    
        /// <summary>
        /// Indicates that the device is a convenience, combination, in vitro diagnostic (IVD), or medical procedure kit
        /// </summary>
        /// <value>Indicates that the device is a convenience, combination, in vitro diagnostic (IVD), or medical procedure kit</value>
        [DataMember(Name="IsKit", EmitDefaultValue=false)]
        public bool? IsKit { get; set; }
    
        /// <summary>
        /// Indicates if the product combines drugs, devices, and/or biological products
        /// </summary>
        /// <value>Indicates if the product combines drugs, devices, and/or biological products</value>
        [DataMember(Name="IsCombinationProduct", EmitDefaultValue=false)]
        public bool? IsCombinationProduct { get; set; }
    
        /// <summary>
        /// Returns the Product Information
        /// </summary>
        /// <value>Returns the Product Information</value>
        [DataMember(Name="FDAProductInfo", EmitDefaultValue=false)]
        public List<FDAProductInfo> FDAProductInfo { get; set; }
    
        /// <summary>
        /// Returns the donation identification number
        /// </summary>
        /// <value>Returns the donation identification number</value>
        [DataMember(Name="HasDonationIdentificationNumberOnLabel", EmitDefaultValue=false)]
        public bool? HasDonationIdentificationNumberOnLabel { get; set; }
    
        /// <summary>
        /// Indicates that the device does not require a prescription to use
        /// </summary>
        /// <value>Indicates that the device does not require a prescription to use</value>
        [DataMember(Name="IsOTC", EmitDefaultValue=false)]
        public bool? IsOTC { get; set; }
    
        /// <summary>
        /// Returns clinical dimensions of the product
        /// </summary>
        /// <value>Returns clinical dimensions of the product</value>
        [DataMember(Name="SizeInfo", EmitDefaultValue=false)]
        public List<SizeInfo> SizeInfo { get; set; }
    
        /// <summary>
        /// Returns storage and handling requirements for the device
        /// </summary>
        /// <value>Returns storage and handling requirements for the device</value>
        [DataMember(Name="StorageInfo", EmitDefaultValue=false)]
        public List<StorageInfo> StorageInfo { get; set; }
    
        /// <summary>
        /// Indicates whether the device is marketed as sterilized or not
        /// </summary>
        /// <value>Indicates whether the device is marketed as sterilized or not</value>
        [DataMember(Name="IsDevicePackagedAsSterile", EmitDefaultValue=false)]
        public bool? IsDevicePackagedAsSterile { get; set; }
    
        /// <summary>
        /// Indicates whether the device requires sterilization prior to use
        /// </summary>
        /// <value>Indicates whether the device requires sterilization prior to use</value>
        [DataMember(Name="RequiresSterilizationPriorToUseIndicator", EmitDefaultValue=false)]
        public bool? RequiresSterilizationPriorToUseIndicator { get; set; }
    
        /// <summary>
        /// Indicates the method(s) of sterilization that can be used for this device
        /// </summary>
        /// <value>Indicates the method(s) of sterilization that can be used for this device</value>
        [DataMember(Name="SterilizationMethod", EmitDefaultValue=false)]
        public List<string> SterilizationMethod { get; set; }
    
        /// <summary>
        /// Returns FDA Device Class category
        /// </summary>
        /// <value>Returns FDA Device Class category</value>
        [DataMember(Name="DeviceCategory", EmitDefaultValue=false)]
        public List<string> DeviceCategory { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Device {\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  EnhancedDeviceName: ").Append(EnhancedDeviceName).Append("\n");
            sb.Append("  LabelerID: ").Append(LabelerID).Append("\n");
            sb.Append("  LabelerName: ").Append(LabelerName).Append("\n");
            sb.Append("  UDI: ").Append(UDI).Append("\n");
            sb.Append("  GTIN14: ").Append(GTIN14).Append("\n");
            sb.Append("  HIBC: ").Append(HIBC).Append("\n");
            sb.Append("  ISBT128: ").Append(ISBT128).Append("\n");
            sb.Append("  UPC: ").Append(UPC).Append("\n");
            sb.Append("  GUDIDDescription: ").Append(GUDIDDescription).Append("\n");
            sb.Append("  DeviceTerms: ").Append(DeviceTerms).Append("\n");
            sb.Append("  HCPCSCodes: ").Append(HCPCSCodes).Append("\n");
            sb.Append("  BasePackageType: ").Append(BasePackageType).Append("\n");
            sb.Append("  BasePackageCount: ").Append(BasePackageCount).Append("\n");
            sb.Append("  UnitOfUseDINumber: ").Append(UnitOfUseDINumber).Append("\n");
            sb.Append("  FDBVersionNumber: ").Append(FDBVersionNumber).Append("\n");
            sb.Append("  VersionModelNumber: ").Append(VersionModelNumber).Append("\n");
            sb.Append("  CatalogNumber: ").Append(CatalogNumber).Append("\n");
            sb.Append("  MRISafetyStatus: ").Append(MRISafetyStatus).Append("\n");
            sb.Append("  LatexIndicator: ").Append(LatexIndicator).Append("\n");
            sb.Append("  IsFDAImplantDevice: ").Append(IsFDAImplantDevice).Append("\n");
            sb.Append("  HasLotNumber: ").Append(HasLotNumber).Append("\n");
            sb.Append("  HasSerialNumber: ").Append(HasSerialNumber).Append("\n");
            sb.Append("  HasExpirationDate: ").Append(HasExpirationDate).Append("\n");
            sb.Append("  HasManufacturingDate: ").Append(HasManufacturingDate).Append("\n");
            sb.Append("  IsSingleUse: ").Append(IsSingleUse).Append("\n");
            sb.Append("  RequiresPrescriptionIndicator: ").Append(RequiresPrescriptionIndicator).Append("\n");
            sb.Append("  DIRecordPublishDate: ").Append(DIRecordPublishDate).Append("\n");
            sb.Append("  IsDifferentFromPrimaryDI: ").Append(IsDifferentFromPrimaryDI).Append("\n");
            sb.Append("  DirectMarkingDI: ").Append(DirectMarkingDI).Append("\n");
            sb.Append("  ConsumerInfo: ").Append(ConsumerInfo).Append("\n");
            sb.Append("  HasHCT: ").Append(HasHCT).Append("\n");
            sb.Append("  IsKit: ").Append(IsKit).Append("\n");
            sb.Append("  IsCombinationProduct: ").Append(IsCombinationProduct).Append("\n");
            sb.Append("  FDAProductInfo: ").Append(FDAProductInfo).Append("\n");
            sb.Append("  HasDonationIdentificationNumberOnLabel: ").Append(HasDonationIdentificationNumberOnLabel).Append("\n");
            sb.Append("  IsOTC: ").Append(IsOTC).Append("\n");
            sb.Append("  SizeInfo: ").Append(SizeInfo).Append("\n");
            sb.Append("  StorageInfo: ").Append(StorageInfo).Append("\n");
            sb.Append("  IsDevicePackagedAsSterile: ").Append(IsDevicePackagedAsSterile).Append("\n");
            sb.Append("  RequiresSterilizationPriorToUseIndicator: ").Append(RequiresSterilizationPriorToUseIndicator).Append("\n");
            sb.Append("  SterilizationMethod: ").Append(SterilizationMethod).Append("\n");
            sb.Append("  DeviceCategory: ").Append(DeviceCategory).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Device);
        }

        /// <summary>
        /// Returns true if Device instances are equal
        /// </summary>
        /// <param name="other">Instance of Device to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Device other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceName == other.DeviceName ||
                    this.DeviceName != null &&
                    this.DeviceName.Equals(other.DeviceName)
                ) && 
                (
                    this.EnhancedDeviceName == other.EnhancedDeviceName ||
                    this.EnhancedDeviceName != null &&
                    this.EnhancedDeviceName.Equals(other.EnhancedDeviceName)
                ) && 
                (
                    this.LabelerID == other.LabelerID ||
                    this.LabelerID != null &&
                    this.LabelerID.Equals(other.LabelerID)
                ) && 
                (
                    this.LabelerName == other.LabelerName ||
                    this.LabelerName != null &&
                    this.LabelerName.Equals(other.LabelerName)
                ) && 
                (
                    this.UDI == other.UDI ||
                    this.UDI != null &&
                    this.UDI.Equals(other.UDI)
                ) && 
                (
                    this.GTIN14 == other.GTIN14 ||
                    this.GTIN14 != null &&
                    this.GTIN14.Equals(other.GTIN14)
                ) && 
                (
                    this.HIBC == other.HIBC ||
                    this.HIBC != null &&
                    this.HIBC.Equals(other.HIBC)
                ) && 
                (
                    this.ISBT128 == other.ISBT128 ||
                    this.ISBT128 != null &&
                    this.ISBT128.Equals(other.ISBT128)
                ) && 
                (
                    this.UPC == other.UPC ||
                    this.UPC != null &&
                    this.UPC.Equals(other.UPC)
                ) && 
                (
                    this.GUDIDDescription == other.GUDIDDescription ||
                    this.GUDIDDescription != null &&
                    this.GUDIDDescription.Equals(other.GUDIDDescription)
                ) && 
                (
                    this.DeviceTerms == other.DeviceTerms ||
                    this.DeviceTerms != null &&
                    this.DeviceTerms.SequenceEqual(other.DeviceTerms)
                ) && 
                (
                    this.HCPCSCodes == other.HCPCSCodes ||
                    this.HCPCSCodes != null &&
                    this.HCPCSCodes.SequenceEqual(other.HCPCSCodes)
                ) && 
                (
                    this.BasePackageType == other.BasePackageType ||
                    this.BasePackageType != null &&
                    this.BasePackageType.Equals(other.BasePackageType)
                ) && 
                (
                    this.BasePackageCount == other.BasePackageCount ||
                    this.BasePackageCount != null &&
                    this.BasePackageCount.Equals(other.BasePackageCount)
                ) && 
                (
                    this.UnitOfUseDINumber == other.UnitOfUseDINumber ||
                    this.UnitOfUseDINumber != null &&
                    this.UnitOfUseDINumber.Equals(other.UnitOfUseDINumber)
                ) && 
                (
                    this.FDBVersionNumber == other.FDBVersionNumber ||
                    this.FDBVersionNumber != null &&
                    this.FDBVersionNumber.Equals(other.FDBVersionNumber)
                ) && 
                (
                    this.VersionModelNumber == other.VersionModelNumber ||
                    this.VersionModelNumber != null &&
                    this.VersionModelNumber.Equals(other.VersionModelNumber)
                ) && 
                (
                    this.CatalogNumber == other.CatalogNumber ||
                    this.CatalogNumber != null &&
                    this.CatalogNumber.SequenceEqual(other.CatalogNumber)
                ) && 
                (
                    this.MRISafetyStatus == other.MRISafetyStatus ||
                    this.MRISafetyStatus != null &&
                    this.MRISafetyStatus.Equals(other.MRISafetyStatus)
                ) && 
                (
                    this.LatexIndicator == other.LatexIndicator ||
                    this.LatexIndicator != null &&
                    this.LatexIndicator.Equals(other.LatexIndicator)
                ) && 
                (
                    this.IsFDAImplantDevice == other.IsFDAImplantDevice ||
                    this.IsFDAImplantDevice != null &&
                    this.IsFDAImplantDevice.Equals(other.IsFDAImplantDevice)
                ) && 
                (
                    this.HasLotNumber == other.HasLotNumber ||
                    this.HasLotNumber != null &&
                    this.HasLotNumber.Equals(other.HasLotNumber)
                ) && 
                (
                    this.HasSerialNumber == other.HasSerialNumber ||
                    this.HasSerialNumber != null &&
                    this.HasSerialNumber.Equals(other.HasSerialNumber)
                ) && 
                (
                    this.HasExpirationDate == other.HasExpirationDate ||
                    this.HasExpirationDate != null &&
                    this.HasExpirationDate.Equals(other.HasExpirationDate)
                ) && 
                (
                    this.HasManufacturingDate == other.HasManufacturingDate ||
                    this.HasManufacturingDate != null &&
                    this.HasManufacturingDate.Equals(other.HasManufacturingDate)
                ) && 
                (
                    this.IsSingleUse == other.IsSingleUse ||
                    this.IsSingleUse != null &&
                    this.IsSingleUse.Equals(other.IsSingleUse)
                ) && 
                (
                    this.RequiresPrescriptionIndicator == other.RequiresPrescriptionIndicator ||
                    this.RequiresPrescriptionIndicator != null &&
                    this.RequiresPrescriptionIndicator.Equals(other.RequiresPrescriptionIndicator)
                ) && 
                (
                    this.DIRecordPublishDate == other.DIRecordPublishDate ||
                    this.DIRecordPublishDate != null &&
                    this.DIRecordPublishDate.Equals(other.DIRecordPublishDate)
                ) && 
                (
                    this.IsDifferentFromPrimaryDI == other.IsDifferentFromPrimaryDI ||
                    this.IsDifferentFromPrimaryDI != null &&
                    this.IsDifferentFromPrimaryDI.Equals(other.IsDifferentFromPrimaryDI)
                ) && 
                (
                    this.DirectMarkingDI == other.DirectMarkingDI ||
                    this.DirectMarkingDI != null &&
                    this.DirectMarkingDI.Equals(other.DirectMarkingDI)
                ) && 
                (
                    this.ConsumerInfo == other.ConsumerInfo ||
                    this.ConsumerInfo != null &&
                    this.ConsumerInfo.SequenceEqual(other.ConsumerInfo)
                ) && 
                (
                    this.HasHCT == other.HasHCT ||
                    this.HasHCT != null &&
                    this.HasHCT.Equals(other.HasHCT)
                ) && 
                (
                    this.IsKit == other.IsKit ||
                    this.IsKit != null &&
                    this.IsKit.Equals(other.IsKit)
                ) && 
                (
                    this.IsCombinationProduct == other.IsCombinationProduct ||
                    this.IsCombinationProduct != null &&
                    this.IsCombinationProduct.Equals(other.IsCombinationProduct)
                ) && 
                (
                    this.FDAProductInfo == other.FDAProductInfo ||
                    this.FDAProductInfo != null &&
                    this.FDAProductInfo.SequenceEqual(other.FDAProductInfo)
                ) && 
                (
                    this.HasDonationIdentificationNumberOnLabel == other.HasDonationIdentificationNumberOnLabel ||
                    this.HasDonationIdentificationNumberOnLabel != null &&
                    this.HasDonationIdentificationNumberOnLabel.Equals(other.HasDonationIdentificationNumberOnLabel)
                ) && 
                (
                    this.IsOTC == other.IsOTC ||
                    this.IsOTC != null &&
                    this.IsOTC.Equals(other.IsOTC)
                ) && 
                (
                    this.SizeInfo == other.SizeInfo ||
                    this.SizeInfo != null &&
                    this.SizeInfo.SequenceEqual(other.SizeInfo)
                ) && 
                (
                    this.StorageInfo == other.StorageInfo ||
                    this.StorageInfo != null &&
                    this.StorageInfo.SequenceEqual(other.StorageInfo)
                ) && 
                (
                    this.IsDevicePackagedAsSterile == other.IsDevicePackagedAsSterile ||
                    this.IsDevicePackagedAsSterile != null &&
                    this.IsDevicePackagedAsSterile.Equals(other.IsDevicePackagedAsSterile)
                ) && 
                (
                    this.RequiresSterilizationPriorToUseIndicator == other.RequiresSterilizationPriorToUseIndicator ||
                    this.RequiresSterilizationPriorToUseIndicator != null &&
                    this.RequiresSterilizationPriorToUseIndicator.Equals(other.RequiresSterilizationPriorToUseIndicator)
                ) && 
                (
                    this.SterilizationMethod == other.SterilizationMethod ||
                    this.SterilizationMethod != null &&
                    this.SterilizationMethod.SequenceEqual(other.SterilizationMethod)
                ) && 
                (
                    this.DeviceCategory == other.DeviceCategory ||
                    this.DeviceCategory != null &&
                    this.DeviceCategory.SequenceEqual(other.DeviceCategory)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.DeviceName != null)
                    hash = hash * 59 + this.DeviceName.GetHashCode();
                
                if (this.EnhancedDeviceName != null)
                    hash = hash * 59 + this.EnhancedDeviceName.GetHashCode();
                
                if (this.LabelerID != null)
                    hash = hash * 59 + this.LabelerID.GetHashCode();
                
                if (this.LabelerName != null)
                    hash = hash * 59 + this.LabelerName.GetHashCode();
                
                if (this.UDI != null)
                    hash = hash * 59 + this.UDI.GetHashCode();
                
                if (this.GTIN14 != null)
                    hash = hash * 59 + this.GTIN14.GetHashCode();
                
                if (this.HIBC != null)
                    hash = hash * 59 + this.HIBC.GetHashCode();
                
                if (this.ISBT128 != null)
                    hash = hash * 59 + this.ISBT128.GetHashCode();
                
                if (this.UPC != null)
                    hash = hash * 59 + this.UPC.GetHashCode();
                
                if (this.GUDIDDescription != null)
                    hash = hash * 59 + this.GUDIDDescription.GetHashCode();
                
                if (this.DeviceTerms != null)
                    hash = hash * 59 + this.DeviceTerms.GetHashCode();
                
                if (this.HCPCSCodes != null)
                    hash = hash * 59 + this.HCPCSCodes.GetHashCode();
                
                if (this.BasePackageType != null)
                    hash = hash * 59 + this.BasePackageType.GetHashCode();
                
                if (this.BasePackageCount != null)
                    hash = hash * 59 + this.BasePackageCount.GetHashCode();
                
                if (this.UnitOfUseDINumber != null)
                    hash = hash * 59 + this.UnitOfUseDINumber.GetHashCode();
                
                if (this.FDBVersionNumber != null)
                    hash = hash * 59 + this.FDBVersionNumber.GetHashCode();
                
                if (this.VersionModelNumber != null)
                    hash = hash * 59 + this.VersionModelNumber.GetHashCode();
                
                if (this.CatalogNumber != null)
                    hash = hash * 59 + this.CatalogNumber.GetHashCode();
                
                if (this.MRISafetyStatus != null)
                    hash = hash * 59 + this.MRISafetyStatus.GetHashCode();
                
                if (this.LatexIndicator != null)
                    hash = hash * 59 + this.LatexIndicator.GetHashCode();
                
                if (this.IsFDAImplantDevice != null)
                    hash = hash * 59 + this.IsFDAImplantDevice.GetHashCode();
                
                if (this.HasLotNumber != null)
                    hash = hash * 59 + this.HasLotNumber.GetHashCode();
                
                if (this.HasSerialNumber != null)
                    hash = hash * 59 + this.HasSerialNumber.GetHashCode();
                
                if (this.HasExpirationDate != null)
                    hash = hash * 59 + this.HasExpirationDate.GetHashCode();
                
                if (this.HasManufacturingDate != null)
                    hash = hash * 59 + this.HasManufacturingDate.GetHashCode();
                
                if (this.IsSingleUse != null)
                    hash = hash * 59 + this.IsSingleUse.GetHashCode();
                
                if (this.RequiresPrescriptionIndicator != null)
                    hash = hash * 59 + this.RequiresPrescriptionIndicator.GetHashCode();
                
                if (this.DIRecordPublishDate != null)
                    hash = hash * 59 + this.DIRecordPublishDate.GetHashCode();
                
                if (this.IsDifferentFromPrimaryDI != null)
                    hash = hash * 59 + this.IsDifferentFromPrimaryDI.GetHashCode();
                
                if (this.DirectMarkingDI != null)
                    hash = hash * 59 + this.DirectMarkingDI.GetHashCode();
                
                if (this.ConsumerInfo != null)
                    hash = hash * 59 + this.ConsumerInfo.GetHashCode();
                
                if (this.HasHCT != null)
                    hash = hash * 59 + this.HasHCT.GetHashCode();
                
                if (this.IsKit != null)
                    hash = hash * 59 + this.IsKit.GetHashCode();
                
                if (this.IsCombinationProduct != null)
                    hash = hash * 59 + this.IsCombinationProduct.GetHashCode();
                
                if (this.FDAProductInfo != null)
                    hash = hash * 59 + this.FDAProductInfo.GetHashCode();
                
                if (this.HasDonationIdentificationNumberOnLabel != null)
                    hash = hash * 59 + this.HasDonationIdentificationNumberOnLabel.GetHashCode();
                
                if (this.IsOTC != null)
                    hash = hash * 59 + this.IsOTC.GetHashCode();
                
                if (this.SizeInfo != null)
                    hash = hash * 59 + this.SizeInfo.GetHashCode();
                
                if (this.StorageInfo != null)
                    hash = hash * 59 + this.StorageInfo.GetHashCode();
                
                if (this.IsDevicePackagedAsSterile != null)
                    hash = hash * 59 + this.IsDevicePackagedAsSterile.GetHashCode();
                
                if (this.RequiresSterilizationPriorToUseIndicator != null)
                    hash = hash * 59 + this.RequiresSterilizationPriorToUseIndicator.GetHashCode();
                
                if (this.SterilizationMethod != null)
                    hash = hash * 59 + this.SterilizationMethod.GetHashCode();
                
                if (this.DeviceCategory != null)
                    hash = hash * 59 + this.DeviceCategory.GetHashCode();
                
                return hash;
            }
        }

    }
}
