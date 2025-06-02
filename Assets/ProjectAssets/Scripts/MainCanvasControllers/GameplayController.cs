using UnityEngine;
using UnityEngine.UI;

public class GameplayController : GameSectionBaseController
{

    [SerializeField] Button pauseButton;

    void Awake()
    {
        this.gameStatus = GameStatus.Gameplay;
        base.Init();
        HideSection(true);

    }

    protected override void ActivateSection()
    {
        base.ActivateSection();

    }

    protected override void DeactivateSection()
    {
        base.ActivateSection();

    }

}
