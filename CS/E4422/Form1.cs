using DevExpress.LookAndFeel;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E4422 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(OnCustomDrawCell);
            List<Invoice> invoices = CreateData();
            bindingSource1.DataSource = invoices;
        }

        private static RichEditDocumentServer server = new RichEditDocumentServer();

        private void OnCustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if (e.Column == colDescription && !string.IsNullOrEmpty(gridView1.FindFilterText)) {
                server.RtfText = e.DisplayText;
                Document document = server.Document;
                document.BeginUpdate();
                DocumentRange[] ranges = document.FindAll(gridView1.FindFilterText, SearchOptions.None);
                for (int i = 0; i < ranges.Length; i++) {
                    CharacterProperties cp = document.BeginUpdateCharacters(ranges[i]);
                    cp.BackColor = LookAndFeelHelper.GetHighlightSearchAppearance(UserLookAndFeel.Default, false).BackColor;
                    document.EndUpdateCharacters(cp);
                }
                document.EndUpdate();
                e.DisplayText = server.RtfText;
            }
        }

        private static List<Invoice> CreateData() {
            List<Invoice> invoices = new List<Invoice>(10);
            invoices.Add(new Invoice(0, 10.0m, @"{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\cf0 RTF }{\b\cf0 text}{\cf0  sample 1.}\par}"));
            invoices.Add(new Invoice(1, 15.0m, @"{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\cf0 RTF }{\b\cf0 text}{\cf0  sample 2.}\par}"));
            invoices.Add(new Invoice(2, 20.0m, @"{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\cf0 RTF }{\b\cf0 text}{\cf0  sample 3.}\par}"));
            return invoices;
        }
    }
}
