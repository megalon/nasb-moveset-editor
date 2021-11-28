# NASB Moveset Editor

![image](https://user-images.githubusercontent.com/27714637/143726563-3632a7b1-657a-4b45-9083-72d235d5ab7e.png)

This is a custom moveset editor for Nickelodeon All-Star Brawl's BulkSerialized file format!

It runs in the Unity Editor using [xNode](https://github.com/Siccity/xNode) and a fork of [NASB_Parser](https://github.com/sc2ad/NASB_Parser).

# 🚀 Installation

## 1. Setup Unity 2020.3.15f2
Download and install `Unity 2020.3.15f2`

The simplest way to do this is through [Unity Hub.](https://unity3d.com/get-unity/download)

Once installed, create a new 3D Unity project using `Unity 2020.3.15f2`

## 2. Import xNode

Open the file `Packages/manifest.json` in a text editor, and add the line below at the top of the dependencies list

```
"com.github.siccity.xnode": "https://github.com/siccity/xNode.git",
```
Save the file, then go back to the Unity window. It should start downloading xNode.

## 3. Import NASB Moveset Editor

Download the file `NASB_Moveset_Editor_{VERSION}.unitypackage` from the [releases page here.](https://github.com/megalon/nasb-moveset-editor/releases/latest) 

Simply drag this file into your Unity project to import the package.

It will ask you what you want to import. Make sure to import everything!

## 4. Open the editor panel
In Unity, open the NASB Moveset Editor control panel from the top menu bar `NASB -> NASB Moveset Editor`.

You can dock this window inside unity by dragging the tab.

# ℹ Usage

Nickelodeon All-Star Brawl stores moveset data in text files using a custom format, known as **BulkSerialized**.

The NASB Moveset Editor can read these BulkSerialized files, and split them apart so that each `IdState` gets it's own Moveset Graph.

**In general, each Moveset Graph is it's own "move" in the moveset!**

## Import TextAsset

First you need a `BulkSerialized` text file.

You can extract these files from within the game using a tool like [Asset Studio.](https://github.com/Perfare/AssetStudio)

*These may change with each update, so make sure you have the latest files!*

The movesets for characters are typically named by their ID. For example, `char_rival.txt` for Helga. You can tell if you have a correct file if you open it in a text editor, and it starts with `BulkSerialize` followed by a bunch of numbers on each line.

![Example BulkSerialized file](https://user-images.githubusercontent.com/27714637/143726738-68d888c8-3fc7-4d78-b1df-c389549f3cef.png)

**Once you have a BulkSerialized file**

Click the `Import TextAsset` button in the NASB Moveset Editor window to import the BulkSerialized text file.

This will create a folder at the path `Assets/Editor/Moveset Graphs/{filename}`. Here you can find the Moveset Graphs for this moveset.

Double click on one of these files in the Unity Inspector to open it in the NASB Moveset Editor!

![Example folder structure in Unity Editor](https://user-images.githubusercontent.com/27714637/143726775-bb8d0924-0219-4f91-8192-359565123d36.png)

Notice how some things seem to be missing. What about idle? Falling? EdgeGrab?

These are contained within the `characterBase.txt` BulkSerialized file. Each character overrides these moves, but only if they need to.

Import that file if you want to see all of the base moves that each character can overwrite. There's over 200!

## Create New Moveset Graph

You can create a nearly blank moveset graph by clicking the "Create New Moveset Graph" button.

This will open a new window requesting some basic information about the graph!

![image](https://user-images.githubusercontent.com/27714637/143726851-c9759969-e54c-4a43-a1f9-c1e0bef72e9e.png)

Click "Create Moveset Graph" and it will open the graph in the editor.

You probably want to copy and paste from an existing move in a different moveset to get started.

## Export TextAsset

Select the moveset you want to export from the dropdown, then click on the Export TextAsset button.

![image](https://user-images.githubusercontent.com/27714637/143726984-7260cf87-b51e-4fe4-9d7a-3744353e7836.png)

This will convert the collection of graphs in the selected folder back into a BulkSerialized text file for you to use in the game.

# Controls

| Keybind | Action |
|----|----|
| Left Click | Select nodes. Click on a "port" and drag it to another port to connect two nodes. Right click while dragging to create a re-route point. |
| Right Click | Context Menu. Right click in empty space within the editor to add a new node from the drop-down menu. |
| Middle Click | Move the viewport in the editor window. |
| Right Click + Drag | Alternative to Middle Click. Move the viewport in the editor window. |
| Scroll Wheel | Zoom. You can define the min / max zoom level in the Preferences. |  
| F | Focus selected. If no node is selected, it returns the viewport to (0, 0) |
| A | Select all |
| CTRL + Z | Undo (This uses Unity's undo system) |
| CTRL + Y | Redo (This uses Unity's undo system) |

# Credits

[NASB_Parser by sc2ad](https://github.com/sc2ad/NASB_Parser)

[xNode by Siccity](https://github.com/Siccity/xNode)

[NASB_Parser_to_xNode by megalon](https://github.com/megalon/NASB_Parser_to_xNode)
