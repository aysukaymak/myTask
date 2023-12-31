using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace mytask_.UI.Modules
{
    public partial class ucCalendar : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public int userId;
        public ucCalendar(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            list_tasks(); //when form is opened, list notes in tileview
            scheduler_settings(); //tileview design settings
            //set_initial_texts(); //display first row details in tileview, details are displayed in header, date and note fields of form
        }

        SqlConnection_ connection_ = new SqlConnection_();

        private void scheduler_settings()
        {
            //required mappings
            schedulerDataStorage1.Appointments.Mappings.End = "end_date";
            schedulerDataStorage1.Appointments.Mappings.Start = "start_date";
            schedulerDataStorage1.Appointments.Mappings.Description = "content";
            schedulerDataStorage1.Appointments.Mappings.Subject = "header";

            schedulerControl1.MonthView.AppointmentDisplayOptions.ShowReminder = false;
        }

        public void list_tasks()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id, header, note as content, date as start_date, date as end_date " +
                                                   $"from notes " +
                                                   $"union " +
                                                   $"select id, header, task as content, start_date, end_date " +
                                                   $"from tasks " +
                                                   $"where user_id = {1}", connection_.Connection_()); //change user_id value after completed users and login tables
            da.Fill(dt);
            
            schedulerControl1.DataStorage.Appointments.DataSource = dt;
        }
    }
}