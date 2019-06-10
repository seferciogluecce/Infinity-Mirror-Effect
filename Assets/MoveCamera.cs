using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int increment = 22;
    float sensitivity = 22;
    float minFov = 15;
    Vector3 initPos;
    float maxFov = 90;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(0, 0, increment * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(0, 0, -increment * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, increment * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, -increment * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(increment * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(-increment * Time.deltaTime, 0, 0);
        }






        Vector3 mousepos = Input.mousePosition;
        mousepos.z = -Camera.main.transform.position.z;

        mousepos = Camera.main.ScreenToWorldPoint(mousepos);


        if (Input.GetKeyDown(KeyCode.Mouse0)){
            initPos = mousepos;
        }

        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            this.transform.Translate( (initPos.x- mousepos.x)*Time.deltaTime, (initPos.y - mousepos.y) * Time.deltaTime, 0);

        }

    }
}
