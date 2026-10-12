# October 2026: start and fall recovery

The author requested that the broken checkpoint be temporarily disabled and the player returned to the beginning of the parkour course.

Only two original project files were changed after exact backups: `Assets/Scripts/AntiAbyss.cs` and `Assets/Scenes/SampleScene.unity`. The preserved historical versions remain under `../source/`.

The player prefab root moves from (-13.3, 45, 353) to (0, 1.1, -6), above the first Start platform. The old checkpoint changed only Z to 167 while retaining an unrelated X and Y. That update is disabled; falling below Y = -50 restores the initial spawn and clears linear/angular velocity.

Runtime regression checks passed: correct spawn, stable contact with the starting platform, no checkpoint rewrite after Z = 160, return after a fall, cleared velocity, and stable landing after respawn. The changes are dated 2026 rather than attributed to the historical 2023 work.
