using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    protected Stack<MenuWindow> _history;

    void Start()
    {
        _history = new Stack<MenuWindow>();
    }

    public void AddToHistory(MenuWindow closedWondow)
    {
        _history.Push(closedWondow);
    }

    public void GoBack()
    {
        if (_history.Count > 0)
        {
            _history.Pop().Open();
        }
    }
}
