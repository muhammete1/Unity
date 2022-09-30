using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraDegistirme : MonoBehaviour
{
    public GameObject[] kameralar;
    private int kameraSayi;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < kameralar.Length; i++)
        {
            kameralar[i].SetActive(false);
        }
        kameralar[kameraSayi].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            kameralar[kameraSayi].SetActive(false);
            kameraSayi++;
            if (kameraSayi >= kameralar.Length)
            {
                kameraSayi = 0;
            }
            kameralar[kameraSayi].SetActive(true);
        }
    }
}
