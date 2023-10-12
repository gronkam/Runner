using Runner.Core;
using Runner.Renderer;
using UnityEngine;
using Zenject;

namespace Runner
{
    public class CoinSpawner: MonoBehaviour, ITickable
    {
        [SerializeField] 
        private float _spawnInterval = 10f;
        
        [Inject]
        private CoinRenderer.Pool _pool;
        
        [Inject]
        private EffectListSettings _effectListSettings;

        [Inject]
        private ICoinDetector _coinDetector;
        
        private Vector3 LastSpawnPosition = Vector3.up;
        
        void ITickable.Tick()
        {
            while ((LastSpawnPosition - _coinDetector.Position).sqrMagnitude < 10000)
            {
                SpawnObject(LastSpawnPosition + Vector3.forward * _spawnInterval);
            }
        }

        private void SpawnObject(Vector3 position)
        {
            var coin = _pool.Spawn();
            LastSpawnPosition = coin.transform.position = position;
            coin.SetEffect(GetRandomEffect());
        }

        private BaseEffectSettings GetRandomEffect()
        {
            return _effectListSettings.Effects[Random.Range(0, _effectListSettings.Effects.Count)];
        }
    }
}