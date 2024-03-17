﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Symbology;

namespace Working_with_DotSpatial_Symbology_and_Attribute_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.AddLayers();
        }

        private void mapOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvAttributeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.Layers.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this application?", "Admin", MessageBoxButtons.OKCancel) ==
DialogResult.OK)
            {
                //Close() method is used to close the application. 
                this.Close();
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomOut();
        }

        private void zoomExtentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomToMaxExtent();
        }

        private void btnDisplayStateName_Click(object sender, EventArgs e)
        {
            if (Map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    IFeatureLayerExtensions.AddLabels(stateLayer, "[STATE_NAME]", new Font("Tahoma", (float)8.0), Color.Black);
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnFilterByStateName_Click(object sender, EventArgs e)
        {
            //Check the number of layers from MapControl 
            if (Map1.Layers.Count > 0)
            {
                //Declare a MapPolygonLayer 
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                //TypeCast the first layer from MapControl to MapPolygonLayer. 
                //Layers are 0 based, therefore 0 is going to grab the first layer from the MapControl 
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                //Check whether stateLayer is polygon layer or not 
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //SelectByAttribute method is used to implement the filter operations. 
                    //In this example, STATE_NAME is used implement the filter operation 
                    //We can see the IdhoSate on the map 
                    stateLayer.SelectByAttribute("[STATE_NAME] = 'Idaho'");
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnFilterByPopState_Click(object sender, EventArgs e)
        {
            //check the number of layers from map control 

            if (Map1.Layers.Count > 0)
            {
                //Delacre a MapPolygonLayer 
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                //Type cast the FirstLayer of MapControl to MapPolygonLayer 
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                //Check the MapPolygonLayer ( Make sure that it has a polygon layer) 
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");

                }
                else
                {
                    //!!!-------------------- this line is necessary otherwise the code doesn't work----------------------
                    //this will load the attribute table of the layer into memory. 
                    stateLayer.DataSet.FillAttributes();

                    //Create a new PolygonScheme 
                    PolygonScheme scheme = new PolygonScheme();

                    //Create a new PolygonCategory 
                    PolygonCategory category = new PolygonCategory(Color.Yellow, Color.Red, 1);

                    //Declare a filter string 
                    //[POP1990],[STATE_NAME] are attributes from the attribute table of the given shape file. 

                    string filter = "[POP1990] > 10000000 OR [STATE_NAME] = 'Idaho'";

                    //Set/Assign the filter expression to PolygonCategory 
                    category.FilterExpression = filter;

                    //Set the Legend Text 
                    category.LegendText = "population > 10 Million";

                    //Add the PolygonCategory in to the PolygonScheme 
                    scheme.AddCategory(category);

                    //Set the scheme in to the MapPolygonLayer's symbology 
                    stateLayer.Symbology = scheme;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }
        private void btnRandomColors_Click(object sender, EventArgs e)
        {
            //check the number of layers from map control 
            if (Map1.Layers.Count > 0)
            {
                //Delacre a MapPolygonLayer 
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                //Type cast the FirstLayer of MapControl to MapPolygonLayer 
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                //Check the MapPolygonLayer ( Make sure that it has a polygon layer) 
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Create a new PolygonScheme 
                    PolygonScheme scheme = new PolygonScheme();

                    //Set the ClassificationType for the PolygonScheme via EditorSettings 
                    scheme.EditorSettings.ClassificationType = ClassificationType.UniqueValues;

                    //Set the UniqueValue field name 
                    //Here STATE_NAME would be the Unique value field 
                    scheme.EditorSettings.FieldName = "STATE_NAME";

                    //create categories on the scheme based on the attributes table and field name 
                    //In this case field name is STATE_NAME 
                    scheme.CreateCategories(stateLayer.DataSet.DataTable);

                    //Set the scheme to stateLayer's symbology 
                    stateLayer.Symbology = scheme;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }

        }
        /// <summary> 
        /// This method is used filter the attribute table of the shapefile based on the population in 1990. 
        /// </summary> 
        /// <param name="population">Amount of population in 1990</param> 
        /// <remarks>No return value</remarks> 
        private void filterbyPopulation(int population)
        {
            if (Map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //!!! this line is necessary otherwise the code doesn't work 
                    //this will load the attribute table of the layer into memory. 
                    stateLayer.DataSet.FillAttributes();
                    PolygonScheme scheme = new PolygonScheme();

                    PolygonCategory category = new PolygonCategory(Color.Yellow, Color.Red, 1);

                    string filter = "[POP1990] < " + population + "";

                    category.FilterExpression = filter;

                    category.LegendText = "population < " + population.ToString();

                    scheme.AddCategory(category);

                    stateLayer.Symbology = scheme;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }
        private void btnFilterByPopulation_Click(object sender, EventArgs e)
        {
            double number;
            //Validating the textbox input. 
            if (string.IsNullOrEmpty(txtPopulation.Text) || !double.TryParse(txtPopulation.Text, out number))
            {
                MessageBox.Show("Please enter a valid value", "Admin", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtPopulation.Text = "";
            }
            else
            {
                //Call the filterbyPopulation method. 
                //We need to pass an interger intput paramter, 
                // Therefore, I just implemented integer typecasting. 
                filterbyPopulation(Convert.ToInt32(txtPopulation.Text.ToString()));
            }
        }

        private void btnViewAttributes_Click(object sender, EventArgs e)
        {
            //Declare a datatable 
            DataTable dt = null;

            if (Map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Get the shapefile's attribute table to our datatable dt 
                    dt = stateLayer.DataSet.DataTable;
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void dgvAttributeTable_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAttributeTable.SelectedRows)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                if (stateLayer == null)
                { MessageBox.Show("The layer is not a polygon layer."); }
                else
                {
                    stateLayer.SelectByAttribute("[STATE_NAME] =" + "'" + row.Cells["STATE_NAME"].Value + "'");
                }
            }
        }
    }
}
