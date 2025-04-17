using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rd;
    private Transform currentPoint;
    public float speed;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform){
            rd.linearVelocity = new  Vector2(-speed,0);
        }
        else{
            rd.linearVelocity = new  Vector2(speed,0);
        }
        if(Vector2.Distance(transform.position, currentPoint.position)< 0.5f && currentPoint == pointB.transform){
            currentPoint = pointA.transform;
        }
        if(Vector2.Distance(transform.position, currentPoint.position)< 0.5f && currentPoint == pointA.transform){
            currentPoint = pointB.transform;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
    }
}
