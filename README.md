# NASB Moveset Editor

This is a custom moveset editor for Nickelodeon All-Star Brawl's BulkSerialized file format.

It runs in the Unity Editor using [xNode](https://github.com/Siccity/xNode) and a fork of [NASB_Parser](https://github.com/sc2ad/NASB_Parser).

# Installation

## Step 1 Setup Unity 2020.3.15f2
Download and install `Unity 2020.3.15f2`

The simplest way to do this is through [Unity Hub.](https://unity3d.com/get-unity/download)

## Step 2 Import Packages
Create a new 3D Unity project using `Unity 2020.3.15f2`

Once created, open the file `Packages/manifest.json` in a text editor, and add the two lines below at the top of the dependencies list

```
"com.github.siccity.xnode": "https://github.com/siccity/xNode.git",
"com.github.megalon.nasb-moveset-editor": "https://github.com/megalon/nasb-moveset-editor",
```
Save the file, then when go back to the Unity window. It should start downloading the packages.

## Step 3 Open the editor panel
In Unity, open the NASB Moveset Editor control panel from the top menu bar `NASB -> NASB Moveset Editor`.

You can dock this window inside unity by dragging the tab.

# Usage

Nickelodeon All-Star Brawl stores moveset data in text files using a custom format, known as **BulkSerialized**.

The NASB Moveset Editor can read these BulkSerialized files, and split them apart so that each `IdState` gets it's own Moveset Graph.

**In general, each Moveset Graph is it's own "move" in the moveset!**

## Import TextAsset

First you need a `BulkSerialized` text file.

You can extract these files from within the game using a tool like [Asset Studio](https://github.com/Perfare/AssetStudio)

The movesets for characters are typically named by their ID. For example, `char_rival.txt` for Helga. You can tell if you have a correct file if you open it in a text editor, and it starts with `BulkSerialize` followed by a bunch of numbers on each line.

**Once you have a BulkSerialized file**

Click the `Import TextAsset` button to import the BulkSerialized text file.

This will create a folder at the path `Assets/Editor/Moveset Graphs/{filename}` Here you can find the Moveset Graphs for this moveset.

Double click on one of these files in the Unity Inspector to open it in the NASB Moveset Editor!

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

## Credits

[NASB_Parser by sc2ad](https://github.com/sc2ad/NASB_Parser)

[xNode by Siccity](https://github.com/Siccity/xNode)

[NASB_Parser_to_xNode by megalon](https://github.com/megalon/NASB_Parser_to_xNode)
