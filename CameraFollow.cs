using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float boundTop = 2f;
    public float boundBottom = -2f;
    public float smoothSpeed = 0.125f;
    public float bound2Top = 1f;
    public float bound2Bottom = -1f;
    void LateUpdate()
    {
        float yPos = (target.transform.position.y < transform.position.y + bound2Top && target.transform.position.y > transform.position.y + bound2Bottom) ? 
            transform.position.y : Mathf.Lerp(transform.position.y, target.position.y, Time.deltaTime * smoothSpeed);

        transform.position = new Vector3(target.position.x, 
            Mathf.Clamp(yPos, target.position.y + boundBottom, target.position.y + boundTop), 
            transform.position.z);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(new Vector3(target.position.x, transform.position.y, target.position.z), new Vector3(1, Mathf.Abs(boundBottom) + boundTop, 1));
        Gizmos.DrawWireCube(new Vector3(target.position.x, transform.position.y, target.position.z), new Vector3(1, Mathf.Abs(bound2Bottom) + bound2Top, 1));
    }
}
