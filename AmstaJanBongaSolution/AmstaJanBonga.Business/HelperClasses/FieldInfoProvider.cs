///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (7 + 0));
			InitChoreEntityInfos();
			InitEmployeeEntityInfos();
			InitEmployeeLivingroomEntityInfos();
			InitLivingroomEntityInfos();
			InitPatientEntityInfos();
			InitUserEntityInfos();
			InitUserRoleEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits ChoreEntity's FieldInfo objects</summary>
		private void InitChoreEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChoreFieldIndex), "ChoreEntity");
			this.AddElementFieldInfo("ChoreEntity", "Date", typeof(System.DateTime), true, false, false, false,  (int)ChoreFieldIndex.Date, 0, 0, 0);
			this.AddElementFieldInfo("ChoreEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)ChoreFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("ChoreEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ChoreFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("ChoreEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ChoreFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("ChoreEntity", "LivingroomId", typeof(System.Int32), true, true, false, false,  (int)ChoreFieldIndex.LivingroomId, 0, 0, 10);
			this.AddElementFieldInfo("ChoreEntity", "PatientId", typeof(System.Int32), true, true, false, false,  (int)ChoreFieldIndex.PatientId, 0, 0, 10);
			this.AddElementFieldInfo("ChoreEntity", "TimeOfDayTypeEnum", typeof(System.Byte), true, false, false, false,  (int)ChoreFieldIndex.TimeOfDayTypeEnum, 0, 0, 3);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeFieldIndex), "EmployeeEntity");
			this.AddElementFieldInfo("EmployeeEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "DateDeletion", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.DateDeletion, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)EmployeeFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "ImagePath", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.ImagePath, 255, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "IsMarkedAsDeleted", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.IsMarkedAsDeleted, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "UserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeeFieldIndex.UserId, 0, 0, 10);
		}
		/// <summary>Inits EmployeeLivingroomEntity's FieldInfo objects</summary>
		private void InitEmployeeLivingroomEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeLivingroomFieldIndex), "EmployeeLivingroomEntity");
			this.AddElementFieldInfo("EmployeeLivingroomEntity", "EmployeeId", typeof(System.Int32), true, true, false, false,  (int)EmployeeLivingroomFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeLivingroomEntity", "LivingroomId", typeof(System.Int32), true, true, false, false,  (int)EmployeeLivingroomFieldIndex.LivingroomId, 0, 0, 10);
		}
		/// <summary>Inits LivingroomEntity's FieldInfo objects</summary>
		private void InitLivingroomEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LivingroomFieldIndex), "LivingroomEntity");
			this.AddElementFieldInfo("LivingroomEntity", "ColourTypeEnum", typeof(System.Byte), false, false, false, false,  (int)LivingroomFieldIndex.ColourTypeEnum, 0, 0, 3);
			this.AddElementFieldInfo("LivingroomEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)LivingroomFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("LivingroomEntity", "DateDeletion", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LivingroomFieldIndex.DateDeletion, 0, 0, 0);
			this.AddElementFieldInfo("LivingroomEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LivingroomFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("LivingroomEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LivingroomFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("LivingroomEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)LivingroomFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("LivingroomEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)LivingroomFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("LivingroomEntity", "IsMarkedAsDeleted", typeof(System.Boolean), false, false, false, false,  (int)LivingroomFieldIndex.IsMarkedAsDeleted, 0, 0, 0);
			this.AddElementFieldInfo("LivingroomEntity", "Name", typeof(System.String), false, false, false, false,  (int)LivingroomFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits PatientEntity's FieldInfo objects</summary>
		private void InitPatientEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PatientFieldIndex), "PatientEntity");
			this.AddElementFieldInfo("PatientEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)PatientFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "DateDeletion", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PatientFieldIndex.DateDeletion, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PatientFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)PatientFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("PatientEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)PatientFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PatientFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PatientEntity", "ImagePath", typeof(System.String), false, false, false, false,  (int)PatientFieldIndex.ImagePath, 255, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)PatientFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "IsMarkedAsDeleted", typeof(System.Boolean), false, false, false, false,  (int)PatientFieldIndex.IsMarkedAsDeleted, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "LivingroomId", typeof(System.Int32), false, true, false, false,  (int)PatientFieldIndex.LivingroomId, 0, 0, 10);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)UserFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DateDeletion", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserFieldIndex.DateDeletion, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DateLastLogin", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserFieldIndex.DateLastLogin, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)UserFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)UserFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "IsMarkedAsDeleted", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsMarkedAsDeleted, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 255, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Salt", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Salt, 255, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Username", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Username, 50, 0, 0);
		}
		/// <summary>Inits UserRoleEntity's FieldInfo objects</summary>
		private void InitUserRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserRoleFieldIndex), "UserRoleEntity");
			this.AddElementFieldInfo("UserRoleEntity", "RoleTypeEnum", typeof(System.Byte), false, false, false, false,  (int)UserRoleFieldIndex.RoleTypeEnum, 0, 0, 3);
			this.AddElementFieldInfo("UserRoleEntity", "UserId", typeof(System.Int32), true, true, false, false,  (int)UserRoleFieldIndex.UserId, 0, 0, 10);
		}
		
	}
}




