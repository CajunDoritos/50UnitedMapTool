/*
 * Project.cs
 * 
 * Author(s):
 * Hayden Stith (CajunDoritos)
 * 
 * Purpose:
 * This class serves to define the Project object type to define an ATS / ETS2 map project.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _50UnitedMapTool
{
    public class Project
    {
        //Manifest
        public string Location { get; set; }
        public string DisplayName { get; set; }
        public string Version { get; set; }
        public List<string> Categories { get; set; }
        public string IconLocation { get; set; }
        public List<string> CompatibleVersions { get; set; }

        //Sectors
        private List<Vector2> Sectors { get; set; } //Vector2 seems stupid now but might add some handy features in the future

        //Constructor
        public Project(string location, string displayName, string version, List<string> categories, string iconLocation, List<string> compatibleVersions, List<Vector2> sectors)
        {
            Location = location;
            DisplayName = displayName;
            Version = version;
            Categories = categories;
            IconLocation = iconLocation;
            CompatibleVersions = compatibleVersions;
            Sectors = sectors;
        }

        //Return List of Categories in String Array
        public string[] CategoriesToArray()
        {
            return CommonTools.StringListToArray(Categories);
        }

        //Return List of Compatible Versions in String Array
        public string[] CompatibleVersionsToArray()
        {
            return CommonTools.StringListToArray(CompatibleVersions);
        }

        //Return List of Sectors in String Array
        public Vector2[] SectorsToArray()
        {
            return CommonTools.Vector2ListToArray(Sectors);
        }
    }
}
