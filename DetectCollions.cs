using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollions : MonoBehaviour
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

    // para que funcione este metodo, hay que marcar Istrigger en el componente del box collider y a?adir un componente rigidbody en uno de los dos gameobject
    // ya sea el animal o la municion ( lo mejor es hacerlo en la municion)
    private void OnTriggerEnter(Collider other)
    {
        //Check if the other tag was the Player, if it was remove a life
        if (other.CompareTag("Player"))
        {
            gameManager.Addlives(-1);
            Destroy(gameObject);
            
        }
        //Check if the other tag was an Animal, if so add points to the score
        else if (other.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
        }
       
    }
}
