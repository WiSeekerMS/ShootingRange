﻿using Common;
using Common.Audio;
using Factories;
using FPS;
using Target;
using UI;
using UnityEngine;
using Utils.Extensions;
using Zenject;

namespace Bootstrap
{
    public class MainInstaller : MonoInstaller
    {
        [SerializeField] private SettingsPanel _settingsPanel;
        [SerializeField] private GameUIController _gameUIController;
        [SerializeField] private AudioController _audioController;
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private TargetCreator _targetCreator;
        [SerializeField] private FPSController _fpsController;
        
        public override void InstallBindings()
        {
            Container.InstallRegistry(_settingsPanel);
            Container.InstallRegistry(_gameUIController);
            Container.InstallRegistry(_audioController);
            Container.InstallRegistry(_gameManager);
            Container.InstallRegistry(_targetCreator);
            Container.InstallRegistry(_fpsController);

            BindFactories();
        }

        private void BindFactories()
        {
            Container
                .BindFactory<FlyingBullet, BulletFactory>()
                .AsSingle();
        }
    }
}