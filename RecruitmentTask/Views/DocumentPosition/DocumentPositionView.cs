using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RecruitmentTask.Views.DocumentPositionView{
    public partial class DocumentPositionView : XtraUserControl {
        public DocumentPositionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<RecruitmentTask.ViewModels.DocumentPositionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                documentPositionViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for DocumentHead LookUp editor
			fluentAPI.SetBinding(DocumentHeadLookUpEdit.Properties, p => p.DataSource, x => x.LookUpDocumentHead.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }

    }
}
