using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void Update()
    {
        Vector3 targetPos = player.position + offset;
        targetPos.x = 0;
        targetPos.y += 2;
        transform.position = targetPos;
    }
}
