using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{

    private GameObject mainCamera;

    
    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {

        if (mainCamera.transform.position.z >= this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
