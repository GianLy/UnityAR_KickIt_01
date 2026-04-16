using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

        public Rigidbody BalonRigidbody;
        public float Fuerza = 10f;
        public Transform BalonTransforn;
        public Transform DestinoTransform;
        public Animator DireccionAnimator;
        public Animator ElevacionAnimator;

    private void Start()
    {
        DireccionAnimator.speed = 1;
        ElevacionAnimator.speed = 0;
    }
    public void PatearPelota()
        {

            Vector3 direccion = (DestinoTransform.position - BalonTransforn.position). normalized;

            //print("Pelota pateada");

            BalonRigidbody.AddForce(direccion * Fuerza, ForceMode.Impulse);
        }
    public void PosicionarBalon()
    {
        BalonRigidbody.velocity = Vector3.zero;
        BalonRigidbody.angularVelocity = Vector3.zero;

        BalonRigidbody.Sleep();

        BalonTransforn.position = new Vector3(0f, 0.5f, 0f);
        BalonTransforn.rotation = Quaternion.identity;
    }

}
