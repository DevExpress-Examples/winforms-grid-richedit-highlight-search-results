<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630309/21.2.12%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4422)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Winforms Data Grid - Highlight search results in a Rich Text Editor

The WinForms RichEdit does not highlight search results to avoid performance issues. Rich content includes undisplayed markup characters and the WinForms Data Grid includes these characters in the search. This example shows how to handle the [CustomDrawCell](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomDrawCell) event to highlight the search string within RTF content.


## Files to Review

* [Form1.cs](./CS/E4422/Form1.cs) (VB: [Form1.vb](./VB/E4422/Form1.vb))
* [Program.cs](./CS/E4422/Program.cs) (VB: [Program.vb](./VB/E4422/Program.vb))
