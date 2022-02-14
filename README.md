# Coralogix NetCore SDK Example Project

## Install:
Go to your Project and Add CoralogixCoreSDK  nuget package.

## Configuration:

**PRIVATE_KEY** (String): 
> A unique ID that represents your team. The private key can be found under DataFlow->Api Keys->Send Your Logs. 

**APLICATION_NAME** (String): 
>This is a name tag for the data coming from this application, you can later filter by it on Coralogix.

**SUBSYSTEM_NAME** (String): 
>The name of your sub-system, much like the application name but nested under application name.

This Variables need to be set when you Configure you CoralogixLogger inside your code.
```
coralogixLogger.Configure("PRIVATE_KEY", "APPLICATION_NAME", "SUBSYSTEM_NAME");

```

**CORALOGIX_LOG_URL** (String):
>Coralogix supports multiple geo regions and depending on where you account is located, 
>This part is required only if you are not in the EU region
>The URL can be provide as an Evironment variable.
```
 CORALOGIX_LOG_URL = 'https://<Cluster_api_URL>:443/api/v1/logs'
```
The options:
```
api.coralogix.us 
api.coralogix.com (default)
api.app.coralogix.in
api.coralogixsg.com
```

For more information please visit https://coralogix.com/integrations/coralogix-net-integration/
