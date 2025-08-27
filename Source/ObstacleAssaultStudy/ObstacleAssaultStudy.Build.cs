// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ObstacleAssaultStudy : ModuleRules
{
	public ObstacleAssaultStudy(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ObstacleAssaultStudy",
			"ObstacleAssaultStudy/Variant_Platforming",
			"ObstacleAssaultStudy/Variant_Platforming/Animation",
			"ObstacleAssaultStudy/Variant_Combat",
			"ObstacleAssaultStudy/Variant_Combat/AI",
			"ObstacleAssaultStudy/Variant_Combat/Animation",
			"ObstacleAssaultStudy/Variant_Combat/Gameplay",
			"ObstacleAssaultStudy/Variant_Combat/Interfaces",
			"ObstacleAssaultStudy/Variant_Combat/UI",
			"ObstacleAssaultStudy/Variant_SideScrolling",
			"ObstacleAssaultStudy/Variant_SideScrolling/AI",
			"ObstacleAssaultStudy/Variant_SideScrolling/Gameplay",
			"ObstacleAssaultStudy/Variant_SideScrolling/Interfaces",
			"ObstacleAssaultStudy/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
