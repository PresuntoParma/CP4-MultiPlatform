using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public StateMachine machine {  get; private set; }
    public MenuState menuState;
    public GameState gameState;
    public GameOverState gameOverState;

    public int score;

    private void Awake()
    {
        SingletonSetup();
        StateMachineSetup();
    }

    public void AddScore(int ammount)
    {
        score += ammount;
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
}
