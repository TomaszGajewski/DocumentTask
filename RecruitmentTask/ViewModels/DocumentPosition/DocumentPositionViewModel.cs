using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RecruitmentTask.RecTaskEntitiesDataModel;
using RecruitmentTask.Common;
using RecruitmentTask;

namespace RecruitmentTask.ViewModels {

    /// <summary>
    /// Represents the single DocumentPosition object view model.
    /// </summary>
    public partial class DocumentPositionViewModel : SingleObjectViewModel<DocumentPosition, int, IRecTaskEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DocumentPositionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DocumentPositionViewModel Create(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DocumentPositionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DocumentPositionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DocumentPositionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DocumentPositionViewModel(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.DocumentPosition, x => x.ProductName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of DocumentHead for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DocumentHead> LookUpDocumentHead {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DocumentPositionViewModel x) => x.LookUpDocumentHead,
                    getRepositoryFunc: x => x.DocumentHead);
            }
        }

    }
}
