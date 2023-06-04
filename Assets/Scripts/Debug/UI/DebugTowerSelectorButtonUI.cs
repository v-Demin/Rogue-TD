using System;
using TMPro;
using UnityEngine;

public class DebugTowerSelectorButtonUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMesh;
    [SerializeField] private GameObject _activeRoot;
    [SerializeField] private GameObject _deactiveRoot;
    
    private TowerId _towerId;
    private bool _selectedState;
    private Action _action;

    public bool SelectedState
    {
        get => _selectedState;
        set
        {
            _selectedState = value;
            UpdateState();
        }
    }

    public void Init(Action action, TowerId towerId, bool selectedState)
    {
        _action = action;
        _towerId = towerId;
        _selectedState = selectedState;
        _textMesh.text = towerId.ToString();
        UpdateState();
    }
    
    public void InvokeAction()
    {
        _action.Invoke();
    }

    private void UpdateState()
    {
        _activeRoot.SetActive(SelectedState);
        _deactiveRoot.SetActive(!SelectedState);
    }
}
