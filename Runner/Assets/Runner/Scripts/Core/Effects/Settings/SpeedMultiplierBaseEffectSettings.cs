﻿using UnityEngine;

namespace Runner.Core
{
    [CreateAssetMenu(menuName = "Configs/Effects/SpeedMultiplier")]
    public class SpeedMultiplierEffectSettings : BaseEffectSettings<SpeedMultiplierEffect>
    {
        [field: SerializeField]
        public float SpeedMultiplier { get; private set; }
    }
}