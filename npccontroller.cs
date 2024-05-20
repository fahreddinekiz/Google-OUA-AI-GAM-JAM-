using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npccontroller : MonoBehaviour
{
    public float Walktime;
    private NavMeshAgent agent;
    public Animator anim;
    private float time;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (WalkTimeBool()) RandomWalk();
        anim.SetFloat("speed", agent.velocity.magnitude);
    }
    private float RandomValue() => Random.Range(0, 30);

    private Vector3 RandomPos() => new Vector3(RandomValue(), transform.position.y, RandomValue());
    private void RandomWalk() => agent.SetDestination(RandomPos());

    private bool WalkTimeBool()
    {
        if (Walktime < time)
        {
            time = 0;
            return true;
        }
        else return false;
    }
}
