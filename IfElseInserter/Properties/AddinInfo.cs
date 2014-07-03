using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"IfElseInserter", 
	Namespace = "IfElseInserter",
	Version = "1.0"
)]

[assembly:AddinName ("IfElseInserter")]
[assembly:AddinCategory ("IfElseInserter")]
[assembly:AddinDescription ("IfElseInserter")]
[assembly:AddinAuthor ("Max Hoffman")]

[assembly:AddinDependency ("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]
