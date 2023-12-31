using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using mytask_.UI.Modules;

namespace mytask_
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        private int userId;
        public frmMain(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        //get for userId
        public int getUserId () { return userId; }

        


        async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer1.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer1.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer1.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                    {
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            control[0].BringToFront();
                        }));
                    }
                }
            });
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Add(new ucNotes() { Dock = DockStyle.Fill });
            this.itemNav.Caption = $"{accordionControlElementNotes.Text}";
        }

        private async void accordionControlElementSearch_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementSearch.Text}";
            if (ModulesInfo.GetItem("ucSearch") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucSearch", "mytask_.UI.Modules.ucSearch"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucSearch"));
        }

        private async void accordionControlElementNewNote_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementNewNote.Text}";
            if (ModulesInfo.GetItem("ucNewNote") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucNewNote", "mytask_.UI.Modules.ucNewNote"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucNewNote"));
        }

        private async void accordionControlElementNotes_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementNotes.Text}";
            if (ModulesInfo.GetItem("ucNotes") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucNotes", "mytask_.UI.Modules.ucNotes"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucNotes"));
        }

        private async void accordionControlElementCalendar_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementCalendar.Text}";
            if (ModulesInfo.GetItem("ucCalendar") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucCalendar", "mytask_.UI.Modules.ucCalendar"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucCalendar"));
        }

        private async void accordionControlElementProfile_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementProfile.Text}";
            if (ModulesInfo.GetItem("ucProfile") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucProfile", "mytask_.UI.Modules.ucProfile"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucProfile"));
        }

        private async void accordionControlElementNewTask_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlElementNewTask.Text}";
            if (ModulesInfo.GetItem("ucNewTask") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucNewTask", "mytask_.UI.Modules.ucNewTask"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucNewTask"));
        }
    }
}
