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
        SceneManager.LoadScene("MenuScene");
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
