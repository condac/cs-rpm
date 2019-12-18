// Realistic Power Mod RPM By condac
// RPM Mod
// Thanks to Japa_, nlight, 
using ICities;
using UnityEngine;
using System;
using System.IO;
using System.Reflection;
using ColossalFramework;
using ColossalFramework.DataBinding;
using ColossalFramework.Globalization;


namespace RPMmod {


    public class RPMMod : IUserMod    {

        public string Name        {
            get { return "Realistic Power Mod"; }
        }

        public string Description        {
            get { return "More realistic power plant productions v0.4"; }
        }
    }

    // Inherit interfaces and implement your mod logic here
    // You can use as many files and subfolders as you wish to organise your code, as long
    // as it remains located under the Source folder.
    public class LoadingExtension : LoadingExtensionBase    {
        public override void OnLevelLoaded(LoadMode mode)        {
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "RPMod v0.4");

            BuildingCollection[] buildingCollections = UnityEngine.Object.FindObjectsOfType<BuildingCollection>();
            foreach (BuildingCollection buildingCollection in buildingCollections)            {
                foreach (BuildingInfo bInfo in buildingCollection.m_prefabs)                {
                    //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"RoadSlopes.csv", true))
                    //{
                    //    file.WriteLine(netInfo.name+ "," + netInfo.m_class.name + "," + netInfo.m_maxSlope);
                    //}
                    //DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, bInfo.m_class.name);
                    switch (bInfo.m_class.name)                    {
                        case "Electricity Facility":
                            //DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, bInfo.m_buildingAI.name);
                            //bInfo.m_buildingAI.name;
                            switch (bInfo.m_buildingAI.name)                            {
                                case "Nuclear Power Plant":
                                    PowerPlantAI plantAI = (PowerPlantAI)bInfo.m_buildingAI;
                                    plantAI.m_electricityProduction = 46875;
                                    break;
                                case "Solar Power Plant":
                                    plantAI = (PowerPlantAI)bInfo.m_buildingAI;
                                    plantAI.m_electricityProduction = 3438;
                                    break;
                                case "Coal Power Plant":
                                    plantAI = (PowerPlantAI)bInfo.m_buildingAI;
                                    plantAI.m_electricityProduction = 12500;
                                    plantAI.m_pollutionAccumulation = 100; //50 default
                                    plantAI.m_pollutionRadius = 200; //100 default
                                    break;
                                case "Oil Power Plant":
                                    plantAI = (PowerPlantAI)bInfo.m_buildingAI;
                                    plantAI.m_electricityProduction = 15625;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Electricity Wind Turbine":
                            //DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, bInfo.m_buildingAI.name);
                            //bInfo.m_buildingAI.name;
                            switch (bInfo.m_buildingAI.name)                            {
                                case "Wind Turbine":
                                    PowerPlantAI plantAI = (PowerPlantAI)bInfo.m_buildingAI;
                                    plantAI.m_electricityProduction = 125;
                                    plantAI.m_maintenanceCost = 50; // 500 default
                                    //DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Wind:"+plantAI.m_electricityProduction);
                                    break;
                                case "Advanced Wind Turbine":
                                    plantAI = (PowerPlantAI)bInfo.m_buildingAI;
                                    plantAI.m_electricityProduction = 625;
                                    plantAI.m_maintenanceCost = 125; // 1250 default
                                    //DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Wind:"+plantAI.m_electricityProduction);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            base.OnLevelLoaded(mode);
        }
    }

    /*
    //Variable Wind power
    public class MyIThreadingExtensionBase : ThreadingExtensionBase    {
        public int variableWind = 10;
        public int variableWindAdvanced = 10;
        public float turbineMW = 4;
        public float advancedMW = 10;
        public float convFactor = 62.5f;
        public int minMW = (int)(1 * 62.5);
        public int minAdvancedMW = (int)(4 * 62.5);
        public float changeSpeed = 0.1f;
        //Thread: Main
        
        public override void OnAfterSimulationTick()        {
            

            WindManager wind = UnityEngine.Object.FindObjectOfType<WindManager>();
            variableWind         = (int)(Mathf.Sin( wind.m_windDirection * changeSpeed) * turbineMW * convFactor);
            variableWindAdvanced = (int)(Mathf.Cos(wind.m_windDirection * changeSpeed) * advancedMW * convFactor);
            variableWind = Mathf.Abs(variableWind);
            variableWindAdvanced = Mathf.Abs(variableWindAdvanced);

            if (variableWind < minMW)    {
                variableWind = minMW;
            }
            if (variableWindAdvanced < minAdvancedMW)    {
                variableWindAdvanced = minAdvancedMW;
            }
            BuildingCollection[] buildingCollections = UnityEngine.Object.FindObjectsOfType<BuildingCollection>();
            foreach (BuildingCollection buildingCollection in buildingCollections)  {
                foreach (BuildingInfo bInfo in buildingCollection.m_prefabs)   {
                    switch (bInfo.m_class.name)     {
                        
                        case "Electricity Wind Turbine":
                            switch (bInfo.m_buildingAI.name)   {
                                case "Wind Turbine":
                                    PowerPlantAI plantAI = (PowerPlantAI)bInfo.m_buildingAI;
                                    plantAI.m_electricityProduction = variableWind;
                                    break;
                                case "Advanced Wind Turbine":
                                    plantAI = (PowerPlantAI)bInfo.m_buildingAI;
                                    plantAI.m_electricityProduction = variableWindAdvanced;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
       
    }*/
}