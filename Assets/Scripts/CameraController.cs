
using UnityEngine;
using UnityEngine.Accessibility;


public class CameraController : MonoBehaviour
{
    private bool doMovement = true;
    public float panSpeed = 30f;
    public float panBorderTicknes = 10f;
    public float scrollSpeed = 5f;
    public float minY = 30f;
    public float maxY = 200f;

    void Update()
    {
        if (gameManager.GameIsOver)
        {
            this.enabled = false;
            return;
        }


        
        if (Input.GetKeyDown(KeyCode.Escape))   // ???????????????
        {
            doMovement = !doMovement;
        }

        if (!doMovement)
        {
            return;
        }

        
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height-panBorderTicknes)
        {
            
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime,Space.World);

        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderTicknes)
        {

            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderTicknes)
        {

            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey("a") || Input.mousePosition.x <=panBorderTicknes)
        {

            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
            
        }
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scroll * 10000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;

    }
}
