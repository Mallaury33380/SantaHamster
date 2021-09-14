using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    [SerializeField] private float maxSpeedForward;
    [SerializeField] private float maxSpeedBack;
    [SerializeField] private float acceleration;

    [SerializeField] private float m_speedRot;
    [SerializeField] private float CoeffDerap;

    [SerializeField] private float m_speedRotCamera;
    [SerializeField] private GameObject Camera;

    [SerializeField] private float forceGravité;
    [SerializeField] private float coeffFrotement;

    public AudioSource Galop;
    public AudioSource Marche;
    public AudioSource Sonnette;


    private bool isOut;
    public float coeffOut;

    private string Avancer;
    private string Reculer;
    private string Gauche;
    private string Droite;

    private Vector3 m_oldMousePos;
    private bool Derap;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Derap = false;
        rb = GetComponent<Rigidbody>();
        Avancer=PlayerPrefs.GetString("Avancer");
        Reculer = PlayerPrefs.GetString("Reculer");
        Gauche = PlayerPrefs.GetString("Gauche");
        Droite = PlayerPrefs.GetString("Droite");
        isOut = false;

        Camera.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "out")
        {
            isOut = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        float forward = maxSpeedForward;
        float back = maxSpeedBack;

        if (isOut)
        {
            forward *= coeffOut;
            back *= coeffOut;
        }
              
        float maxVelocity = transform.forward.x * rb.velocity.x + transform.forward.z * rb.velocity.z;

        if (Input.GetKey(Avancer))
        {
            rb.velocity = rb.velocity + transform.forward * acceleration;
            if (maxVelocity > forward)
            {
                rb.velocity = transform.forward * forward-transform.up*forceGravité;
                Derap = true;
            }
            if (!Galop.isPlaying)
            {
                Galop.Play();
            }
            if (!Sonnette.isPlaying)
            {
                Sonnette.Play();
            }
        }
        else
        {
            Galop.Stop();
        }
        if (Input.GetKey(Reculer))
        {
            rb.velocity = rb.velocity - transform.forward * acceleration;
            if (maxVelocity < back)
            {
                rb.velocity = transform.forward * back;
                Derap = true;
            }
            if (!Marche.isPlaying)
            {
                Marche.Play();
            }
        }
        



        if (Input.GetKey(Gauche))
        {
            if (Derap)
            {
                transform.Rotate(0.0f, -m_speedRot*CoeffDerap, 0.0f);
            }
            else
            {
                transform.Rotate(0.0f, -m_speedRot, 0.0f);
            }
            if (!Marche.isPlaying)
            {
                Marche.Play();
            }
        }
        if (Input.GetKey(Droite))
        {
            if (Derap)
            {
                transform.Rotate(0.0f, m_speedRot*CoeffDerap, 0.0f);
            }
            else
            {
                transform.Rotate(0.0f, m_speedRot, 0.0f);
            }
            if (!Marche.isPlaying)
            {
                Marche.Play();
            }
        }

        //Camera
        float deltaX = Input.mousePosition.x - m_oldMousePos.x;
        Camera.transform.Rotate(0.0f, deltaX * m_speedRotCamera, 0.0f);
        m_oldMousePos = Input.mousePosition;

        //Gravité
        rb.AddForce(-transform.up * forceGravité);

        //Frottement
        rb.velocity = rb.velocity * ((1-coeffFrotement)+coeffFrotement*Time.deltaTime);


        Derap = false;
        isOut = false;
    }
}
