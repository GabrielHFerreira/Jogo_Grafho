using UnrealBuildTool;

public class Turtleguita_WarEditorTarget : TargetRules
{
	public Turtleguita_WarEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Turtleguita_War");
	}
}
