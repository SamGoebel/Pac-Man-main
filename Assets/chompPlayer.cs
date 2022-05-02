using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chompPlayer : MonoBehaviour
{
   // private Player thePlayer = new Player("Sam");
    private Rigidbody rb;
    public float speed = 20f;
  

    // Start is called before the first frame update
    void Start()
    {
       // CORE.setPlayer(thePlayer);
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

   // public Player getPlayer()
   // {
    //    return this.thePlayer;
    //}



    // Update is called once per frame
    void Update()
    {
        //print(thePlayer.getName());
        if (Input.GetKeyDown("up"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;
        }

    }
}
