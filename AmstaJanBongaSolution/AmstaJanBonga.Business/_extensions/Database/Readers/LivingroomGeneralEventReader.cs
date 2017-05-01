﻿using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingroomGeneralEventReader
    {
        public static LivingroomGeneralEventCollection GetAllLivingroomGeneralEventsByLivingroomId(int livingroomId)
        {
            var livingroomGeneralEvents = new LivingroomGeneralEventCollection();

            var predicate = new PredicateExpression();
            predicate.Add(LivingroomGeneralEventFields.LivingroomId == livingroomId);

            livingroomGeneralEvents.GetMulti(predicate, -1);

            return livingroomGeneralEvents;
        }

        public static List<DateTime> GetAllUsedDatesByLivingroomId(int livingroomId)
        {
            // Result fields.
            var fields = new ResultsetFields(1)
            {
                LivingroomGeneralEventFields.Date
            };

            // Sorting
            var sorter = new SortExpression
            {
                LivingroomGeneralEventFields.Date | SortOperator.Ascending
            };

            // Predicate
            var predicate = new PredicateExpression
            {
                LivingroomGeneralEventFields.LivingroomId == livingroomId
            };

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, sorter, predicate, null, false, null, null, 0, 0);

            var dates = new List<DateTime>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dates.Add(Convert.ToDateTime(dt.Rows[i]["Date"]));
            }

            return dates;
        }

        public static LivingroomGeneralEventEntity GetLivingroomGeneralByIdAndDate(int livingroomId, DateTime date, bool throwExceptionWhenNotFound)
        {
            var livingroomGeneralEvent = new LivingroomGeneralEventEntity(date, livingroomId);

            if (throwExceptionWhenNotFound && livingroomGeneralEvent.IsNew)
                throw new Exception("Nothing found for livingroom {0} and date {1}.".FormatString(livingroomId, date));
            else if (livingroomGeneralEvent.IsNew)
                return null;

            return livingroomGeneralEvent;
        }
    }
}