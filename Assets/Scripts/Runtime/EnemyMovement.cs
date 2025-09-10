using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMovement : MonoBehaviour
{
    private float speed;
    private GameObject player;
    [SerializeField] private float xPos;
    [SerializeField] private float yPos;
    private Vector3 enemyPos;
    private Vector3 offset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = new Vector3(xPos, yPos, 0);
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        offset = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * offset;
        transform.position = Vector3.zero + offset;

        //Fix this 
        speed += (player.transform.position - transform.position).magnitude;

    }
}
