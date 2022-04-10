// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class study002 : ModuleRules
{
	public study002(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "GameplayTags", "GameplayAbilities" });

		PrivateDependencyModuleNames.AddRange(new string[] { });
	}
}
