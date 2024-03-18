using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction.PoseDetection;

public class NewVR : MonoBehaviour, ITransformFeatureStateProvider
{
    string debugTest;
    public bool GetCurrentState(TransformConfig config, TransformFeature transformFeature, out string currentState)
    {
        currentState = transformFeature.ToString();
        debugTest = currentState;
        return true;
    }

    public void GetFeatureVectorAndWristPos(TransformConfig config, TransformFeature transformFeature, bool isHandVector, ref Vector3? featureVec, ref Vector3? wristPos)
    {
        throw new System.NotImplementedException();
    }

    public bool IsStateActive(TransformConfig config, TransformFeature feature, FeatureStateActiveMode mode, string stateId)
    {
        throw new System.NotImplementedException();
    }

    public void RegisterConfig(TransformConfig transformConfig)
    {
        throw new System.NotImplementedException();
    }

    public void UnRegisterConfig(TransformConfig transformConfig)
    {
        throw new System.NotImplementedException();
    }

    void OnGUI()
    {
        GUILayout.Label(debugTest);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
