using System;
using Common.Services;
using UnityEngine;
using Zenject;

public class SceneControler : MonoBehaviour
{
    [Inject] private readonly ProviderCommutator _commutator;

    private void Start()
    {
        _commutator.BattlefieldScene.StartScene(new());
    }
}
