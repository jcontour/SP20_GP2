using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertPrefabOnInput : MonoBehaviour
{

    public GameObject ball_prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // how to put exact copy of prefab in scene.
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(ball_prefab);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 mouseOnScreen = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));

            GameObject b = Instantiate(ball_prefab);
            b.transform.position = mouseOnScreen;
        }
        

    }
}
