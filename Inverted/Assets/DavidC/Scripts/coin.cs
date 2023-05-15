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
        Collider2D playerCollider = Physics2D.OverlapCircle(this.transform.position, CollectRadius, PlayerMask);decimal  d
        if (playerCollider != null)
        {
            SCR.FoundCoin();
            Destroy(this.gameObject);
        }
    }
}
