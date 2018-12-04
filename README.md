# Brewski++
##### Brewski++ will be a personal beer logging website which allows the user to add beers that they have tried as well as search other useful information about the beer.  Additionally, find new beers and add them to your list!

## Dependencies
* ##### Dotnet Core 2.1 SDK
* ##### Google Chrome
* ##### -Allow-Control-Allow-Origin: *
  * We are using AJAX (Asyncronous Javascript and XML) requests to access the BreweryDB API.  This Chrome extenion makes it so that your browser won't block the stuff that gets returned from cross domain ajax requests.  Enabling this extension necessary to run the beer search on the webpage.

## How to Run (Two Methods)
#### First Method - Command Line
1. Download Dotnet Core 2.1 SDK https://dotnet.microsoft.com/download.
2. Download or Clone this repository to your C: drive.
3. Open cmd line or powershell and navigate to the following path by copy/pasting or typing:
      'cd c:\C:TwoNodeNull\src\BrewskiiApp - MVC\BrewskiiApp'
4. Type 'dotnet run' and eventually you will see "Now listening on: https://localhost:5001" of  which the address may be slightly different on your machine.
5. Copy https://localhost:5001 into your Google Chrome browser and the site will appear.

#### Second Method - Visual Studio
1. Download Visual Studio 2017 (Community Edition)
2. Download or Clone this repository to your C: drive.
3. Open Visual Studio and select 'File->Open' then when the windows explorer window appears navigate to  'C:\TwoNodeNull\src\BrewskiiApp - MVC' and double click 'BrewskiiApp.sln'
4. Once the program loads locate the click the Debug icon at the top and select "Start Without Debugging" or hit ctrl+f5.
5. Wait and the webpage will load in the browser (you may have to change Visual Studio settings to open the webpage in Google Chrome which is necessary for accessing the API).

## Authors

See our [Authors](https://github.com/IUS-CS/TwoNodeNull/blob/master/AUTHORS) who are participating in this project.

## License

This project is licensed under the MIT License - see the [LICENSE](https://github.com/IUS-CS/TwoNodeNull/blob/master/LICENSE) file for details.