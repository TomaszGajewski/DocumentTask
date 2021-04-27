using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RecruitmentTask.Views.DocumentHeadView{
    public partial class DocumentHeadView : XtraUserControl {
        public DocumentHeadView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<RecruitmentTask.ViewModels.DocumentHeadViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                documentHeadViewBindingSource, x => x.Entity, x => x.Update());
						#region DocumentPosition Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(DocumentPositionGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.DocumentHeadDocumentPositionDetails.SelectedEntity,
                    args => args.Row as RecruitmentTask.DocumentPosition,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(DocumentPositionGridView, "RowClick")
						.EventToCommand(
						    x => x.DocumentHeadDocumentPositionDetails.Edit(null), x => x.DocumentHeadDocumentPositionDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			DocumentPositionGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    DocumentPositionPopUpMenu.ShowPopup(DocumentPositionGridControl.PointToScreen(e.Location), s);
                }
            };

            // We want to show the DocumentHeadDocumentPositionDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(DocumentPositionGridControl, g => g.DataSource, x => x.DocumentHeadDocumentPositionDetails.Entities );
				
			fluentAPI.BindCommand(bbiDocumentPositionNew, x => x.DocumentHeadDocumentPositionDetails.New());
			fluentAPI.BindCommand(bbiDocumentPositionEdit,x => x.DocumentHeadDocumentPositionDetails.Edit(null), x=>x.DocumentHeadDocumentPositionDetails.SelectedEntity);
			fluentAPI.BindCommand(bbiDocumentPositionDelete,x => x.DocumentHeadDocumentPositionDetails.Delete(null), x=>x.DocumentHeadDocumentPositionDetails.SelectedEntity);
			fluentAPI.BindCommand(bbiDocumentPositionRefresh, x => x.DocumentHeadDocumentPositionDetails.Refresh());
            #endregion
            // Binding for Client LookUp editor
            fluentAPI.SetBinding(ClientLookUpEdit.Properties, p => p.DataSource, x => x.LookUpClientDocumentHead.Entities);

            bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
        }
    }
}
