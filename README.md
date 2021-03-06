# Everyday Workflow Tools in Unity
Building games is a time-consuming, complicated, and collaborative process. On massive projects, engineers often build tools like level editors, data visualizers, and automated tasks to enable their teammates to produce a game.

But tools are not just for AAA titles; we can always build small tools throughout the development process to increase productivity and make designing content more fun. One hidden gem of the Unity game engine is the extensibility of its editor. We can use C# scripting, just like our game scripts, to add functionality and graphical interfaces to our Unity workspace.

If you're an engineer or Unity developer, come learn how to make tools that you and your team can use every day in your workflow. If you're an artist, designer, or other non-technical game developer, come learn what kinds of tools you can expect your engineers to be capable of creating!

## What is Serialization?

Serialization is the process of deterministically formatting data so that it can be stored or transmitted. Deserialization is the opposite process.

## Examples/Inspiration for Tools

- [Warcraft 3 World Editor](https://youtu.be/Z4Q3kqAJR8A?t=3m53s)
- [Starcraft 2 Editor](https://youtu.be/pNhJPQvW-pc)
- [TexturePacker](https://www.codeandweb.com/texturepacker)
- [Easy Feedback](https://assetstore.unity.com/packages/tools/integration/easy-feedback-form-81608)
- [Chevy Ray](https://twitter.com/ChevyRay)
- [Stephan Hövelbrinks](https://twitter.com/talecrafter/status/971021795749965824)

## Why would you make a tool?

- Automate something
- Add technical support (debugging, QA, etc.)
- Tweak the engine's default functionality
- Create an interface for designing content

## Unity Editor Attributes

- Use attributes to add quick and dirty utilities to the editor: [Attributes Tutorial](https://unity3d.com/learn/tutorials/topics/scripting/attributes)
- Create a menu item: [Menu Items Tutorial](https://unity3d.com/learn/tutorials/topics/interface-essentials/unity-editor-extensions-menu-items)
- Create an asset for a ScriptableObject type: [ScriptableObjects Tutorial](https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/scriptable-objects)
- Making a field serializable: [Serializable Reference](https://docs.unity3d.com/ScriptReference/Serializable.html)
- Tweak the way fields are exposed to designers: [Range Tutorial](https://unity3d.com/learn/tutorials/topics/tips/show-public-variables-sliders-rangemin-max)

## Unity Editor Extensions

- Assign icons to types in the editor: [Assigning Icons Tutorial](https://docs.unity3d.com/Manual/AssigningIcons.html)
- Extend or replace Unity inspector GUIs: [Building a Custom Inspector Tutorial](https://unity3d.com/learn/tutorials/topics/interface-essentials/building-custom-inspector)
- Change the way a serialized type is displayed across the editor: [Property Drawers Manual](https://docs.unity3d.com/Manual/editor-PropertyDrawers.html)
- Create a custom window for a standalone tool in Unity: [Editor Windows Manual](https://docs.unity3d.com/Manual/editor-EditorWindows.html)