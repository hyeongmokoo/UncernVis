using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.UI.DataVisualization.Charting;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.CartoUI;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

using UncernVis.BivariateRenderer;

namespace UncerVisAddin
{
    /// <summary>
    /// Designer class of the dockable window add-in. It contains user interfaces that
    /// make up the dockable window.
    /// </summary>
    public partial class CompositeSymWin : UserControl
    {
        public CompositeSymWin(object hook)
        {
            InitializeComponent();
            this.Hook = hook;

            IActiveView pActiveView = ArcMap.Document.ActiveView;

            for (int i = 0; i < pActiveView.FocusMap.LayerCount; i++)
            {
                cboSourceLayer.Items.Add(pActiveView.FocusMap.get_Layer(i).Name);
            }
        }

        /// <summary>
        /// Host object of the dockable window
        /// </summary>
        private object Hook
        {
            get;
            set;
        }

        /// <summary>
        /// Implementation class of the dockable window add-in. It is responsible for 
        /// creating and disposing the user interface class of the dockable window.
        /// </summary>
        public class AddinImpl : ESRI.ArcGIS.Desktop.AddIns.DockableWindow
        {
            private CompositeSymWin m_windowUI;

            public AddinImpl()
            {
            }

            protected override IntPtr OnCreateChild()
            {
                m_windowUI = new CompositeSymWin(this.Hook);
                return m_windowUI.Handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (m_windowUI != null)
                    m_windowUI.Dispose(disposing);

                base.Dispose(disposing);
            }

        }

        private void cboSourceLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            IActiveView pActiveView = ArcMap.Document.ActiveView;
            clsSnippet pSnippet = new clsSnippet();
            string strLayerName = cboSourceLayer.Text;

            int intLIndex = pSnippet.GetIndexNumberFromLayerName(pActiveView, strLayerName);
            ILayer pLayer = pActiveView.FocusMap.get_Layer(intLIndex);

            IFeatureLayer pFLayer = pLayer as IFeatureLayer;
            ESRI.ArcGIS.Geodatabase.IFeatureClass pFClass = pFLayer.FeatureClass;

            IFields fields = pFClass.Fields;


            cboValueField.Items.Clear();
            cboUField.Items.Clear();

            for (int i = 0; i < fields.FieldCount; i++)
            {
                cboValueField.Items.Add(fields.get_Field(i).Name);
                cboUField.Items.Add(fields.get_Field(i).Name);
            }
        }

