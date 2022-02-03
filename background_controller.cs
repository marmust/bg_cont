using UnityEngine;

public class background_controller : MonoBehaviour
{
    public Transform camera;
    public Transform bg;
    public float bgSpeed;
    public float offsetX;
    public float offsetY;

    void Update()
    {
        bg.transform.position = new Vector2(camera.transform.position.x * bgSpeed + offsetX, camera.transform.position.y * bgSpeed + offsetY);
    }
}