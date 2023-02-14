using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitikMaju : MonoBehaviour
{
    [SerializeField] Transform[] titikPoint;
    [SerializeField] Transform titikBerhenti;
    [SerializeField] int Kecepatan;
    [SerializeField] int lamaWaktu;

    int titikLanjutIndex;
    Transform titikLanjut;
    // Start is called before the first frame update
    void Start()
    {
        titikLanjut = titikPoint[0];
    }

    // Update is called once per frame
    void Update()
    {
        ObjekJalan();
    }

    void ObjekJalan()
    {
        if (transform.position == titikLanjut.position)
        {
            titikLanjutIndex++;
            if (titikLanjutIndex >= titikPoint.Length)
            {
                //Destroy(gameObject);
            }
            titikLanjut = titikPoint[titikLanjutIndex];
            if (titikLanjutIndex >= 3)
            {
                transform.position = Vector2.MoveTowards(transform.position, titikLanjut.position, 0f * Time.deltaTime);
            }
        }
        else
        {
            MajuJalan();
        }
    }

    void MajuJalan()
    {
        transform.position = Vector2.MoveTowards(transform.position, titikLanjut.position, Kecepatan * Time.deltaTime);
    }
}   