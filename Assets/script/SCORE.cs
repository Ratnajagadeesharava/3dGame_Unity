using UnityEngine;
using UnityEngine.UI;
public class SCORE : MonoBehaviour
{
    public Transform Cube;
    public Text scoretext;
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        scoretext.text = Cube.position.z.ToString();
        
    }
}
