#README

###Title: 5E Roll Template Generator
###Program: RollTemplate.exe
###Author: Cory Schwarting

#####Release Notes:

Rev 1: 
- Initial Release

Rev 2:
- Added Radio box to switch Damage Tab to instead do Healing.  This will trump the Damage and does not require the Spell Damage checkbox to be selected.
- Modified the program so it does not force "selected|" on all character sheet references.  This was done to follow how I tend to create Macro's, and was force of habit. Added a Checkbox to include this functionality if needed.
- Modified the Spell Save when NPC Macro is checked.  Due to the way NPCs work, they don't have proficiency bonus, or spell stats to calculate, as the stat blocks just include a base number.  The change hides the Spellcasting Modifier combobox and label, and changes the label of the Save Modifier to be the absolute value of that Numeric Up-Down box (no calculations).  To accomodate, the upper limits of the box were increased (changed from 10 to 100).
- Modified the Advantage/Disadvantage field to only be written if the Enable Attack check box is checked.  They are paired together, and both should be written if both are used.

Rev 3: 
- Added Revision Notes to ReadMe.txt

Rev 4:
- Fixed issues with Spell Description, Spell Higher Level, Spell Save, and Spell Effect being required to have Spell Info checked.  They are mutually exclusive, and the software was updated to allow this.

Rev 5:
- Fixed Spell Save calculation, it wasn't using the spellcasting modifier, but the actual spellcasting attribute value.

#####About:
I have made a utility for creating Roll Template Macros compatible with the 5th Edition (Community Contributes) Character Sheets. It is a small executable that will allow you to enter in the data to make it look like a roll from the character sheet. Makes quick work when you are trying to create macro's and you want them to look nice.

#####Credits:
I want to thank Ditto8353 for their post on Reddit on 5E Default Roll Template.  It is what has helped me the most in creating this program.  If you are interrested in learning more about it, please see the site here: https://www.reddit.com/r/Roll20/comments/2zx7a1/dd_5e_roll_template/

I also want to thank the artist iconcubic for their Icon files they submitted to iconarchive.com.  I have used the D20 Icon for use on this program.  For more information about the icon, and where do download it, and other dice icons, please see the site here: http://www.iconarchive.com/show/dnd-dice-icons-by-iconcubic/d20-icon.html

#####DETAILS

- Reset Button: Resets all the fields back to default values.

- Generate Button: This will generate the macro and create a Pop- Up window to all you to manually edit any parts of the Macro.  A button is included to allow single click to copy to clipboard for pasting into Roll20.

- Use selected token: This checkbox will add a "selected|" to all references to the character sheet. This is useful if you are making a macro to be used on multiple tokens and character sheets. 

#####Header

- Roll Type: This combo box choses the templates color pallete that matches the character sheet.  Each type has a different color associated with it.  For example, Weapon is Green and Spells are Purple.

- NPC Macro: This checkbox will modify the program slightly by disabling the Proficiency Bonus and Ability Modifier.  The reason it does this is because the Proficiency Bonus is calculated into the NPC's modifier in the Monster Manual, but the 5th Edition (Community Contributes) character sheet only has a proficiency bonus for Player Characters.  It therefore removes those options to try and provide a more consistant macro with unknown additional values.

- Title: This text box is what will appear in big lettering in the Roll Template.  This is typically the weapon/spell being used.

- Sub Headers: These text boxes are the fields immediately below the Title, and the Sub- Header (2) and Sub- Header (2) Right are seperated by a dot in the middle.  These can be used for character/npc names, melee/ranged/spell type, or any other information.

- Emote: This does not appear in the header, but immediately below it inside a dashed line box.  This can be used to state what your character is doing, saying, or what the ability is doing.  I find this a great place to create a Rollable Table of Viscious Mockery Insults, and roll them through the Emote.

#####Attack

- Enable Attack: This check box will enable/disable the use of the Attack information being added to the macro.  This has to be enabled for the Enable Advantage/Disadvantage to be used.

- Enable Advantage/Disadvantage: This check box will enable/disable the use of the Advantage/Disadvantage being used in the macro.  This will be next to the Attack Roll, seperated by a pipe.

- Ability Modifier: This is the players stat to use to add the ability from the character sheet.  This will do a direct reference to the Character Sheet.

- Proficiency Bonus: This checkbox will include the Proficiency Bonus in the Attack Roll.  It will use the Proficiency Bonus listed on the character sheet doing the rolling. Note that NPC sheets don't have a proficiency bonus.

- Modifier: This numeric box will allow you to add or subtract a number from the final value.

