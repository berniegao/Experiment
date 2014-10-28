Introduction
------------
Thank you for downloading the AngularJS TODO sample for Multi-Device Hybrid Apps. This app demonstrates some the basic functionality provided by our tool, used to create Apache Cordova packaged HTML apps that make use of native device capabilities, and Microsoft Azure based cloud backend.


Building the Sample
-------------------
Bing Maps API
For purposes of distribution, we have removed our API key. Please create and copy over your Bing Maps API key for the app to work as expected. If the Bing Maps key is not present, the location information shows up as "latitude, longitude" in the ToDo, instead of the actual address.

Microsoft Azure
For purposes of distribution, we have removed our API key and added a comment instead. The app falls back to local storage if you choose not to enter an API key.

Create your Azure Mobile Service [Optional]
- Navigate to http://azure.microsoft.com
- Go to Portal and login with your Microsoft account
- Create a new Azure Mobile Service
- Create a table in your database with the following schema (id:string, __createdAt:date, __updatedAt:date, __version:timestamp, text:string, done:boolean, 
address:string)


Description
-----------
Multi-Device Hybrid apps combines the goodness of your favorite IDE with the ease of creating apps for multiple mobile operating systems, all in a simple to use workflow. One of the major pain points for our enterprise developers is the effort required to build apps for multiple platforms, while keeping costs and effort down. Multi-Device Hybrid Apps allows developers to use HTML5 and JavaScript, along with their favorite open source framework libraries to build web applications.

Leveraging the Apache Cordova framework, we create packaged mobile apps that feel and behave like native device applications. What’s great is that all this can be done completely from within Visual Studio, with full tooling support for building, debugging and packaging that our customers love. Our highlight features include attaching and debugging to the Android emulator and devices, plus, being able to build and simulate remotely for the iOS platform.

The TODO sample helps you get up and running with an app that you quickly F5 and start playing around with. It showcases the use of the Geolocation plugin from Cordova, that lets the app use native device capabilities. It also uses Microsoft Azure as its cloud backend, to sync and make data available on any device, anytime.


Running the app
---------------
After you finish downloading and installing our extension (http://go.microsoft.com/fwlink/?LinkId=397606), open up the project in Visual Studio.
Add any API keys as explained above. Press F5 and you're on your way! If you haven't already done so, consider taking a look at our landing page for more information 
(http://go.microsoft.com/fwlink/?LinkID=398477).

What the script downloads:
When you run the app for the first time, the Powershell script is executed at pre-build time and downloads the dependent library files. This step is only executed the 
first time (you need to have a working internet connection for the script to run correctly). Please note, this is a special step we have added to enable users to get 
the pre-requisite libraries and is *not* part of the standard Apache Cordova project template.

Path to downloaded files:
- scripts/frameworks/angular.min.js
- scripts/frameworks/angular-resource.min.js

Note: The .jsproj file has been modified to include a call to the Powershell script for downloading the dependency libraries


Important links
---------------
AngularJS License (https://github.com/angular/angular.js/blob/master/LICENSE)


Terms of Use
-------------
By downloading and running this project, you agree to the license terms of the third party application software, Microsoft products, and components to be installed. 
The third party software and products are provided to you by third parties. You are responsible for reading and accepting the relevant license terms for all software 
that will be installed. Microsoft grants you no rights to third party software.


License
-------
Copyright © Microsoft Corporation. All rights reserved.
Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.  You may obtain a copy of the License 
at http://www.apache.org/licenses/LICENSE-2.0.
THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED 
WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABILITY OR NON-INFRINGEMENT.
See the Apache Version 2.0 License for specific language governing permissions and limitations under the License


Known Issues
------------
There are known issues related to AngularJS on Windows Store apps


More Information
----------------
Email us at multidevicehybridapp@microsoft.com