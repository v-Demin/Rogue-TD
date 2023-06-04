using System;
using System.Collections.Generic;
using System.Linq;
using Submodules.Common.Collections;
using UnityEngine;

public class DebugTowerSelector : MonoBehaviour
{
    public Action<TowerId, bool> OnSelectionStateChanged;
    [SerializeField] private List<TowerId> _baseSelectedTowers = new ();
    private EnumDictionary<TowerId, bool> _towerSelections = new ();

    private void Start()
    {
        _baseSelectedTowers.ForEach(tower =>
        {
            ChangeSelectionState(tower, true);
        });
    }

    public bool GetSelectionStatus(TowerId towerId) => _towerSelections[towerId];

    public List<TowerId> GetSelectedTowers() =>
        _towerSelections.Dictionary.ToList()
            .Where(pair => GetSelectionStatus(pair.Key))
            .Select(pair => pair.Key)
            .ToList();

    public List<(TowerId, bool)> GetAllTowerInfo =>
        _towerSelections.Dictionary.ToList().Select(pair => (pair.Key, pair.Value)).ToList();

    public void TrySelect(TowerId towerId)
    {
        ChangeSelectionState(towerId, !_towerSelections[towerId]);
    }

    private void ChangeSelectionState(TowerId towerId, bool selectionState)
    {
        _towerSelections[towerId] = selectionState;
        OnSelectionStateChanged?.Invoke(towerId, selectionState);
    }
}
