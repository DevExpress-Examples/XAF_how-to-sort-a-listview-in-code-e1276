using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Win.Editors;

namespace WinWebSolution.Module.Win {
    public class WinSortListViewController : SortListViewControllerBase {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            if (View.Editor is GridListEditor gridListEditor) {
                gridListEditor.GridView.OptionsCustomization.AllowSort = false;
            }
        }
    }
}
