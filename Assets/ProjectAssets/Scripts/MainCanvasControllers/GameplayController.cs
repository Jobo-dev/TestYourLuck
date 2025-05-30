using UnityEngine;
using UnityEngine.UI;

public class GameplayController : GameSectionBaseController
{

    [SerializeField] Button pauseButton;

    void Start()
    {
        gameStatus = GameStatus.MainMenu;
        base.Init();
        HideSection(false);

    }
}
