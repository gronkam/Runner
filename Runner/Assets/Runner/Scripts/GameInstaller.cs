using Runner.Core;
using Runner.Renderer;
using UnityEngine;
using Zenject;

namespace Runner
{
    public class GameInstaller: MonoInstaller<GameInstaller>
    {
        [SerializeField] private CoinSpawner _coinSpawner;
        [SerializeField] private GameObject _coinPrefab;
        [SerializeField] private GameObject _playerPrefab;
        
        [SerializeField] private CharacterSettings _characterSettings;
        [SerializeField] private EffectListSettings _effectList;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<TimeManager>().AsSingle().NonLazy();
            
            Container.Bind<CharacterSettings>().FromInstance(_characterSettings).AsSingle().NonLazy();
            Container.Bind<EffectListSettings>().FromInstance(_effectList).AsSingle().NonLazy();
            
            Container.BindInterfacesAndSelfTo<Character>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<EffectFactory>().AsSingle().NonLazy();
            
            Container.BindMemoryPool<CoinRenderer, CoinRenderer.Pool>()
                .WithInitialSize(10)
                .FromComponentInNewPrefab(_coinPrefab)
                .UnderTransformGroup("Coins");
            
            Container.BindInterfacesAndSelfTo<CoinSpawner>().FromInstance(_coinSpawner).AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<CoinDetector>().FromComponentOn(_playerPrefab).AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<CharacterRenderer>().FromComponentOn(_playerPrefab).AsSingle().NonLazy();
        }
    }
}