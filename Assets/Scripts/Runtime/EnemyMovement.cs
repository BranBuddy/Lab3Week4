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

       

        
    }

    

}
