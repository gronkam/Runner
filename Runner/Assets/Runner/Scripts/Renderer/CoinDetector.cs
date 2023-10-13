using Runner.Core;
using UnityEngine;
using Zenject;

namespace Runner.Renderer
{
    // Detects collisions with coins and applies effects
    public class CoinDetector : MonoBehaviour, ICoinDetector
    {
        [Inject] 
        private IEffectContainer _effectContainer;  // Injected effect container

        public Vector3 Position => transform.position;  // Detector position
        
        // Triggered on collision with another collider
        private void OnTriggerEnter(Collider other)
        {
            CoinRenderer coinRenderer = other.GetComponent<CoinRenderer>();
            if (coinRenderer != null)
            {
                _effectContainer.AddEffect(coinRenderer.EffectSettings);
                coinRenderer.Despawn();
            }
        }
    }
}