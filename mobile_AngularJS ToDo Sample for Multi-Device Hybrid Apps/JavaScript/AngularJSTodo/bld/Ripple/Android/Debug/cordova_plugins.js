cordova.define('cordova/plugin_list', function(require, exports, module) {
module.exports = [
    {
        "file": "plugins/com.msopentech.azure-mobile-services/www/MobileServices.Web.Ext.js",
        "id": "com.msopentech.azure-mobile-services.AzureMobileServices.Ext",
        "runs": true
    },
    {
        "file": "plugins/com.msopentech.azure-mobile-services/www/MobileServices.Web-1.1.3.js",
        "id": "com.msopentech.azure-mobile-services.AzureMobileServices",
        "runs": true
    },
    {
        "file": "plugins/org.apache.cordova.inappbrowser/www/inappbrowser.js",
        "id": "org.apache.cordova.inappbrowser.inappbrowser",
        "clobbers": [
            "window.open"
        ]
    }
];
module.exports.metadata = 
// TOP OF METADATA
{
    "org.apache.cordova.geolocation": "0.3.7",
    "com.msopentech.azure-mobile-services": "0.1.2",
    "org.apache.cordova.inappbrowser": "0.5.0"
}
// BOTTOM OF METADATA
});