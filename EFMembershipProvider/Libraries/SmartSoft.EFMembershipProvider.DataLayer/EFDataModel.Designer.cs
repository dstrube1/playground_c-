﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 29/10/2008 8:46:36 PM
namespace SmartSoft.EFMembershipProvider.DataLayer
{
    
    /// <summary>
    /// There are no comments for EFDataModelEntities in the schema.
    /// </summary>
    public partial class EFDataModelEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new EFDataModelEntities object using the connection string found in the 'EFDataModelEntities' section of the application configuration file.
        /// </summary>
        public EFDataModelEntities() : 
                base("name=EFDataModelEntities", "EFDataModelEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new EFDataModelEntities object.
        /// </summary>
        public EFDataModelEntities(string connectionString) : 
                base(connectionString, "EFDataModelEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new EFDataModelEntities object.
        /// </summary>
        public EFDataModelEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "EFDataModelEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<User> User
        {
            get
            {
                if ((this._User == null))
                {
                    this._User = base.CreateQuery<User>("[User]");
                }
                return this._User;
            }
        }
        private global::System.Data.Objects.ObjectQuery<User> _User;
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        public void AddToUser(User user)
        {
            base.AddObject("User", user);
        }
    }
    /// <summary>
    /// There are no comments for EFDataModelModel.User in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="EFDataModelModel", Name="User")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class User : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="username">Initial value of Username.</param>
        /// <param name="email">Initial value of Email.</param>
        /// <param name="isApproved">Initial value of IsApproved.</param>
        public static User CreateUser(global::System.Guid id, string username, string email, bool isApproved)
        {
            User user = new User();
            user.Id = id;
            user.Username = username;
            user.Email = email;
            user.IsApproved = isApproved;
            return user;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property CreationDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> CreationDate
        {
            get
            {
                return this._CreationDate;
            }
            set
            {
                this.OnCreationDateChanging(value);
                this.ReportPropertyChanging("CreationDate");
                this._CreationDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("CreationDate");
                this.OnCreationDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _CreationDate;
        partial void OnCreationDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnCreationDateChanged();
        /// <summary>
        /// There are no comments for Property Username in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                this.OnUsernameChanging(value);
                this.ReportPropertyChanging("Username");
                this._Username = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Username");
                this.OnUsernameChanged();
            }
        }
        private string _Username;
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this.ReportPropertyChanging("FirstName");
                this._FirstName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("FirstName");
                this.OnFirstNameChanged();
            }
        }
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this.ReportPropertyChanging("LastName");
                this._LastName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("LastName");
                this.OnLastNameChanged();
            }
        }
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        /// <summary>
        /// There are no comments for Property ApplicationName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationName
        {
            get
            {
                return this._ApplicationName;
            }
            set
            {
                this.OnApplicationNameChanging(value);
                this.ReportPropertyChanging("ApplicationName");
                this._ApplicationName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ApplicationName");
                this.OnApplicationNameChanged();
            }
        }
        private string _ApplicationName;
        partial void OnApplicationNameChanging(string value);
        partial void OnApplicationNameChanged();
        /// <summary>
        /// There are no comments for Property Email in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this.OnEmailChanging(value);
                this.ReportPropertyChanging("Email");
                this._Email = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Email");
                this.OnEmailChanged();
            }
        }
        private string _Email;
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        /// <summary>
        /// There are no comments for Property Password in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                this.OnPasswordChanging(value);
                this.ReportPropertyChanging("Password");
                this._Password = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Password");
                this.OnPasswordChanged();
            }
        }
        private string _Password;
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        /// <summary>
        /// There are no comments for Property PasswordQuestion in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordQuestion
        {
            get
            {
                return this._PasswordQuestion;
            }
            set
            {
                this.OnPasswordQuestionChanging(value);
                this.ReportPropertyChanging("PasswordQuestion");
                this._PasswordQuestion = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("PasswordQuestion");
                this.OnPasswordQuestionChanged();
            }
        }
        private string _PasswordQuestion;
        partial void OnPasswordQuestionChanging(string value);
        partial void OnPasswordQuestionChanged();
        /// <summary>
        /// There are no comments for Property PasswordAnswer in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordAnswer
        {
            get
            {
                return this._PasswordAnswer;
            }
            set
            {
                this.OnPasswordAnswerChanging(value);
                this.ReportPropertyChanging("PasswordAnswer");
                this._PasswordAnswer = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("PasswordAnswer");
                this.OnPasswordAnswerChanged();
            }
        }
        private string _PasswordAnswer;
        partial void OnPasswordAnswerChanging(string value);
        partial void OnPasswordAnswerChanged();
        /// <summary>
        /// There are no comments for Property IsApproved in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsApproved
        {
            get
            {
                return this._IsApproved;
            }
            set
            {
                this.OnIsApprovedChanging(value);
                this.ReportPropertyChanging("IsApproved");
                this._IsApproved = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("IsApproved");
                this.OnIsApprovedChanged();
            }
        }
        private bool _IsApproved;
        partial void OnIsApprovedChanging(bool value);
        partial void OnIsApprovedChanged();
        /// <summary>
        /// There are no comments for Property LastActivityDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> LastActivityDate
        {
            get
            {
                return this._LastActivityDate;
            }
            set
            {
                this.OnLastActivityDateChanging(value);
                this.ReportPropertyChanging("LastActivityDate");
                this._LastActivityDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("LastActivityDate");
                this.OnLastActivityDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _LastActivityDate;
        partial void OnLastActivityDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnLastActivityDateChanged();
        /// <summary>
        /// There are no comments for Property LastLoginDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> LastLoginDate
        {
            get
            {
                return this._LastLoginDate;
            }
            set
            {
                this.OnLastLoginDateChanging(value);
                this.ReportPropertyChanging("LastLoginDate");
                this._LastLoginDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("LastLoginDate");
                this.OnLastLoginDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _LastLoginDate;
        partial void OnLastLoginDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnLastLoginDateChanged();
        /// <summary>
        /// There are no comments for Property LastPasswordChangedDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> LastPasswordChangedDate
        {
            get
            {
                return this._LastPasswordChangedDate;
            }
            set
            {
                this.OnLastPasswordChangedDateChanging(value);
                this.ReportPropertyChanging("LastPasswordChangedDate");
                this._LastPasswordChangedDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("LastPasswordChangedDate");
                this.OnLastPasswordChangedDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _LastPasswordChangedDate;
        partial void OnLastPasswordChangedDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnLastPasswordChangedDateChanged();
        /// <summary>
        /// There are no comments for Property IsOnline in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<bool> IsOnline
        {
            get
            {
                return this._IsOnline;
            }
            set
            {
                this.OnIsOnlineChanging(value);
                this.ReportPropertyChanging("IsOnline");
                this._IsOnline = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("IsOnline");
                this.OnIsOnlineChanged();
            }
        }
        private global::System.Nullable<bool> _IsOnline;
        partial void OnIsOnlineChanging(global::System.Nullable<bool> value);
        partial void OnIsOnlineChanged();
        /// <summary>
        /// There are no comments for Property IsLockedOut in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<bool> IsLockedOut
        {
            get
            {
                return this._IsLockedOut;
            }
            set
            {
                this.OnIsLockedOutChanging(value);
                this.ReportPropertyChanging("IsLockedOut");
                this._IsLockedOut = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("IsLockedOut");
                this.OnIsLockedOutChanged();
            }
        }
        private global::System.Nullable<bool> _IsLockedOut;
        partial void OnIsLockedOutChanging(global::System.Nullable<bool> value);
        partial void OnIsLockedOutChanged();
        /// <summary>
        /// There are no comments for Property LastLockedOutDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> LastLockedOutDate
        {
            get
            {
                return this._LastLockedOutDate;
            }
            set
            {
                this.OnLastLockedOutDateChanging(value);
                this.ReportPropertyChanging("LastLockedOutDate");
                this._LastLockedOutDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("LastLockedOutDate");
                this.OnLastLockedOutDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _LastLockedOutDate;
        partial void OnLastLockedOutDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnLastLockedOutDateChanged();
        /// <summary>
        /// There are no comments for Property FailedPasswordAttemptCount in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> FailedPasswordAttemptCount
        {
            get
            {
                return this._FailedPasswordAttemptCount;
            }
            set
            {
                this.OnFailedPasswordAttemptCountChanging(value);
                this.ReportPropertyChanging("FailedPasswordAttemptCount");
                this._FailedPasswordAttemptCount = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("FailedPasswordAttemptCount");
                this.OnFailedPasswordAttemptCountChanged();
            }
        }
        private global::System.Nullable<int> _FailedPasswordAttemptCount;
        partial void OnFailedPasswordAttemptCountChanging(global::System.Nullable<int> value);
        partial void OnFailedPasswordAttemptCountChanged();
        /// <summary>
        /// There are no comments for Property FailedPasswordAttemptWindowStart in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> FailedPasswordAttemptWindowStart
        {
            get
            {
                return this._FailedPasswordAttemptWindowStart;
            }
            set
            {
                this.OnFailedPasswordAttemptWindowStartChanging(value);
                this.ReportPropertyChanging("FailedPasswordAttemptWindowStart");
                this._FailedPasswordAttemptWindowStart = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("FailedPasswordAttemptWindowStart");
                this.OnFailedPasswordAttemptWindowStartChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _FailedPasswordAttemptWindowStart;
        partial void OnFailedPasswordAttemptWindowStartChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnFailedPasswordAttemptWindowStartChanged();
        /// <summary>
        /// There are no comments for Property FailedPasswordAnswerAttemptCount in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> FailedPasswordAnswerAttemptCount
        {
            get
            {
                return this._FailedPasswordAnswerAttemptCount;
            }
            set
            {
                this.OnFailedPasswordAnswerAttemptCountChanging(value);
                this.ReportPropertyChanging("FailedPasswordAnswerAttemptCount");
                this._FailedPasswordAnswerAttemptCount = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("FailedPasswordAnswerAttemptCount");
                this.OnFailedPasswordAnswerAttemptCountChanged();
            }
        }
        private global::System.Nullable<int> _FailedPasswordAnswerAttemptCount;
        partial void OnFailedPasswordAnswerAttemptCountChanging(global::System.Nullable<int> value);
        partial void OnFailedPasswordAnswerAttemptCountChanged();
        /// <summary>
        /// There are no comments for Property FailedPasswordAnswerAttemptWindowStart in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> FailedPasswordAnswerAttemptWindowStart
        {
            get
            {
                return this._FailedPasswordAnswerAttemptWindowStart;
            }
            set
            {
                this.OnFailedPasswordAnswerAttemptWindowStartChanging(value);
                this.ReportPropertyChanging("FailedPasswordAnswerAttemptWindowStart");
                this._FailedPasswordAnswerAttemptWindowStart = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("FailedPasswordAnswerAttemptWindowStart");
                this.OnFailedPasswordAnswerAttemptWindowStartChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _FailedPasswordAnswerAttemptWindowStart;
        partial void OnFailedPasswordAnswerAttemptWindowStartChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnFailedPasswordAnswerAttemptWindowStartChanged();
        /// <summary>
        /// There are no comments for Property LastModified in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> LastModified
        {
            get
            {
                return this._LastModified;
            }
            set
            {
                this.OnLastModifiedChanging(value);
                this.ReportPropertyChanging("LastModified");
                this._LastModified = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("LastModified");
                this.OnLastModifiedChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _LastModified;
        partial void OnLastModifiedChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnLastModifiedChanged();
        /// <summary>
        /// There are no comments for Property Comment in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this.ReportPropertyChanging("Comment");
                this._Comment = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Comment");
                this.OnCommentChanged();
            }
        }
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
    }
}