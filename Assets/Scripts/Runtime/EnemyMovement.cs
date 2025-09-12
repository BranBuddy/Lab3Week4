using Mono.Cecil;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 15;
    private GameObject player;
    [SerializeField] private float xPos;
    [SerializeField] private float yPos;
    private Vector3 enemyPos;
    private Vector3 offset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = new Vector3(xPos, yPos, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        
        float enemySpeed = distance * speed;

        offset = Quaternion.AngleAxis(enemySpeed * Time.deltaTime, Vector3.forward) * offset;
        transform.position = Vector3.zero + offset;

        //Looking at Player
        Vector2 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            transform.position = Vector3.MoveTowards(transform.position, -Vector3.forward, .5f);   
        }
    }


}
