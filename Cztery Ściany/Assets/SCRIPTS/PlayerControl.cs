using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int liczbacalkowita;//np.:1,2,54,76
    float liczbaprzecinkowa = 0.01f;//np.:4.32423, 56.32423

    // Start is called before the first frame update
    void Start()
    {
        //Wszystko co tutaj zamiescimy wykonuje sie podczas startu gry/aplikacji

        Debug.Log("Tutaj jest testowa informacja");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //jezeli wscisnieto przycisk "A" - w lewo (za miast d)
        {
            //To wykonuje to
            transform.position = new Vector3(transform.position.x + liczbaprzecinkowa, transform.position.y, transform.position.z);

            Debug.Log("wcisniento przycisk A");
        }

        if (Input.GetKey(KeyCode.D)) //jezeli wscisnieto przycisk "D" - w prawo (zamiast a)
        {
            //To wykonuje to
            transform.position = new Vector3(transform.position.x - liczbaprzecinkowa, transform.position.y, transform.position.z);
            Debug.Log("wcisniento przycisk D");
        }

        if (Input.GetKey(KeyCode.W)) //jezeli wscisnieto przycisk "W" - do tylu (zamiasy s) 
        {
            //To wykonuje to
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + liczbaprzecinkowa);
            Debug.Log("wcisniento przycisk W");
        }

        if (Input.GetKey(KeyCode.S)) //jezeli wscisnieto przycisk "S" - do przodu (zamiast w)
        {
            //To wykonuje to
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - liczbaprzecinkowa);
            Debug.Log("wcisniento przycisk S");
        }



    }

    



}
