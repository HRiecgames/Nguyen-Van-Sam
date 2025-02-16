using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelMain : MonoBehaviour, IMenu
{
    [SerializeField] private Button btnTimer;

    [SerializeField] private Button btnMoves;

    [SerializeField] private Button btnRestart;

    private UIMainManager m_mngr;
    private int _level_index = 0;

    private void Awake()
    {
        btnMoves.onClick.AddListener(OnClickMoves);
        btnTimer.onClick.AddListener(OnClickTimer);
        btnRestart.onClick.AddListener(OnClickRestart);
    }

    private void OnDestroy()
    {
        if (btnMoves) btnMoves.onClick.RemoveAllListeners();
        if (btnTimer) btnTimer.onClick.RemoveAllListeners();
    }

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    private void OnClickRestart()
    {
        if (_level_index == 0)
        {
            m_mngr.LoadLevelTimer();
        } else if (_level_index == 1)
        {
            m_mngr.LoadLevelMoves();
        }
    }

    private void OnClickTimer()
    {
        _level_index = 0;
        m_mngr.LoadLevelTimer();
    }

    private void OnClickMoves()
    {
        _level_index = 1;
        m_mngr.LoadLevelMoves();
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
