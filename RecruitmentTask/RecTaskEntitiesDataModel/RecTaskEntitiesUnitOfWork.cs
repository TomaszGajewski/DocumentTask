using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using RecruitmentTask;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecruitmentTask.RecTaskEntitiesDataModel {

    /// <summary>
    /// A RecTaskEntitiesUnitOfWork instance that represents the run-time implementation of the IRecTaskEntitiesUnitOfWork interface.
    /// </summary>
    public class RecTaskEntitiesUnitOfWork : DbUnitOfWork<RecTaskEntities>, IRecTaskEntitiesUnitOfWork {

        public RecTaskEntitiesUnitOfWork(Func<RecTaskEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Client, int> IRecTaskEntitiesUnitOfWork.Client {
            get { return GetRepository(x => x.Set<Client>(), (Client x) => x.Id); }
        }

        IRepository<DocumentHead, int> IRecTaskEntitiesUnitOfWork.DocumentHead {
            get { return GetRepository(x => x.Set<DocumentHead>(), (DocumentHead x) => x.Id); }
        }

        IRepository<DocumentPosition, int> IRecTaskEntitiesUnitOfWork.DocumentPosition {
            get { return GetRepository(x => x.Set<DocumentPosition>(), (DocumentPosition x) => x.Id); }
        }
    }
}
