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
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using AmstaJanBonga.Business.DaoClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses.SelfServicingSpecific;
using SD.LLBLGen.Pro.QuerySpec.SelfServicing;

namespace AmstaJanBonga.Business.StoredProcedureCallerClasses
{
	/// <summary>Class which contains the static logic to execute retrieval stored procedures in the database.</summary>
	public static partial class RetrievalProcedures
	{

		/// <summary>Gets the SP Call using query for fetching the GetAllEventsForTodayByPatientIdResult TypedView.</summary>
		/// <param name="unix">Input parameter of stored procedure</param>
		/// <param name="patientId">Input parameter of stored procedure</param>
		/// <returns>ready to use IRetrievalQuery instance for fetching the typedview</returns>
		public static IRetrievalQuery GetQueryForGetAllEventsForTodayByPatientIdResultTypedView(System.Int32 unix, System.Int32 patientId)
		{
			IRetrievalQuery query = GetGetAllEventsForTodayByPatientIdCallAsQuery(unix, patientId);
			query.ResultsetNumber = 1;
			return query;
		}
		
		
		/// <summary>Fetches the typed view 'GetAllEventsForTodayByPatientIdResult' using a stored procedure call. </summary>
		/// <param name="transactionToUse">The transaction to use.</param>
		/// <param name="fields">The typed view fields.</param>
		/// <param name="typedViewToFetch">The typed view to fetch. Should be a 'GetAllEventsForTodayByPatientIdResultTypedView' instance</param>
		/// <param name="unix">Input parameter of stored procedure</param>
		/// <param name="patientId">Input parameter of stored procedure</param>
		internal static bool FetchGetAllEventsForTodayByPatientIdResultTypedView(ITransaction transactionToUse, IEntityFields fields, DataTable typedViewToFetch, System.Int32 unix, System.Int32 patientId)
		{
			DaoBase dao = new CommonDaoBase();
			StoredProcedureCall call = CreateGetAllEventsForTodayByPatientIdCall(new DataAccessCoreImpl(dao, transactionToUse), unix, patientId);
			IRetrievalQuery query = call.ToRetrievalQuery();
			query.ResultsetNumber = 1;
			bool toReturn = dao.GetMultiAsDataTable(fields, typedViewToFetch, query, transactionToUse);
			return toReturn;
		}
	

		/// <summary>Calls stored procedure 'GetAllEventsForTodayByPatientId'.<br/><br/></summary>
		/// <param name="unix">Input parameter of stored procedure. </param>
		/// <param name="patientId">Input parameter of stored procedure. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable GetAllEventsForTodayByPatientId(System.Int32 unix, System.Int32 patientId)
		{
			return GetAllEventsForTodayByPatientId(unix, patientId, null);
		}

		/// <summary>Calls stored procedure 'GetAllEventsForTodayByPatientId'.<br/><br/></summary>
		/// <param name="unix">Input parameter of stored procedure. </param>
		/// <param name="patientId">Input parameter of stored procedure. </param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable GetAllEventsForTodayByPatientId(System.Int32 unix, System.Int32 patientId,  ITransaction transactionToUse)
		{
			using(StoredProcedureCall call = CreateGetAllEventsForTodayByPatientIdCall(new DataAccessCoreImpl(new CommonDaoBase(), transactionToUse), unix, patientId))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}
		
		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'GetAllEventsForTodayByPatientId'.</summary>
		/// <param name="unix">Input parameter of stored procedure</param>
		/// <param name="patientId">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetGetAllEventsForTodayByPatientIdCallAsQuery( System.Int32 unix, System.Int32 patientId )
		{
			return CreateGetAllEventsForTodayByPatientIdCall(new DataAccessCoreImpl(new CommonDaoBase(), null), unix, patientId).ToRetrievalQuery();
		}

		/// <summary>Creates the call object for the call 'GetAllEventsForTodayByPatientId' to stored procedure 'GetAllEventsForTodayByPatientId'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="unix">Input parameter</param>
		/// <param name="patientId">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateGetAllEventsForTodayByPatientIdCall(IDataAccessCore dataAccessProvider, System.Int32 unix, System.Int32 patientId)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Vanderlaan_jouwsoftware_janbonga_development].[Vanderlaan].[GetAllEventsForTodayByPatientId]", "GetAllEventsForTodayByPatientId")
							.AddParameter("@Unix", "Int", 0, ParameterDirection.Input, true, 10, 0, unix)
							.AddParameter("@PatientId", "Int", 0, ParameterDirection.Input, true, 10, 0, patientId);
		}


		#region Included Code

		#endregion
	}
}
