using UnityEngine;
using UnityEngine.UI;

public class MenuToggle : MonoBehaviour
{
    protected GameObject _checkmark;

    protected virtual void Start()
    {
        var _toggle = GetComponent<Toggle>();
        _toggle.onValueChanged.AddListener(SetAction);

        _checkmark = _toggle.graphic.gameObject;

        //add to toggle group
        var _group = GetComponentInParent<ToggleGroup>();
        if (_group != null)
        {
            _toggle.group = _group;
        }
    }

    protected virtual void SetAction(bool value)
    {
        Debug.Log("set" + value, gameObject);
    }
}
