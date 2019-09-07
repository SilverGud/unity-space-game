using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform Bullet;
    public Transform CannonPosition;
    public Slider sld;

    public int Score;

    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h*.3f, v*.3f, 0));

        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(Bullet, CannonPosition.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        sld.value -= 5;
        Destroy(col.gameObject);
    }
}
