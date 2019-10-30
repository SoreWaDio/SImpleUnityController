using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWindow : MonoBehaviour
{
    [Header("NextWindow")]
    [SerializeField] protected MenuWindow _nextWindow;

    [Header("Menu")]
    [SerializeField] private Menu _menu;

    protected virtual void Start()
    {
        if (_menu == null)
        {
            _menu = GetComponentInParent<Menu>();
        }
    }
    
    public virtual void Open()
    {
        gameObject.SetActive(true);
    }

    protected virtual void Close()
    {
        _menu.AddToHistory(this);
        gameObject.SetActive(false);
    }

    protected virtual void OpenNextWindow(MenuWindow nextWindow)
    {
        if(nextWindow == null)
        {
            Debug.LogAssertion("Window is not assigned", gameObject);
            return;
        }

        Close();
        nextWindow.Open();
    }

    public virtual void GoBack()
    {
        gameObject.SetActive(false);
        _menu.GoBack();
    }
}
