using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsout : MonoBehaviour
{
    [Header("When lights are on")]
    public int LightsOnTimeMin;
    public int LightsOnTimeMax;

    [Header("Keep this at zero! the code will set it")]
    [SerializeField] private float LightsOnTime;

    private float _lightsontime;

    public bool LightsOn;

    public bool GeneratorTurnedOn;

    [Header("When lights are off")]
    public float LightsOffTime;
    private float _lightsofftime;

    [Header("Losing canvas")]
    public GameObject LostGameCanvas;

    public GameObject Lights;

    public void Start()
    {
        LostcanvasOff();
        LightsOn = true;
        LightsOnTime = RandLightsOnTime();
        _lightsontime = LightsOnTime;
        
    }
    public void Update()
    {
        if (GeneratorTurnedOn)
        {
            LightsOnTime = RandLightsOnTime();
            _lightsontime = LightsOnTime;
            LightsOn = true;
            GeneratorOFF();
            Debug.Log("LIGHTS ON!!");
        }
        if (LightsOn)
        {
            Lights.SetActive(true);

            if(_lightsontime > 0 ) 
            {
                _lightsontime -= Time.deltaTime;
            } 
            
            else
            {
                Debug.Log("LIGHTS OFF!!");
                _lightsontime = 0;
                _lightsofftime = LightsOffTime;
                LightsOn = false;
            }
        }
        else
        {
            Lights.SetActive(false);

            if(_lightsofftime > 0 )
            {
                _lightsofftime -= Time.deltaTime;
            }
            else
            {
                Debug.Log("LOST GAME!!");
                _lightsofftime = 0;
                LostcanvasOn();


            }
        }
    }


    public float RandLightsOnTime()
    {
        LightsOnTime = Random.Range(LightsOnTimeMin, LightsOnTimeMax);
        return LightsOnTime;
    }

    public void GeneratorON()
    {
        GeneratorTurnedOn = true;
    }

    public void GeneratorOFF()
    {
        GeneratorTurnedOn = false;
    }


    public void LostcanvasOn()
    {
        LostGameCanvas.SetActive(true);
    }

    public void LostcanvasOff()
    {
        LostGameCanvas.SetActive(false);
    }

}
