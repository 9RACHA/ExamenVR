using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positioner : MonoBehaviour
{
    public Transform startPosition;
    // Start is called before the first frame update
    void Start()
    {
        if(startPosition == null) {
            Debug.Log("StartPositioner.Start Non está establecido startPosition");
        } else {
            transform.position = startPosition.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -2) {
            transform.position = startPosition.position;
        }
    }
}