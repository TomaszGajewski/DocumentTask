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
    /// Represents the DocumentHead collection view model.
    /// </summary>
    public partial class DocumentHeadCollectionViewModel : CollectionViewModel<DocumentHead, int, IRecTaskEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DocumentHeadCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DocumentHeadCollectionViewModel Create(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DocumentHeadCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DocumentHeadCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DocumentHeadCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DocumentHeadCollectionViewModel(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.DocumentHead) {
        }
    }
}