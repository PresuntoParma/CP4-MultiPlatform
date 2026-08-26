using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuState : IGameStates
{
    public GameManager gm;
    public MenuState(GameManager gm)
    {
        this.gm = gm;
    }

    public void Enter()
    {

    }

    public void Exit()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void FixedTick()
    {

    }

    public void Tick()
    {

    }
}
