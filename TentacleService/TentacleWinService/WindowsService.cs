using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TentacleWinService
{
    public partial class WindowsService : ServiceBase
    {
        ServiceHost Host;

        public WindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Host = new ServiceHost(typeof(TentacleService.TentacleService));
            Host.Open();

        }

        protected override void OnStop()
        {
            Host.Close();
        }
    }
}
