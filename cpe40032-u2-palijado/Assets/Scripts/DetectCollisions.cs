using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Deduct a life to the player if he collide with an animal
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }else if (other.CompareTag("Animal"))
        {
            Destroy(gameObject);
            // Adds 1 point to the score each time an animal was hit
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
        }
    }
}
