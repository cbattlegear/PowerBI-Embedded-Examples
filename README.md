# Power BI Embedded sample in .NET 7

## Requirements

1. .NET 7.0 SDK or higher

2. IDE/code editor. We recommend using Visual Studio Code or Visual Studio 2022 (or a later version).


## Embed for your customers

### Set up a Power BI app

Follow the steps on [aka.ms/EmbedForCustomer](https://aka.ms/embedforcustomer)

### Run the application on localhost

1. Open the [PowerBI-Embedded-Examples.sln](./PowerBI-Embedded-Examples.sln) file in Visual Studio. If you are using Visual Studio Code then, open [PowerBI-Embedded-Examples](./PowerBI-Embedded-Examples) folder.

2. Fill in the required parameters in the [appsettings.json](./PowerBI-Embedded-Examples/appsettings.json) file. Refer to [PowerBI.cs](./PowerBI-Embedded-Examples/Models/PowerBI.cs) and [AzureAd.cs](./PowerBI-Embedded-Examples/Models/AzureAd.cs) for more info on the config parameters.

3. Build and run the application.

#### Supported browsers:

1. Google Chrome

2. Microsoft Edge

3. Mozilla Firefox

## Important

For security reasons, in a real world application, passwords and secrets should not be stored in config files. Instead, consider securing your credentials with an application such as Key Vault.
