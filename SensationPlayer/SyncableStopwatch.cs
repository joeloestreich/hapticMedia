using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer {
    public class SyncableStopwatch : Stopwatch {

        private double timestamp = 0;
        private double asTime = 0;

        public double GetSyncedSeconds() {
            return Elapsed.TotalSeconds - timestamp + asTime;
        }

        public void SyncTime(double seconds) {
            timestamp = Elapsed.TotalSeconds;
            asTime = seconds;
        }
    }
}
