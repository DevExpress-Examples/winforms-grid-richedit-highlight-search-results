using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace CustomEditor {
    public class CustomEdit : RichTextEdit {
        //The static constructor which calls the registration method
        static CustomEdit() {
            RepositoryItemCustomEdit.RegisterCustomEdit();
        }

        //Initialize the new instance
        public CustomEdit() {
            //...
        }

        //Return the unique name
        public override string EditorTypeName {
            get { return RepositoryItemCustomEdit.CustomEditName; }
        }

        //Override the Properties property
        //Simply type-cast the object to the custom repository item type
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomEdit Properties {
            get { return base.Properties as RepositoryItemCustomEdit; }
        }
    }
}
