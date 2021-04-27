using DevExpress.Mvvm.DataModel;
using RecruitmentTask;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecruitmentTask.RecTaskEntitiesDataModel {

    /// <summary>
    /// IRecTaskEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IRecTaskEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Client entities repository.
        /// </summary>
		IRepository<Client, int> Client { get; }
        
        /// <summary>
        /// The DocumentHead entities repository.
        /// </summary>
		IRepository<DocumentHead, int> DocumentHead { get; }
        
        /// <summary>
        /// The DocumentPosition entities repository.
        /// </summary>
		IRepository<DocumentPosition, int> DocumentPosition { get; }
    }
}