- Quick Select: These buttons are used to quickly configure the base requirements for each type of use case.  Melee will enable Attack/Advantage, Damage, Critical, and disable Spell Info, and Saves. Custom fields are NOT cleared.  This will configure for each type, Finesse and Ranged are similar to Melee, but use Dexterity Modifier, NPC will enable the NPC Checkbox, Demo will create a Greatsword Macro as an example, Intelligence, Wisdom, and Charisma will setup Spell Attacks, and Spell Save will configure the macro for a Spell Save.

#####Damage

- Enable Damage: This check box will enable/disable the Damage fields for being used in the macro.  This has to be enabled for the Enable Additional Damage fields to be added as well.

- \# Dice: This is the number of dice to be rolled for damage. The unlabeled combo box next to it has the different standard dice listed that can be rolled (includes D20 although unlikely it will ever be used).

- Ability Modifier: Like the attack roll, this uses the appropriate ability mod from the character sheet.

- Modifier: Like the attack roll, this adds or subtracts a number from your damage.

- Damage Type: This text box will state what the damage being done is.

- Enable Additional Damage: These checkboxes will enable or disable the inclusion of the values in the text boxes.  

- Special: This text box is for the dice rolls (formated as 2d4+2).

- Type: Since Damage/Healing are the same type of rolls, you can switch this page between Damage and Healing.  If Healing is selected, the tab will modify to show you are in Healing mode.  It will display in the Roll Template as Healing.  This does not require the Spell_Damage checkbox to be enabled.

#####Critical Damage

- Enable Critical Damage: This check box will enable/disable the Critical Damage fields for being used in the macro. This has to be enabled for the Enable Additional Damage fields to be added as well.

- \# Dice: This is the number of dice to be rolled for damage. The unlabeled combo box next to it has the different standard dice listed that can be rolled (includes D20 although unlikely it will ever be used).

- Damage Type: This text box will state what the damage being done is.

- Enable Additional Damage: These checkboxes will enable or disable the inclusion of the values in the text boxes.  

- Special: This text box is for the dice rolls (formated as 2d4+2).

#####Spell Info

- Enable Spell Info?: This check box will enable/disable the inclusion of the spell info.  This includes the Class, Cast Time, Duration, Target, Range, and Components.

- Class: This is the class where the spell is from.

- Cast Time: How long it takes for the spell to be cast.

- Duration: How long the spell persists.

- Target: The target of the spell (15 ft. Cone, 1 Target, 3 Creatures you can see, etc.)

- Range: The range of the spell.

- Components: What components are required for the spell.  Vocal and Somatic are checkboxes for inclusion, Material will also add the text in the box below it.

- Spell Details: This will modify how the program writes the macro.  For example, there are two types of damage fields, Melee/Ranged Damage and Spell Damage.  

- Spell Attack: This checkbox will write the Attack Tab to the Spell Attack fields instead of the regular Attack fields. 

- Spell Damage: This checkbox will write the Damage tab to the Spell Damage fields instead of the regular Damage Fields. 

- Spell Critical: This checkbox will write the Critical Damage tab to the Spell Critical fields instead of the regular Critical Damage Fields.

- Spell Save: This checkbox will use the Spellcasting Modifier, Save Modifier, and DC Save Stat sections below to create the Spell Save.

- Spellcasting Modifier: This combo box will be used for calculating the DC.  It will be 8 plus the Spellcasting Modifier from the Character Sheet plus the Proficiency Bonus plus the Save Modifier. If the NPC Macro checkbox is selected, this box will be hidden.

- Save Modifier: This combo box will be used for calculating the DC.  It will be 8 plus the Spellcasting Modifier from the Character Sheet plus the Proficiency Bonus plus the Save Modifier. If the NPC Macro checkbox is selected, it will be labeled as "NPC Save DC", and will be the value solely used for the Save DC (no additional calculations).

- DC Save Stat: The type of save required against the spell.

#####Spell Description

- Spell Description: This checkbox will enable the text box below to to be intered into the Spell Description field.

- Spell Effect: This checkbox will enable the text box below to to be intered into the Spell Effect field.

- Spell Save Success: This checkbox is driven by the Spell Save checkbox in the Spell Info tab.  This will detail what happens if the Spell Save is successful.

- Spell Higher Level: This checkbox will enable the text box below to to be intered into the Spell Higher Level field

#####Custom

- Label: These boxes will the the title of the label on any custom fields.

- Text: These boxes will be the information added with the text box label on the left.

- Custom: This information will be added directly at the end of the macro unedited.  Formatting will need to be done by the user.
