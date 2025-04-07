using UnityEngine;

public class Npc : MonoBehaviour
{
    public int Health;
    public int Level;
    public float Speed;
    public Vector3 position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Health = 100; 
         Level = 1;
         Speed = 2.20f;
         position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.z += Speed * Time.deltaTime;
        transform.position = position;
    }
}
