using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZooming : MonoBehaviour {

    public float offset;
    public float speed;
    //x - min y - max
    public Vector2 minMaxXPosition;
    public Vector2 minMaxYPosition;
    private float screenWidth;
    private float screenHeight;
    private Vector3 cameraMove;
    // Use this for initialization
    void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        cameraMove.x = transform.position.x;
        cameraMove.y = transform.position.y;
        cameraMove.z = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        //Move camera
        if ((Input.mousePosition.x > screenWidth - offset) && transform.position.x < minMaxXPosition.y)
        {
            cameraMove.x += MoveSpeed();
        }
        if ((Input.mousePosition.x < offset) && transform.position.x > minMaxXPosition.x)
        {
            cameraMove.x -= MoveSpeed();
        }
        if ((Input.mousePosition.y > screenHeight - offset) && transform.position.y < minMaxYPosition.y)
        {
            cameraMove.y += MoveSpeed();
        }
        if ((Input.mousePosition.y < offset) && transform.position.y > minMaxYPosition.x)
        {
            cameraMove.y -= MoveSpeed();
        }
        transform.position = cameraMove;


        //scrool
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && Camera.main.orthographicSize > 1.0f) // forward
        {
            Camera.main.orthographicSize += 0.1f;
          
            //minMaxXPosition.x = minMaxXPosition.x - (minMaxXPosition.x * 1.02f);
            //minMaxXPosition.y = minMaxXPosition.y + (minMaxXPosition.y * 1.02f);
            //minMaxYPosition.x = minMaxXPosition.x - (minMaxXPosition.x * 1.02f);
            //minMaxYPosition.y = minMaxXPosition.y + (minMaxXPosition.y * 1.02f);

            //transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && Camera.main.orthographicSize < 5.0f) // back
        {
            Camera.main.orthographicSize -= 0.1f;
            //minMaxXPosition.x = minMaxXPosition.x + (minMaxXPosition.x * 1.02f);
            //minMaxXPosition.y = minMaxXPosition.y - (minMaxXPosition.y * 1.02f);
            //minMaxYPosition.x = minMaxXPosition.x + (minMaxXPosition.x * 1.02f);
            //minMaxYPosition.y = minMaxXPosition.y - (minMaxXPosition.y * 1.02f);

        }
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, 1.0f, 5.0f);
        Debug.Log(minMaxXPosition.x + "  " + minMaxXPosition.y);
    }

    float MoveSpeed()
    {
        return speed * Time.deltaTime;
    }

    


}
