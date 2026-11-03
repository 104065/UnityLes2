using UnityEngine;

public class Draaier : MonoBehaviour
{
    public float snelheid = 90f;
    public bool draaien = true;
    public GameObject deur;
    
    [SerializeField] private float hoogte = 1f;
    void Start()
    {
        deur.GetComponent<Renderer>().material.color = Color.red;
        deur.transform.position = new Vector3(0, 2, 0);
        deur.SetActive(true);
        
        Debug.Log("Hallo Unity");
    }

    void Update()
    {
        if (draaien)
        {
            transform.Rotate(0, snelheid * Time.deltaTime, 0);
        }
    }
}
