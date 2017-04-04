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

using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.FactoryClasses
{
	/// <summary>
	/// Generic factory for DAO objects. 
	/// </summary>
	public partial class DAOFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private DAOFactory()
		{
		}

		/// <summary>Creates a new ChoreDAO object</summary>
		/// <returns>the new DAO object ready to use for Chore Entities</returns>
		public static ChoreDAO CreateChoreDAO()
		{
			return new ChoreDAO();
		}

		/// <summary>Creates a new EmployeeDAO object</summary>
		/// <returns>the new DAO object ready to use for Employee Entities</returns>
		public static EmployeeDAO CreateEmployeeDAO()
		{
			return new EmployeeDAO();
		}

		/// <summary>Creates a new EmployeeLivingroomDAO object</summary>
		/// <returns>the new DAO object ready to use for EmployeeLivingroom Entities</returns>
		public static EmployeeLivingroomDAO CreateEmployeeLivingroomDAO()
		{
			return new EmployeeLivingroomDAO();
		}

		/// <summary>Creates a new LivingroomDAO object</summary>
		/// <returns>the new DAO object ready to use for Livingroom Entities</returns>
		public static LivingroomDAO CreateLivingroomDAO()
		{
			return new LivingroomDAO();
		}

		/// <summary>Creates a new PatientDAO object</summary>
		/// <returns>the new DAO object ready to use for Patient Entities</returns>
		public static PatientDAO CreatePatientDAO()
		{
			return new PatientDAO();
		}

		/// <summary>Creates a new UserDAO object</summary>
		/// <returns>the new DAO object ready to use for User Entities</returns>
		public static UserDAO CreateUserDAO()
		{
			return new UserDAO();
		}

		/// <summary>Creates a new UserRoleDAO object</summary>
		/// <returns>the new DAO object ready to use for UserRole Entities</returns>
		public static UserRoleDAO CreateUserRoleDAO()
		{
			return new UserRoleDAO();
		}

		/// <summary>Creates a new TypedListDAO object</summary>
		/// <returns>The new DAO object ready to use for Typed Lists</returns>
		public static TypedListDAO CreateTypedListDAO()
		{
			return new TypedListDAO();
		}

		#region Included Code

		#endregion
	}
}
