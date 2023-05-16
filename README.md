# ScriptableObjects
 Example of Scriptable objects For Learning

Scriptable Object in Unity is a special type of asset that allows you to create and store custom data or behavior that can be easily reused and shared across multiple parts of your game.

Think of it as a container for variables, settings, or even code that you can create and modify directly within the Unity Editor. Unlike regular scripts that are attached to specific GameObjects, Scriptable Objects are not tied to any particular object and can be accessed and used by multiple scripts and objects.

Scriptable Objects are useful for managing game data, configurations, and even creating custom tools within the Unity Editor. They provide a way to organize and centralize your game's information, making it easier to maintain and modify your game's behavior and content.

/////////////////////////////////////////////////////////////

 In this Project, I create "PlayerData" Scriptable Object

 -It has 3 variables, 
 1)PlayerName 
 2)PlayerLevel
 3)PlayerScore

 Then in order to use this, you can create its instance in any script, Like
 public PlayerData playerData;

 then you can access its properties like
 playerData.playerName

 I create a instance in a script name PlayerController, You can check that out.

 Important Note: To create a scriptable object
 -Create a C# script from project Window by right click, Create-> C# Script

 -Write code in this syntax
[CreateAssetMenu(fileName = "Name", menuName = "ScriptableObject/Name")]

public class Name : ScriptableObject
{
}

Where FileName would be the name of the scriptable Object, and
MenuName is for editor, after seeing this, when you right click in project Window now, and then Create, you will notice that above C# script is ScriptableObject, and on hover on it, you will see "Name", this is the menuName that is set above

menuName = "ScriptableObject/Name"

and when you click on Create->ScriptableObject->Name, it will create a new scriptableObject, on clicking it, you can set its values from inspecter or change its name, and then you can pass it to PlayerController where the instance is declared.

After Running, you can see in console the debug values from class PlayerController.
