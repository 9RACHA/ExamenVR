using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDrawer : MonoBehaviour
{
    private Vector3 initPosition;

    private bool locked;
    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position;
        locked = true;

        //BrazoBalanza.OnWeightChanged += checkLockState;
    }

    // Update is called once per frame
    void Update()
    {
        if(locked) {
            transform.position = initPosition;
        }
    }

    private void checkLockState(bool pesoCorrecto) {
        locked = ! pesoCorrecto;
    }
}