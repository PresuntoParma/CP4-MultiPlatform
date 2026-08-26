using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public StateMachine machine {  get; private set; }
    public MenuState menuState;
    public GameState gameState;
    public GameOverState gameOverState;

    public Action OnScoreChange;

    public int score;

    public bool playing;

    private void Awake()
    {
        SingletonSetup();
        StateMachineSetup();
    }

    private void Start()
    {
        machine.ChangeState(menuState);
    }

    public void AddScore(int ammount)
    {
        score += ammount;
        OnScoreChange();
    }

    private void SingletonSetup()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        instance = this;

        DontDestroyOnLoad(this);
    }

    private void StateMachineSetup()
    {
        machine = new StateMachine();
        menuState = new MenuState(this);
        gameState = new GameState(this);
        gameOverState = new GameOverState(this);
    }

    public void StartGame()
    {
        machine.ChangeState(gameState);
    }
}
