using System;
using Common.Services;
using Submodules.Common.Collections;
using UnityEngine;
using Zenject;

public class DebugSceneControler : MonoBehaviour
{
    [Inject] private readonly ProviderCommutator _commutator;

    [SerializeField] private DebugTowerSelector _selector;
    
#if !UNITY_EDITOR
    private void Start()
    {
        LoadBattleScene();
    }
#endif

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadBattleScene();
        }
    }

    public void LoadBattleScene()
    {
        _commutator.BattlefieldScene.StartScene(new (_selector.GetSelectedTowers()));
    }
}
