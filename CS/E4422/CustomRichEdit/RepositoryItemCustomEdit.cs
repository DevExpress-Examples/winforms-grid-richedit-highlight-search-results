using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;

namespace CustomEditor {
    //The attribute that points to the registration method
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemCustomEdit : RepositoryItemRichTextEdit {
        //The static constructor which calls the registration method
        static RepositoryItemCustomEdit() {
            RegisterCustomEdit();
        }

        //Initialize new properties
        public RepositoryItemCustomEdit() {
        }

        //The unique name for the custom editor
        public const string CustomEditName = "CustomEdit";

        //Return the unique name
        public override string EditorTypeName {
            get { return CustomEditName; }
        }

        //Register the editor
        public static void RegisterCustomEdit() {
            //Icon representing the editor within a container editor's Designer
            Image img = null;
            try {
                img = (Bitmap)Bitmap.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp"));
            }
            catch {
            }
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomEdit), typeof(RepositoryItemCustomEdit), typeof(CustomEditViewInfo), new RichTextEditPainter(), true, img));
        }

        //Override the Assign method
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                var source = item as RepositoryItemCustomEdit;
                if (source == null) {
                    return;
                }
            }
            finally {
                EndUpdate();
            }
        }
    }
}
