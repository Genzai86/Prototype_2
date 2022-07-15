using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
//Importante!! Para que se aplique a todos los gameobject del mismo tipo en prefabs ir al boton de Override del inspector del objeto y marcar Apply all
{
    private float topbound = 30;
    private float lowerbound = -10;
    private float sideBound = 30;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerbound)
        {
            //Debug.Log Nos devuelve el mensaje que escribamos entre comillas en la consola
            // en la ventana de la consola cuando suceda el metodo que estamos definiendo.
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
    }
}
