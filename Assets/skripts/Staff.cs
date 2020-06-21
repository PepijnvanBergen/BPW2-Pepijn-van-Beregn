using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    private float shootTime = 0f;
    public float timeBetweenShot;

    public Transform staffLocation;
    public float offset;
    public float flippedOffset;
    private playerFlip PF;

    public GameObject projectile;
    public Transform shotPoint;

    private void Start()
    {
        PF = GameObject.FindObjectOfType<playerFlip>();
    }
    void Update()
    {
        float weaponOffset = 0f;
        //transform.position = staffLocation;
        if (PF.isFlipped) weaponOffset = flippedOffset; else if (!PF.isFlipped) weaponOffset = offset;

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + weaponOffset);

        if(shootTime <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, shotPoint.position, transform.rotation);
                shootTime = timeBetweenShot;
            }
        }
        else
        {
            shootTime -= Time.deltaTime;
        }
    }
}
