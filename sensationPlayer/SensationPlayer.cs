using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer {
    public class SensationPlayer {

        public Dictionary<double, SensationWrapper> SensationSequence;
        BackgroundWorker BGWorker;
        SyncableStopwatch Timer;

        private bool Play = false;
        double LastCheckedTime = 0;

        List<double> upcomingSensationKeys;

        public SensationPlayer() {
            this.SensationSequence = new Dictionary<double, SensationWrapper>();
            this.Timer = new SyncableStopwatch();
            this.BGWorker = new BackgroundWorker();
            this.BGWorker.DoWork += BGWorker_DoWork;
        }

        public SensationPlayer(Dictionary<double, SensationWrapper> sequence) {
            this.SensationSequence = sequence;
            this.Timer = new SyncableStopwatch();
            this.BGWorker = new BackgroundWorker();
            this.BGWorker.DoWork += BGWorker_DoWork;

            upcomingSensationKeys = new List<double>(SensationSequence.Keys);
        }

        public void Start() {
            Play = true;
            if (!this.BGWorker.IsBusy) {
                this.BGWorker.RunWorkerAsync();
            }
            Timer.Start();
        }

        public void Stop() {
            Timer.Stop();
            Play = false;
        }

        public void TimeCheck(double externalTime) {
            double localTime = Timer.GetSyncedSeconds();

            double difference = localTime - externalTime;
            bool sync = difference > 0.5 || difference < -0.5;

            if (sync) {
                Sync(externalTime);
            }
        }

        public void Sync() {
            // Reset Upcomming Keys in case we go back
            upcomingSensationKeys = new List<double>(SensationSequence.Keys);

            // Only Keys that end in future
            upcomingSensationKeys = upcomingSensationKeys.FindAll(x => x + SensationSequence[x].GetLengthInSeconds() > LastCheckedTime);

            // Order
            upcomingSensationKeys = upcomingSensationKeys.OrderBy(x => x).ToList();
        }

        public void Sync(double time) {
            Timer.SyncTime(time);
            LastCheckedTime = time;
            Sync();
        }

        public double GetCurTime() {
            return Timer.GetSyncedSeconds();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e) {
            while (Play) {
                if (upcomingSensationKeys.Any() && LastCheckedTime >= upcomingSensationKeys[0]) {
                     SensationWrapper wrapper = SensationSequence[upcomingSensationKeys[0]];
                    upcomingSensationKeys.RemoveAt(0);
                    PlaySensation(wrapper.GetSensation());
                }
                LastCheckedTime = Timer.GetSyncedSeconds();
            }
        }

        internal virtual void PlaySensation(Sensation sensation) {
            OWO.Send(sensation);
        }
    }
}
