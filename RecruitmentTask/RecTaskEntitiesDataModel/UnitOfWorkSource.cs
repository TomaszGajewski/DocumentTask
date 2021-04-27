using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using RecruitmentTask;
using System;
using System.Collections;
using System.Linq;

namespace RecruitmentTask.RecTaskEntitiesDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork>(() => new RecTaskEntitiesUnitOfWork(() => new RecTaskEntities()));
        }
    }
}