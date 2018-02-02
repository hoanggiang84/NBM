using System.Diagnostics;

namespace SAM.HPCncForm.Classes
{
    class WaitTimer
    {
        private readonly Stopwatch _waitTimer = new Stopwatch();
        private int _waitPeriod;
        public void StartWaiting(int ms)
        {
            _waitTimer.Restart();
            _waitPeriod = ms;
        }

        public bool Overflow()
        {
            return (_waitTimer.ElapsedMilliseconds >= _waitPeriod);
        }

        public void ResetTimer()
        {
            _waitTimer.Stop();
            _waitTimer.Reset();
        }
    }
}
