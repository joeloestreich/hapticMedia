using OWOGame;
using owoMedia.sensationPlayer.sensationTemplate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.sensationPlayer {
    public class SensationPlayer {

        Dictionary<double, SensationTemplate> SensationSequence;
        BackgroundWorker BGWorker;
        SyncableStopwatch Timer;

        private bool Play = false;
        double LastCheckedTime = 0;

        public SensationPlayer() {
            this.SensationSequence = new Dictionary<double, SensationTemplate>();
            this.Timer = new SyncableStopwatch();
            this.BGWorker = new BackgroundWorker();
            this.BGWorker.DoWork += BGWorker_DoWork;
        }

        public SensationPlayer(Dictionary<double, SensationTemplate> sequence) {
            this.SensationSequence = sequence;
            this.Timer = new SyncableStopwatch();
            this.BGWorker = new BackgroundWorker();
            this.BGWorker.DoWork += BGWorker_DoWork;
        }

        public void Start() {
            Play = true;
            this.BGWorker.RunWorkerAsync();
            Timer.Start();
        }

        public void Stop() {
            Timer.Stop();
            Play = false;
        }

        public void Sync(double time) {
            Timer.SyncTime(time);
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e) {
            List<double> allTimes = new List<double>(SensationSequence.Keys);
            allTimes = allTimes.FindAll(x => x > LastCheckedTime);
            allTimes = allTimes.OrderBy(x => x).ToList();
            while (Play) {
                if (allTimes.Any() && LastCheckedTime > allTimes[0]) {
                    SensationSequence[allTimes[0]].PlaySensation();
                    allTimes.RemoveAt(0);
                }
                LastCheckedTime = Timer.GetSyncedSeconds();
            }
        }
    }
}
