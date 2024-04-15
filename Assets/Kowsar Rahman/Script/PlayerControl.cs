using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerControl : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody rigid;
    private float xInput;
    private float zInput;
    public TextMeshProUGUI scoretxt;
    int score = 0;
    public GameObject winui;
// Update ls called once per frame
void Update()
    {
        Inputs();
     }

    private void FixedUpdate()
    {
        Move();
    }
    //Start ls called before the first frame update 
    void Start() {
        rigid = GetComponent<Rigidbody>();
        scoretxt.text = "Score : " + score.ToString();
    }
    private void Inputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        rigid.AddForce(new Vector3(xInput, 0f, zInput) * speed);
            } 
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            soundManager.instance.coinssource.PlayOneShot(soundManager.instance.coinSound);
            other.gameObject.SetActive(false);
            score++;
            scoretxt.text = "Score : " + score.ToString();
            if(score == 10)
            {
                winui.SetActive(true);
            }
        }
    }
}