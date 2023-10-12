using Runner.Core;
using UnityEngine;
using Zenject;

namespace Runner.Renderer
{
    public class CoinDetector : MonoBehaviour, ICoinDetector
    {
        [Inject] 
        private IEffectContainer _effectContainer;
        [Inject] 
        private EffectFactory _effectFactory;

        public Vector3 Position => transform.position;
        
        private void OnTriggerEnter(Collider other)
        {
            CoinRenderer coinRenderer = other.GetComponent<CoinRenderer>();
            if (coinRenderer != null)
            {
                _effectContainer.AddEffect(_effectFactory.Create(coinRenderer.EffectSettings));
                coinRenderer.Despawn();
            }
        }
    }
}