# README #

iBeacon Demo for iOS built with Xamarin
Currently set to work with Roximity (iOS and Android) and Estimote (iOS only) beacons.

In order to detect your beacons you will need to configure the uuid and region name in the code.
For now it's defined in the implementation class of BeaconLocator so you will have to do it for each platform.

For Android & iOS on BeaconLocator, start at line 16 : 

	readonly string uuid = "8deefbb9-f738-4297-8040-96668bb44281";
	readonly string regionName = "OfficeBeacon";

The UUID is the unique identifier for all of your beacons. The regionName defines the name of the region, that's not an information fix on beacons, you can put every think you want.
