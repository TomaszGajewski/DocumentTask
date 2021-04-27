using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using RecruitmentTask.RecTaskEntitiesDataModel;

namespace RecruitmentTask.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the RecTaskEntities data model.
    /// </summary>
    public partial class RecTaskEntitiesViewModel : DocumentsViewModel<RecTaskEntitiesModuleDescription, IRecTaskEntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of RecTaskEntitiesViewModel as a POCO view model.
        /// </summary>
        public static RecTaskEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new RecTaskEntitiesViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the RecTaskEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RecTaskEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected RecTaskEntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override RecTaskEntitiesModuleDescription[] CreateModules() {
			return new RecTaskEntitiesModuleDescription[] {
                new RecTaskEntitiesModuleDescription( "Client", "ClientCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Client)),
                new RecTaskEntitiesModuleDescription( "Document Head", "DocumentHeadCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.DocumentHead)),
                new RecTaskEntitiesModuleDescription( "Document Position", "DocumentPositionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.DocumentPosition)),
			};
        }
                		protected override void OnActiveModuleChanged(RecTaskEntitiesModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class RecTaskEntitiesModuleDescription : ModuleDescription<RecTaskEntitiesModuleDescription> {
        public RecTaskEntitiesModuleDescription(string title, string documentType, string group, Func<RecTaskEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}