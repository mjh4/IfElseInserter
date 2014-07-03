using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;   
using Mono.TextEditor;
using System;
using MonoDevelop.Ide.CodeFormatting;  
using MonoDevelop.Projects.Policies;

namespace IfElseInserter
{

	class InsertIfElseHandler : CommandHandler
	{
		protected override void Run ()
		{
			//Get the document
			Document doc = IdeApp.Workbench.ActiveDocument;
		
			// Get the text editor data to manipulate
			var textEditorData = doc.GetContent<ITextEditorDataProvider> ().GetTextEditorData ();

			// Add the first line of the if-else block, otherwise our getLineIndent won't be correct
			// with an empty line
			textEditorData.InsertAtCaret ("if (conditional) {");

			// Grab the Indent
			string ind = textEditorData.GetLineIndent (textEditorData.Caret.Line);

			// Helper string
			string space = "\n" + ind;

			//Inser the rest of the 
			textEditorData.InsertAtCaret (
				space + "\t" + "then-expression;" +
				space + "}" +
				space + "else" +
				space + "{" +
				space + "\t" + "else-expression;" +
				space + "}");
					
		}

		protected override void Update (CommandInfo info)
		{
			Document doc = IdeApp.Workbench.ActiveDocument;  
			info.Enabled = doc != null && doc.GetContent<ITextEditorDataProvider> () != null;  

		}   
	}
}