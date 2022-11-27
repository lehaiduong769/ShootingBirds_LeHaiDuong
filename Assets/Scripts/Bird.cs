using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public GameObject prefabBlood;
    bool isDead = false;
    Rigidbody2D rigid;
    public float speed;

    public bool isScore = false;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.AddForce(new Vector2(200, 50));
        Destroy(this.gameObject, 10);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            isDead = true;
            SpawnBlood();
        }
    }
    void SpawnBlood()
    {
        if (isDead == true)
        {
            GameObject blood = Instantiate(prefabBlood, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            isDead = false;
            Destroy(blood, 10);
        }
    }
}
