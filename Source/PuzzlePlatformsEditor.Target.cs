using UnrealBuildTool;
using System.Collections.Generic;

public class PuzzlePlatformsEditorTarget : TargetRules
{
	public PuzzlePlatformsEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PuzzlePlatforms");
	}
}
