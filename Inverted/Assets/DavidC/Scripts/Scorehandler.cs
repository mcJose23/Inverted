using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorehandler : MonoBehaviour
{
    public int CoinScore = 0;
   
    // Update is called once per frame
    public void FoundCoin()
    {
        CoinScore = CoinScore + 1;
    }
}
