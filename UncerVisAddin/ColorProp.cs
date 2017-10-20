using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;

namespace UncerVisAddin
{
    public class ColorProp : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public ColorProp()
        {
        }

        protected override void OnClick()
        {

            UID dockWinID = new UIDClass();
            dockWinID.Value = ThisAddIn.IDs.ColPropWin;

            IDockableWindow dockWindow = ArcMap.DockableWindowManager.GetDockableWindow(dockWinID);

            if (dockWindow == null)
                return;

            dockWindow.Show(!dockWindow.IsVisible());
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
