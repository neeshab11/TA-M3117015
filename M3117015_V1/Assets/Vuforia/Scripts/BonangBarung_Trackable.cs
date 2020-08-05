/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class BonangBarung_Trackable : MonoBehaviour, ITrackableEventHandler
{
	
    #region PROTECTED_MEMBER_VARIABLES
	
		public GameObject bonangar5;
		public GameObject bonangar6;
		public GameObject bonanga1;
		public GameObject bonanga2;
		public GameObject bonanga3;
		public GameObject bonanga5;
		public GameObject bonanga6;
		public GameObject bonangat1;
		public GameObject bonangbt1;
		public GameObject bonangb6;
		public GameObject bonangb5;
		public GameObject bonangb3;
		public GameObject bonangb2;
		public GameObject bonangb1;
		public GameObject bonangbr6;
		public GameObject bonangabr5;

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;
		
		 bonangar5.GetComponent<AudioSource>().mute = false;
		 bonangar6.GetComponent<AudioSource>().mute = false;
		 bonanga1.GetComponent<AudioSource>().mute = false;
		 bonanga2.GetComponent<AudioSource>().mute = false;
		 bonanga3.GetComponent<AudioSource>().mute = false;
		 bonanga5.GetComponent<AudioSource>().mute = false;
		 bonanga6.GetComponent<AudioSource>().mute = false;
		 bonangat1.GetComponent<AudioSource>().mute = false;
		 bonangbt1.GetComponent<AudioSource>().mute = false;
		 bonangb6.GetComponent<AudioSource>().mute = false;
		 bonangb5.GetComponent<AudioSource>().mute = false;
		 bonangb3.GetComponent<AudioSource>().mute = false;
		 bonangb2.GetComponent<AudioSource>().mute = false;
		 bonangb1.GetComponent<AudioSource>().mute = false;
		 bonangbr6.GetComponent<AudioSource>().mute = false;
		 bonangabr5.GetComponent<AudioSource>().mute = false;
		
    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;
			
		 bonangar5.GetComponent<AudioSource>().mute = true;
		 bonangar6.GetComponent<AudioSource>().mute = true;
		 bonanga1.GetComponent<AudioSource>().mute = true;
		 bonanga2.GetComponent<AudioSource>().mute = true;
		 bonanga3.GetComponent<AudioSource>().mute = true;
		 bonanga5.GetComponent<AudioSource>().mute = true;
		 bonanga6.GetComponent<AudioSource>().mute = true;
		 bonangat1.GetComponent<AudioSource>().mute = true;
		 bonangbt1.GetComponent<AudioSource>().mute = true;
		 bonangb6.GetComponent<AudioSource>().mute = true;
		 bonangb5.GetComponent<AudioSource>().mute = true;
		 bonangb3.GetComponent<AudioSource>().mute = true;
		 bonangb2.GetComponent<AudioSource>().mute = true;
		 bonangb1.GetComponent<AudioSource>().mute = true;
		 bonangbr6.GetComponent<AudioSource>().mute = true;
		 bonangabr5.GetComponent<AudioSource>().mute = true;
    }

    #endregion // PROTECTED_METHODS
}
