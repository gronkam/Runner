using Runner.Core;
using UnityEngine;
using Zenject;

namespace Runner.Renderer
{
    public class CoinRenderer: MonoBehaviour
    {
        public class Pool : MonoMemoryPool<CoinRenderer>
        {
            protected override void OnSpawned(CoinRenderer item)
            {
                base.OnSpawned(item);
                item.gameObject.SetActive(true);
            }

            protected override void OnDespawned(CoinRenderer item)
            {
                base.OnDespawned(item);
                item.gameObject.SetActive(false);
            }
        }
        
        [Inject]
        private Pool _pool;
        
        public BaseEffectSettings EffectSettings { get; private set; }

        public void Despawn()
        {
            _pool.Despawn(this);
        }

        public void SetEffect(BaseEffectSettings effectSettings)
        {
            EffectSettings = effectSettings;
        }
    }
}