using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngrafiiExecutor
{
    /*
    public class PackageAdded_Result
    {
        public string packageId { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string state { get; set; }
        public _documents documents { get; set; }
        public _signers signers { get; set; }
    }

    public class _documents
    {
        public string documentId { get; set; }
        public string packageId { get; set; }
        public string fileName { get; set; }
        public _revisions revisions { get; set; }

    }

    public class _revisions
    {
        public string documentId { get; set; }
        public string revisionsId { get; set; }
        public int revisionNumber { get; set; }
        public string signerId { get; set; }
    }

    public class _signers
    {
        public string packageId { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string type { get; set; }
        public string timeExpires { get; set; } //format seems to be "YYYY-MM-DDTHH:mm:ss:fffZ"
    }
    */


    public class PackageAdded_Result
    {
        public Package package { get; set; }
        public object contacts { get; set; }
        public string action { get; set; }
        public string eventId { get; set; }
    }

    public class Package
    {
        public string packageId { get; set; }
        public string ownerUserId { get; set; }
        public string organizationId { get; set; }
        public string memberId { get; set; }
        public object meetingId { get; set; }
        public string keyId { get; set; }
        public string name { get; set; }
        public object category { get; set; }
        public object description { get; set; }
        public object message { get; set; }
        public DateTime timeCreated { get; set; }
        public object timeRetention { get; set; }
        public object timeDeleted { get; set; }
        public DateTime timeSignBy { get; set; }
        public DateTime timeLastModified { get; set; }
        public Options options { get; set; }
        public string locale { get; set; }
        public string type { get; set; }
        public string state { get; set; }
        public bool api { get; set; }
        public object externalData { get; set; }
        public Context context { get; set; }
        public Tracker tracker { get; set; }
        public string action { get; set; }
        public object[] deletedDocuments { get; set; }
        public object[] deletedSigners { get; set; }
        public Organization organization { get; set; }
        public Owner owner { get; set; }
        public object member { get; set; }
        public object meeting { get; set; }
        public object[] meetings { get; set; }
        public Document[] documents { get; set; }
        public Signer1[] signers { get; set; }
        public object access { get; set; }
        public object history { get; set; }
        public object notifications { get; set; }
        public object[] notificationAlerts { get; set; }
    }

    public class Options
    {
        public bool embedded { get; set; }
        public object embeddedTheme { get; set; }
        public object brandId { get; set; }
        public bool requestGeoLocation { get; set; }
        public bool addDocumentIdentifier { get; set; }
        public object retentionPeriod { get; set; }
        public object cacText { get; set; }
        public bool templateParseTags { get; set; }
        public bool securityCode { get; set; }
        public bool securityPassphrase { get; set; }
        public bool markAll { get; set; }
        public bool markClickToSign { get; set; }
        public bool markTypeToSign { get; set; }
        public bool markTouchToSign { get; set; }
        public bool allowMarkTouchToSignMouse { get; set; }
        public bool meetingVideoRecordingAuto { get; set; }
        public bool meetingVideoRecordingDisabled { get; set; }
        public object meetingVideoRetentionPeriod { get; set; }
        public bool masterFileShareMeetings { get; set; }
        public bool notificationsOff { get; set; }
        public bool notifyConfirmation { get; set; }
        public bool notifyAccessed { get; set; }
        public bool notifyPackageSign { get; set; }
        public bool notifySigners { get; set; }
        public bool notifyMeeting { get; set; }
        public bool notifyMeetingIcsAttachment { get; set; }
        public bool notifyDocumentExecuted { get; set; }
        public bool notifyDocumentExecutedOwner { get; set; }
        public bool notifyDocumentExecutedSigners { get; set; }
        public bool notifyDocumentExecutedAttachRevision { get; set; }
        public bool notifyDocumentExecutedAttachExecuted { get; set; }
        public bool notifyDocumentExecutedAttachCac { get; set; }
        public bool allowSignerTools { get; set; }
        public bool allowSignerToolsTemplate { get; set; }
        public Signertools signerTools { get; set; }
    }

    public class Signertools
    {
        public bool sign { get; set; }
        public bool annotateMobile { get; set; }
        public bool annotateDesktop { get; set; }
        public bool text { get; set; }
        public bool note { get; set; }
        public bool stamp { get; set; }
        public bool forms { get; set; }
        public bool autoForms { get; set; }
        public bool image { get; set; }
    }

    public class Context
    {
        public object generateSignerLinks { get; set; }
    }

    public class Tracker
    {
        public DateTime timeSignBy { get; set; }
        public string name { get; set; }
        public object message { get; set; }
        public Options1 options { get; set; }
        public string action { get; set; }
        public bool wasExecuted { get; set; }
        public object updatedLinks { get; set; }
    }

    public class Options1
    {
        public bool embedded { get; set; }
        public object embeddedTheme { get; set; }
        public object brandId { get; set; }
        public bool requestGeoLocation { get; set; }
        public bool addDocumentIdentifier { get; set; }
        public object retentionPeriod { get; set; }
        public object cacText { get; set; }
        public bool templateParseTags { get; set; }
        public bool securityCode { get; set; }
        public bool securityPassphrase { get; set; }
        public bool markAll { get; set; }
        public bool markClickToSign { get; set; }
        public bool markTypeToSign { get; set; }
        public bool markTouchToSign { get; set; }
        public bool allowMarkTouchToSignMouse { get; set; }
        public bool meetingVideoRecordingAuto { get; set; }
        public bool meetingVideoRecordingDisabled { get; set; }
        public object meetingVideoRetentionPeriod { get; set; }
        public bool masterFileShareMeetings { get; set; }
        public bool notificationsOff { get; set; }
        public bool notifyConfirmation { get; set; }
        public bool notifyAccessed { get; set; }
        public bool notifyPackageSign { get; set; }
        public bool notifySigners { get; set; }
        public bool notifyMeeting { get; set; }
        public bool notifyMeetingIcsAttachment { get; set; }
        public bool notifyDocumentExecuted { get; set; }
        public bool notifyDocumentExecutedOwner { get; set; }
        public bool notifyDocumentExecutedSigners { get; set; }
        public bool notifyDocumentExecutedAttachRevision { get; set; }
        public bool notifyDocumentExecutedAttachExecuted { get; set; }
        public bool notifyDocumentExecutedAttachCac { get; set; }
        public bool allowSignerTools { get; set; }
        public bool allowSignerToolsTemplate { get; set; }
        public Signertools1 signerTools { get; set; }
    }

    public class Signertools1
    {
        public bool sign { get; set; }
        public bool annotateMobile { get; set; }
        public bool annotateDesktop { get; set; }
        public bool text { get; set; }
        public bool note { get; set; }
        public bool stamp { get; set; }
        public bool forms { get; set; }
        public bool autoForms { get; set; }
        public bool image { get; set; }
    }

    public class Organization
    {
        public string organizationId { get; set; }
        public string sharedId { get; set; }
        public DateTime timeCreated { get; set; }
        public DateTime timeUpdated { get; set; }
        public DateTime timeRenewed { get; set; }
        public string securityStamp { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string locale { get; set; }
        public string timeZone { get; set; }
        public object brandId { get; set; }
        public Packageoptions packageOptions { get; set; }
        public object packageOptionsTemplates { get; set; }
        public Options2 options { get; set; }
        public Subscription subscription { get; set; }
        public Subscriptionlimits subscriptionLimits { get; set; }
        public string type { get; set; }
        public string state { get; set; }
        public object[] brands { get; set; }
        public Member[] members { get; set; }
        public Usage usage { get; set; }
        public int memberLicensesUsed { get; set; }
        public int memberLicensesRemaining { get; set; }
        public int memberLicenses { get; set; }
    }

    public class Packageoptions
    {
        public Default _default { get; set; }
        public Sequential Sequential { get; set; }
    }

    public class Default
    {
        public object embedded { get; set; }
        public object embeddedTheme { get; set; }
        public object brandId { get; set; }
        public object requestGeoLocation { get; set; }
        public object addDocumentIdentifier { get; set; }
        public object retentionPeriod { get; set; }
        public object cacText { get; set; }
        public object templateParseTags { get; set; }
        public object securityCode { get; set; }
        public object securityPassphrase { get; set; }
        public object markAll { get; set; }
        public object markClickToSign { get; set; }
        public object markTypeToSign { get; set; }
        public object markTouchToSign { get; set; }
        public object allowMarkTouchToSignMouse { get; set; }
        public object meetingVideoRecordingAuto { get; set; }
        public object meetingVideoRecordingDisabled { get; set; }
        public object meetingVideoRetentionPeriod { get; set; }
        public object masterFileShareMeetings { get; set; }
        public object notificationsOff { get; set; }
        public object notifyConfirmation { get; set; }
        public object notifyAccessed { get; set; }
        public object notifyPackageSign { get; set; }
        public object notifySigners { get; set; }
        public object notifyMeeting { get; set; }
        public object notifyMeetingIcsAttachment { get; set; }
        public object notifyDocumentExecuted { get; set; }
        public object notifyDocumentExecutedOwner { get; set; }
        public object notifyDocumentExecutedSigners { get; set; }
        public object notifyDocumentExecutedAttachRevision { get; set; }
        public object notifyDocumentExecutedAttachExecuted { get; set; }
        public object notifyDocumentExecutedAttachCac { get; set; }
        public object allowSignerTools { get; set; }
        public object allowSignerToolsTemplate { get; set; }
        public object signerTools { get; set; }
    }

    public class Sequential
    {
        public object embedded { get; set; }
        public object embeddedTheme { get; set; }
        public object brandId { get; set; }
        public object requestGeoLocation { get; set; }
        public bool addDocumentIdentifier { get; set; }
        public object retentionPeriod { get; set; }
        public object cacText { get; set; }
        public object templateParseTags { get; set; }
        public bool securityCode { get; set; }
        public bool securityPassphrase { get; set; }
        public bool markAll { get; set; }
        public bool markClickToSign { get; set; }
        public bool markTypeToSign { get; set; }
        public bool markTouchToSign { get; set; }
        public bool allowMarkTouchToSignMouse { get; set; }
        public bool meetingVideoRecordingAuto { get; set; }
        public bool meetingVideoRecordingDisabled { get; set; }
        public object meetingVideoRetentionPeriod { get; set; }
        public bool masterFileShareMeetings { get; set; }
        public object notificationsOff { get; set; }
        public object notifyConfirmation { get; set; }
        public bool notifyAccessed { get; set; }
        public object notifyPackageSign { get; set; }
        public bool notifySigners { get; set; }
        public object notifyMeeting { get; set; }
        public object notifyMeetingIcsAttachment { get; set; }
        public object notifyDocumentExecuted { get; set; }
        public bool notifyDocumentExecutedOwner { get; set; }
        public bool notifyDocumentExecutedSigners { get; set; }
        public bool notifyDocumentExecutedAttachRevision { get; set; }
        public object notifyDocumentExecutedAttachExecuted { get; set; }
        public object notifyDocumentExecutedAttachCac { get; set; }
        public bool allowSignerTools { get; set; }
        public bool allowSignerToolsTemplate { get; set; }
        public Signertools2 signerTools { get; set; }
    }

    public class Signertools2
    {
        public object sign { get; set; }
        public object annotateMobile { get; set; }
        public object annotateDesktop { get; set; }
        public object text { get; set; }
        public object note { get; set; }
        public object stamp { get; set; }
        public object forms { get; set; }
        public object autoForms { get; set; }
        public object image { get; set; }
    }

    public class Options2
    {
        public object registrationCode { get; set; }
        public object registrationCardToken { get; set; }
        public string registrationCountry { get; set; }
        public object registrationProvince { get; set; }
        public string registrationIpAddress { get; set; }
        public object registrationPlanCode { get; set; }
        public object registrationPlanInterval { get; set; }
        public string registrationLocale { get; set; }
        public string registrationTimeZone { get; set; }
        public object registrationCampaignReferral { get; set; }
        public object clientLogLevel { get; set; }
    }

    public class Subscription
    {
        public int version { get; set; }
        public string subscriptionId { get; set; }
        public string organizationId { get; set; }
        public DateTime timePeriodStart { get; set; }
        public DateTime timePeriodEnd { get; set; }
        public DateTime timeUpdated { get; set; }
        public DateTime timeRenewed { get; set; }
        public DateTime timeIssued { get; set; }
        public DateTime timeExpires { get; set; }
        public object timeTrialExpires { get; set; }
        public object timeCancel { get; set; }
        public object timeCancelled { get; set; }
        public Invoicenext invoiceNext { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public object phoneNumber { get; set; }
        public object addressLine1 { get; set; }
        public object addressLine2 { get; set; }
        public object province { get; set; }
        public object city { get; set; }
        public object postal { get; set; }
        public string country { get; set; }
        public string cardName { get; set; }
        public Cardaddress cardAddress { get; set; }
        public string cardMasked { get; set; }
        public string cardCountry { get; set; }
        public string cardBrand { get; set; }
        public int cardExpireMonth { get; set; }
        public int cardExpireYear { get; set; }
        public bool cardAddressValid { get; set; }
        public bool cardPostalValid { get; set; }
        public bool cardCvcValid { get; set; }
        public bool cardValid { get; set; }
        public int accountBalance { get; set; }
        public bool accountDelinquent { get; set; }
        public string currency { get; set; }
        public object discount { get; set; }
        public Plan plan { get; set; }
        public object[] addOns { get; set; }
        public object[] credits { get; set; }
        public Feature[] features { get; set; }
        public object[] roles { get; set; }
        public Terms terms { get; set; }
        public object termRenewalPlanCode { get; set; }
        public object termRenewalPlanInterval { get; set; }
        public string billingType { get; set; }
        public bool cancelled { get; set; }
        public string state { get; set; }
        public object invalidCard { get; set; }
        public string signature { get; set; }
    }

    public class Invoicenext
    {
        public string invoiceId { get; set; }
        public string organizationId { get; set; }
        public string subscriptionId { get; set; }
        public object externalInvoiceId { get; set; }
        public string invoiceNumber { get; set; }
        public object receiptNumber { get; set; }
        public DateTime timeCreated { get; set; }
        public object timeDue { get; set; }
        public DateTime timeNextAttempt { get; set; }
        public object timeDelivered { get; set; }
        public DateTime timePeriodStart { get; set; }
        public DateTime timePeriodEnd { get; set; }
        public int attemptCount { get; set; }
        public object statementDescription { get; set; }
        public string currency { get; set; }
        public string locale { get; set; }
        public Address address { get; set; }
        public Item[] items { get; set; }
        public int amountDue { get; set; }
        public int amountPaid { get; set; }
        public int amountRemaining { get; set; }
        public int subtotal { get; set; }
        public object discount { get; set; }
        public int discountAmount { get; set; }
        public object taxes { get; set; }
        public int total { get; set; }
        public int startingBalance { get; set; }
        public int endingBalance { get; set; }
        public object[] taxRates { get; set; }
        public object taxRate { get; set; }
        public string type { get; set; }
        public string state { get; set; }
    }

    public class Address
    {
        public string name { get; set; }
        public string email { get; set; }
        public object phoneNumber { get; set; }
        public object addressLine1 { get; set; }
        public object addressLine2 { get; set; }
        public object city { get; set; }
        public object province { get; set; }
        public object postal { get; set; }
        public string country { get; set; }
    }

    public class Item
    {
        public string invoiceItemId { get; set; }
        public string invoiceId { get; set; }
        public string externalInvoiceItemId { get; set; }
        public DateTime? timePeriodStart { get; set; }
        public DateTime? timePeriodEnd { get; set; }
        public string code { get; set; }
        public object transaction { get; set; }
        public bool proration { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
        public int? quantity { get; set; }
        public int amount { get; set; }
        public string type { get; set; }
    }

    public class Cardaddress
    {
        public string name { get; set; }
        public object email { get; set; }
        public object phoneNumber { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
    }

    public class Plan
    {
        public string planId { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public string currency { get; set; }
        public string interval { get; set; }
        public int amount { get; set; }
        public bool customPricing { get; set; }
        public bool discontinued { get; set; }
        public object unit { get; set; }
        public object mode { get; set; }
        public string type { get; set; }
    }

    public class Terms
    {
        public object termPlanLocked { get; set; }
        public object termMembersLocked { get; set; }
        public object termMembersMin { get; set; }
        public object termDuration { get; set; }
        public object timeTermStart { get; set; }
        public object timeTermEnd { get; set; }
    }

    public class Feature
    {
        public string code { get; set; }
        public int? quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public int? max { get; set; }
        public int? limit { get; set; }
        public bool? perMember { get; set; }
        public object options { get; set; }
        public string unit { get; set; }
        public string type { get; set; }
        public Pricing pricing { get; set; }
    }

    public class Pricing
    {
        public int amount { get; set; }
        public object transform { get; set; }
        public string aggregateMode { get; set; }
        public Tier[] tiers { get; set; }
        public string tierMode { get; set; }
    }

    public class Tier
    {
        public int? upTo { get; set; }
        public object flatAmount { get; set; }
        public int unitAmount { get; set; }
    }

    public class Subscriptionlimits
    {
        public Packages packages { get; set; }
        public Api_Packages api_packages { get; set; }
        public Meeting_Minutes meeting_minutes { get; set; }
        public Meeting_Streaming_Minutes meeting_streaming_minutes { get; set; }
        public Video_Minutes video_minutes { get; set; }
    }

    public class Packages
    {
        public int max { get; set; }
    }

    public class Api_Packages
    {
        public int max { get; set; }
    }

    public class Meeting_Minutes
    {
        public int max { get; set; }
    }

    public class Meeting_Streaming_Minutes
    {
        public int max { get; set; }
    }

    public class Video_Minutes
    {
        public int max { get; set; }
    }

    public class Usage
    {
        public string organizationId { get; set; }
        public DateTime timeGenerated { get; set; }
        public DateTime periodStart { get; set; }
        public DateTime periodEnd { get; set; }
        public Members members { get; set; }
        public Allpackages allPackages { get; set; }
        public Packages1 packages { get; set; }
        public Apipackages apiPackages { get; set; }
        public Documents documents { get; set; }
        public Meetings meetings { get; set; }
        public Meetingminutes meetingMinutes { get; set; }
        public Meetingstreamingminutes meetingStreamingMinutes { get; set; }
        public Videos videos { get; set; }
        public Videominutes videoMinutes { get; set; }
        public Videostorage videoStorage { get; set; }
        public Longpensignings longPenSignings { get; set; }
    }

    public class Members
    {
        public string code { get; set; }
        public int current { get; set; }
        public object included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public int max { get; set; }
        public object limit { get; set; }
    }

    public class Allpackages
    {
        public string code { get; set; }
        public int current { get; set; }
        public object included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public object limit { get; set; }
    }

    public class Packages1
    {
        public string code { get; set; }
        public int current { get; set; }
        public int included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public int max { get; set; }
        public int limit { get; set; }
    }

    public class Apipackages
    {
        public string code { get; set; }
        public int current { get; set; }
        public int included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public int max { get; set; }
        public int limit { get; set; }
    }

    public class Documents
    {
        public string code { get; set; }
        public int current { get; set; }
        public object included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public object limit { get; set; }
    }

    public class Meetings
    {
        public string code { get; set; }
        public int current { get; set; }
        public object included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public object limit { get; set; }
    }

    public class Meetingminutes
    {
        public string code { get; set; }
        public int current { get; set; }
        public int included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public int limit { get; set; }
    }

    public class Meetingstreamingminutes
    {
        public string code { get; set; }
        public int current { get; set; }
        public int included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public int limit { get; set; }
    }

    public class Videos
    {
        public string code { get; set; }
        public int current { get; set; }
        public object included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public object limit { get; set; }
    }

    public class Videominutes
    {
        public string code { get; set; }
        public int current { get; set; }
        public int included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public int limit { get; set; }
    }

    public class Videostorage
    {
        public string code { get; set; }
        public int current { get; set; }
        public int included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public object limit { get; set; }
    }

    public class Longpensignings
    {
        public string code { get; set; }
        public int current { get; set; }
        public object included { get; set; }
        public int quantity { get; set; }
        public object trial { get; set; }
        public object min { get; set; }
        public object max { get; set; }
        public object limit { get; set; }
    }

    public class Member
    {
        public string organizationId { get; set; }
        public string memberId { get; set; }
        public string userId { get; set; }
        public string invitedByMemberId { get; set; }
        public DateTime timeCreated { get; set; }
        public object timeLastAccessed { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string initials { get; set; }
        public object profileImage { get; set; }
        public string title { get; set; }
        public string email { get; set; }
        public object emailAlias { get; set; }
        public object mobileNumberCountryCode { get; set; }
        public object mobileNumberOriginal { get; set; }
        public string mobileNumber { get; set; }
        public string locale { get; set; }
        public string timeZone { get; set; }
        public string[] roles { get; set; }
        public object disabledFeatures { get; set; }
        public object packageOptionsTemplates { get; set; }
        public object memberBrandId { get; set; }
        public object brandId { get; set; }
        public object brands { get; set; }
        public string type { get; set; }
        public string state { get; set; }
        public object settings { get; set; }
        public string name { get; set; }
        public bool isOwner { get; set; }
        public bool isAdministrator { get; set; }
        public bool isMember { get; set; }
        public bool isSPaperAdministrator { get; set; }
        public bool isSPaperBranding { get; set; }
        public bool isLongPenAdministrator { get; set; }
        public bool isLicensed { get; set; }
        public bool isActive { get; set; }
        public bool isInvited { get; set; }
        public bool isDisabled { get; set; }
        public bool isDeleted { get; set; }
    }

    public class Owner
    {
        public string id { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string mobileNumber { get; set; }
        public string state { get; set; }
        public object organizationId { get; set; }
        public object brandId { get; set; }
        public object isSubscriptionValid { get; set; }
        public object isSubscriptionManual { get; set; }
        public object isSubscriptionTrialing { get; set; }
        public object isGuest { get; set; }
        public object isMember { get; set; }
        public object isServerAdministrator { get; set; }
        public object features { get; set; }
        public string[] roles { get; set; }
    }

    public class Document
    {
        public string documentId { get; set; }
        public string originalId { get; set; }
        public string packageId { get; set; }
        public object index { get; set; }
        public object name { get; set; }
        public string fileName { get; set; }
        public string fileType { get; set; }
        public int fileSize { get; set; }
        public object protectedClientId { get; set; }
        public int numberPages { get; set; }
        public DateTime timeUploaded { get; set; }
        public DateTime timeLastModified { get; set; }
        public int numberSigners { get; set; }
        public int numberSigned { get; set; }
        public string uploadedBy { get; set; }
        public string uploadedFrom { get; set; }
        public object description { get; set; }
        public object templateOriginal { get; set; }
        public Template template { get; set; }
        public object form { get; set; }
        public object data { get; set; }
        public string state { get; set; }
        public Tracker1 tracker { get; set; }
        public string action { get; set; }
        public Revision[] revisions { get; set; }
        public Signer[] signers { get; set; }
        public object messages { get; set; }
        public object[] marks { get; set; }
        public object[] signatures { get; set; }
        public object[] images { get; set; }
    }

    public class Template
    {
        public object id { get; set; }
        public DateTime timeUpdated { get; set; }
        public object name { get; set; }
        public object description { get; set; }
        public object message { get; set; }
        public bool isDocumentTemplate { get; set; }
        public object[] recipients { get; set; }
        public object[] signers { get; set; }
        public Field[] fields { get; set; }
        public object options { get; set; }
    }

    public class Field
    {
        public object parentKey { get; set; }
        public string key { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public object subType { get; set; }
        public object propertyKey { get; set; }
        public object dataKey { get; set; }
        public string signerKey { get; set; }
        public string tag { get; set; }
        public bool isInternal { get; set; }
        public bool isTag { get; set; }
        public bool isCac { get; set; }
        public bool isModified { get; set; }
        public bool isInvalid { get; set; }
        public object description { get; set; }
        public Position position { get; set; }
        public Options3 options { get; set; }
    }

    public class Position
    {
        public int page { get; set; }
        public float y { get; set; }
        public float x { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float fontSize { get; set; }
        public object minWidth { get; set; }
        public object maxWidth { get; set; }
        public object minHeight { get; set; }
        public object maxHeight { get; set; }
        public float movable { get; set; }
    }

    public class Options3
    {
        public bool required { get; set; }
        public object defaultValue { get; set; }
        public object defaultValues { get; set; }
        public object placeholder { get; set; }
        public bool outline { get; set; }
        public object background { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public object align { get; set; }
        public object fontSize { get; set; }
    }

    public class Tracker1
    {
        public object index { get; set; }
        public object name { get; set; }
        public string fileName { get; set; }
        public string description { get; set; }
        public int numberPages { get; set; }
        public int numberSigned { get; set; }
        public int numberSigners { get; set; }
        public string action { get; set; }
        public bool wasFileReplaced { get; set; }
        public bool wasTemplateUpdated { get; set; }
        public bool wasRegen { get; set; }
        public bool wasSigned { get; set; }
        public bool wasExecuted { get; set; }
    }

    public class Revision
    {
        public string documentId { get; set; }
        public string revisionId { get; set; }
        public int revisionNumber { get; set; }
        public object masterFileId { get; set; }
        public object timeLastOpened { get; set; }
        public string signerId { get; set; }
        public bool isSigned { get; set; }
        public object timeSigned { get; set; }
        public object address { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
        public object metadataLog { get; set; }
        public bool hasMetadata { get; set; }
        public int sizeBefore { get; set; }
        public object sizeAfter { get; set; }
        public string state { get; set; }
        public Location location { get; set; }
        public object masterFile { get; set; }
    }

    public class Location
    {
        public object address { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
    }

    public class Signer
    {
        public string signerId { get; set; }
        public string signerKey { get; set; }
        public string name { get; set; }
        public string initials { get; set; }
        public string email { get; set; }
        public string mobileNumber { get; set; }
        public Preferences preferences { get; set; }
        public string action { get; set; }
        public string actionSummary { get; set; }
        public bool hasSigned { get; set; }
        public bool isNext { get; set; }
        public bool isOwner { get; set; }
        public bool isHost { get; set; }
        public bool isMe { get; set; }
    }

    public class Preferences
    {
        public object locale { get; set; }
    }

    public class Signer1
    {
        public object returnUrl { get; set; }
        public object returnState { get; set; }
        public string signerId { get; set; }
        public string packageId { get; set; }
        public DateTime timeCreated { get; set; }
        public DateTime timeUpdated { get; set; }
        public int index { get; set; }
        public string role { get; set; }
        public string type { get; set; }
        public object locale { get; set; }
        public bool signCac { get; set; }
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public object mobileNumberCountryCode { get; set; }
        public object mobileNumberOriginal { get; set; }
        public string mobileNumber { get; set; }
        public Preferences1 preferences { get; set; }
        public string state { get; set; }
        public Tracker2 tracker { get; set; }
        public string action { get; set; }
        public bool isMe { get; set; }
        public bool isOwner { get; set; }
        public bool isHost { get; set; }
        public bool isUser { get; set; }
        public bool isGuest { get; set; }
        public object links { get; set; }
        public object signLink { get; set; }
        public object meetingLink { get; set; }
        public object meetingParticipant { get; set; }
    }

    public class Preferences1
    {
        public object locale { get; set; }
    }

    public class Tracker2
    {
        public int index { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string mobileNumber { get; set; }
        public bool signCac { get; set; }
        public string role { get; set; }
        public object locale { get; set; }
        public string action { get; set; }
        public bool wasNext { get; set; }
        public bool wasSigned { get; set; }
        public bool wasExecuted { get; set; }
        public object invalidatedLinks { get; set; }
    }

}
