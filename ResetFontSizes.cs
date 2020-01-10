/*
EPLAN P8 script to reset the font sizes presented to the user in the
dropdown when editing Text properties to their default values.

Created by Luc Morin January 10 2020
http://www.stlm.ca
*/

public class ResetFontSizes
{
    [DeclareAction("ResetFontSizes")]
    public void SetValues()
    {
        //The SettingNode object allows us to manipulate EPLAN settings that are stored a a Node.
        Eplan.EplApi.Base.SettingNode node = new Eplan.EplApi.Base.SettingNode("STATION.GedViewer.TextStyle.mm.EN");
        node.ResetNode();
    }

    [DeclareMenu]
    public void MenuFunction()
    {
        Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();
        oMenu.AddMenuItem("Reset Font Sizes to default value", "ResetFontSizes");
    }

}
