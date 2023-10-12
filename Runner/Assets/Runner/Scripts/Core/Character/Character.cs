using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Runner.Core
{
    public class Character: IEffectable, ICharacter, IEffectContainer, ITickable
    {
        public float Speed { get; set; }
        public MoveType MoveType { get; set; }
        
        private CharacterSettings Settings { get; }
        private bool EffectsChanged { get; set; }

        private List<BaseEffect> Effects { get; }

        public Character(CharacterSettings settings)
        {
            Settings = settings;
            Effects = new List<BaseEffect>();
            SetDefaults();
        }
        
        void ITickable.Tick()
        {
            RefreshEffects();
            if (EffectsChanged)
            {
                SetDefaults();
                ApplyEffects();
            }
            EffectsChanged = false;
            
            void RefreshEffects()
            {
                for (int i = Effects.Count - 1; i >= 0; i--)
                {
                    Effects[i].RefreshEffect();
                    if (Effects[i].IsExpired)
                    {
                        Effects.RemoveAt(i);
                        EffectsChanged = true;
                    }
                }
            }

            void ApplyEffects()
            {
                foreach (BaseEffect effect in Effects)
                {
                    effect.ApplyEffect(this);
                }
            }
        }

        private void SetDefaults()
        {
            Speed = Settings.DefaultSpeed;
            MoveType = Settings.DefaultMoveType;
        }

        public void AddEffect(BaseEffect effect)
        {
            Effects.Add(effect);
            EffectsChanged = true;
        }
    }
}