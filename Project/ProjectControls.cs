/*
 * ProjectControls.cs
 * 
 * Authors:
 * Hayden Stith (CajunDoritos)
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _50UnitedMapTool
{
    class ProjectControls
    {
        // Project Open, and Save functions
        public static Project openProject(string location)
        {
            //Declare Manifest values (null as placeholder for program compile)
            string displayName = null;
            string version = null;
            List<string> categories = null;
            string iconLocation = null;

            //Check if manifest.sii exists
            if (File.Exists(location + @"\manifest.sii")) { 
            
            } else
            {
                displayName = null;
                version = null;
                categories = null;
                iconLocation = null;
            }

            //Placeholder
            List<string> compat = new List<string>();
            compat.Add("1.37");

            //Placeholder
            List<Vector2> sectors = new List<Vector2>();
            sectors.Add(new Vector2(0001, -0001));

            //Placeholder for program compile but probably going to stay
            return new Project(location, displayName, version, categories, iconLocation, compat, sectors);
        }


    }
}
