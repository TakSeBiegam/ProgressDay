using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public string ItemName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKey(KeyCode.F))
        {
            Destroy(gameObject);
            if(ItemName == "Sword")
                GetComponent<Movement>().isPlayerHaveSword = true;
        }
            
    }
}
