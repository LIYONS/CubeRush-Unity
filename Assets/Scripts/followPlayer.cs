using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;

    public Vector3 offSet;

    void Update()
    {
        transform.position=player.position + offSet;
    }
}
