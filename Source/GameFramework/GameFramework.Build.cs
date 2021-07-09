// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class GameFramework : ModuleRules
{
	public GameFramework(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange(
		new string[] {
				"GameFramework"
			}
		);

		PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", 
			"CoreUObject", 
			"Engine",
			"EnhancedInput"
		});

		PrivateDependencyModuleNames.AddRange(new string[] {
			"RenderCore",
			"SlateCore",
		});
	}
}
