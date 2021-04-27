using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RecruitmentTask.Views.ClientView{
    public partial class ClientView : XtraUserControl {
        public ClientView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<RecruitmentTask.ViewModels.ClientViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                clientViewBindingSource, x => x.Entity, x => x.Update());
						#region DocumentHead Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(DocumentHeadGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ClientDocumentHeadDetails.SelectedEntity,
                    args => args.Row as RecruitmentTask.DocumentHead,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(DocumentHeadGridView, "RowClick")
						.EventToCommand(
						    x => x.ClientDocumentHeadDetails.Edit(null), x => x.ClientDocumentHeadDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			DocumentHeadGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    DocumentHeadPopUpMenu.ShowPopup(DocumentHeadGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ClientDocumentHeadDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(DocumentHeadGridControl, g => g.DataSource, x => x.ClientDocumentHeadDetails.Entities);
				
														fluentAPI.BindCommand(bbiDocumentHeadNew, x => x.ClientDocumentHeadDetails.New());
																													fluentAPI.BindCommand(bbiDocumentHeadEdit,x => x.ClientDocumentHeadDetails.Edit(null), x=>x.ClientDocumentHeadDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiDocumentHeadDelete,x => x.ClientDocumentHeadDetails.Delete(null), x=>x.ClientDocumentHeadDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiDocumentHeadRefresh, x => x.ClientDocumentHeadDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
