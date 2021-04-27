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
    /// Represents the single Client object view model.
    /// </summary>
    public partial class ClientViewModel : SingleObjectViewModel<Client, int, IRecTaskEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ClientViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ClientViewModel Create(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ClientViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ClientViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClientViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ClientViewModel(IUnitOfWorkFactory<IRecTaskEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Client, x => x.LastName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of DocumentHead for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DocumentHead> LookUpDocumentHead {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ClientViewModel x) => x.LookUpDocumentHead,
                    getRepositoryFunc: x => x.DocumentHead);
            }
        }

        /*LookUp*/
        public class ClientForDocumentHead
        {
            public static IQueryable<ClientForDocumentHead> GetClientForDocument(IQueryable<Client> query)
            {
                return query.Select(x => new ClientForDocumentHead
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

        public IEntitiesViewModel<ClientForDocumentHead> LookUpClientDocuments
        {
            get { return GetLookUpProjectionsViewModel((ClientViewModel x) => x.LookUpClientDocuments, x => x.Client,
                projection: query => ClientForDocumentHead.GetClientForDocument(query)); }
        }

        /*LookUp*/


        /// <summary>
        /// The view model for the ClientDocumentHead detail collection.
        /// </summary>
        public CollectionViewModelBase<DocumentHead, DocumentHead, int, IRecTaskEntitiesUnitOfWork> ClientDocumentHeadDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ClientViewModel x) => x.ClientDocumentHeadDetails,
                    getRepositoryFunc: x => x.DocumentHead,
                    foreignKeyExpression: x => x.ClientId,
                    navigationExpression: x => x.Client);
            }
        }
    }
}
