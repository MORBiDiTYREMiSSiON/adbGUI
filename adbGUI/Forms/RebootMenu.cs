﻿using System;
using System.CodeDom;
using System.Linq;
using System.Windows.Forms;

namespace adbGUI
{
      public partial class RebootMenu : Form
      {
            public RebootMenu()
            {
                  InitializeComponent();
            }
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                  if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
                  Close();
                  return true;
            }

            private void RebootMenu_Load(object sender, EventArgs e)
            {
                  combo_rebootmenu.SelectedIndex = 0;
            }


            private void btn_rebootmenu_reboot_Click(object sender, EventArgs e)
            {
                  Close();

                  var mainform = Application.OpenForms.OfType<MainForm>().Single();

                  switch (combo_rebootmenu.SelectedIndex)
                  {
                        case 0:
                              mainform.AdbMethods.callADB_wo("", "shell reboot -p");
                              break;
                        case 1:
                              mainform.AdbMethods.callADB_wo("", "reboot");
                              break;
                        case 2:
                              mainform.AdbMethods.callADB_wo("", "reboot bootloader");
                              break;
                        case 3:
                              mainform.AdbMethods.callADB_wo("", "reboot recovery");
                              break;
                  }


                  //if (combo_rebootmenu.SelectedIndex == 0)
                  //{
                  //      mainform.AdbMethods.callADB_wo("", "shell reboot -p");
                  //}
                  //else if (combo_rebootmenu.SelectedIndex == 1)
                  //{
                  //      mainform.AdbMethods.callADB_wo("", "reboot");
                  //}
                  //else if (combo_rebootmenu.SelectedIndex == 2)
                  //{
                  //      mainform.AdbMethods.callADB_wo("", "reboot bootloader");
                  //}
                  //else if (combo_rebootmenu.SelectedIndex == 3)
                  //{
                  //      mainform.AdbMethods.callADB_wo("", "reboot recovery");
                  //}
            }
      }
}
