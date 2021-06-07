# Monster Merger for Sins

Monster Merger is made for a roleplaying game called Sins, and can save data for creatures, humans, and modifications, and merge them together to output the combined stats of a monster and the modifications applied to it.

## Files
Monster merger saves files as .json files, in a folder called Data. here, it is split between modifiers and monsters. Files are saved when the program is closed, and loaded when the program opens. The buttons on the main menu can mimic this behaviour for realtime saving and loading.

NOTE: The state of objects in memory is only saved by closing the program normally or by using the button on the main menu!

## Create
The create option in the menu opens the create menu from which a new object can be made. The Name and Category can be used for managing objects in large quantities. Once saved, the create menu will be closed and the object is stored to memory.

## Modify
Modify opens a list of all loaded objects in memory and displays them in alphabetical order. From here, it gives the option to open the object in the editor again, or delete it entirely

## Merge
The Merge menu allows one monster to be selected from memory, and then allows modifiers to be applied to the monster in order. Final layer allows any final adjustments to be made by opening it in the editor, but can never be saved to memory as a stand alone modifier.

When finished, click on Full View or Simplified View to perform all calculations and spit out the stats meant to be saved to a sheet. The Recalculation options recalculate Vitality and Focus from main stat before calculating the modifiers for them, so they are accurate.

### Presets
Presets allow you to save common or favorite builds. Presets are saved inside the monster's file, and DO NOT save the actual stats. if a modifier or the monster is altered, the final outcome of the preset is altered aswell, and any modifiers that are missing are removed from the preset completely!