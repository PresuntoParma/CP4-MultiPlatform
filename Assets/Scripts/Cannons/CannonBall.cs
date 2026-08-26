using UnityEngine;

public class CannonBall : MonoBehaviour
{
    private void Deactivate()
    {
        this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.machine.ChangeState(GameManager.instance.gameOverState);
        }
        else if (other.gameObject.CompareTag("Wall"))
        {
            GameManager.instance.AddScore(1);
            Deactivate();
        }
    }
}
