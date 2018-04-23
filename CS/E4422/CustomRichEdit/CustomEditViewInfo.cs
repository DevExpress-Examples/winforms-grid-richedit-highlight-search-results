using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace CustomEditor {
    public class CustomEditViewInfo : RichTextEditViewInfo {
        public CustomEditViewInfo(RepositoryItem item)
            : base(item) {
        }

        public override string DisplayText {
            get {
                object value = Viewer.EditValue;
                if (value==null)
                    return String.Empty;
                return value.ToString();
            }
        }
    }
}
