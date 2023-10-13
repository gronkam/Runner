using Runner.Core;
using Runner.Renderer;
using UnityEngine;
using Zenject;

namespace Runner
{
    // Spawns coins at intervals along the path
    public class CoinSpawner: MonoBehaviour, ITickable
    {
        [SerializeField] 
        private float _spawnInterval = 10f;  // Interval between spawns
        
        [Inject]
        private CoinRenderer.Pool _pool;  // Injected pool
        
        [Inject]
        private EffectListSettings _effectListSettings;  // Injected effect list settings

        [Inject]
        private ICoinDetector _coinDetector;  // Injected coin detector
        
        private Vector3 LastSpawnPosition = Vector3.up;  // Last spawn position
        
        // Called every tick to spawn coins if necessary
        void ITickable.Tick()
        {
            while ((LastSpawnPosition - _coinDetector.Position).sqrMagnitude < 10000)
            {
                SpawnObject(LastSpawnPosition + Vector3.forward * _spawnInterval);
            }
        }

        // Spawns a coin at the specified position
        private void SpawnObject(Vector3 position)
        {
            var coin = _pool.Spawn();
            LastSpawnPosition = coin.transform.position = position;
            coin.SetEffect(GetRandomEffect());
        }

        // Gets a random effect from the effect list settings
        private BaseEffectSettings GetRandomEffect()
        {
            return _effectListSettings.Effects[Random.Range(0, _effectListSettings.Effects.Count)];
        }
    }
}