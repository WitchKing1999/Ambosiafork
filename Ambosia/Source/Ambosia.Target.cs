// (C) Flumminard 2015

using UnrealBuildTool;
using System.Collections.Generic;

public class AmbosiaTarget : TargetRules
{
	public AmbosiaTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "Ambosia" } );
	}
}
