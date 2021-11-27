# NASB Moveset Editor

This is a custom moveset editor for Nickelodeon All-Star Brawl's BulkSerialized file format.

It runs in the Unity Editor using [xNode](https://github.com/Siccity/xNode) and a fork of [NASB_Parser](https://github.com/sc2ad/NASB_Parser).

# Installation

## Step 1 Setup Unity 2020.3.15f2
Download and install `Unity 2020.3.15f2`

The simplest way to do this is through [Unity Hub.](https://unity3d.com/get-unity/download)

## Step 2 Import xNode
Create a new 3D Unity project using `Unity 2020.3.15f2`

Once created, copy and paste the line below into the your `manifest.json` in `Packages/manifest.json` to add xNode to the list of dependencies.

`"com.github.siccity.xnode": "https://github.com/siccity/xNode.git"`

It should prompt you to import xNode. Make sure everything is checked, and import it.

## Step 3 Import the NASB Moveset Editor
Create a folder named `Editor` inside your Assets folder

Import the files from this github repo into this `Editor` folder.

## Step 4 Open the editor panel
Open the NASB Moveset Editor control panel from the menu bar `NASB -> NASB Moveset Editor`.

You can dock this window inside unity by dragging the tab.

# Usage

Nickelodeon All-Star Brawl stores moveset data in text files using a custom format, known as **BulkSerialized**.

The NASB Moveset Editor can read these BulkSerialized files, and split them apart so that each `IdState` gets it's own Moveset Graph.

In general, each Moveset Graph is it's own "move" in the moveset!

## Import TextAsset

First you need a `BulkSerialized` text file.

You can extract these files from within the game using a tool like [Asset Studio](https://github.com/Perfare/AssetStudio)

You can tell if you have a correct file if you open it in a text editor, and it starts with `BulkSerialize` followed by a bunch of numbers on each line.

The movesets for characters are typically named by their ID. For example, `char_rival.txt` for Helga.

**Once you have a BulkSerialized file**

Click the `Import TextAsset` button to import the BulkSerialized text file.

This will create a folder at the path `Assets/Editor/Moveset Graphs/{filename}`

Here you can find the Moveset Graphs for this moveset.

Double click on one of these files in the Unity Inspector to open it in the NASB Moveset Editor!


## Credits

[NASB_Parser by sc2ad](https://github.com/sc2ad/NASB_Parser)

[xNode by Siccity](https://github.com/Siccity/xNode)

[NASB_Parser_to_xNode by megalon](https://github.com/megalon/NASB_Parser_to_xNode)
