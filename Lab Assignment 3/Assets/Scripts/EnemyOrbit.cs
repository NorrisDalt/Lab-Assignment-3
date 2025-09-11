using UnityEngine;

public class EnemyOrbit : MonoBehaviour
{
    public Transform player;
    public float orbitSpeed = 2f;
    public float moveSpeed = 3f;

    void FixedUpdate()
    {
        Vector2 toPlayer = player.position - transform.position;

        float angle = Mathf.Atan2(toPlayer.y, toPlayer.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90f);

        Vector2 perpendicular = new Vector2(-toPlayer.y, toPlayer.x).normalized;
        transform.position += (Vector3)(perpendicular * orbitSpeed * Time.fixedDeltaTime);
    }
}

