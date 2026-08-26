using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverState : IGameStates
{

    public GameManager gm;
    public GameOverState(GameManager gm)
    {
        this.gm = gm;
    }

    public void Enter()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void Exit()
    {

    }

    public void FixedTick()
    {

    }

    public void Tick()
    {

    }
}
