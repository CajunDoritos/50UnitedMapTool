/*
 * frmMain.cs
 * 
 * Authors:
 * Hayden Stith (CajunDoritos)
 * 
 * Notes:
 * I did this in a weekend so get off my back.
 * Needs complete rewrite in the future but I'm too lazy to do that now.
 * 
 * Known Problems:
 * Loading a new project doesn't close the old one properly, 
 * would be fixed by writing a close project method (would've happened if I didn't do this in 2 days and didn't do any planning).
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _50UnitedMapTool
{
    public partial class frmMain : Form
    {

        public static string projectDir;
        public static string atsBaseDir;

        //manifest.sii
        public static string packageVersion = "";
        public static string displayName = "";
        public static string author = "";
        public static string categories = "";
        public static string icon = "mod_icon.jpg";
        public static string iconLocation;

        //description.txt
        public static string descriptionLocation;
        public static string descriptionFileName = "description.txt";
        public static string description;

        //sectors.fumt
        public static List<string> sectors = new List<string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdOpenProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                openNewProject(fbdOpenProject.SelectedPath);
            }
            else
            {
                MessageBox.Show("Failed to Open Path", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pullToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Load Project Directory
            if(Properties.Settings.Default.ProjectDirectory != "")
            {
                projectDir = Properties.Settings.Default.ProjectDirectory;
                openProject(Properties.Settings.Default.ProjectDirectory);
            } else
            {
                DialogResult result = fbdOpenProject.ShowDialog();

                if(result == DialogResult.OK)
                {
                    projectDir = fbdOpenProject.SelectedPath;
                    openNewProject(projectDir);
                }
            }

            //Check For ATS Directory
            if(Properties.Settings.Default.ATSBaseDirectory != "")
            {
                atsBaseDir = Properties.Settings.Default.ATSBaseDirectory;
                txtATSBase.Text = atsBaseDir;
            }

            //Look For Sector File in Project Directory
            lsbSectors.Items.Clear();

            if (File.Exists(projectDir + @"\sectors.fumt"))
            {
                string[] rawSectors = File.ReadAllLines(projectDir + @"\sectors.fumt");
                
                for(int i = 0; i < rawSectors.Length; i++)
                {
                    sectors.Add(rawSectors[i]);
                    lsbSectors.Items.Add(rawSectors[i]);
                }
            }

        }

        private void openProject(string projectFolder)
        {

            projectDir = projectFolder;

            if(File.Exists(projectFolder + @"\manifest.sii")) {
                StreamReader reader = new StreamReader(projectFolder + @"\manifest.sii");

                try
                {
                    string manifest = reader.ReadToEnd();

                    packageVersion = getBetween(manifest, "package_version: \"", "\"");
                    displayName = getBetween(manifest, "display_name: \"", "\"");
                    author = getBetween(manifest, "author: \"", "\"");
                    categories = getBetween(manifest, "category[]: \"", "\"");

                    if (getBetween(manifest, "icon: \"", "\"") != "")
                    {
                        icon = getBetween(manifest, "icon: \"", "\"");

                        iconLocation = projectFolder + "\\" + icon;

                        if (File.Exists(iconLocation))
                        {
                            picIcon.ImageLocation = iconLocation;
                        }
                    }

                    if (getBetween(manifest, "description_file: \"", "\"") != "")
                    {
                        descriptionFileName = getBetween(manifest, "description_file: \"", "\"");

                        descriptionLocation = projectFolder + "\\" + descriptionFileName;

                        reader = new StreamReader(descriptionLocation);

                        try
                        {
                            description = reader.ReadToEnd();

                            rtbDescription.Text = description;
                        }
                        catch
                        {
                            MessageBox.Show("Failed to open description file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    txtPackageVersion.Text = packageVersion;
                    txtDisplayName.Text = displayName;
                    txtAuthor.Text = author;
                    txtCategories.Text = categories;

                }
                catch
                {
                    MessageBox.Show("Failed to open manifest.sii", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Select node in node tree (Quite frankly this needs to be put into the form load but im too lazy.)
            trvMapView.ExpandAll(); // Expand nodes
            trvMapView.Select(); // This is needed for some reason that man is yet to understand
            trvMapView.SelectedNode = trvMapView.Nodes[0].FirstNode; // Select manifest child node
            
        }

        private void openNewProject(string projectFolder)
        {
            Properties.Settings.Default.ProjectDirectory = projectFolder;
            openProject(projectFolder);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void trvMapView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // This whole section is a shitshow that doesn't work well. Complete rewrite is not only needed but is neccessary for proper function.
            // Not to mention the lack of scaleability.

            if (trvMapView.SelectedNode.Name == "tvnManifest")
            {
                grbMapConfig.Visible = true;
                grbSectorsConfig.Visible = false;
            } else if (trvMapView.SelectedNode.Name == "tvnSectors")
            {
                grbSectorsConfig.Visible = true;
                grbMapConfig.Visible = false;
            } else if (trvMapView.SelectedNode.Name == "tvnPackage")
            {
                grbSectorsConfig.Visible = false;
                grbMapConfig.Visible = false;
            }
        }

        private void btnChangeIcon_Click(object sender, EventArgs e)
        {

            iconLocation = projectDir + "\\" + icon;

            DialogResult result = ofdModIcon.ShowDialog();

            if(result == DialogResult.OK)
            {
                if (File.Exists(iconLocation))
                {
                    File.Delete(iconLocation);
                }
                File.Copy(ofdModIcon.FileName, iconLocation);
                picIcon.ImageLocation = iconLocation;
            }
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            const int kNotFound = -1;

            var startIdx = strSource.IndexOf(strStart);
            if (startIdx != kNotFound)
            {
                startIdx += strStart.Length;
                var endIdx = strSource.IndexOf(strEnd, startIdx);
                if (endIdx > startIdx)
                {
                    return strSource.Substring(startIdx, endIdx - startIdx);
                }
            }
            return String.Empty;
        }

        private void txtPackageVersion_TextChanged(object sender, EventArgs e)
        {
            packageVersion = txtPackageVersion.Text;
        }

        private void txtDisplayName_TextChanged(object sender, EventArgs e)
        {
            displayName = txtDisplayName.Text;
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            author = txtAuthor.Text;
        }

        private void txtCategories_TextChanged(object sender, EventArgs e)
        {
            categories = txtCategories.Text;
        }

        private void tsmSaveProject_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            descriptionLocation = projectDir + "\\" + descriptionFileName;

            try
            {

                //manifest.sii
                if (File.Exists(iconLocation))
                {
                    string[] manifest = { "SiiNunit", "{", "mod_package : .package_name", "{", "        package_version: \"" + packageVersion + "\"", "        display_name: \"" + displayName + "\"", "        author: \"" + author + "\"", "        category[]: \"" + categories + "\"", "        icon: \"" + icon + "\"", "        description_file: \"" + descriptionFileName + "\"", "}", "}" };

                    if (File.Exists(projectDir + @"\manifest.sii"))
                    {
                        File.Delete(projectDir + @"\manifest.sii");
                    }

                    File.WriteAllLines(projectDir + @"\manifest.sii", manifest);

                }
                else
                {
                    string[] manifest = { "SiiNunit", "{", "mod_package : .package_name", "{", "        package_version: \"" + packageVersion + "\"", "        display_name: \"" + displayName + "\"", "        author: \"" + author + "\"", "        category[]: \"" + categories + "\"", "        #icon: \"\"", "        description_file: \"" + descriptionFileName + "\"", "}", "}" };

                    if (File.Exists(projectDir + @"\manifest.sii"))
                    {
                        File.Delete(projectDir + @"\manifest.sii");
                    }

                    File.WriteAllLines(projectDir + @"\manifest.sii", manifest);

                }

                //description.txt
                if (File.Exists(descriptionLocation))
                {
                    File.Delete(descriptionLocation);
                }

                File.WriteAllText(descriptionLocation, description);

                //sectors.fumt
                if (sectors.Count > 0)
                {
                    if (File.Exists(projectDir + @"\sectors.fumt"))
                    {
                        File.Delete(projectDir + @"\sectors.fumt");
                    }

                    File.WriteAllLines(projectDir + @"\sectors.fumt", sectors);
                } else if (File.Exists(projectDir + @"\sectors.fumt"))
                {
                    File.Delete(projectDir + @"\sectors.fumt");
                }
            }
            catch
            {
                MessageBox.Show("Failed to Save", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            description = rtbDescription.Text;
        }

        private void btnBrowseBase_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdATSBase.ShowDialog();

            if(result == DialogResult.OK)
            {
                atsBaseDir = fbdATSBase.SelectedPath;
                Properties.Settings.Default.ATSBaseDirectory = atsBaseDir;
                txtATSBase.Text = atsBaseDir;
            }
        }

        private void btnAddSector_Click(object sender, EventArgs e)
        {
            frmAddSector addSector = new frmAddSector();

            if (addSector.ShowDialog() == DialogResult.OK)
            {
                string sector = addSector.getSector();
                sectors.Add(sector);
                lsbSectors.Items.Add(sector);
            }
            
        }

        private void btnRemoveSector_Click(object sender, EventArgs e)
        {
            if (lsbSectors.SelectedItem != null)
            {
                sectors.Remove(lsbSectors.SelectedItem.ToString());
                lsbSectors.Items.RemoveAt(lsbSectors.SelectedIndex);
            }
        }

        private void btnRemoveAllSectors_Click(object sender, EventArgs e)
        {
            sectors.Clear();
            lsbSectors.Items.Clear();
        }

        private void btnDumpSector_Click(object sender, EventArgs e)
        {
            if (lsbSectors.SelectedItem != null)
            {
                dumpSector(lsbSectors.SelectedItem.ToString());
            }
        }

        private void dumpSector(string sector)
        {
            // Oh dear sweet baby jesus I forget how this works. Highly inefficent but gets the job done so...

            try
            {
                if (atsBaseDir != "")
                {
                    if (!Directory.Exists(projectDir + @"\map"))
                    {
                        Directory.CreateDirectory(projectDir + @"\map");
                    }

                    if (!Directory.Exists(projectDir + @"\map\usa"))
                    {
                        Directory.CreateDirectory(projectDir + @"\map\usa");
                    }

                    if (File.Exists(atsBaseDir + @"\map\usa\sec" + sector + ".aux"))
                    {
                        if (File.Exists(atsBaseDir + @"\map\usa\sec" + sector + ".base"))
                        {
                            if (File.Exists(atsBaseDir + @"\map\usa\sec" + sector + ".data"))
                            {
                                if (File.Exists(atsBaseDir + @"\map\usa\sec" + sector + ".desc"))
                                {

                                    if (File.Exists(projectDir + @"\map\usa\sec" + sector + ".aux"))
                                    {
                                        File.Delete(projectDir + @"\map\usa\sec" + sector + ".aux");
                                    }

                                    if (File.Exists(projectDir + @"\map\usa\sec" + sector + ".base"))
                                    {
                                        File.Delete(projectDir + @"\map\usa\sec" + sector + ".base");
                                    }

                                    if (File.Exists(projectDir + @"\map\usa\sec" + sector + ".data"))
                                    {
                                        File.Delete(projectDir + @"\map\usa\sec" + sector + ".data");
                                    }

                                    if (File.Exists(projectDir + @"\map\usa\sec" + sector + ".desc"))
                                    {
                                        File.Delete(projectDir + @"\map\usa\sec" + sector + ".desc");
                                    }

                                    // The four horesemen of map segments
                                    File.Copy(atsBaseDir + @"\map\usa\sec" + sector + ".aux", projectDir + @"\map\usa\sec" + sector + ".aux");
                                    File.Copy(atsBaseDir + @"\map\usa\sec" + sector + ".base", projectDir + @"\map\usa\sec" + sector + ".base");
                                    File.Copy(atsBaseDir + @"\map\usa\sec" + sector + ".data", projectDir + @"\map\usa\sec" + sector + ".data");
                                    File.Copy(atsBaseDir + @"\map\usa\sec" + sector + ".desc", projectDir + @"\map\usa\sec" + sector + ".desc");

                                }
                                else
                                {
                                    MessageBox.Show("That Sector Doesn't Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("That Sector Doesn't Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("That Sector Doesn't Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } else
                    {
                        MessageBox.Show("That Sector Doesn't Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

            }
                else
                {
                    MessageBox.Show("Set Your Base Directory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Failed to Dump Sector", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDumpAllSectors_Click(object sender, EventArgs e)
        {
            dumpAllSectors();
        }

        private void dumpAllSectors()
        {
            for (int i = 0; i < sectors.Count; i++)
            {
                dumpSector(sectors[i]);
            }
        }

        private void btnScanSectors_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(projectDir + @"\map"))
                {
                    if (Directory.Exists(projectDir + @"\map\usa"))
                    {

                        string[] files = Directory.GetFiles(projectDir + @"\map\usa");

                        for (int i = 0; i < files.Length; i++)
                        {
                            if (String.Compare(Path.GetExtension(files[i]), ".aux", true) == 0)
                            {
                                if (!sectors.Contains(getBetween(files[i], "sec", ".aux")))
                                {
                                    sectors.Add(getBetween(files[i], "sec", ".aux"));
                                    lsbSectors.Items.Add(getBetween(files[i], "sec", ".aux"));
                                }
                            }
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Faile to Scan Sectors", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}