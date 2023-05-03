using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    pubilc float speed;
    public Ridigbody2D rb;
    bool facingleft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OncollisionEnter2D(Collision2D collision)
    {
        if (collision != null && !collision.collider.Comparetag("Player") && colision.collider.CompareTag("Ground"))
        {
            facingleft = !facingleft;
        }
    }
