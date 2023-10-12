using Runner.Core;
using UnityEngine;

namespace Runner
{
    public class TimeManager : ITime
    {
        public float CurrentTime => Time.time;
    }
}