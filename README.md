# Pixeltheory Base
Base library package for use with Unity projects. Includes logging, worker thread exception, and inter-scene data management tools and classes.
###
### Installation
Pick a protocol to use for downloading the package. SSH if you have already uploaded a public key to Github, and can use SSH to access repositories. HTTPS if you would rather "Login with Github" in your browsewr rather than upload a public key.

Copy one of the below links, depending on which protocol you have chosen:
* SSH : 
ssh://git@github.<area>com/pixeltheorygames/pixeltheory-unity-base.git?path=/unity/pixeltheory-unity-base/Packages/com.pixeltheory.base
* HTTPS : https:/<area>/github.com/pixeltheorygames/pixeltheory-unity-base.git?path=/unity/pixeltheory-unity-base/Packages/com.pixeltheory.base

Open up the PackageManager in the Unity Editor.
![OpenPackageManagerUnityEditor.png](github%2FREADME_Images%2FOpenPackageManagerUnityEditor.png)

Add the link you selected above to the PackageManager.
![AddGitURLPackageManagerUnityEditor.png](github%2FREADME_Images%2FAddGitURLPackageManagerUnityEditor.png)

The package should now be added and available to use in your Unity project.
###
### Usage
#### PixelObject
Inherits from ScriptableObject. Used for asset oriented components further down the packages pipeline (i.e. PixelSocket). As of know, the base PixelObject class is empty, but marked as reserved for future use, in the case we need to have some object maintenance code at the base level.
###
#### PixelBehaviour
Inherits from MonoBehaviour. Abstract class. Has generic constraints that require the self type (TypeSelf) for single instance use-cases, as well as a TypeData constraint that is used by the Blackboard class. TypeData should be the type of whatever class inherits from PixelObject and is being used for runtime data purposes. See Blackboard usage for more information on runtime data management. 
###
#### PixelLog
Static logging class. Only logs to console when in the UNITY_EDITOR or in DEVELOPMENT_BUILD mode.
###
#### Blackboard
Blackboard inherits from PixelObject, and is a wrapper class for a user defined runtime data class. The user defined data class must also inherit from PixelObject. The Blackboard's sole purpose is to check to see if another runtime data object has been loaded into memory. If so, to throw away the data object set inside the fields of the Blackboard object instance, and use the in-memory "shared" data. If there is no data already loaded into memory, then the Blackboard will take it's local data object, and elevate it to global "shared". Another way to think about it is that Blackboard objects, which are assets, and set on PixelBehaviour Inspector fields, on scene load will check to see if a Blackboard in a previous scene has already designated a data object as the current and source-of-truth data, and use that instead of the local data object set in the Blackboard fields. This means that starting a game from the first scene ensures that the data passed around from scene to scene is the same data object, but also allows developers to set a "debug" data object to be used in just a singel scene.
###
### Known Issues
1. Worker thread exception catching only works (and is only needed) on iOS. Also it currently does not work.
2. Unit Tests are incomplete.
###
### To-do List
1. Finish WIP exception catching mechanism.
2. Finish implementing rest of Unit Tests.
3. Clean up repository and project files.
