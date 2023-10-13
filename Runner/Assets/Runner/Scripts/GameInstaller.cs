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
            //Install managers
            Container.BindInterfacesAndSelfTo<TimeManager>().AsSingle().NonLazy();
            
            //Install settings
            Container.Bind<CharacterSettings>().FromInstance(_characterSettings).AsSingle().NonLazy();
            Container.Bind<EffectListSettings>().FromInstance(_effectList).AsSingle().NonLazy();
            
            //Install effects
            Container.BindInterfacesAndSelfTo<EffectFactory>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<EffectListContainer>().AsSingle().NonLazy();
            
            //Install character
            Container.BindInterfacesAndSelfTo<Character>().AsSingle().NonLazy();
            
            //Install coin pool
            Container.BindMemoryPool<CoinRenderer, CoinRenderer.Pool>()
                .WithInitialSize(10)
                .FromComponentInNewPrefab(_coinPrefab)
                .UnderTransformGroup("Coins");
            
            //Install coin spawner
            Container.BindInterfacesAndSelfTo<CoinSpawner>().FromInstance(_coinSpawner).AsSingle().NonLazy();
            
            //install character renderer
            Container.BindInterfacesAndSelfTo<CoinDetector>().FromComponentOn(_playerPrefab).AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<CharacterRenderer>().FromComponentOn(_playerPrefab).AsSingle().NonLazy();
        }
    }
}