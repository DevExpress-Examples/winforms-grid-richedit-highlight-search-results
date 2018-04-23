# How to make RichEdit highlight strings that match the Find panel text


<p>Since RichEdit may contain large amounts of content, highlighting substrings may affect application performance; which is why, by default, RichEdit doesn't highlight search strings instances. In any case, Rich content includes undisplayed markup characters and the Grid includes these in the search. This example illustrates how to implement the intended functionality. It uses the Grid custom <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomDrawCelltopic"><u>painting events</u></a> to highlight a matched string and a <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument4716"><u>custom RichEdit</u></a> to obtain the text without markup.</p>

<br/>


