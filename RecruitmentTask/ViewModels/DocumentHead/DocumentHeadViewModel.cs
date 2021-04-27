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
    /// Represents the single DocumentHead object view model.
    /// </summary>
    public partial class DocumentHeadViewModel : SingleObjectViewModel<DocumentHead, int, IRecTaskEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DocumentHeadViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DocumentHeadViewModel Create(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DocumentHeadViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DocumentHeadViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DocumentHeadViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DocumentHeadViewModel(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.DocumentHead, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Client for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Client> LookUpClient {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DocumentHeadViewModel x) => x.LookUpClient,
                    getRepositoryFunc: x => x.Client);
            }
        }


        /*LookUp*/
        public class ClientForLookUpDocumentHead
        {
            public static IQueryable<ClientForLookUpDocumentHead> GetClientForDocument(IQueryable<Client> query)
            {
                return query.Select(x => new ClientForLookUpDocumentHead
                {
                    Id = x.Id,
                    AccountNumber = x.AccountNumber,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                });
            }
            public int Id { get; set; }
            public string AccountNumber { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public IEntitiesViewModel<ClientForLookUpDocumentHead> LookUpClientDocumentHead
        {
            get
            {
                return GetLookUpProjectionsViewModel((DocumentHeadViewModel x) => x.LookUpClientDocumentHead, x => x.Client,
              projection: query => ClientForLookUpDocumentHead.GetClientForDocument(query));
            }
        }


        /*LookUp*/


        /// <summary>
        /// The view model that contains a look-up collection of DocumentPosition for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DocumentPosition> LookUpDocumentPosition {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DocumentHeadViewModel x) => x.LookUpDocumentPosition,
                    getRepositoryFunc: x => x.DocumentPosition);
            }
        }

        /// <summary>
        /// The view model for the DocumentHeadDocumentPosition detail collection.
        /// </summary>
        public CollectionViewModelBase<DocumentPosition, DocumentPosition, int, IRecTaskEntitiesUnitOfWork> DocumentHeadDocumentPositionDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (DocumentHeadViewModel x) => x.DocumentHeadDocumentPositionDetails, 
                    getRepositoryFunc: x => x.DocumentPosition,
                    foreignKeyExpression: x => x.DocumentHeadId,
                    navigationExpression: x => x.DocumentHead);
            }
        }
    }
}
