using UnrealBuildTool;

public class Turtleguita_WarTarget : TargetRules
{
	public Turtleguita_WarTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Turtleguita_War");
	}
}
