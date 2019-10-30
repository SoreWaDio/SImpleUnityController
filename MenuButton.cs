using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public System.Action OnButtonClick;

    protected virtual void Start()
    {
        var _button = GetComponent<Button>();
        _button.onClick.AddListener(ClickAction);
        

        AdditionalStart();
    }

    protected override void AdditionalStart()
    {

    }

    protected virtual void ClickAction()
    {
        OnButtonClick?.Invoke();
        Debug.Log("click", gameObject);
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
