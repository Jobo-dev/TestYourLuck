using System.Collections.Generic;
using System;
using UnityEngine;

public enum GameStatus
{
    MainMenu,
    Gameplay,
    Config,
    GameOver,
    Bank,
    Tutorial,
    Pause,
    Settings,
    None
}

namespace Managers
{
    public class GameStatusManager : MonoBehaviour
    {
        public static GameStatusManager instance;

        [SerializeField] internal GameStatus currentStatus = GameStatus.MainMenu;
        [SerializeField] internal GameStatus previousStatus = GameStatus.None;

        [SerializeField] private List<GameSectionBaseController> gameSectionElementsList;
        private Dictionary<GameStatus, GameSectionBaseController> gameSectionDictionary;
        private Action<GameStatus> OnGameStatusChanged;


        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }

        private void Start()
        {
            gameSectionDictionary = new Dictionary<GameStatus, GameSectionBaseController>();
            if(gameSectionElementsList.Count != 0)
            {
                foreach (GameSectionBaseController controller in gameSectionElementsList)
                {

                    gameSectionDictionary.Add(controller.gameStatus, controller);
                    Debug.Log($"Set controller {controller.GetType()} with " +
                        $"the key {controller.gameStatus.ToString()}");
                }
            }
            else
            {
                Debug.LogWarning($"{GetType()} Warning: The game selection elements list is empty");
                
            }


                OnGameStatusChanged += GameStatusChanged;
        }

        internal void SetGameStatus(GameStatus status)
        {
            previousStatus = currentStatus;
            currentStatus = status;
            OnGameStatusChanged?.Invoke(status);
        }

        private void GameStatusChanged(GameStatus status)
        {
            Debug.Log($"Action called because a status changed. Key: {status.ToString()}");
            gameSectionDictionary[status].OnSectionActive?.Invoke();
        }

        private void ExitGame()
        {
            Application.Quit();
        }
    }
}