Imports DevExpress.XtraRichEdit
Imports System
Imports System.Windows.Forms

Namespace E4422

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            RichEditControlCompatibility.UseThemeFonts = False
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
