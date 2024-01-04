using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    public Sprite sprite1, sprite2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            GetComponent<SpriteRenderer>().sprite = sprite2;
        }
    }
}
