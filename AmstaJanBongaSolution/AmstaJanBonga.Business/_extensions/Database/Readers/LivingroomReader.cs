using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using System;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingroomReader
    {
        #region Entities

        /// <summary>
        /// Gets the livingroom with the corresponding livingroom id or null. 
        /// </summary>
        /// <param name="livingroomId">The livingrooms unique id.</param>
        /// <param name="name">The name of the livingroom.</param>
        /// <param name="colourType">The colour of the livingroom, default is grey.</param>
        /// <returns></returns>
        public static LivingroomEntity GetLivingroomById(int livingroomId, string name, ColourTypeEnum colourType = ColourTypeEnum.Default)
        {
            return new LivingroomEntity(livingroomId);
        }

        /// <summary>
        /// Gets the livingroom with the corresponding livingroom id or null.
        /// </summary>
        /// <param name="livingroomId">The livingrooms unique id.</param>
        /// <param name="name">The name of the livingroom.</param>
        /// <param name="colourType">The colour of the livingroom, default is grey.</param>
        /// <param name="throwExceptionWhenNotFound"></param>
        /// <returns></returns>
        public static LivingroomEntity GetLivingroomById(int livingroomId, string name, ColourTypeEnum colourType, bool throwExceptionWhenNotFound)
        {
            var livingroom = GetLivingroomById(livingroomId, name, colourType);

            if (livingroom == null && throwExceptionWhenNotFound)
                throw new Exception("Livingroom not found for id {0}.".FormatString(livingroomId));

            return livingroom;
        }

        #endregion

        #region Collections

        /// <summary>
        /// Returns a collection of all the livingrooms.
        /// </summary>
        /// <returns></returns>
        public static LivingroomCollection GetAllLivingrooms()
        {
            var livingrooms = new LivingroomCollection();
            livingrooms.GetMulti(null, 0);

            return livingrooms;
        }

        #endregion
    }
}
