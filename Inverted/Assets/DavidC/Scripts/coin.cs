using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public Scorehandler SCR;

    public LayerMask PlayerMask;
    public float CollectRadius = 0.5f;
    
    private void start()
    {
        SCR = FindObjectOfType<Scorehandler>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(this.transform.position, CollectRadius, PlayerMask)) ;
        {
            SCR.FoundCoin();
            Destroy(this.gameObject);
        }
    }
}
