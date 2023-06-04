using UnityEngine;

public class DebugTowerSelectorUI : MonoBehaviour
{
    [SerializeField] private DebugTowerSelectorButtonUI _prefab;
    [SerializeField] private Transform _contentRoot;
    [SerializeField] private DebugTowerSelector _selector;
    
    private void Start()
    {
        _selector.GetAllTowerInfo.ForEach(pair =>
        {
            var button = Instantiate(_prefab, _contentRoot);
            button.gameObject.SetActive(true);
            button.Init(() => _selector.TrySelect(pair.Item1), pair.Item1, pair.Item2);
            _selector.OnSelectionStateChanged += (tower, selected) =>
            {
                if (tower == pair.Item1)
                {
                    button.SelectedState = selected;
                }
            };
        });
    }
}
