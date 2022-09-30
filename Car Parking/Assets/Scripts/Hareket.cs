using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public Transform OnSagTeker, ArkaSagTeker, OnSolTeker, ArkaSolTeker;
    public WheelCollider OnSagCollider, ArkaSagCollider, OnSolCollider, ArkaSolCollider;
    public float Tork = 1000f;
    public float MaxTekerAcisi = 35f;

    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float TekerinIleriGeriHareketi = Tork * Input.GetAxis("Vertical");
        ArkaSagCollider.motorTorque = TekerinIleriGeriHareketi;
        ArkaSolCollider.motorTorque = TekerinIleriGeriHareketi;

        float TekerinSagaSolaHareketi = Input.GetAxis("Horizontal") * MaxTekerAcisi;
        OnSagCollider.steerAngle = TekerinSagaSolaHareketi;
        OnSolCollider.steerAngle = TekerinSagaSolaHareketi;

        OnSagTeker.Rotate(OnSagCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        OnSolTeker.Rotate(OnSolCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        ArkaSagTeker.Rotate(ArkaSagCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        ArkaSolTeker.Rotate(ArkaSolCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);

        OnSagTeker.localEulerAngles = new Vector3(OnSagTeker.localEulerAngles.x, OnSagCollider.steerAngle - OnSagTeker.localEulerAngles.z, OnSagTeker.localEulerAngles.z);
        OnSolTeker.localEulerAngles = new Vector3(OnSolTeker.localEulerAngles.x, OnSolCollider.steerAngle - OnSolTeker.localEulerAngles.z, OnSolTeker.localEulerAngles.z);

    }
    void Update()
    {
    }

}
