using Runner.Core;
using UnityEngine;
using Zenject;

namespace Runner.Renderer
{
    public class CoinDetector : MonoBehaviour, ICoinDetector
    {
        [Inject] 
        private IEffectContainer _effectContainer;

        public Vector3 Position => transform.position;
        
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