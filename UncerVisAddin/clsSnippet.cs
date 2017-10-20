using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace UncerVisAddin
{
    class clsSnippet
    {
        public System.Int32 GetIndexNumberFromLayerName(ESRI.ArcGIS.Carto.IActiveView activeView, System.String layerName)
        {

            if (activeView == null || layerName == null)
            {
                return -1;
            }
            ESRI.ArcGIS.Carto.IMap map = activeView.FocusMap;

            // Get the number of layers
            int numberOfLayers = map.LayerCount;

            // Loop through the layers and get the correct layer index
            for (System.Int32 i = 0; i < numberOfLayers; i++)
            {
                if (layerName == map.get_Layer(i).Name)
                {

                    // Layer was found
                    return i;
                }
            }

            // No layer was found
            return -1;

        }

        public string FilePathinRfromLayer(ESRI.ArcGIS.Carto.IFeatureLayer pFLayer)
        {
            ESRI.ArcGIS.Geodatabase.IDataset dataset = (ESRI.ArcGIS.Geodatabase.IDataset)(pFLayer);
            string strfullname = dataset.Workspace.PathName + "\\" + dataset.BrowseName;
            if (dataset.Category == "Shapefile Feature Class")
                strfullname = strfullname + ".shp";
            string strNameR = strfullname.Replace(@"\", @"\\");
            return strNameR;
        }
        public ESRI.ArcGIS.Display.IRgbColor getRGB(int R, int G, int B)
        {
            IRgbColor pRgbColor = new RgbColorClass();
            pRgbColor.Red = R;
            pRgbColor.Green = G;
            pRgbColor.Blue = B;

            return pRgbColor;

        }
        public ESRI.ArcGIS.Geometry.IEnvelope DrawRectangle(ESRI.ArcGIS.Carto.IActiveView activeView)
        {

            if (activeView == null)
            {
                return null;
            }
            else
            {

                ESRI.ArcGIS.Display.IScreenDisplay screenDisplay = activeView.ScreenDisplay;

                // Constant
                screenDisplay.StartDrawing(screenDisplay.hDC, (System.Int16)ESRI.ArcGIS.Display.esriScreenCache.esriNoScreenCache); // Explicit Cast
                //ESRI.ArcGIS.Display.IRgbColor rgbColor = new ESRI.ArcGIS.Display.RgbColorClass();
                //rgbColor.Red = 255;

                //ESRI.ArcGIS.Display.IColor color = rgbColor; // Implicit Cast
                ESRI.ArcGIS.Display.ISimpleFillSymbol simpleFillSymbol = new ESRI.ArcGIS.Display.SimpleFillSymbolClass();
                //simpleFillSymbol.Color = color;
                simpleFillSymbol.Style = esriSimpleFillStyle.esriSFSHollow;

                ESRI.ArcGIS.Display.ISymbol symbol = simpleFillSymbol as ESRI.ArcGIS.Display.ISymbol; // Dynamic Cast
                ESRI.ArcGIS.Display.IRubberBand rubberBand = new ESRI.ArcGIS.Display.RubberEnvelopeClass();
                ESRI.ArcGIS.Geometry.IGeometry geometry = rubberBand.TrackNew(screenDisplay, symbol);
                screenDisplay.SetSymbol(symbol);
                ESRI.ArcGIS.Geometry.IEnvelope pEnvelope = geometry as ESRI.ArcGIS.Geometry.IEnvelope;
                screenDisplay.DrawRectangle(pEnvelope); // Dynamic Cast
                screenDisplay.FinishDrawing();

                return pEnvelope;
            }
        }
        public void ClearSelectedMapFeatures(ESRI.ArcGIS.Carto.IActiveView activeView, ESRI.ArcGIS.Carto.IFeatureLayer featureLayer) //dhncho 01.10
        {
            if (activeView == null || featureLayer == null)
            {
                return;
            }
            ESRI.ArcGIS.Carto.IFeatureSelection featureSelection = featureLayer as ESRI.ArcGIS.Carto.IFeatureSelection; // Dynamic Cast

            // Invalidate only the selection cache. Flag the original selection
            activeView.PartialRefresh(ESRI.ArcGIS.Carto.esriViewDrawPhase.esriViewGeoSelection, null, null);

            // Clear the selection
            featureSelection.Clear();

            // Flag the new selection
            activeView.PartialRefresh(ESRI.ArcGIS.Carto.esriViewDrawPhase.esriViewGeoSelection, null, null);
        }
        public IFeatureCursor FeatureCursorFromSelection(IFeatureLayer pFLayer, bool blnUseSelected)
        {
            IFeatureCursor pFCursor = null;
            IFeatureSelection pFeatureSelection = pFLayer as IFeatureSelection;
            int intNFeatureCount = pFeatureSelection.SelectionSet.Count;
            if (intNFeatureCount > 0 && blnUseSelected == true)
            {
                ICursor pCursor = null;

                pFeatureSelection.SelectionSet.Search(null, true, out pCursor);
                pFCursor = (IFeatureCursor)pCursor;

            }
            else if (intNFeatureCount == 0 && blnUseSelected == true)
            {
                MessageBox.Show("Select at least one feature");

            }
            else
            {
                pFCursor = pFLayer.Search(null, true);
                intNFeatureCount = pFLayer.FeatureClass.FeatureCount(null);
            }
            return pFCursor;
        }

    }
}
