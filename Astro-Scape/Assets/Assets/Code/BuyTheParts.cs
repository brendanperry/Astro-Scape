using UnityEngine;
using System.Collections;
//using Prime31;
using System.Collections.Generic;

public class BuyTheParts : MonoBehaviour
{

	public int parts;
	public string Product;
	public int amount;
	public string CanGet;

	void Start ()
	{

		parts = PlayerPrefs.GetInt ("shipParts");
		if (CanGet == "Yes") {
			var productIDs = new string[] { "stackoshards", "pileofshards", "chestofshards" };
			//StoreKitBinding.requestProductData (productIDs);
		}
	}


	public void onClick ()
	{
/*
		if (StoreKitBinding.canMakePayments () == true) {

			StoreKitBinding.purchaseProduct (Product, 1);

			StoreKitManager.purchaseSuccessfulEvent += StoreKitManager_purchaseSuccessfulEvent;
		} */
	}

/*
	void StoreKitManager_purchaseSuccessfulEvent (StoreKitTransaction obj)
	{
		parts = PlayerPrefs.GetInt ("shipParts");
		parts += amount;
		PlayerPrefs.SetInt ("shipParts", parts);
	} */
}