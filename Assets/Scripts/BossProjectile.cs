using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("test");
        switch (collision.gameObject.tag)
        {
            case "Player":
                collision.gameObject.GetComponent<PlayerHealth>().Damage(damage);
                Destroy(gameObject);
                break;
            case "Item":
                Destroy(gameObject);
                break;
        }
        Destroy(gameObject, 3f);
    }

}