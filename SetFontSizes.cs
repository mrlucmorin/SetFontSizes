/*
EPLAN P8 script to allow setting the font sizes presented to the user in the
dropdown when editing Text properties.

Created by Luc Morin January 10 2020
http://www.stlm.ca
*/


public class SetFontSizes
{
    [DeclareAction("SetFontSizes")]
    public void SetValues()
    {
        //The Settings object allows us to manipulate EPLAN settings.
        Eplan.EplApi.Base.Settings setting = new Eplan.EplApi.Base.Settings();
				
        //For each index, we set the desired value. 
        //Index 0 is set to value -16002, which means "From layer" and should probably left untouched.
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", -16002, 0);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 1.3, 1);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 1.8, 2);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 2.5, 3);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 3.5, 4);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 5.0, 5);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 7.0, 6);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 10.0, 7);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 14.0, 8);
        setting.SetDoubleSetting("STATION.GedViewer.TextStyle.mm.EN.Heights", 20.0, 9);
    }

    [DeclareMenu]
    public void MenuFunction()
    {

        Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();
        oMenu.AddMenuItem("Set Custom Font Sizes", "SetFontSizes");

    }

}
