using Runner.Core;
using UnityEngine;

namespace Runner
{
    // Implements default Unity ITime interface to provide current time
    public class TimeManager : ITime
    {
        public float CurrentTime => Time.time;
    }
}