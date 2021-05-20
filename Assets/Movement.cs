using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    public Vector2 jumpHeight;
    public Vector3 respawnPoint;
    public GameManager gm;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) //makes player jump
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Comida")
        {
            gm.ComidaCollected();
            Destroy(other.gameObject);
        }
    }

    
}
