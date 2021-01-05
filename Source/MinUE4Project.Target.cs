// redbox, 2021

using UnrealBuildTool;
using System.Collections.Generic;

public class MinUE4ProjectTarget : TargetRules
{
	public MinUE4ProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("MinUE4Project");
	}
}
