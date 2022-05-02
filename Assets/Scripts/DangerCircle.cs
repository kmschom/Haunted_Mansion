using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerCircle : MonoBehaviour
{   
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");

    }


    void FixedUpdate() {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float minDist = 1000f;
        
        foreach(var enemy in enemies)
        {
            float x = enemy.transform.position.x - Player.transform.position.x;
            float y = enemy.transform.position.y - Player.transform.position.y;
            float dist = Mathf.Abs(x) + Mathf.Abs(y);
            if (dist < minDist){
                minDist = dist;
            }

        }
        
        Debug.Log(minDist);
        gameObject.GetComponent <SpriteRenderer> ().color = Color.Lerp(Color.red, Color.green, (minDist-0.5f)/4f);

    }
}
