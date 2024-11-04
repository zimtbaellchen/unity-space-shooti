using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spaceship : MonoBehaviour
{
    public float moveSpeed;
    public GameObject laserObject;
    public GameObject cannonLeft;
    public GameObject cannonRight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
        
    }

    void Movement()
    {
        Vector3 movement = Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -23, 23);
        transform.position = position;

       // Vector3 rotation = Vector3.forward * Input.GetAxis("Horizontal") * moveSpeed* -8 * Time.deltaTime;
        //transform.Rotate(rotation);



    }

    void Shooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserObject, cannonRight.transform.position, laserObject.transform.rotation);
            Instantiate(laserObject, cannonLeft.transform.position, laserObject.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        GameManager.instance.gameOver = true;
    }






}
