using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorehandler : MonoBehaviour
{
    public int CoinScore = 0;
    public TMP_Text ScoreText;
    
    private void Update()
    {
        ScoreText.text = "" + CoinScore;
    }
    // Update is called once per frame
    public void FoundCoin()
    {
        CoinScore = CoinScore + 1;
    }
}
