using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // or it can be also written as if(collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = new Color(207f / 255f, 97f / 255f, 66f / 255f);             
        }        
    }
}
