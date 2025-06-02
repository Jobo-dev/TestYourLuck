using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : GameSectionBaseController
{

    [SerializeField] private Button startButton;
    [SerializeField] private Button configButton;
    [SerializeField] private Button exitButton;

    


    void Awake()
    {
        gameStatus = GameStatus.MainMenu;
        base.Init();
        HideSection(false);
        startButton.onClick.AddListener(StartGame);
    }


    private void StartGame()
    {
        base.HideSection(true);
        ManagerVault.instance.gameStatusManager.SetGameStatus(GameStatus.Gameplay);
    }

}
