// redbox, 2021

using UnrealBuildTool;
using System.Collections.Generic;

public class MinUE4ProjectEditorTarget : TargetRules
{
	public MinUE4ProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("MinUE4Project");
	}
}
