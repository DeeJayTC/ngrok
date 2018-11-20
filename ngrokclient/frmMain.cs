#region FileHeader
// ==========================================================
// File:            ngrokclient.frmMain.cs
// Last Mod:        20.11.2018
// Created:         20.11.2018
// Created By:      Tim cadenbach
// Copyright (C) 2018 Tim Cadenbach - Apache 2.0 License
//  ==========================================================
#endregion

#region Imports

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Yaml;

#endregion

namespace ngrokclient
{
    public partial class FrmMain : Form
    {
        private NgrokConfig Config;

        public FrmMain()
        {
            InitializeComponent();
            LoadConfiguration();


        }


        private void LoadConfiguration()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\.ngrok2\ngrok.yml";
                var configurationBuilder = new ConfigurationBuilder().AddYamlFile(path);
                Config = new NgrokConfig(configurationBuilder.Build());


                txtAuthToken.Text = Config.Token;
            }
            catch (IOException ex)
            {

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
