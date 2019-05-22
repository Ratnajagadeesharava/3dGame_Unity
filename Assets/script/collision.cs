using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    public Transform Cube;
    public Text scoretext;
    public Rigidbody rb;
    public cubemovemnent movement;
    //public GameManager GameManager;
    void Update()
    {
        scoretext.text = Cube.position.z.ToString();
        

    }
    void OnCollisionEnter()
    {
        movement.enabled = false;
        rb.useGravity = true;
      // FindObjectOfType<GameManager>().EndGame();
    }


}