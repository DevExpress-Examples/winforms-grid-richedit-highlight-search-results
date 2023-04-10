<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630309/21.2.12%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4422)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/E4422/Form1.cs) (VB: [Form1.vb](./VB/E4422/Form1.vb))
* [Invoice.cs](./CS/E4422/Invoice.cs) (VB: [Invoice.vb](./VB/E4422/Invoice.vb))
* [Program.cs](./CS/E4422/Program.cs) (VB: [Program.vb](./VB/E4422/Program.vb))
<!-- default file list end -->
# How to make RichEdit highlight strings that match the Find panel text


<p>Since RichEdit may contain large amounts of content, highlighting substrings may affect application performance; which is why, by default, RichEdit doesn't highlight search strings instances. In any case, Rich content includes undisplayed markup characters and the Grid includes these in the search. This example illustrates how to implement the intended functionality. It uses the Grid custom <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomDrawCelltopic"><u>painting events</u></a> to highlight a matched string and a <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument4716"><u>custom RichEdit</u></a> to obtain the text without markup.</p>

<br/>
