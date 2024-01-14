using UnrealBuildTool;

public class Turtleguita_WarServerTarget : TargetRules
{
	public Turtleguita_WarServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Turtleguita_War");
	}
}
