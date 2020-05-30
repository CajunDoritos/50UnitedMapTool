namespace _50UnitedMapTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.tsdFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdGit = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmGitCommit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGitPull = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGitPush = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGitMerge = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdOpenProject = new System.Windows.Forms.FolderBrowserDialog();
            this.grbMap = new System.Windows.Forms.GroupBox();
            this.trvMapView = new System.Windows.Forms.TreeView();
            this.grbMapConfig = new System.Windows.Forms.GroupBox();
            this.grbDescription = new System.Windows.Forms.GroupBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.grbManifest = new System.Windows.Forms.GroupBox();
            this.btnChangeIcon = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.txtCategories = new System.Windows.Forms.TextBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtPackageVersion = new System.Windows.Forms.TextBox();
            this.lblPackageVersion = new System.Windows.Forms.Label();
            this.ofdModIcon = new System.Windows.Forms.OpenFileDialog();
            this.grbSectorsConfig = new System.Windows.Forms.GroupBox();
            this.btnScanSectors = new System.Windows.Forms.Button();
            this.btnRemoveAllSectors = new System.Windows.Forms.Button();
            this.btnDumpSector = new System.Windows.Forms.Button();
            this.btnDumpAllSectors = new System.Windows.Forms.Button();
            this.btnRemoveSector = new System.Windows.Forms.Button();
            this.btnAddSector = new System.Windows.Forms.Button();
            this.lsbSectors = new System.Windows.Forms.ListBox();
            this.lblSectors = new System.Windows.Forms.Label();
            this.btnBrowseBase = new System.Windows.Forms.Button();
            this.txtATSBase = new System.Windows.Forms.TextBox();
            this.lblATSBase = new System.Windows.Forms.Label();
            this.fbdATSBase = new System.Windows.Forms.FolderBrowserDialog();
            this.grbMap.SuspendLayout();
            this.grbMapConfig.SuspendLayout();
            this.grbDescription.SuspendLayout();
            this.grbManifest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.grbSectorsConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsMenu
            // 
            this.tlsMenu.AllowDrop = true;
            resources.ApplyResources(this.tlsMenu, "tlsMenu");
            this.tlsMenu.Name = "tlsMenu";
            // 
            // tsdFile
            // 
            this.tsdFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenProject,
            this.tsmSaveProject,
            this.tsmExport,
            this.toolStripSeparator1,
            this.tsmExit});
            resources.ApplyResources(this.tsdFile, "tsdFile");
            this.tsdFile.Name = "tsdFile";
            // 
            // tsmOpenProject
            // 
            this.tsmOpenProject.Name = "tsmOpenProject";
            resources.ApplyResources(this.tsmOpenProject, "tsmOpenProject");
            this.tsmOpenProject.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tsmSaveProject
            // 
            this.tsmSaveProject.Name = "tsmSaveProject";
            resources.ApplyResources(this.tsmSaveProject, "tsmSaveProject");
            this.tsmSaveProject.Click += new System.EventHandler(this.tsmSaveProject_Click);
            // 
            // tsmExport
            // 
            this.tsmExport.Name = "tsmExport";
            resources.ApplyResources(this.tsmExport, "tsmExport");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            resources.ApplyResources(this.tsmExit, "tsmExit");
            this.tsmExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsdGit
            // 
            this.tsdGit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdGit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGitCommit,
            this.tsmGitPull,
            this.tsmGitPush,
            this.tsmGitMerge});
            resources.ApplyResources(this.tsdGit, "tsdGit");
            this.tsdGit.Name = "tsdGit";
            // 
            // tsmGitCommit
            // 
            this.tsmGitCommit.Name = "tsmGitCommit";
            resources.ApplyResources(this.tsmGitCommit, "tsmGitCommit");
            this.tsmGitCommit.Click += new System.EventHandler(this.pullToolStripMenuItem_Click);
            // 
            // tsmGitPull
            // 
            this.tsmGitPull.Name = "tsmGitPull";
            resources.ApplyResources(this.tsmGitPull, "tsmGitPull");
            // 
            // tsmGitPush
            // 
            this.tsmGitPush.Name = "tsmGitPush";
            resources.ApplyResources(this.tsmGitPush, "tsmGitPush");
            // 
            // tsmGitMerge
            // 
            this.tsmGitMerge.Name = "tsmGitMerge";
            resources.ApplyResources(this.tsmGitMerge, "tsmGitMerge");
            // 
            // fbdOpenProject
            // 
            resources.ApplyResources(this.fbdOpenProject, "fbdOpenProject");
            // 
            // grbMap
            // 
            resources.ApplyResources(this.grbMap, "grbMap");
            this.grbMap.Controls.Add(this.trvMapView);
            this.grbMap.Name = "grbMap";
            this.grbMap.TabStop = false;
            // 
            // trvMapView
            // 
            resources.ApplyResources(this.trvMapView, "trvMapView");
            this.trvMapView.Name = "trvMapView";
            this.trvMapView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("trvMapView.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("trvMapView.Nodes1")))});
            this.trvMapView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMapView_AfterSelect);
            // 
            // grbMapConfig
            // 
            resources.ApplyResources(this.grbMapConfig, "grbMapConfig");
            this.grbMapConfig.Controls.Add(this.grbDescription);
            this.grbMapConfig.Controls.Add(this.grbManifest);
            this.grbMapConfig.Name = "grbMapConfig";
            this.grbMapConfig.TabStop = false;
            // 
            // grbDescription
            // 
            resources.ApplyResources(this.grbDescription, "grbDescription");
            this.grbDescription.Controls.Add(this.rtbDescription);
            this.grbDescription.Name = "grbDescription";
            this.grbDescription.TabStop = false;
            // 
            // rtbDescription
            // 
            resources.ApplyResources(this.rtbDescription, "rtbDescription");
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // grbManifest
            // 
            resources.ApplyResources(this.grbManifest, "grbManifest");
            this.grbManifest.Controls.Add(this.btnChangeIcon);
            this.grbManifest.Controls.Add(this.picIcon);
            this.grbManifest.Controls.Add(this.lblIcon);
            this.grbManifest.Controls.Add(this.txtCategories);
            this.grbManifest.Controls.Add(this.lblCategories);
            this.grbManifest.Controls.Add(this.txtAuthor);
            this.grbManifest.Controls.Add(this.lblAuthor);
            this.grbManifest.Controls.Add(this.txtDisplayName);
            this.grbManifest.Controls.Add(this.lblDisplayName);
            this.grbManifest.Controls.Add(this.txtPackageVersion);
            this.grbManifest.Controls.Add(this.lblPackageVersion);
            this.grbManifest.Name = "grbManifest";
            this.grbManifest.TabStop = false;
            // 
            // btnChangeIcon
            // 
            resources.ApplyResources(this.btnChangeIcon, "btnChangeIcon");
            this.btnChangeIcon.Name = "btnChangeIcon";
            this.btnChangeIcon.UseVisualStyleBackColor = true;
            this.btnChangeIcon.Click += new System.EventHandler(this.btnChangeIcon_Click);
            // 
            // picIcon
            // 
            resources.ApplyResources(this.picIcon, "picIcon");
            this.picIcon.Image = global::_50UnitedMapTool.Properties.Resources.noimage;
            this.picIcon.Name = "picIcon";
            this.picIcon.TabStop = false;
            // 
            // lblIcon
            // 
            resources.ApplyResources(this.lblIcon, "lblIcon");
            this.lblIcon.Name = "lblIcon";
            // 
            // txtCategories
            // 
            resources.ApplyResources(this.txtCategories, "txtCategories");
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.TextChanged += new System.EventHandler(this.txtCategories_TextChanged);
            // 
            // lblCategories
            // 
            resources.ApplyResources(this.lblCategories, "lblCategories");
            this.lblCategories.Name = "lblCategories";
            // 
            // txtAuthor
            // 
            resources.ApplyResources(this.txtAuthor, "txtAuthor");
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // lblAuthor
            // 
            resources.ApplyResources(this.lblAuthor, "lblAuthor");
            this.lblAuthor.Name = "lblAuthor";
            // 
            // txtDisplayName
            // 
            resources.ApplyResources(this.txtDisplayName, "txtDisplayName");
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.TextChanged += new System.EventHandler(this.txtDisplayName_TextChanged);
            // 
            // lblDisplayName
            // 
            resources.ApplyResources(this.lblDisplayName, "lblDisplayName");
            this.lblDisplayName.Name = "lblDisplayName";
            // 
            // txtPackageVersion
            // 
            resources.ApplyResources(this.txtPackageVersion, "txtPackageVersion");
            this.txtPackageVersion.Name = "txtPackageVersion";
            this.txtPackageVersion.TextChanged += new System.EventHandler(this.txtPackageVersion_TextChanged);
            // 
            // lblPackageVersion
            // 
            resources.ApplyResources(this.lblPackageVersion, "lblPackageVersion");
            this.lblPackageVersion.Name = "lblPackageVersion";
            // 
            // ofdModIcon
            // 
            this.ofdModIcon.DefaultExt = "jpg";
            resources.ApplyResources(this.ofdModIcon, "ofdModIcon");
            // 
            // grbSectorsConfig
            // 
            resources.ApplyResources(this.grbSectorsConfig, "grbSectorsConfig");
            this.grbSectorsConfig.Controls.Add(this.btnScanSectors);
            this.grbSectorsConfig.Controls.Add(this.btnRemoveAllSectors);
            this.grbSectorsConfig.Controls.Add(this.btnDumpSector);
            this.grbSectorsConfig.Controls.Add(this.btnDumpAllSectors);
            this.grbSectorsConfig.Controls.Add(this.btnRemoveSector);
            this.grbSectorsConfig.Controls.Add(this.btnAddSector);
            this.grbSectorsConfig.Controls.Add(this.lsbSectors);
            this.grbSectorsConfig.Controls.Add(this.lblSectors);
            this.grbSectorsConfig.Controls.Add(this.btnBrowseBase);
            this.grbSectorsConfig.Controls.Add(this.txtATSBase);
            this.grbSectorsConfig.Controls.Add(this.lblATSBase);
            this.grbSectorsConfig.Name = "grbSectorsConfig";
            this.grbSectorsConfig.TabStop = false;
            // 
            // btnScanSectors
            // 
            resources.ApplyResources(this.btnScanSectors, "btnScanSectors");
            this.btnScanSectors.Name = "btnScanSectors";
            this.btnScanSectors.UseVisualStyleBackColor = true;
            this.btnScanSectors.Click += new System.EventHandler(this.btnScanSectors_Click);
            // 
            // btnRemoveAllSectors
            // 
            resources.ApplyResources(this.btnRemoveAllSectors, "btnRemoveAllSectors");
            this.btnRemoveAllSectors.Name = "btnRemoveAllSectors";
            this.btnRemoveAllSectors.UseVisualStyleBackColor = true;
            this.btnRemoveAllSectors.Click += new System.EventHandler(this.btnRemoveAllSectors_Click);
            // 
            // btnDumpSector
            // 
            resources.ApplyResources(this.btnDumpSector, "btnDumpSector");
            this.btnDumpSector.Name = "btnDumpSector";
            this.btnDumpSector.UseVisualStyleBackColor = true;
            this.btnDumpSector.Click += new System.EventHandler(this.btnDumpSector_Click);
            // 
            // btnDumpAllSectors
            // 
            resources.ApplyResources(this.btnDumpAllSectors, "btnDumpAllSectors");
            this.btnDumpAllSectors.Name = "btnDumpAllSectors";
            this.btnDumpAllSectors.UseVisualStyleBackColor = true;
            this.btnDumpAllSectors.Click += new System.EventHandler(this.btnDumpAllSectors_Click);
            // 
            // btnRemoveSector
            // 
            resources.ApplyResources(this.btnRemoveSector, "btnRemoveSector");
            this.btnRemoveSector.Name = "btnRemoveSector";
            this.btnRemoveSector.UseVisualStyleBackColor = true;
            this.btnRemoveSector.Click += new System.EventHandler(this.btnRemoveSector_Click);
            // 
            // btnAddSector
            // 
            resources.ApplyResources(this.btnAddSector, "btnAddSector");
            this.btnAddSector.Name = "btnAddSector";
            this.btnAddSector.UseVisualStyleBackColor = true;
            this.btnAddSector.Click += new System.EventHandler(this.btnAddSector_Click);
            // 
            // lsbSectors
            // 
            resources.ApplyResources(this.lsbSectors, "lsbSectors");
            this.lsbSectors.FormattingEnabled = true;
            this.lsbSectors.Items.AddRange(new object[] {
            resources.GetString("lsbSectors.Items")});
            this.lsbSectors.Name = "lsbSectors";
            // 
            // lblSectors
            // 
            resources.ApplyResources(this.lblSectors, "lblSectors");
            this.lblSectors.Name = "lblSectors";
            // 
            // btnBrowseBase
            // 
            resources.ApplyResources(this.btnBrowseBase, "btnBrowseBase");
            this.btnBrowseBase.Name = "btnBrowseBase";
            this.btnBrowseBase.UseVisualStyleBackColor = true;
            this.btnBrowseBase.Click += new System.EventHandler(this.btnBrowseBase_Click);
            // 
            // txtATSBase
            // 
            resources.ApplyResources(this.txtATSBase, "txtATSBase");
            this.txtATSBase.Name = "txtATSBase";
            // 
            // lblATSBase
            // 
            resources.ApplyResources(this.lblATSBase, "lblATSBase");
            this.lblATSBase.Name = "lblATSBase";
            // 
            // fbdATSBase
            // 
            resources.ApplyResources(this.fbdATSBase, "fbdATSBase");
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbMap);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.grbMapConfig);
            this.Controls.Add(this.grbSectorsConfig);
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbMap.ResumeLayout(false);
            this.grbMapConfig.ResumeLayout(false);
            this.grbDescription.ResumeLayout(false);
            this.grbManifest.ResumeLayout(false);
            this.grbManifest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.grbSectorsConfig.ResumeLayout(false);
            this.grbSectorsConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripDropDownButton tsdFile;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenProject;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveProject;
        private System.Windows.Forms.ToolStripMenuItem tsmExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripDropDownButton tsdGit;
        private System.Windows.Forms.ToolStripMenuItem tsmGitCommit;
        private System.Windows.Forms.ToolStripMenuItem tsmGitPull;
        private System.Windows.Forms.ToolStripMenuItem tsmGitPush;
        private System.Windows.Forms.ToolStripMenuItem tsmGitMerge;
        private System.Windows.Forms.FolderBrowserDialog fbdOpenProject;
        private System.Windows.Forms.GroupBox grbMap;
        private System.Windows.Forms.TreeView trvMapView;
        private System.Windows.Forms.GroupBox grbMapConfig;
        private System.Windows.Forms.GroupBox grbDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.GroupBox grbManifest;
        private System.Windows.Forms.TextBox txtCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtPackageVersion;
        private System.Windows.Forms.Label lblPackageVersion;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btnChangeIcon;
        private System.Windows.Forms.OpenFileDialog ofdModIcon;
        private System.Windows.Forms.GroupBox grbSectorsConfig;
        private System.Windows.Forms.Button btnBrowseBase;
        private System.Windows.Forms.TextBox txtATSBase;
        private System.Windows.Forms.Label lblATSBase;
        private System.Windows.Forms.FolderBrowserDialog fbdATSBase;
        private System.Windows.Forms.Label lblSectors;
        private System.Windows.Forms.ListBox lsbSectors;
        private System.Windows.Forms.Button btnAddSector;
        private System.Windows.Forms.Button btnRemoveSector;
        private System.Windows.Forms.Button btnDumpSector;
        private System.Windows.Forms.Button btnDumpAllSectors;
        private System.Windows.Forms.Button btnRemoveAllSectors;
        private System.Windows.Forms.Button btnScanSectors;
    }
}

