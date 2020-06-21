using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;
    public int health;
    public int armor;
    public int armorCounter;

    bool is1 = false;
    bool is2 = false;
    bool is3 = false;

    public Transform chestplateHolder;
    public Transform shieldHolder;
    public Transform shoeHolder;

    public Rigidbody2D rb;
    public Rigidbody2D rb2;
    public GameObject chestPlate;
    public GameObject shield;
    public GameObject shoes;
    public Camera cam;

    private SliderScript SC;

    public Vector2 movement;
    Vector2 mousePos;

    private void Awake()
    {
        SC = GameObject.FindObjectOfType<SliderScript>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb2.rotation = angle;

        armorSpawner();
    }

    public void damage(int damage)
    {
        if(armor <= 0)
        {
            health -= damage;
            SC.UpdateHealth(health);
        }
        else
        {
            armor -= damage;
            SC.UpdateArmor(armor);
        }
        if(health < 0)
        {
            Destroy(gameObject);
        }
    }
    public void addArmor(int ammount)
    {
        armor += ammount;
        SC.UpdateArmor(armor);
    }
    private void armorSpawner()
    {
        if(armorCounter == 1 && !is1)
        {
            Debug.Log("hi");
            is1 = true;
            GameObject chestplate = Instantiate(chestPlate, chestplateHolder.position, Quaternion.identity);
            chestplate.transform.parent = gameObject.transform;
            addArmor(2);
        }
        if(armorCounter == 2 && !is2)
        {
            is2 = true;
            GameObject shieldObject = Instantiate(shield, shieldHolder.position, Quaternion.identity);
            shieldObject.transform.parent = gameObject.transform;
            addArmor(1);
        }
        if (armorCounter == 3 && !is3)
        {
            is3 = true;
            GameObject shoesObject = Instantiate(shoes, shoeHolder.position, Quaternion.identity);
            shoesObject.transform.parent = gameObject.transform;
            addArmor(1);
        }
    }
}
