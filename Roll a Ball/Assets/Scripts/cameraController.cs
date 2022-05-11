using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Controls1 cont;

    // script created to avoid putting MainCamera into the player
    // When camera is inside the player it rolls along with the ball's rotation
    // The goal is to remove that rotation

    private void Awake()
    {
        cont = new Controls1();
    }

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame, however
    // LateUpdate is best to use for follow cameras, procedural animation and gathering last-known states
    // guaranteed to run after all items have been processed in update (know absolutely that the player has moved for that frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    private void OnEnable()
    {
        cont.Player.Menu.performed += doPanLeft;
        cont.Player.Menu.Enable();
        cont.Player.PanLeft.performed += doPanLeft;
        cont.Player.PanLeft.Enable();
        cont.Player.PanRight.performed += doPanRight;
        cont.Player.PanRight.Enable();
    }

    public Camera cam;

    void doPanLeft(InputAction.CallbackContext obj)
    {
        // change mainCamera transform
        Debug.Log("Pan left");
        Debug.Log(offset.ToString());
        if (offset == new Vector3(0f, 8.5f, -9f))
        {
            
            offset = new Vector3(-9f, 9f, 0f); // not adding to previous values because I'm using if statements, haven't found a function
                                               //Transform tran = GetComponent<Transform>();
            transform.rotation = Quaternion.Euler(Vector3.right * 45);

            //transform.Rotate(45, 90, -45);
            //transform.LookAt(player.transform);
            //transform.Rotate(new Vector3(0f,90f,0f));
            //transform.rotation.SetLookRotation(new Vector3(45f, 90f, 0));
            //transform.SetPositionAndRotation(offset, offset.);
            //tran.rotation.eulerAngles.Set(45f, 90f, 0);
            //transform.rotation.eulerAngles.Set(45f, 90f, 0);
            //transform.rotation.SetFromToRotation(transform.rotation.eulerAngles, new Vector3(45f, 90f, 0));
            //eulerAngles = new Vector3(45f, 90f, 0f);
            //transform.Rotate(new Vector3(45f,90f,0f));
        }
        //offset = 
        //Vector3 addition = new Vector3(0f,45f,0f);
        //Transform tran = GetComponent<Transform>();
        //transform.Translate(player.); // (-,+) for

        //transform.Rotate(transform.rotation.eulerAngles + addition);
        //tran.rotation.Set(tran.rotation + );
        //transform.rotation.SetFromToRotation(transform.rotation.eulerAngles, transform.rotation.eulerAngles + addition);

    }

    void doPanRight(InputAction.CallbackContext obj)
    {
        Debug.Log("Pan right");
        if (offset == new Vector3(0f, 9f, -9f))
        {
            offset = new Vector3(-9f, 9f, 0f); // not adding to previous values because I'm using if statements, haven't found a function
            transform.Rotate(new Vector3(0f, 90f, 0f));
        }
        //Vector3 addition = new Vector3(0f, -45f, 0f);
        //transform.Rotate(transform.rotation.eulerAngles + addition);
        //transform.rotation.SetFromToRotation(transform.rotation.eulerAngles, transform.rotation.eulerAngles + addition);
    }

    private void OnDisable()
    {
        cont.Player.Menu.Disable();
        cont.Player.PanLeft.Disable();
        cont.Player.PanRight.Disable();
    }
}
