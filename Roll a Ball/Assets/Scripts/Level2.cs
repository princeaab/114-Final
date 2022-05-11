using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    //[SerializeField] GameObject player;
    //controlScript inst;

    public GameObject platform;
    public GameObject cube;

    // Called before start
    //void Awake()
    //{
    //    //inst = player.GetComponent<controlScript>();
    //    //inst.count = 5; < access to count variable from other script
    //}

    private void Start()
    {
        platform.SetActive(false);
        cube.SetActive(false);
    }

    public void CheckSetup(int count)
    {
        if(count == 11)
        {
            platform.SetActive(true);
            cube.SetActive(true);
        }
    }
}
