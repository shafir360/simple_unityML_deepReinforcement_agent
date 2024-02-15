using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class MoveToGoalAgent : Agent
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Material winMaterial;
    [SerializeField] private Material loseMaterial;

    [SerializeField] private Material defmat;

    [SerializeField] private MeshRenderer floorMeshRenderer;

    public Transform Goalpos;


    public override void OnEpisodeBegin()
    {
        float x = Random.Range(-5.3f,2.7f);
        float z= Random.Range(-3f,5f);
        transform.localPosition = new Vector3(x,0.49f,z);
        //floorMeshRenderer.material = defmat;

        x = Random.Range(-5.3f,2.7f);
        z= Random.Range(-3f,5f);

        Goalpos.localPosition = new Vector3(x,0f,z);
    }
    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(targetTransform.localPosition);
    }
    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveZ = actions.ContinuousActions[1];

        float moveSpeed = 5f;

        transform.localPosition += new Vector3(moveX,0,moveZ) * Time.deltaTime * moveSpeed;
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerEnter(Collider other){

        if(other.TryGetComponent<Goal>(out Goal goal)){
            SetReward(+1f);
            floorMeshRenderer.material = winMaterial;
            EndEpisode();
        }

        if(other.TryGetComponent<Wall>(out Wall wall)){
            SetReward(-1f);
            floorMeshRenderer.material = loseMaterial;
            EndEpisode();
        }
        
    }



}
