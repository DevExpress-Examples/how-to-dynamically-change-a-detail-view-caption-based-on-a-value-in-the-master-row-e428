<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q182806/Form1.cs) (VB: [Form1.vb](./VB/Q182806/Form1.vb))
* [MyGridView.cs](./CS/Q182806/MyGridView.cs) (VB: [MyGridView.vb](./VB/Q182806/MyGridView.vb))
* [Program.cs](./CS/Q182806/Program.cs) (VB: [Program.vb](./VB/Q182806/Program.vb))
<!-- default file list end -->
# How to dynamically change a detail view caption based on a value in the master row


<p>The XtraGrid provides you with a capability to manually define a view caption that will be displayed for child views when the GridView.OptionsDetail.ShowDetailTabs property is set to true. Sometimes, it can be useful to dinamically change this caption based on any value in the master row. For example, when the a detail view is being zoomed, it's unclear what master field the detail view corresponds to. This example demonstrates how to implement this feature by creating a GridView descendant. This example can be used in most situations with minimal changes to code. All that you need to make it work on your side, is to define a new KeyFieldName property for each view, which has details.</p>

<br/>


