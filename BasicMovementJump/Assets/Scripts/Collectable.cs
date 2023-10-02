using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int collectableValue;
    //we need a reference to player score .cs script that script is attached to the paler

    public GameObject playerObject;
    private PlayerScore gameScore;

    // Start is called before the first frame update
    void Start()
    {
        //find the object that has the plarescore.cs sript attached to it 
        //can use .find but should avoid if u can
        //by making the player object variable publuc we can use unity editor to link the varible with the object which will allow us to acces the script 
        //can do tis but nit required at this time 
        //will search entire hiearchy until it finds player
        //playerObject = GameObject.Find("player");

        //cannot just use componet because cs is not attached to the collectable
        gameScore = playerObject.GetComponent<PlayerScore>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            gameScore.setPlayerScore(collectableValue);
            Destroy(this.gameObject);
        }
    }
}
