using TMPro;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 10f;
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject panel;

    private Rigidbody rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Move();
        Respawn();

        scoreText.text = "Score: " + score.ToString();

            ApplyDownwardForce();
    }

    private void ApplyDownwardForce()
    {
        Vector3 downwardForce = new Vector3(0f, -60f, 0f); // Adjust the Y component for desired downward force

        rb.AddForce(downwardForce, ForceMode.Acceleration); // Use ForceMode.Acceleration for continuous acceleration
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jump"))
        {
            // Add an upward force to lift the ball
            Vector3 upwardForce = new Vector3(0f, 60f, 0f); // Example: 10 units of force upward
            rb.AddForce(upwardForce, ForceMode.Impulse);

            // Optionally, change the ball's position after adding the force
            transform.position = transform.position + new Vector3(0f, 4f, 0f); // Example: Move ball upwards by 4 units
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            panel.SetActive(true);
            transform.position = new Vector3(-0.0299999993f, 0.742999971f, -40.5999985f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            audioSource.Play();
            score++;
            Destroy(other.gameObject);
        }
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.velocity = movement * moveSpeed;
    }

    void Respawn()
    {
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(-0.0299999993f, 0.742999971f, -40.5999985f);

            rb.velocity = Vector3.zero;
        }
    }
}
