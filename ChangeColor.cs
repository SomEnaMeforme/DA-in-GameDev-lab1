using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static Perceptron Perceptron { get; private set; }
    private List<double> parametres = new List<double>();
    private int TrainingSetIndex = 1;
    private int InputIndex = 0;

    public static void InitPerceptron(Perceptron perceptron)
    {
        Perceptron = perceptron;
    }

    public void OnCollisionEnter(Collision collision)
    {
        var param = collision.collider.GetComponent<Renderer>().material.color == Color.black ? 1 : 0;
        parametres.Add(param);
        if (parametres.Count == 2)
        {
            ChangePlaneColor(parametres);
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        collision.collider.attachedRigidbody.AddForce(Vector3.up * 200f);
        

    }
    public void OnCollisionExit (Collision collision)
    {
        collision.collider.GetComponent<Renderer>().material.color = Perceptron.ts[TrainingSetIndex].input[InputIndex] == 0 ? Color.white : Color.black;
        if (InputIndex == 1)
        {
            TrainingSetIndex = TrainingSetIndex == 3 ? 0 : TrainingSetIndex + 1;
            parametres.Clear();
        }
        InputIndex = InputIndex == 1 ? 0 : InputIndex + 1; 
    }

    public void ChangePlaneColor(List<double> parametres)
    {
        var result = Perceptron.ApplyNetwork(parametres[0], parametres[1]);
        this.GetComponent<Renderer>().material.color = result == 1 ? Color.black : Color.white;
    }
}

