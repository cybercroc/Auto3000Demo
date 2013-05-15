﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Auto3000.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities() : base("name=Entities", "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(string connectionString) : base(connectionString, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(EntityConnection connection) : base(connection, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="contactId">No Metadata Documentation available.</param>
        public int usp_Contacts_del(Nullable<global::System.Int32> contactId)
        {
            ObjectParameter contactIdParameter;
            if (contactId.HasValue)
            {
                contactIdParameter = new ObjectParameter("ContactId", contactId);
            }
            else
            {
                contactIdParameter = new ObjectParameter("ContactId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction("usp_Contacts_del", contactIdParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="contactId">No Metadata Documentation available.</param>
        public ObjectResult<usp_Contacts_sel_Result> usp_Contacts_sel(Nullable<global::System.Int32> contactId)
        {
            ObjectParameter contactIdParameter;
            if (contactId.HasValue)
            {
                contactIdParameter = new ObjectParameter("ContactId", contactId);
            }
            else
            {
                contactIdParameter = new ObjectParameter("ContactId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction<usp_Contacts_sel_Result>("usp_Contacts_sel", contactIdParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="contactId">No Metadata Documentation available.</param>
        /// <param name="isApproved">No Metadata Documentation available.</param>
        public int usp_Contacts_upd(Nullable<global::System.Int32> contactId, Nullable<global::System.Boolean> isApproved)
        {
            ObjectParameter contactIdParameter;
            if (contactId.HasValue)
            {
                contactIdParameter = new ObjectParameter("ContactId", contactId);
            }
            else
            {
                contactIdParameter = new ObjectParameter("ContactId", typeof(global::System.Int32));
            }
    
            ObjectParameter isApprovedParameter;
            if (isApproved.HasValue)
            {
                isApprovedParameter = new ObjectParameter("IsApproved", isApproved);
            }
            else
            {
                isApprovedParameter = new ObjectParameter("IsApproved", typeof(global::System.Boolean));
            }
    
            return base.ExecuteFunction("usp_Contacts_upd", contactIdParameter, isApprovedParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="feedBackId">No Metadata Documentation available.</param>
        public int usp_Feedbacks_Del(Nullable<global::System.Int32> feedBackId)
        {
            ObjectParameter feedBackIdParameter;
            if (feedBackId.HasValue)
            {
                feedBackIdParameter = new ObjectParameter("FeedBackId", feedBackId);
            }
            else
            {
                feedBackIdParameter = new ObjectParameter("FeedBackId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction("usp_Feedbacks_Del", feedBackIdParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="feedBackId">No Metadata Documentation available.</param>
        public ObjectResult<usp_Feedbacks_sel_Result> usp_Feedbacks_sel(Nullable<global::System.Int32> feedBackId)
        {
            ObjectParameter feedBackIdParameter;
            if (feedBackId.HasValue)
            {
                feedBackIdParameter = new ObjectParameter("FeedBackId", feedBackId);
            }
            else
            {
                feedBackIdParameter = new ObjectParameter("FeedBackId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction<usp_Feedbacks_sel_Result>("usp_Feedbacks_sel", feedBackIdParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="feedBackId">No Metadata Documentation available.</param>
        /// <param name="isShown">No Metadata Documentation available.</param>
        public int usp_Feedbacks_upd(global::System.String feedBackId, Nullable<global::System.Boolean> isShown)
        {
            ObjectParameter feedBackIdParameter;
            if (feedBackId != null)
            {
                feedBackIdParameter = new ObjectParameter("FeedBackId", feedBackId);
            }
            else
            {
                feedBackIdParameter = new ObjectParameter("FeedBackId", typeof(global::System.String));
            }
    
            ObjectParameter isShownParameter;
            if (isShown.HasValue)
            {
                isShownParameter = new ObjectParameter("IsShown", isShown);
            }
            else
            {
                isShownParameter = new ObjectParameter("IsShown", typeof(global::System.Boolean));
            }
    
            return base.ExecuteFunction("usp_Feedbacks_upd", feedBackIdParameter, isShownParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="userId">No Metadata Documentation available.</param>
        /// <param name="feedBack">No Metadata Documentation available.</param>
        /// <param name="ratings">No Metadata Documentation available.</param>
        /// <param name="questionId">No Metadata Documentation available.</param>
        /// <param name="answers">No Metadata Documentation available.</param>
        public int usp_Feedbacks_ins(global::System.String userId, global::System.String feedBack, Nullable<global::System.Int32> ratings, Nullable<global::System.Int32> questionId, global::System.String answers)
        {
            ObjectParameter userIdParameter;
            if (userId != null)
            {
                userIdParameter = new ObjectParameter("UserId", userId);
            }
            else
            {
                userIdParameter = new ObjectParameter("UserId", typeof(global::System.String));
            }
    
            ObjectParameter feedBackParameter;
            if (feedBack != null)
            {
                feedBackParameter = new ObjectParameter("FeedBack", feedBack);
            }
            else
            {
                feedBackParameter = new ObjectParameter("FeedBack", typeof(global::System.String));
            }
    
            ObjectParameter ratingsParameter;
            if (ratings.HasValue)
            {
                ratingsParameter = new ObjectParameter("Ratings", ratings);
            }
            else
            {
                ratingsParameter = new ObjectParameter("Ratings", typeof(global::System.Int32));
            }
    
            ObjectParameter questionIdParameter;
            if (questionId.HasValue)
            {
                questionIdParameter = new ObjectParameter("QuestionId", questionId);
            }
            else
            {
                questionIdParameter = new ObjectParameter("QuestionId", typeof(global::System.Int32));
            }
    
            ObjectParameter answersParameter;
            if (answers != null)
            {
                answersParameter = new ObjectParameter("Answers", answers);
            }
            else
            {
                answersParameter = new ObjectParameter("Answers", typeof(global::System.String));
            }
    
            return base.ExecuteFunction("usp_Feedbacks_ins", userIdParameter, feedBackParameter, ratingsParameter, questionIdParameter, answersParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="userName">No Metadata Documentation available.</param>
        /// <param name="password">No Metadata Documentation available.</param>
        public ObjectResult<global::System.String> usp_AdminUser_sel(global::System.String userName, global::System.String password)
        {
            ObjectParameter userNameParameter;
            if (userName != null)
            {
                userNameParameter = new ObjectParameter("UserName", userName);
            }
            else
            {
                userNameParameter = new ObjectParameter("UserName", typeof(global::System.String));
            }
    
            ObjectParameter passwordParameter;
            if (password != null)
            {
                passwordParameter = new ObjectParameter("Password", password);
            }
            else
            {
                passwordParameter = new ObjectParameter("Password", typeof(global::System.String));
            }
    
            return base.ExecuteFunction<global::System.String>("usp_AdminUser_sel", userNameParameter, passwordParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="announcementId">No Metadata Documentation available.</param>
        public int usp_Announcement_del(Nullable<global::System.Int32> announcementId)
        {
            ObjectParameter announcementIdParameter;
            if (announcementId.HasValue)
            {
                announcementIdParameter = new ObjectParameter("AnnouncementId", announcementId);
            }
            else
            {
                announcementIdParameter = new ObjectParameter("AnnouncementId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction("usp_Announcement_del", announcementIdParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="announcementId">No Metadata Documentation available.</param>
        /// <param name="title">No Metadata Documentation available.</param>
        /// <param name="description">No Metadata Documentation available.</param>
        /// <param name="expiry">No Metadata Documentation available.</param>
        /// <param name="isActive">No Metadata Documentation available.</param>
        public ObjectResult<Nullable<global::System.Int32>> usp_Announcement_ins(Nullable<global::System.Int32> announcementId, global::System.String title, global::System.String description, global::System.String expiry, Nullable<global::System.Boolean> isActive)
        {
            ObjectParameter announcementIdParameter;
            if (announcementId.HasValue)
            {
                announcementIdParameter = new ObjectParameter("AnnouncementId", announcementId);
            }
            else
            {
                announcementIdParameter = new ObjectParameter("AnnouncementId", typeof(global::System.Int32));
            }
    
            ObjectParameter titleParameter;
            if (title != null)
            {
                titleParameter = new ObjectParameter("Title", title);
            }
            else
            {
                titleParameter = new ObjectParameter("Title", typeof(global::System.String));
            }
    
            ObjectParameter descriptionParameter;
            if (description != null)
            {
                descriptionParameter = new ObjectParameter("Description", description);
            }
            else
            {
                descriptionParameter = new ObjectParameter("Description", typeof(global::System.String));
            }
    
            ObjectParameter expiryParameter;
            if (expiry != null)
            {
                expiryParameter = new ObjectParameter("Expiry", expiry);
            }
            else
            {
                expiryParameter = new ObjectParameter("Expiry", typeof(global::System.String));
            }
    
            ObjectParameter isActiveParameter;
            if (isActive.HasValue)
            {
                isActiveParameter = new ObjectParameter("IsActive", isActive);
            }
            else
            {
                isActiveParameter = new ObjectParameter("IsActive", typeof(global::System.Boolean));
            }
    
            return base.ExecuteFunction<Nullable<global::System.Int32>>("usp_Announcement_ins", announcementIdParameter, titleParameter, descriptionParameter, expiryParameter, isActiveParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="announcementId">No Metadata Documentation available.</param>
        public ObjectResult<usp_Announcement_sel_Result> usp_Announcement_sel(Nullable<global::System.Int32> announcementId)
        {
            ObjectParameter announcementIdParameter;
            if (announcementId.HasValue)
            {
                announcementIdParameter = new ObjectParameter("AnnouncementId", announcementId);
            }
            else
            {
                announcementIdParameter = new ObjectParameter("AnnouncementId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction<usp_Announcement_sel_Result>("usp_Announcement_sel", announcementIdParameter);
        }

        #endregion

    }

    #endregion

    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="Auto3000Model", Name="usp_Announcement_sel_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class usp_Announcement_sel_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new usp_Announcement_sel_Result object.
        /// </summary>
        /// <param name="announcementId">Initial value of the AnnouncementId property.</param>
        public static usp_Announcement_sel_Result Createusp_Announcement_sel_Result(global::System.Int32 announcementId)
        {
            usp_Announcement_sel_Result usp_Announcement_sel_Result = new usp_Announcement_sel_Result();
            usp_Announcement_sel_Result.AnnouncementId = announcementId;
            return usp_Announcement_sel_Result;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AnnouncementId
        {
            get
            {
                return _AnnouncementId;
            }
            set
            {
                OnAnnouncementIdChanging(value);
                ReportPropertyChanging("AnnouncementId");
                _AnnouncementId = StructuralObject.SetValidValue(value, "AnnouncementId");
                ReportPropertyChanged("AnnouncementId");
                OnAnnouncementIdChanged();
            }
        }
        private global::System.Int32 _AnnouncementId;
        partial void OnAnnouncementIdChanging(global::System.Int32 value);
        partial void OnAnnouncementIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ExpiryDate
        {
            get
            {
                return _ExpiryDate;
            }
            set
            {
                OnExpiryDateChanging(value);
                ReportPropertyChanging("ExpiryDate");
                _ExpiryDate = StructuralObject.SetValidValue(value, true, "ExpiryDate");
                ReportPropertyChanged("ExpiryDate");
                OnExpiryDateChanged();
            }
        }
        private global::System.String _ExpiryDate;
        partial void OnExpiryDateChanging(global::System.String value);
        partial void OnExpiryDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value, "IsActive");
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private Nullable<global::System.Boolean> _IsActive;
        partial void OnIsActiveChanging(Nullable<global::System.Boolean> value);
        partial void OnIsActiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="Auto3000Model", Name="usp_Contacts_sel_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class usp_Contacts_sel_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new usp_Contacts_sel_Result object.
        /// </summary>
        /// <param name="contactId">Initial value of the ContactId property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        /// <param name="phone">Initial value of the Phone property.</param>
        /// <param name="isApproved">Initial value of the IsApproved property.</param>
        /// <param name="subjectName">Initial value of the SubjectName property.</param>
        public static usp_Contacts_sel_Result Createusp_Contacts_sel_Result(global::System.Int32 contactId, global::System.String email, global::System.String phone, global::System.Boolean isApproved, global::System.String subjectName)
        {
            usp_Contacts_sel_Result usp_Contacts_sel_Result = new usp_Contacts_sel_Result();
            usp_Contacts_sel_Result.ContactId = contactId;
            usp_Contacts_sel_Result.Email = email;
            usp_Contacts_sel_Result.Phone = phone;
            usp_Contacts_sel_Result.IsApproved = isApproved;
            usp_Contacts_sel_Result.SubjectName = subjectName;
            return usp_Contacts_sel_Result;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ContactId
        {
            get
            {
                return _ContactId;
            }
            set
            {
                OnContactIdChanging(value);
                ReportPropertyChanging("ContactId");
                _ContactId = StructuralObject.SetValidValue(value, "ContactId");
                ReportPropertyChanged("ContactId");
                OnContactIdChanged();
            }
        }
        private global::System.Int32 _ContactId;
        partial void OnContactIdChanging(global::System.Int32 value);
        partial void OnContactIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, true, "UserName");
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false, "Email");
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, false, "Phone");
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ZipCode
        {
            get
            {
                return _ZipCode;
            }
            set
            {
                OnZipCodeChanging(value);
                ReportPropertyChanging("ZipCode");
                _ZipCode = StructuralObject.SetValidValue(value, true, "ZipCode");
                ReportPropertyChanged("ZipCode");
                OnZipCodeChanged();
            }
        }
        private global::System.String _ZipCode;
        partial void OnZipCodeChanging(global::System.String value);
        partial void OnZipCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsApproved
        {
            get
            {
                return _IsApproved;
            }
            set
            {
                OnIsApprovedChanging(value);
                ReportPropertyChanging("IsApproved");
                _IsApproved = StructuralObject.SetValidValue(value, "IsApproved");
                ReportPropertyChanged("IsApproved");
                OnIsApprovedChanged();
            }
        }
        private global::System.Boolean _IsApproved;
        partial void OnIsApprovedChanging(global::System.Boolean value);
        partial void OnIsApprovedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SentDate
        {
            get
            {
                return _SentDate;
            }
            set
            {
                OnSentDateChanging(value);
                ReportPropertyChanging("SentDate");
                _SentDate = StructuralObject.SetValidValue(value, true, "SentDate");
                ReportPropertyChanged("SentDate");
                OnSentDateChanged();
            }
        }
        private global::System.String _SentDate;
        partial void OnSentDateChanging(global::System.String value);
        partial void OnSentDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SubjectName
        {
            get
            {
                return _SubjectName;
            }
            set
            {
                OnSubjectNameChanging(value);
                ReportPropertyChanging("SubjectName");
                _SubjectName = StructuralObject.SetValidValue(value, false, "SubjectName");
                ReportPropertyChanged("SubjectName");
                OnSubjectNameChanged();
            }
        }
        private global::System.String _SubjectName;
        partial void OnSubjectNameChanging(global::System.String value);
        partial void OnSubjectNameChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="Auto3000Model", Name="usp_Feedbacks_sel_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class usp_Feedbacks_sel_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new usp_Feedbacks_sel_Result object.
        /// </summary>
        /// <param name="feedBackId">Initial value of the FeedBackId property.</param>
        /// <param name="ratings">Initial value of the Ratings property.</param>
        /// <param name="show">Initial value of the Show property.</param>
        /// <param name="answers">Initial value of the Answers property.</param>
        /// <param name="question">Initial value of the Question property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        public static usp_Feedbacks_sel_Result Createusp_Feedbacks_sel_Result(global::System.Int32 feedBackId, global::System.Int32 ratings, global::System.Boolean show, global::System.String answers, global::System.String question, global::System.String userId)
        {
            usp_Feedbacks_sel_Result usp_Feedbacks_sel_Result = new usp_Feedbacks_sel_Result();
            usp_Feedbacks_sel_Result.FeedBackId = feedBackId;
            usp_Feedbacks_sel_Result.Ratings = ratings;
            usp_Feedbacks_sel_Result.Show = show;
            usp_Feedbacks_sel_Result.Answers = answers;
            usp_Feedbacks_sel_Result.Question = question;
            usp_Feedbacks_sel_Result.UserId = userId;
            return usp_Feedbacks_sel_Result;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 FeedBackId
        {
            get
            {
                return _FeedBackId;
            }
            set
            {
                OnFeedBackIdChanging(value);
                ReportPropertyChanging("FeedBackId");
                _FeedBackId = StructuralObject.SetValidValue(value, "FeedBackId");
                ReportPropertyChanged("FeedBackId");
                OnFeedBackIdChanged();
            }
        }
        private global::System.Int32 _FeedBackId;
        partial void OnFeedBackIdChanging(global::System.Int32 value);
        partial void OnFeedBackIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FeedBack
        {
            get
            {
                return _FeedBack;
            }
            set
            {
                OnFeedBackChanging(value);
                ReportPropertyChanging("FeedBack");
                _FeedBack = StructuralObject.SetValidValue(value, true, "FeedBack");
                ReportPropertyChanged("FeedBack");
                OnFeedBackChanged();
            }
        }
        private global::System.String _FeedBack;
        partial void OnFeedBackChanging(global::System.String value);
        partial void OnFeedBackChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Ratings
        {
            get
            {
                return _Ratings;
            }
            set
            {
                OnRatingsChanging(value);
                ReportPropertyChanging("Ratings");
                _Ratings = StructuralObject.SetValidValue(value, "Ratings");
                ReportPropertyChanged("Ratings");
                OnRatingsChanged();
            }
        }
        private global::System.Int32 _Ratings;
        partial void OnRatingsChanging(global::System.Int32 value);
        partial void OnRatingsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Show
        {
            get
            {
                return _Show;
            }
            set
            {
                OnShowChanging(value);
                ReportPropertyChanging("Show");
                _Show = StructuralObject.SetValidValue(value, "Show");
                ReportPropertyChanged("Show");
                OnShowChanged();
            }
        }
        private global::System.Boolean _Show;
        partial void OnShowChanging(global::System.Boolean value);
        partial void OnShowChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SentDate
        {
            get
            {
                return _SentDate;
            }
            set
            {
                OnSentDateChanging(value);
                ReportPropertyChanging("SentDate");
                _SentDate = StructuralObject.SetValidValue(value, true, "SentDate");
                ReportPropertyChanged("SentDate");
                OnSentDateChanged();
            }
        }
        private global::System.String _SentDate;
        partial void OnSentDateChanging(global::System.String value);
        partial void OnSentDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Answers
        {
            get
            {
                return _Answers;
            }
            set
            {
                OnAnswersChanging(value);
                ReportPropertyChanging("Answers");
                _Answers = StructuralObject.SetValidValue(value, false, "Answers");
                ReportPropertyChanged("Answers");
                OnAnswersChanged();
            }
        }
        private global::System.String _Answers;
        partial void OnAnswersChanging(global::System.String value);
        partial void OnAnswersChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Question
        {
            get
            {
                return _Question;
            }
            set
            {
                OnQuestionChanging(value);
                ReportPropertyChanging("Question");
                _Question = StructuralObject.SetValidValue(value, false, "Question");
                ReportPropertyChanged("Question");
                OnQuestionChanged();
            }
        }
        private global::System.String _Question;
        partial void OnQuestionChanging(global::System.String value);
        partial void OnQuestionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value, false, "UserId");
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.String _UserId;
        partial void OnUserIdChanging(global::System.String value);
        partial void OnUserIdChanged();

        #endregion

    }

    #endregion

}
