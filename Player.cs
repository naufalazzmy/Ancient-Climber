using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isLeft = false;

    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
           transform.position = new Vector2(-1, transform.position.y);
            isLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.position = new Vector2(1, transform.position.y);
            isLeft = false;
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision) {
  
        if(collision.gameObject.tag == "leftPillar" && isLeft) {
            // Gamve Over
        }
        if(collision.gameObject.tag == "rightPillar" && !isLeft) {
            // Game Over
        };

        if (collision.gameObject.tag == "Coin") {
            // Add points
        };
    }
}
