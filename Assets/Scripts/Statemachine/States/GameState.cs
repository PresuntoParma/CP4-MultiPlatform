using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : IGameStates
{
    public GameManager gm;
    public GameState(GameManager gm)
    {
        this.gm = gm;
    }

    public void Enter()
    {
        gm.score = 0;
        gm.playing = true;
        SceneManager.LoadScene("GameScene");
    }

    public void Exit()
    {
        gm.playing = false;
    }

    public void FixedTick()
    {

    }

    public void Tick()
    {

    }
}
