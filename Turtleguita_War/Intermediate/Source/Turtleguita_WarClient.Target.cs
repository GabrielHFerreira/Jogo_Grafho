using UnrealBuildTool;

public class Turtleguita_WarClientTarget : TargetRules
{
	public Turtleguita_WarClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Turtleguita_War");
	}
}
