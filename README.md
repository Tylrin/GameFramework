# GameFramework
![GameFramework Logo](/Resources/ProjectDesign/Export/GameFramework_SocialPreview.png)
The GameFramework is a layer on top of Unreal Engines Gameplay Framework. It includes destinct game states and functionalities for logo movies, start- and main menus, scalability settings, loading screens and save games.
## Project Philosophy 
The main goal is to create a complete game framework that is both versatile and simple. The driving philosophy of the project is to be as engine agnostic as possible. That mean relying heavely on the build-in engine codebase and not implementing any online services to guarantee the highest longevity and best platform compatibility. The game framework is best used for single player titles.
## Q&A
Whats being worked on?
- To see what I am working on look at the project tap and kanban cards.

Why does localization doesn't work for me?
- Changing localization at runtime only works in standalone games or packaged projects not in PIE. Settings that dirty the user settings also only properly work in packaged projects.

For what platforms is this framework?
- The priority for the project is PC but nothing strictly limits it to the PC or just keyboard and mouse. Also other platforms require extra setup and SDK's that are not included in the repo.

Where can I find platform specific SDK's?
- [Platform SDKs](/Resources/Documentation/PlatformInfo.md)
## Work in Progress
This project is very much work in progress and is not finished. Not all features that are listed in the description of the repository are included but they are planned to be added or are currently in development.

## Sources
- [Unreal Engine Branding](https://www.unrealengine.com/en-US/branding)
## License & Contribution
**Source code** of the plugin is licensed under MIT license, and other developers are encouraged to fork the repository, open issues & pull requests to help the development.