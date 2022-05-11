using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class controlScript : MonoBehaviour
{
    public int speed = 25;
    public Rigidbody rb;
    public int count = 0;
    public Text countText;
    public Text win;
    public Button restart;
    public Button nextLVL;
    private int level = 0;
    private Controls cont;
    private void Awake()
    {
        cont = new Controls();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // move to awake?
        count = 0;
        SetCountText();
        win.text = "";
        Debug.Log("Level " + level);
    }

    // Fixed update is used with physics
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    { // Collider.OnTriggerEnter(Collider) gives us the notice of touch without creating a physical contact
        // called when an object first touches a trigger collider
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            if(count < 12)
                LevelSpecialties();
        }
        if(other.gameObject.CompareTag("Boundary"))
        {
            gameObject.SetActive(false);
            restart.gameObject.SetActive(true);
        }
    }
    // go to Pick Up objects > Box Collider > Is Trigger (Check)
    // Unity holds a cache for static colliders
    // since our collider items are rotating, the cache is being reset each frame and taking up memory
    // we must make these colliders dynamic by giving it a rigid body
    // lastly, we will enable Is Kinematic in the rigid body
    // with this, no physics applies to the object rather than just toggling gravity

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        {
            countText.enabled = false;
            restart.gameObject.SetActive(true);
            nextLVL.gameObject.SetActive(true);
            win.text = "You've won!";
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        level = level + 1;
        SceneManager.LoadScene(level);
        //SceneManager.LoadScene(SceneManager.GetSceneByPath("Assets/Scenes/Level2.unity").buildIndex);
    }

    // UI Menu

    private void OnEnable()
    {
        cont.Player.Menu.performed += openMenu;
        cont.Player.Menu.Enable();
    }

    public GameObject menu;
    private void openMenu(InputAction.CallbackContext obj)
    {
        Debug.Log("Open Menu");
        if(menu.activeInHierarchy)
        {
            menu.SetActive(false);
        }
        else
        {
            menu.SetActive(true);
        }
    }

    private void OnDisable()
    {
        cont.Player.Menu.Disable();
    }

    public void endGame()
    {
        Application.Quit();
    }
    
    public void close()
    {
        menu.SetActive(false);
    }

    // Levels

    void LevelSpecialties()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameObject plane = GameObject.Find("Plane");
            Level2 inst = plane.GetComponent<Level2>();
            inst.CheckSetup(count);
        }
    }
}
