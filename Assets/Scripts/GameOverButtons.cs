using UnityEngine;

public class GameOverButtons : MonoBehaviour
{
    public void Menu()
    {
        GameManager.instance.machine.ChangeState(GameManager.instance.menuState);
    }

    public void TryAgain()
    {
        GameManager.instance.StartGame();
    }
}
