using FirebaseUnityWrapper.Auth;
using GMSTasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebaseTest : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    //Test
    public void CreateUserWithEmailAndPassword()
    {
        FirebaseAuth firebaseAuth;

        firebaseAuth = FirebaseAuth.Instance;
        ITask<AuthResult> authTask = firebaseAuth.CreateUserWithEmailAndPassword("yusufaltungoldtrxx@hotmail.com", "m123416");

        authTask.AddOnSuccessListener((result) =>
        {
            Debug.Log("[HMSP:] FirebaseAuth archiveSummary " + result.User.Anonymous);
        }).AddOnFailureListener((exception) =>
        {
            Debug.Log("[HMS:] FirebaseAuth fail: " + exception.Message + "[HMS:]" + exception.InnerException + "[HMS:]" + exception.HResult + exception.ToString());
        });
    }
    public void SignInAnonymously()
    {
        FirebaseAuth firebaseAuth;

        firebaseAuth = FirebaseAuth.Instance;
        ITask<AuthResult> authTask = firebaseAuth.SignInAnonymously();

        authTask.AddOnSuccessListener((result) =>
        {
            Debug.Log("[HMSP:] FirebaseAuth archiveSummary " + result.User.Anonymous);
        }).AddOnFailureListener((exception) =>
        {
            Debug.Log("[HMS:] FirebaseAuth fail: " + exception.Message + "[HMS:]" + exception.InnerException + "[HMS:]" + exception.HResult + exception.ToString());
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
