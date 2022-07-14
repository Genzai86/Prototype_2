using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // para que funcione este metodo, hay que marcar Istrigger en el componente del box collider y añadir un componente rigidbody en uno de los dos gameobject
    // ya sea el animal o la municion ( lo mejor es hacerlo en la municion)
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (other.gameObject.name != "Player")
        {
            Destroy(other.gameObject);
            
        }
        else
        {
            Debug.Log("Hit!");
        }
       
    }
}
