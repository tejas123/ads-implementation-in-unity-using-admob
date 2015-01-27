using UnityEngine;
using System.Collections.Generic;
using Prime31;


public class AdMobUIManager : MonoBehaviourGUI
{
#if UNITY_ANDROID
	void OnGUI()
	{
		beginColumn();


		if( GUILayout.Button( "Init" ) )
		{
			AdMobAndroid.init( "a14de56b4e8babd" );
			//AdMobAndroid.init( "YOUR_APP_ID_HERE" );
		}


		if( GUILayout.Button( "Set Test Devices" ) )
		{
			AdMobAndroid.setTestDevices( new string[] { "<DEVIE_ID>", "<DEVICE_ID>", "<DEVICE_ID>" } );
		}


		if( GUILayout.Button( "Create Smart Banner" ) )
		{
			// place it on the top
			AdMobAndroid.createBanner( AdMobAndroidAd.smartBanner, AdMobAdPlacement.BottomCenter );
		}


		if( GUILayout.Button( "Create 320x50 banner" ) )
		{
			// place it on the top
			AdMobAndroid.createBanner( "<BANNER_ID>", AdMobAndroidAd.phone320x50, AdMobAdPlacement.TopCenter );
		}


		if( GUILayout.Button( "Create 300x250 banner" ) )
		{
			// center it on the top
			AdMobAndroid.createBanner( AdMobAndroidAd.tablet300x250, AdMobAdPlacement.BottomCenter );
		}


		if( GUILayout.Button( "Destroy Banner" ) )
		{
			AdMobAndroid.destroyBanner();
		}


		endColumn( true );


		if( GUILayout.Button( "Refresh Ad" ) )
		{
			AdMobAndroid.refreshAd();
		}


		if( GUILayout.Button( "Request Interstitial" ) )
		{
			// replace with your adUnitId!
			AdMobAndroid.requestInterstital( "INTERSTITIAL_ID" );
		}


		if( GUILayout.Button( "Is Interstitial Ready?" ) )
		{
			var isReady = AdMobAndroid.isInterstitalReady();
			Debug.Log( "is interstitial ready? " + isReady );
		}


		if( GUILayout.Button( "Display Interstitial" ) )
		{
			AdMobAndroid.displayInterstital();
		}


		if( GUILayout.Button( "Hide Banner" ) )
		{
			AdMobAndroid.hideBanner( true );
		}


		if( GUILayout.Button( "Show Banner" ) )
		{
			AdMobAndroid.hideBanner( false );
		}

		endColumn();
	}
#endif
}
