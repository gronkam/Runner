using Runner.Core;
using UnityEngine;
using Zenject;

namespace Runner.Renderer
{
    // Renders coins and manages spawning and despawning
    public class CoinRenderer: MonoBehaviour
    {
        // Pool class for managing CoinRenderer instances
        public class Pool : MonoMemoryPool<CoinRenderer>
        {
            // Called when a CoinRenderer is spawned
            protected override void OnSpawned(CoinRenderer item)
            {
                base.OnSpawned(item);
                item.gameObject.SetActive(true);
            }

            // Called when a CoinRenderer is despawned
            protected override void OnDespawned(CoinRenderer item)
            {
                base.OnDespawned(item);
                item.gameObject.SetActive(false);
            }
        }
        
        [Inject]
        private Pool _pool;  // Injected pool
        
        public BaseEffectSettings EffectSettings { get; private set; }  // Effect settings

        // Despawns this coin renderer
        public void Despawn()
        {
            _pool.Despawn(this);
        }

        // Sets the effect settings for this coin
        public void SetEffect(BaseEffectSettings effectSettings)
        {
            EffectSettings = effectSettings;
        }
    }
}