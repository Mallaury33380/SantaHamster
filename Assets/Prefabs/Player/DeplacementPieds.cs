using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPieds : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_speedRot;
    [SerializeField] private float m_speedRotCamera;
    [SerializeField] private GameObject Camera;
    private string Avancer;
    private string Reculer;
    private string Gauche;
    private string Droite;

    private Vector3 m_oldMousePos;

    // Start is called before the first frame update
    void Start()
    {
        Avancer=PlayerPrefs.GetString("Avancer");
        Reculer= PlayerPrefs.GetString("Reculer");
        Gauche= PlayerPrefs.GetString("Gauche");
        Droite= PlayerPrefs.GetString("Droite");
        Camera.transform.rotation=Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Avancer))
        {
            transform.Translate(0.0f, 0.0f, m_speed * Time.deltaTime);
        }
        if (Input.GetKey(Reculer))
        {
            transform.Translate(0.0f, 0.0f, -m_speed * Time.deltaTime);
        }
        if (Input.GetKey(Gauche))
        {
            transform.Rotate(0.0f,  -m_speedRot, 0.0f);
        }
        if (Input.GetKey(Droite))
        {
            transform.Rotate(0.0f, m_speedRot, 0.0f);
        }

        float deltaX = Input.mousePosition.x - m_oldMousePos.x;
        Camera.transform.Rotate(0.0f, deltaX * m_speedRotCamera, 0.0f);
        m_oldMousePos = Input.mousePosition;

    }
}
