using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RecruitmentTask.RecTaskEntitiesDataModel;
using RecruitmentTask.Common;
using RecruitmentTask;

namespace RecruitmentTask.ViewModels {

    /// <summary>
    /// Represents the Client collection view model.
    /// </summary>
    public partial class ClientCollectionViewModel : CollectionViewModel<Client, int, IRecTaskEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ClientCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ClientCollectionViewModel Create(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ClientCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ClientCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClientCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ClientCollectionViewModel(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Client) {
        }
    }
}