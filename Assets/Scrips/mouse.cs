using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    [SerializeField] GameObject a;
    GameObject b;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            b = Instantiate(a);
            b.transform.position = Input.mousePosition;
        }
    }   
}
