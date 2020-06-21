using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFlip : MonoBehaviour
{
    private playerMovement PM;
    public bool isFlipped;

    private void Start()
    {
        PM = GameObject.FindObjectOfType<playerMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        if (PM.movement.x > 0.01f)
        {
            isFlipped = true;
            transform.localScale = new Vector3(-6.456f, 6.456f, 6.456f);
        }
        else if (PM.movement.x < -0.01f)
        {
            isFlipped = false;
            transform.localScale = new Vector3(6.456f, 6.456f, 6.456f);
        }
    }
}
