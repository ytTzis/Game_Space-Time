# Game_Space-Time

## Environment

- Unity version: `2022.3.62f3`
- Recommended branch: `main`
- Platform used in current setup: `Windows`

## Required Unity Packages

The project was last opened and updated with these important package versions:

- `com.unity.inputsystem`: `1.14.0`
- `com.unity.cinemachine`: `2.10.3`
- `com.unity.textmeshpro`: `3.0.7`
- `com.unity.timeline`: `1.7.7`
- `com.unity.postprocessing`: `3.4.0`

The package source is currently set to:

- `https://packages.unity.com`

If Unity opens the project with missing package errors, first confirm:

1. Unity Editor version matches `2022.3.62f3`
2. Package Manager can access `packages.unity.com`
3. `Packages/manifest.json` and `Packages/packages-lock.json` were pulled correctly

## Project Open Steps

1. Clone or pull the latest `main` branch
2. Open the project with Unity Hub using `2022.3.62f3`
3. Wait for package restore and script compilation to finish
4. If Input System prompts for reimport or regeneration, allow Unity to complete it
5. Check that `Assets/Scripts/Config/Input/InputController.cs` is generated without errors

## Current Focus

- `Assets/1_GameScene.unity`
  - heart rate visualization prototype
- `Assets/3_GameScene.unity`
  - cyberpunk lighting adjustments
  - heart rate visualization migration and tuning
- `Assets/2_Game Scene.unity`
  - environment/map structure work in progress

## Notes For Team Sync

- `Scene 3` currently contains ongoing heart-rate-related scene objects and lighting adjustments
- Project settings and package versions were updated together with scene changes
- If the project opens with version mismatch, use the version in this README first before debugging scene errors

