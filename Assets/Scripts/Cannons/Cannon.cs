using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private PoolManager poolManager;

    [SerializeField] private float ballSpeed;

    public void Fire()
    {
        var ball = poolManager.GetBall();
        if (ball == null)
            return;

        ball.SetActive(true);
        ball.transform.position = transform.position;
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.back * ballSpeed;
    }
}