        private void chkNewLayer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewLayer.Checked)
                txtNewLayer.Enabled = true;
            else
            {
                txtNewLayer.Text = "";
                txtNewLayer.Enabled = false;
            }
        }

        private void picSymbolColor_Click(object sender, EventArgs e)
        {
            DialogResult DR = cdColor.ShowDialog();
            if (DR == DialogResult.OK)
                picSymbolColor.BackColor = cdColor.Color;
        }

        private void picLineColor_Click(object sender, EventArgs e)
        {
            DialogResult DR = cdColor.ShowDialog();
            if (DR == DialogResult.OK)
                picLineColor.BackColor = cdColor.Color;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Declare variables
            clsSnippet pSnippet = new clsSnippet();
            string strLayerName = cboSourceLayer.Text;
            IActiveView pActiveView = ArcMap.Document.ActiveView;

            int intLIndex = pSnippet.GetIndexNumberFromLayerName(pActiveView, strLayerName);
            ILayer pLayer = pActiveView.FocusMap.get_Layer(intLIndex);

            IFeatureLayer pFLayer = pLayer as IFeatureLayer;
            ESRI.ArcGIS.Geodatabase.IFeatureClass pFClass = pFLayer.FeatureClass;
            //Create Rendering of Mean Value at Target Layer

            //int intBreakeCount = 4;// Set to 4 Classes needs to be changed.1/29/15
            string strOriRenderField = cboValueField.Text;
            string strUncernRenderField = cboUField.Text;
            double dblConLevel = 0;
            if (tcUncer.SelectedIndex == 0)
                dblConLevel = Convert.ToDouble(nudConfidenceLevelCircle.Value) / 100;
            else if (tcUncer.SelectedIndex == 1)
                dblConLevel = Convert.ToDouble(nudConfidenceLevelBar.Value) / 100;

            //Find Fields
            ITable pTable = (ITable)pFClass;
            int intOriIdx = pTable.FindField(strOriRenderField);
            int intUncernIdx = pTable.FindField(strUncernRenderField);

            //Create Geofeature Layer
            IGeoFeatureLayer pGeofeatureLayer = null;
            if (chkNewLayer.Checked == true)
            {
                IFeatureLayer pflOutput = new FeatureLayerClass();
                pflOutput.FeatureClass = pFClass;
                pflOutput.Name = txtNewLayer.Text;
                pflOutput.Visible = true;
                pGeofeatureLayer = (IGeoFeatureLayer)pflOutput;
            }
            else
            {
                pGeofeatureLayer = (IGeoFeatureLayer)pFLayer;
            }

            ////Calculate Confidence interval
            Chart pChart = new Chart();
            double dblConInstance = pChart.DataManipulator.Statistics.InverseNormalDistribution(dblConLevel);


            if (tcUncer.SelectedIndex == 0)
            {
                double dblMinPtSize = Convert.ToDouble(nudSymbolSize.Value);

                //Find Min value 
                //Set to initial value for min
                IField pOriField = pTable.Fields.get_Field(intOriIdx);
                ICursor pCursor = pTable.Search(null, false);
                IDataStatistics pDataStat = new DataStatisticsClass();
                pDataStat.Field = pOriField.Name;
                pDataStat.Cursor = pCursor;
                IStatisticsResults pStatResults = pDataStat.Statistics;
                double dblMinValue = pStatResults.Maximum;
                pCursor.Flush();

                pCursor = pTable.Search(null, false);
                IRow pRow = pCursor.NextRow();
                double dblValue = 0;

                //Cacluate Min and Max value based on the confidence intervals
                //Min
                while (pRow != null)
                {
                    dblValue = Convert.ToDouble(pRow.get_Value(intOriIdx)) - (Convert.ToDouble(pRow.get_Value(intUncernIdx)) * dblConInstance);
                    if (dblValue < dblMinValue)
                        dblMinValue = dblValue;
                    pRow = pCursor.NextRow();
                }

                //Max
                pCursor.Flush();

                double dblMaxValue = 0;
                pCursor = pTable.Search(null, false);
                pRow = pCursor.NextRow();
                dblValue = 0;

                //Cacluate Min and Max value based on the confidence intervals
                while (pRow != null)
                {
                    dblValue = Convert.ToDouble(pRow.get_Value(intOriIdx)) + (Convert.ToDouble(pRow.get_Value(intUncernIdx)) * dblConInstance);
                    if (dblValue > dblMaxValue)
                        dblMaxValue = dblValue;
                    pRow = pCursor.NextRow();
                }


                //To adjust minn value to 1, if the min value is zero
                double dbladjuctMinvalue = 0;
                if (dblMinValue <= 0)
                {
                    dbladjuctMinvalue = (0 - dblMinValue) + 1;
                    dblMinValue = dblMinValue + dbladjuctMinvalue;
                }


                ////Loading uncertainty proportional symbol renderer
                //IDisplay pDisplay = pActiveView.ScreenDisplay;


                //CircleCompositeRenderer pCircleRenderer = new CircleCompositeRenderer();
                //pCircleRenderer.m_dblMinPtSize = dblMinPtSize;
                //pCircleRenderer.m_dblMinValue = dblMinValue;
                //pCircleRenderer.m_dblMaxValue = dblMaxValue;
                //pCircleRenderer.m_dblOutlineSize = Convert.ToDouble(nudLinewidth.Value);
                //pCircleRenderer.m_dblAdjustedMinValue = dbladjuctMinvalue;

                //IRgbColor pSymbolRgb = new RgbColorClass();
                //pSymbolRgb.Red = picSymbolColor.BackColor.R;
                //pSymbolRgb.Green = picSymbolColor.BackColor.G;
                //pSymbolRgb.Blue = picSymbolColor.BackColor.B;

                //IRgbColor pLineRgb = new RgbColorClass();
                //pLineRgb.Red = picLineColor.BackColor.R;
                //pLineRgb.Green = picLineColor.BackColor.G;
                //pLineRgb.Blue = picLineColor.BackColor.B;

                //pCircleRenderer.m_pLineRgb = pLineRgb;
                //pCircleRenderer.m_pSymbolRgb = pSymbolRgb;

                //pCircleRenderer.m_strUncernRenderField = strUncernRenderField;
                //pCircleRenderer.m_strOriRenderField = strOriRenderField;
                //pCircleRenderer.m_pMultiProportion = pGeofeatureLayer.Renderer;
                //pCircleRenderer.m_pGeoFeatureLayer = pGeofeatureLayer;
                //pCircleRenderer.m_dblConInstance = dblConInstance;
                //IQueryFilter pQFilter = new QueryFilter();
                //pCircleRenderer.PrepareFilter(pFClass, pQFilter);

                //IFeatureCursor pFCursor = pFClass.Search(null, false);
                ////Draw Symbol by Features
                //pCircleRenderer.Draw(pFCursor, esriDrawPhase.esriDPGeography, pDisplay, null);

                ////Create Legend
                //pCircleRenderer.CreateLegend();

                //pGeofeatureLayer.Renderer = (IFeatureRenderer)pCircleRenderer;
                //Loading uncertainty proportional symbol renderer
                //IDisplay pDisplay = pActiveView.ScreenDisplay;

                IPropCompositeRenderer pUnProprotional = new PropCompositeRenderer();

                pUnProprotional.m_dblMinPtSize = dblMinPtSize;
                pUnProprotional.m_dblMinValue = dblMinValue;
                pUnProprotional.m_dblMaxValue = dblMaxValue;

                pUnProprotional.m_dblOutlineSize = Convert.ToDouble(nudLinewidth.Value);
                pUnProprotional.m_dblAdjustedMinValue = dbladjuctMinvalue;

                IRgbColor pSymbolRgb = new RgbColorClass();
                pSymbolRgb.Red = picSymbolColor.BackColor.R;
                pSymbolRgb.Green = picSymbolColor.BackColor.G;
                pSymbolRgb.Blue = picSymbolColor.BackColor.B;

                IRgbColor pLineRgb = new RgbColorClass();
                pLineRgb.Red = picLineColor.BackColor.R;
                pLineRgb.Green = picLineColor.BackColor.G;
                pLineRgb.Blue = picLineColor.BackColor.B;

                pUnProprotional.m_pLineRgb = pLineRgb;
                pUnProprotional.m_pSymbolRgb = pSymbolRgb;

                pUnProprotional.m_strUncernRenderField = strUncernRenderField;
                pUnProprotional.m_strOriRenderField = strOriRenderField;

                pUnProprotional.m_dblConInstance = dblConInstance;
                pUnProprotional.m_pGeometryTypes = pFClass.ShapeType;

                //Create Legend
                pUnProprotional.CreateLegend();

                pGeofeatureLayer.Renderer = (IFeatureRenderer)pUnProprotional;

                if (chkNewLayer.Checked == true)
                    pActiveView.FocusMap.AddLayer(pGeofeatureLayer);
                else
                {
                    pFLayer = (IFeatureLayer)pGeofeatureLayer;
                    ArcMap.Document.UpdateContents();
                }

            }
            if (tcUncer.SelectedIndex == 1)
            {
                double dblChartWidth = Convert.ToDouble(nudChartWidth.Value);
                double dblChartSize = Convert.ToDouble(nudChartSize.Value);
                double dblThickness = Convert.ToDouble(nudThickness.Value);

                //Cacluate Max value based on the confidence intervals
                ICursor pCursor = (ICursor)pFClass.Search(null, false);

                IRow pRow = pCursor.NextRow();
                double dblMaxValue = 0;
                double dblTempValue = 0;
                double dblMaxEstimate = 0;
                double dblMaxUncern = 0;
                double dblTempEstimate = 0;
                double dblTempUncern = 0;

                while (pRow != null)
                {
                    dblTempEstimate = Convert.ToDouble(pRow.get_Value(intOriIdx));
                    dblTempUncern = Convert.ToDouble(pRow.get_Value(intUncernIdx)) * dblConInstance;
                    dblTempValue = dblTempEstimate + dblTempUncern;

                    if (dblTempValue > dblMaxValue)
                    {
                        dblMaxValue = dblTempValue;
                        dblMaxEstimate = dblTempEstimate;
                        dblMaxUncern = dblTempUncern;
                    }
                    pRow = pCursor.NextRow();
                }
                pCursor.Flush();

                //IFeatureCursor pFCursor = pGeofeatureLayer.Search(null, true);
                //BarCompositeRenderer pBarRenderer = new BarCompositeRenderer();

                //pBarRenderer.dblError = dblConInstance;
                //pBarRenderer.intValueFldIdx = intOriIdx;
                //pBarRenderer.intUncerFldIdx = intUncernIdx;
                //pBarRenderer.dblMaxValue = dblMaxValue;
                //pBarRenderer.bln3Dfeature = chk3D.Checked;
                //pBarRenderer.m_strOriRenderField = strOriRenderField;
                //pBarRenderer.m_strUncernRenderField = strUncernRenderField;

                //pBarRenderer.dblMaxEstimate = dblMaxEstimate;
                //pBarRenderer.dblMaxUncern = dblMaxUncern;

                //pBarRenderer.m_dblBarWidth = dblChartWidth;
                //pBarRenderer.m_dblBarSize = dblChartSize;
                //pBarRenderer.m_dblThickness = dblThickness;

                //IQueryFilter pQFilter = new QueryFilterClass();
                //pBarRenderer.m_pQueryFilter = pQFilter;

                //pBarRenderer.PrepareFilter(pFClass, pQFilter);
                //pBarRenderer.Draw(pFCursor, esriDrawPhase.esriDPSelection, pActiveView.ScreenDisplay, null);
                //pBarRenderer.CreateLegend();
                //pGeofeatureLayer.Renderer = pBarRenderer;
                ////pGeofeatureLayer.Renderer = pStackedChartRenderer;
                IChartCompositeRenderer pChartCompositeRenderer = new ChartCompositeRenderer();

                pChartCompositeRenderer.m_dblConInstance = dblConInstance;

                pChartCompositeRenderer.m_dblMaxValue = dblMaxValue;
                pChartCompositeRenderer.m_bln3Dfeature = chk3D.Checked;
                pChartCompositeRenderer.m_strOriRenderField = strOriRenderField;
                pChartCompositeRenderer.m_strUncernRenderField = strUncernRenderField;

                pChartCompositeRenderer.m_dblMaxEstimate = dblMaxEstimate;
                pChartCompositeRenderer.m_dblMaxUncern = dblMaxUncern;

                pChartCompositeRenderer.m_dblBarWidth = dblChartWidth;
                pChartCompositeRenderer.m_dblBarSize = dblChartSize;
                pChartCompositeRenderer.m_dblThickness = dblThickness;

                pChartCompositeRenderer.CreateLegend();
                pGeofeatureLayer.Renderer = pChartCompositeRenderer as IFeatureRenderer;
                if (chkNewLayer.Checked == true)
                    pActiveView.FocusMap.AddLayer(pGeofeatureLayer);
                else
                {
                    pFLayer = (IFeatureLayer)pGeofeatureLayer;
                    ArcMap.Document.UpdateContents();
                }
            }
            pActiveView.Refresh();

        }
       
    }
}
