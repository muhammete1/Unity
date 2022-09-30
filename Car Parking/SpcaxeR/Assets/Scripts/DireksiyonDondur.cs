using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DireksiyonDondur : MonoBehaviour
{
    public Transform Direksiyon;
    public BoxCollider direksiyonCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Direksiyon.Rotate(direksiyonCol. / 60 * 360 * Time.deltaTime, 0, 0);
    }
}
