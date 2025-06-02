using UnityEngine;
using Managers;
using System;

public class GameSectionBaseController : MonoBehaviour
{

    internal GameStatus gameStatus = GameStatus.None;

    [SerializeField]
    internal CanvasGroup canvasGroup;

    internal Action OnSectionActive;
    internal Action OnSectionInactive;

    protected GameStatusManager gamestatusManager;


    protected void Init()
    {
        gamestatusManager = GameStatusManager.instance;
        canvasGroup = GetComponent<CanvasGroup>();
        OnSectionActive += ActivateSection;
        OnSectionInactive += DeactivateSection;
    }

    protected void HideSection(bool hide)
    {
        if (hide)
            canvasGroup.alpha = 0;
        else
            canvasGroup.alpha = 1;
        canvasGroup.interactable = !hide;
        canvasGroup.blocksRaycasts = !hide;
    }

    protected virtual void ActivateSection()
    {
        Debug.Log("Base ActivateSection method activated");
        HideSection(false);
    }

    protected virtual void DeactivateSection()
    {
        Debug.Log("Base ActivateSection method activated");
        HideSection(true);
    }

}
