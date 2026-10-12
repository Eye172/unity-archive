# Restoration and running

Use **Unity 2021.3.14f1**. Do not upgrade the historical originals in place.

1. Work from a complete copy of the corresponding original folder, including `Assets`, `Packages` and `ProjectSettings`.
2. Keep the original asset pack layout and `.meta` files so scene GUID references resolve. This public source archive alone does not contain all required visual and audio assets.
3. Install the target platform module and open the copy through Unity Hub. Let the original package lock restore its dependencies.
4. Select the original scene listed on the project page. The two studies with an empty build list require explicitly adding their `SampleScene`.
5. Check compilation and missing references before entering Play Mode. Use **Window → General → Device Simulator** for previews. Select device and orientation explicitly: Rise is portrait; City sandbox uses landscape mobile controls.

## Capture isolation

Working copies use the company identifier `Eye172ArchivePreview`, separating capture PlayerPrefs from the original game. Editor-only capture tooling saves actual rendered frames and bounded sequences. It does not create synthetic game images or change the historical gameplay controllers.

The capture helper and build entry point are contemporary tooling, not historical game code. Their source is in `tools/`. A restored build should log its exact changes, target scene, capture time and remaining errors.

Rise's original controller uses touch input. Capture gestures use Device Simulator's touch backend. After loading a scene, refocus/reconfigure the Simulator and verify output resolution before recording: an inactive preview can otherwise produce a stretched window-sized screenshot. Check the resulting frames, not just the configured device name. Ads remain in the original test mode; production ad interactions are not part of verification.

## Media policy

Screenshots should show distinct mechanics or interfaces rather than repeated angles of the same frame. Demo clips should be short, use actual running scenes, preserve the original game colours, and disclose debug resets or capture-only adaptations. Raw recordings and unmodified source snapshots remain local; curated media belongs beside each project page.
