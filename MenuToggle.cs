using UnityEngine;
using UnityEngine.UI;

public class MenuToggle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
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

        AdditionalStart();
    }

    protectet virtual void AdditionalStart()
    {

    }

    protected virtual void SetAction(bool value)
    {
        Debug.Log("set" + value, gameObject);
    }

    protected virtual void HoverAction()
    {
        Debug.Log("hover", gameObject);
    }

    protected virtual void UnHoverAction()
    {
        Debug.Log("unhover", gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        UnHoverAction();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        HoverAction();
    }
}
