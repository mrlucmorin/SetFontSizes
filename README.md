# SetFontSizes
Set the Font sizes choices in EPLAN

EPLAN P8 offers a pre-defined list of font sizes when working with texts.

For multiple reasons, you may want to modify the list of values that is offered by the dropdown when editing text font size.

The script *SetFontSizes* can be used to set your own list of values that are offered in the dropdown. Be sure to edit it accorsing to your needs. There are 10 font sizes offered by the EPLAN dropdown, so you must set a value for each of the "index" you want to modify.

## Working in different units and languages
The default script assumes an EPLAN installation in metric (mm). For installation in imperial (Inch), the Setting path must be modifed accordingly. For metric installations, the path is *STATION.GedViewer.TextStyle.mm.EN.Heights*, where mm represents the units that were chosen when installing EPLAN **not the units currently used**, as EPLAN allows you to switch units "on the fly".

Also, the script assumes English as the installation language. For other languages, the setting path needs to be modified accordingly. In the default script, the path is *STATION.GedViewer.TextStyle.mm.EN.Heights*, where EN represents the language code for English. 

If you want to use this script in a German environment, you would modify the path to *STATION.GedViewer.TextStyle.mm.DE.Heights*

# ResetFontSizes
This script allows you to reset the list of font sizes to their original values.

The same notes apply for default installtion units, and languages. Edit the script accordingly.
